using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlAutoLog : UlUserControlEng
    {
        public CtrlAutoLog()
        {
            InitializeComponent();
        }

        private void CtrlAutoLog_Load(object sender, EventArgs e)
        {
            AppRes.TestLog.LoggerMessage += DoLoggerMessage;
        }

        private void DoLoggerMessage(string message)
        {
            if (this.InvokeRequired == true)
            {
                LoggerMessageHandler func = new LoggerMessageHandler(DoLoggerMessage);
                this.BeginInvoke(func, new object[] { message });
            }
            else
            {
                AppRes.TotalLog.Log("TIMELESS", message);
                logEdit.Text += message + "\r\n";
            }
        }

        public void Clear()
        {
            logEdit.Clear();
        }
    }
}
