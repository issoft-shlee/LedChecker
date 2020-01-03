using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public enum ETestButtonState { Started, Paused, Stopped }

    public partial class CtrlAutoRight : UlUserControlEng
    {
        public CtrlAutoRight()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlAutoMain(this), mainButton);
            DefMenu.Add(new CtrlAutoBin(), binButton);
            DefMenu.Index = 0;

            SetButtonState(ETestButtonState.Stopped);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case AppRes.WM_TEST_NORMAL_TERMINATED:
                    FinalizeTest();
                    break;

                case AppRes.WM_TEST_ABNORMAL_TERMINATED:
                    FinalizeTest();
                    break;
            }

            base.WndProc(ref m);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DefMenu.Index = 0;
            SetButtonState(ETestButtonState.Started);
            (DefMenu.Controls(0) as CtrlAutoMain).StartTest();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            SetButtonState(ETestButtonState.Paused);
            (DefMenu.Controls(0) as CtrlAutoMain).PauseTest();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            (DefMenu.Controls(0) as CtrlAutoMain).StopTest();
        }

        private void FinalizeTest()
        {
            SetButtonState(ETestButtonState.Stopped);
            (DefMenu.Controls(0) as CtrlAutoMain).FinalizeTest();
        }

        private void SetButtonState(ETestButtonState state)
        {
            switch (state)
            {
                case ETestButtonState.Started:
                    startButton.Enabled = false;
                    pauseButton.Enabled = true;
                    stopButton.Enabled = true;
                    break;

                case ETestButtonState.Paused:
                    startButton.Enabled = true;
                    pauseButton.Enabled = false;
                    stopButton.Enabled = true;
                    break;

                case ETestButtonState.Stopped:
                    startButton.Enabled = true;
                    pauseButton.Enabled = false;
                    stopButton.Enabled = false;
                    break;
            }
        }
    }
}
