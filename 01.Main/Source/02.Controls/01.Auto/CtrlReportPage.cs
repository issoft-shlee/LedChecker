using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlReportPage : UlUserControlEng
    {
        private int workCount;

        public CtrlReportPage()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Dock = DockStyle.Fill;

            workCount = 0;
            workBook.Document.LoadDocument(AppRes.Properties.FormWork);
            resultBook.Document.LoadDocument(AppRes.Properties.FormResult);
        }

        private void CtrlReportPage_Load(object sender, EventArgs e)
        {
            workBook.Width = Width;
            resultBook.Width = Width;
            resultBook.Height = Height - (resultPanel.Top + resultPanel.Height);
        }

        public void Clear()
        {

        }

        public void SetWorkItems(WorkItem work)
        {
            TestWorkList tests = work.Tests;
            ReportWorkList reports = work.Reports;
            Worksheet sheet = workBook.Document.Worksheets[0];

            workBook.BeginUpdate();

            try
            {
                sheet.ClearContents(sheet["B2:ZZ17"]);

                for (int i = 0; i < tests.Count; i++)
                {
                    sheet.Cells[1, i + 1].Value = tests[i + 1].Index;
                    sheet.Cells[2, i + 1].Value = tests[i + 1].ItemCode.ToString();
                    sheet.Cells[3, i + 1].Value = tests[i + 1].ItemName;
                    sheet.Cells[4, i + 1].Value = tests[i + 1].ItemRef;
                    sheet.Cells[5, i + 1].Value = tests[i + 1].TestPattern;
                    sheet.Cells[6, i + 1].Value = tests[i + 1].BiasCH;
                    sheet.Cells[7, i + 1].Value = tests[i + 1].BiasRange;
                    sheet.Cells[8, i + 1].Value = tests[i + 1].BiasValue;
                    sheet.Cells[9, i + 1].Value = tests[i + 1].ApplyTime;
                }

                for (int i = 0; i < reports.Count; i++)
                {
                    sheet.Cells[12, i + 1].Value = reports[i + 1].Index;
                    sheet.Cells[13, i + 1].Value = reports[i + 1].ItemCode.ToString();
                    sheet.Cells[14, i + 1].Value = reports[i + 1].ItemName;
                    sheet.Cells[15, i + 1].Value = reports[i + 1].ItemRef;
                    sheet.Cells[16, i + 1].Value = reports[i + 1].BiasCH;
                }

                int maxCount = (tests.Count > reports.Count) ? tests.Count + 1 : reports.Count + 1;

                if (maxCount < 12)
                {
                    maxCount = 12;
                    workBook.Options.HorizontalScrollbar.Visibility = SpreadsheetScrollbarVisibility.Hidden;
                }
                else
                {
                    workBook.Options.HorizontalScrollbar.Visibility = SpreadsheetScrollbarVisibility.Visible;
                }

                workBook.WorksheetDisplayArea.SetSize(0, maxCount, 17);
            }
            finally
            {
                workBook.EndUpdate();
            }

            sheet = resultBook.Document.Worksheets[0];
            resultBook.BeginUpdate();
            try
            {
                sheet.ClearContents(sheet["A1:ZZ1000"]);
                sheet.Cells["A1"].Value = "DateTime";
                sheet.Cells["B1"].Value = "ElapsedTime";
                sheet.Cells["C1"].Value = "Bin";

                for (int i = 0; i < reports.Count; i++)
                {
                    sheet.Cells[0, i + 3].Value = reports[i + 1].ItemName;
                }

                int maxCount = reports.Count + 3;

                if (maxCount < 12)
                {
                    maxCount = 12;
                    resultBook.Options.HorizontalScrollbar.Visibility = SpreadsheetScrollbarVisibility.Hidden;
                }
                else
                {
                    resultBook.Options.HorizontalScrollbar.Visibility = SpreadsheetScrollbarVisibility.Visible;
                }

                resultBook.WorksheetDisplayArea.SetSize(0, maxCount, 500);
            }
            finally
            {
                resultBook.EndUpdate();
            }
        }
    }
}
