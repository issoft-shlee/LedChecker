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
        private WorkObject workObject;

        public CtrlReportPage()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            workObject = null;
            Dock = DockStyle.Fill;

            workBook.Document.LoadDocument(AppRes.Properties.FormWork);
            resultBook.Document.LoadDocument(AppRes.Properties.FormResult);
        }

        private void CtrlReportPage_Load(object sender, EventArgs e)
        {
            workBook.Width = Width;
            resultBook.Width = Width;
            resultBook.Height = Height - (resultPanel.Top + resultPanel.Height);
        }

        public void SetWorkIndex(int index)
        {
            if (workObject == null) return;

            Worksheet sheet = workBook.Document.Worksheets[0];
            workBook.BeginUpdate();

            try
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < workObject.Tests.Count; j++)
                    {
                        sheet.Cells[i + 1, j + 1].FillColor = Color.FromKnownColor(KnownColor.Transparent);
                    }
                }

                if (index >= 0)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        sheet.Cells[i + 1, index + 1].FillColor = Color.Linen;
                    }
                }
            }
            finally
            {
                workBook.EndUpdate();
            }
        }

        public void SetWorkObjects(WorkObject work)
        {
            workObject = work;
            TestWorkList tests = workObject.Tests;
            ReportWorkList reports = workObject.Reports;
            Worksheet sheet = workBook.Document.Worksheets[0];

            workBook.BeginUpdate();

            try
            {
                sheet.ClearContents(sheet["B1:ZZ17"]);

                for (int i = 0; i < tests.Count; i++)
                {
                    sheet.Cells[0, i + 1].Value = tests[i + 1].Index;
                    sheet.Cells[1, i + 1].Value = tests[i + 1].ItemCodeN.ToString();
                    sheet.Cells[2, i + 1].Value = tests[i + 1].ItemCodeS.ToString();
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

                workBook.WorksheetDisplayArea.SetSize(0, maxCount, 18);
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
                sheet.Cells["B1"].Value = "Elapsed Time";
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
