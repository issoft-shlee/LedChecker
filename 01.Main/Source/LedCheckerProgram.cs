using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using DevExpress.XtraEditors;

namespace IsSoft.Sec.LedChecker
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            bool isAlone;
            Mutex mutex = new Mutex(true, @"Global\IsSoft.Sec.LedChecker", out isAlone);

            if (isAlone == true)
            {
                WindowsFormsSettings.ForceDirectXPaint();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                try
                {
                    AppRes.Create();
                    AppRes.TotalLog.Log("Begin program");
                    Application.Run(new FormLedCheckerMain());
                }
                catch (Exception e)
                {
                    AppRes.TotalLog["EXCEPTION"] = e.ToString();
                    MessageBox.Show(e.ToString(), AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    AppRes.Destroy();
                    AppRes.TotalLog.Log("End program");

                    mutex.ReleaseMutex();
                }
            }
            else
            {
                MessageBox.Show(
                    "Cannot run this program because of running it already!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                Application.Exit();
            }
        }
    }
}
