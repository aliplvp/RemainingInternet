
namespace RemainingInternet
{
    partial class Main_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_frm));
            this.NotifIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.AppMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.AppMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.AppMenu_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.AppMenu_ChangeURL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SetURL = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtbox_WebSiteURL = new System.Windows.Forms.TextBox();
            this.AppMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifIcon
            // 
            this.NotifIcon.ContextMenuStrip = this.AppMenu;
            this.NotifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifIcon.Icon")));
            this.NotifIcon.Text = "باقیمانده حجم اینترنت";
            this.NotifIcon.Visible = true;
            this.NotifIcon.DoubleClick += new System.EventHandler(this.NotifIcon_DoubleClick);
            // 
            // AppMenu
            // 
            this.AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppMenu_ChangeURL,
            this.toolStripMenuItem2,
            this.AppMenu_Refresh,
            this.toolStripMenuItem1,
            this.AppMenu_Exit});
            this.AppMenu.Name = "AppMenu";
            this.AppMenu.Size = new System.Drawing.Size(203, 104);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // AppMenu_Exit
            // 
            this.AppMenu_Exit.Image = global::RemainingInternet.Properties.Resources.icons8_cancel_128px;
            this.AppMenu_Exit.Name = "AppMenu_Exit";
            this.AppMenu_Exit.Size = new System.Drawing.Size(202, 22);
            this.AppMenu_Exit.Text = "خروج";
            this.AppMenu_Exit.Click += new System.EventHandler(this.AppMenu_Exit_Click);
            // 
            // AppMenu_Refresh
            // 
            this.AppMenu_Refresh.Image = global::RemainingInternet.Properties.Resources.icons8_reset_128px;
            this.AppMenu_Refresh.Name = "AppMenu_Refresh";
            this.AppMenu_Refresh.Size = new System.Drawing.Size(202, 22);
            this.AppMenu_Refresh.Text = "محاسبه مجدد";
            this.AppMenu_Refresh.Click += new System.EventHandler(this.AppMenu_Refresh_Click);
            // 
            // AppMenu_ChangeURL
            // 
            this.AppMenu_ChangeURL.Image = global::RemainingInternet.Properties.Resources.icons8_rename_128px;
            this.AppMenu_ChangeURL.Name = "AppMenu_ChangeURL";
            this.AppMenu_ChangeURL.Size = new System.Drawing.Size(202, 22);
            this.AppMenu_ChangeURL.Text = "تغییر آدرس همای جهان نما";
            this.AppMenu_ChangeURL.Click += new System.EventHandler(this.AppMenu_ChangeURL_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "آدرس سایت همای جهان نما : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(105, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "نرم افزار باقیمانده حجم اینترنت همای جهان نما";
            // 
            // btn_SetURL
            // 
            this.btn_SetURL.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_SetURL.Location = new System.Drawing.Point(507, 140);
            this.btn_SetURL.Name = "btn_SetURL";
            this.btn_SetURL.Size = new System.Drawing.Size(75, 23);
            this.btn_SetURL.TabIndex = 4;
            this.btn_SetURL.Text = "ثبت";
            this.btn_SetURL.UseVisualStyleBackColor = true;
            this.btn_SetURL.Click += new System.EventHandler(this.btn_SetURL_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResult.ForeColor = System.Drawing.Color.Purple;
            this.lblResult.Location = new System.Drawing.Point(30, 144);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(471, 18);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "آدرس لینک معتبر را وارد کنید";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbox_WebSiteURL
            // 
            this.txtbox_WebSiteURL.Location = new System.Drawing.Point(232, 87);
            this.txtbox_WebSiteURL.Name = "txtbox_WebSiteURL";
            this.txtbox_WebSiteURL.Size = new System.Drawing.Size(350, 26);
            this.txtbox_WebSiteURL.TabIndex = 7;
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 175);
            this.ContextMenuStrip = this.AppMenu;
            this.Controls.Add(this.txtbox_WebSiteURL);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btn_SetURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار باقیمانده حجم اینترنت همای جهان نما";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_frm_FormClosing);
            this.Load += new System.EventHandler(this.Main_frm_Load);
            this.AppMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon NotifIcon;
        private System.Windows.Forms.ContextMenuStrip AppMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AppMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem AppMenu_Refresh;
        private System.Windows.Forms.ToolStripMenuItem AppMenu_ChangeURL;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SetURL;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtbox_WebSiteURL;
    }
}

