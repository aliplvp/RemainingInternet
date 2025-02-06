using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemainingInternet
{
    static class Program
    {

        static Mutex mutex = new Mutex(true, "RemainingInternet");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                MessageBox.Show("برنامه از قبل در حال اجرا است!", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // برنامه اجرا نمی‌شود
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_frm());

            GC.KeepAlive(mutex);
        }
    }
}
