using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class FormLedCheckerMain : UlFormEng
    {
        private const int csInvalidTime = 250;
        private const string csDateFormat = "yyyy-MM-dd";
        private const string csTimeFormat = "HH:mm:ss";

        private InvalidThread invalidThread;

        public FormLedCheckerMain()
        {
            InitializeComponent();
            Initialize();
        }

        private void FormLedCheckerMain_Load(object sender, EventArgs e)
        {
            Location = new Point(1920+1440, 0);
            DefMenu.Index = 0;
            DispVersion();

            invalidThread = new InvalidThread(csInvalidTime);
            invalidThread.InvalidControls += InvalidForm;
            invalidThread.Resume();
        }

        private void FormLedCheckerMain_Shown(object sender, EventArgs e)
        {
            AppRes.State = EAppState.Running;
        }

        private void FormLedCheckerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Would you like to exit this program?",
                AppRes.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormLedCheckerMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppRes.State = EAppState.Closing;

            if (invalidThread.IsAlive == true)
            {
                invalidThread.Terminate();
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            mainNotifyIcon.Visible = true;
            ShowInTaskbar = true;
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showUpMenuItem_Click(object sender, EventArgs e)
        {
            mainNotifyIcon.Visible = false;
            ShowInTaskbar = false;
            Show();
        }

        private void Initialize()
        {
            AppRes.Initialize();

            invalidThread = null;

            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlAutoRight(), testButton);
            DefMenu.Add(new CtrlManualRight(), deviceButton);
            DefMenu.Add(new CtrlViewRight(), viewButton);
            DefMenu.Add(new CtrlConfigRight(), configButton);
        }

        public override void InvalidForm(object sender, EventArgs e)
        {
            if (AppRes.State == EAppState.Closing) return;

            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(InvalidForm);
                this.BeginInvoke(func, new object[] { sender, e });
            }
            else
            {
                InvalidDateTime();
                InvalidUserControls(DefMenu);
            }
        }

        private void InvalidDateTime()
        {
            string sDate = DateTime.Now.ToString(csDateFormat);
            string sTime = DateTime.Now.ToString(csTimeFormat);

            if (datePanel.Text != sDate)
            {
                datePanel.Text = sDate;
            }

            if  (timePanel.Text != sTime)
            {
                timePanel.Text = sTime;
            }
        }

        private void InvalidUserControls(UlMenu menu)
        {
            if (menu == null) return;

            UlUserControlEng ctrl = menu.ActiveControl as UlUserControlEng;

            ctrl.InvalidControl(this, null);
            InvalidUserControls(ctrl.DefMenu);
        }

        private void DispVersion()
        {
           verPanel.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        //public void DispMessage(EMsgState state, string msg)
        //{
        //    if (this.InvokeRequired == true)
        //    {
        //        DispMessageHandler func = new DispMessageHandler(DispMessage);
        //        Invoke(func, new object[] { state, msg });
        //    }
        //    else
        //    {
        //        switch (state)
        //        {
        //            case EMsgState.None:
        //                messagePanel.BackColor = Color.Black;
        //                messagePanel.ForeColor = Color.White;
        //                break;

        //            case EMsgState.Emphasize:
        //                messagePanel.BackColor = Color.Blue;
        //                messagePanel.ForeColor = Color.White;
        //                break;

        //            case EMsgState.Alarm:
        //                messagePanel.BackColor = Color.Red;
        //                messagePanel.ForeColor = Color.Yellow;
        //                break;
        //        }

        //        messagePanel.Text = msg;
        //    }
        //}
    }
}
