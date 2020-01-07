using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Ulee.Utils;
using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlAutoMain : UlUserControlEng
    {
        private TestContext context;

        private CtrlReportPage reportPage;

        public CtrlAutoMain(TestContext context)
        {
            this.context = context;

            InitializeComponent();
            Initialize();
        }

        private void CtrlAutoMain_Load(object sender, EventArgs e)
        {
        }

        private void CtrlAutoMain_Enter(object sender, EventArgs e)
        {
        }

        private void Initialize()
        {
            reportPage = new CtrlReportPage();
            reportPagePanel.Controls.Add(reportPage);
        }

        public void SetWorkObjects()
        {
            reportPage.SetWorkObjects(context.Recipe.Work);
        }

        public void SetTestIndex(int index)
        {
            reportPage.SetWorkIndex(index);
        }
    }
}
