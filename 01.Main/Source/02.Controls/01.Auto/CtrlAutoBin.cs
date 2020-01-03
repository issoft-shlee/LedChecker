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
    public partial class CtrlAutoBin : UlUserControlEng
    {
        public CtrlAutoBin()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            binBook.Document.LoadDocument(AppRes.Properties.FormWholeBin);
            binBook.WorksheetDisplayArea.SetSize(0, 10, 20);
        }
    }
}
