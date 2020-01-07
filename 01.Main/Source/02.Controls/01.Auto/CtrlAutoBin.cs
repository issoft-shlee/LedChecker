using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Spreadsheet;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlAutoBin : UlUserControlEng
    {
        private TestContext context;

        public CtrlAutoBin(TestContext context)
        {
            this.context = context;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            binBook.Document.LoadDocument(AppRes.Properties.FormWholeBin);
            binBook.WorksheetDisplayArea.SetSize(0, 10, 20);
        }

        public void SetBinItems()
        {
            BinList bins = context.Recipe.Bin;
            Worksheet sheet = binBook.Document.Worksheets[0];

            binBook.BeginUpdate();
            try
            {
                sheet.ClearContents(sheet["A1:J20"]);

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int index = i * 10 + j;

                        if (index < bins.Count)
                        {
                            sheet.Cells[i * 2 + 0, j].FillColor = bins[i * 10 + j + 1].Mark;
                            sheet.Cells[i * 2 + 0, j].Value = bins[i * 10 + j + 1].Name;
                        }
                        else
                        {
                            sheet.Cells[i * 2 + 0, j].FillColor = Color.FromKnownColor(KnownColor.Transparent);
                            sheet.Cells[i * 2 + 0, j].Value = "";
                        }
                    }
                }
            }
            finally
            {
                binBook.EndUpdate();
            }
        }

        public void DispBinCounter(List<BinCounter> bins)
        {
            Worksheet sheet = binBook.Document.Worksheets[0];

            binBook.BeginUpdate();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        int index = i * 10 + j;

                        if (index < bins.Count)
                        {
                            string sValue = sheet.Cells[i * 2 + 0, j].Value.ToString();

                            if (sValue == "")
                                sheet.Cells[i * 2 + 1, j].Value = "";
                            else
                                sheet.Cells[i * 2 + 1, j].Value = bins[i * 10 + j].Count;
                        }
                        else
                        {
                            sheet.Cells[i * 2 + 1, j].Value = "";
                        }
                    }
                }
            }
            finally
            {
                binBook.EndUpdate();
            }
        }
    }
}
