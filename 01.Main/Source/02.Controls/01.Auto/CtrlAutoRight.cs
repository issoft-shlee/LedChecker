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
    public partial class CtrlAutoRight : UlUserControlEng
    {
        public CtrlAutoRight()
        {
            InitializeComponent();
            Initialize();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        private void Initialize()
        {
            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlAutoMain(), mainButton);
            DefMenu.Add(new CtrlAutoState(), stateButton);
            DefMenu.Index = 0;
        }
    }
}
