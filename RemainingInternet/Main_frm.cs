using Microsoft.Win32;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemainingInternet
{
    public partial class Main_frm : Form
    {
        static string registryKey = @"SOFTWARE\RemainingInternetApp"; // مسیر ذخیره در رجیستری
        static string WebsiteURL = "WebsiteURL"; // نام مقدار ذخیره‌شده در رجیستری
        private static readonly HttpClient client = new HttpClient();

        public Main_frm()
        {
            CheckAndSaveURL();
            InitializeComponent();
            txtbox_WebSiteURL.Text = ReadFromRegistry(WebsiteURL);
        }

        private void AppMenu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public async Task<string> GetTrafficFromWebsite(string url)
        {
            try
            {
                // بررسی اینکه آیا کاربر سرویس همای جهان‌نما دارد یا خیر
                HttpResponseMessage response = await client.GetAsync("https://qom.jahan-nama.com/user/signin");
                string finalUrl = response.RequestMessage.RequestUri.ToString(); // آدرس نهایی پس از ریدایرکت

                if (finalUrl != "https://qom.jahan-nama.com/")
                {
                    MessageBox.Show("شما مشترک اینترنت همای جهان‌نما نیستید. برنامه بسته می‌شود.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit(); // خروج از نرم‌افزار
                    return null; // خروجی نامعتبر برای متوقف شدن ادامه‌ی پردازش
                }

                // دریافت محتوای HTML صفحه اصلی
                string html = await client.GetStringAsync(url);

                // استفاده از Regex برای پیدا کردن مقدار ترافیک سرویس
                var regex = new Regex(@"<label class=""right"">ترافیک سرویس :<\/label>\s*<label class=""left"">(.*?)<\/label>", RegexOptions.Singleline);
                var match = regex.Match(html);

                if (match.Success)
                {
                    string trafficInfo = match.Groups[1].Value.Trim();
                    return trafficInfo;
                }
                else
                {
                    return "ترافیک سرویس پیدا نشد.";
                }
            }
            catch (Exception ex)
            {
                return "خطا در ارسال درخواست: " + ex.Message;
            }
        }


        private async void Main_frm_Load(object sender, EventArgs e)
        {
            this.Hide();
            string result = await GetTrafficFromWebsite(ReadFromRegistry(WebsiteURL));
            NotifIcon.ShowBalloonTip(100, "حجم اینترنت شما", result, ToolTipIcon.Info);
        }

        static string ReadFromRegistry(string ValueName)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKey);
                if (key != null)
                {
                    object value = key.GetValue(ValueName);
                    key.Close();
                    return value as string;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطا در خواندن آدرس سایت از رجیستری: " + ex.Message);
            }
            return null; // مقدار یافت نشد
        }

        static void SaveToRegistry(string url)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(registryKey);
                key.SetValue(WebsiteURL, url, RegistryValueKind.String);
                key.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("خطا در ذخیره آدرس سایت در رجیستری: " + ex.Message);
            }
        }

        static void CheckAndSaveURL()
        {
            string url = ReadFromRegistry(WebsiteURL);

            if (string.IsNullOrEmpty(url))
            {
                url = "https://qom.jahan-nama.com/";
                SaveToRegistry(url);
            }
            else
            {
                Console.WriteLine($"آدرس سایت از رجیستری خوانده شد: {url}");
            }
        }

        private async void AppMenu_Refresh_Click(object sender, EventArgs e)
        {
            string result = await GetTrafficFromWebsite(ReadFromRegistry(WebsiteURL));
            NotifIcon.ShowBalloonTip(100, "حجم اینترنت شما", result, ToolTipIcon.Info);
        }

        private void AppMenu_ChangeURL_Click(object sender, EventArgs e)
        {
            txtbox_WebSiteURL.Text = ReadFromRegistry(WebsiteURL);
            lblResult.Text = "آدرس لینک معتبر را وارد کنید";
            lblResult.ForeColor = System.Drawing.Color.Purple;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private async void btn_SetURL_Click(object sender, EventArgs e)
        {
            string url = txtbox_WebSiteURL.Text;

            if (IsValidUrl(url))
            {
                await CheckWebsiteAvailability(url);
            }
            else
            {
                lblResult.Text = "آدرس سایت معتبر نیست.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool IsValidUrl(string url)
        {
            string pattern = @"^(http|https):\/\/([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,6}(:[0-9]{1,5})?(\/.*)?$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(url);
        }

        private async Task CheckWebsiteAvailability(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    SaveToRegistry(url);
                    lblResult.Text = $"سایت {url} در دسترس است";
                    lblResult.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else
                {
                    SaveToRegistry("https://qom.jahan-nama.com/");
                    lblResult.Text = $"سایت {url} در دسترس نیست (کد: {response.StatusCode})";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                SaveToRegistry("https://qom.jahan-nama.com/");
                lblResult.Text = "خطا در ارسال درخواست: " + ex.Message;
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void NotifIcon_DoubleClick(object sender, EventArgs e)
        {
            AppMenu_Refresh_Click(sender, e);
        }

        private void Main_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
        }
    }
}
