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

            AppRes.TotalLog.LoggerMessage += DoTotalLoggerMessage;
            AppRes.TestLog.LoggerMessage += DoTestLoggerMessage;
        }

        private void DoTotalLoggerMessage(string message)
        {
            if (this.InvokeRequired == true)
            {
                LoggerMessageHandler func = new LoggerMessageHandler(DoTotalLoggerMessage);
                this.BeginInvoke(func, new object[] { message });
            }
            else
            {
                totalLogEdit.Text += message + "\r\n";
            }
        }

        private void DoTestLoggerMessage(string message)
        {
            if (this.InvokeRequired == true)
            {
                LoggerMessageHandler func = new LoggerMessageHandler(DoTestLoggerMessage);
                this.BeginInvoke(func, new object[] { message });
            }
            else
            {
                AppRes.TotalLog.Log("TIMELESS", message);
                testLogEdit.Text += message + "\r\n";
            }
        }

        public void Clear()
        {
            testLogEdit.Clear();
        }
    }
}
