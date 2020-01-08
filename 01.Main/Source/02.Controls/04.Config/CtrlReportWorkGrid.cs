using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraEditors.Controls;


using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlReportWorkGrid : UlUserControlEng
    {
        public Int64 RecipeNo { get; set; }

        public string SmuString { get; set; }

        public List<TestWorkRow> TestRows;

        public List<ReportWorkRow> Rows;

        public int RecordIndex { get; set; }

        public bool Editable
        {
            get { return workGrid.OptionsBehavior.Editable; }
            set { workGrid.OptionsBehavior.Editable = value; }
        }

        public bool SimpleView
        { set { SetSimpleView(value); } }

        public CtrlReportWorkGrid()
        {
            Dock = DockStyle.Fill;

            InitializeComponent();
            Initialize();
        }

        private void workGrid_MouseDown(object sender, MouseEventArgs e)
        {
            VGridHitInfo hit = workGrid.CalcHitInfo(e.Location);

            if (hit == null) return;

            switch (hit.HitInfoType)
            {
                case HitInfoTypeEnum.ValueCell:
                    // Is No cell clicked?
                    if (hit.Row.VisibleIndex == (int)ETestWorkItem.No)
                    {
                        RecordIndex = hit.RecordIndex;
                        ResetAllRowBackground();
                    }
                    break;
            }
        }

        private void workGrid_RecordCellStyle(object sender, GetCustomRowCellStyleEventArgs e)
        {
            if (e.Row.VisibleIndex == 0)
            {
                e.Appearance.BackColor = SystemColors.Control;
            }
            else if (e.RecordIndex == RecordIndex)
            {
                e.Appearance.BackColor = Color.Linen;
            }
        }

        private void workItemCodeLookUp_CloseUp(object sender, CloseUpEventArgs e)
        {
            int record = workGrid.FocusedRecord;
            EReportItemCode code = (EReportItemCode)e.Value;

            workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.ItemName], record, $"{code.ToDescription()}-{record + 1}");
            workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.ItemRef], record, $"None");
            workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.BiasCH], record, $"None");
        }

        private void workItemRefButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int record = workGrid.FocusedRecord;
            EReportItemCode code = (EReportItemCode)workGrid.GetCellValue(
                workGrid.VisibleRows[(int)EReportWorkItem.ItemCode], record);

            List<string> items = CreateReportItemRefItems(ToTestItemCode(code));
            if (items.Count == 0)
            {
                workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.ItemRef], record, $"None");
                return;
            }

            DialogItemListBox dialog = new DialogItemListBox();
            dialog.Text = "Item Reference";
            dialog.Items = items;
            dialog.HAlignment = HorzAlignment.Center;
            dialog.DefaultItem = (string)workGrid.GetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.ItemRef], record);

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.ItemRef], record, dialog.Result);
                }
            }
        }

        private void workBiasCHButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int record = workGrid.FocusedRecord;
            string itemRef = (string)workGrid.GetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.ItemRef], record);
            
            List<string> items = CreateReportBiasCHItems(itemRef);
            if (items.Count == 0)
            {
                workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.BiasCH], record, $"None");
                return;
            }

            DialogItemListBox dialog = new DialogItemListBox();
            dialog.Text = "Bias Channel";
            dialog.Items = items;
            dialog.HAlignment = HorzAlignment.Center;
            dialog.DefaultItem = (string)workGrid.GetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.BiasCH], record);

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.BiasCH], record, dialog.Result);
                }
            }
        }

        private void workRankButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (RecipeNo <= 0) return;

            EReportItemCode code = (EReportItemCode)workGrid.GetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.ItemCode], workGrid.FocusedRecord);
            string rank = (string)workGrid.GetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.Rank], workGrid.FocusedRecord);
            Int64 rankNo = AppHelper.ExtractRecNo(rank);

            DialogRankList dialog = new DialogRankList(RecipeNo, rankNo, code);

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    workGrid.SetCellValue(workGrid.FocusedRow, workGrid.FocusedRecord, $"{dialog.Result.NameRecNo}");
                    workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.Lower], workGrid.FocusedRecord, dialog.Result.Lower);
                    workGrid.SetCellValue(workGrid.VisibleRows[(int)EReportWorkItem.Upper], workGrid.FocusedRecord, dialog.Result.Upper);
                }
            }
        }

        private void Initialize()
        {
            NameValue<EReportItemCode>[] itemCodes = EnumHelper.GetNameValues<EReportItemCode>();
            workItemCodeLookUp.DataSource = itemCodes;
            workItemCodeLookUp.DisplayMember = "Name";
            workItemCodeLookUp.ValueMember = "Value";
            workItemCodeLookUp.KeyMember = "Value";

            RecipeNo = 0;
            RecordIndex = 0;

            TestRows = null;
            Rows = new List<ReportWorkRow>();
            AddRow();

            workGrid.DataSource = Rows;
        }

        private void SetSimpleView(bool enabled)
        {
            workNull1Row.Visible = !enabled;
            workRankRow.Visible = !enabled;
            workLowerRow.Visible = !enabled;
            workUpperRow.Visible = !enabled;
        }

        private ETestItemCode ToTestItemCode(EReportItemCode code)
        {
            ETestItemCode testCode = ETestItemCode.VF;

            switch (code)
            {
                case EReportItemCode.VF:
                    testCode = ETestItemCode.VF;
                    break;

                case EReportItemCode.IF:
                    testCode = ETestItemCode.IF;
                    break;

                case EReportItemCode.VR:
                    testCode = ETestItemCode.VR;
                    break;

                case EReportItemCode.IR:
                    testCode = ETestItemCode.IR;
                    break;

                case EReportItemCode.Die_Lv:
                case EReportItemCode.Die_Lv_Uniformity:
                case EReportItemCode.Die_Contrast:
                case EReportItemCode.Die_Glare:
                case EReportItemCode.Cell_Lv:
                case EReportItemCode.Cell_Lv_Uniformity:
                case EReportItemCode.Cell_Contrast:
                    testCode = ETestItemCode.LMK_Luminance;
                    break;

                case EReportItemCode.Die_X:
                case EReportItemCode.Die_Y:
                case EReportItemCode.Die_XY:
                case EReportItemCode.Die_X_Uniformity:
                case EReportItemCode.Die_Y_Uniformity:
                case EReportItemCode.Cell_X:
                case EReportItemCode.Cell_Y:
                case EReportItemCode.Cell_XY:
                case EReportItemCode.Cell_X_Uniformity:
                case EReportItemCode.Cell_Y_Uniformity:
                    testCode = ETestItemCode.LMK_Color;
                    break;

                case EReportItemCode.IC_ON:
                    testCode = ETestItemCode.IC_ON;
                    break;

                case EReportItemCode.IC_OFF:
                    testCode = ETestItemCode.IC_OFF;
                    break;

                case EReportItemCode.IC_INIT:
                    testCode = ETestItemCode.IC_INIT;
                    break;

                case EReportItemCode.Safety_Check:
                    testCode = ETestItemCode.Safety_Check;
                    break;

                case EReportItemCode.EEPROM_Check:
                    testCode = ETestItemCode.EEPROM_Check;
                    break;

                case EReportItemCode.Watchdog_Enable:
                    testCode = ETestItemCode.Watchdog_Enable;
                    break;

                case EReportItemCode.Watchdog_Disable:
                    testCode = ETestItemCode.Watchdog_Disable;
                    break;

                case EReportItemCode.NTC_Check:
                    testCode = ETestItemCode.NTC_Check;
                    break;
            }

            return testCode;
        }

        private List<string> CreateReportItemRefItems(ETestItemCode code)
        {
            List<string> items = new List<string>();

            foreach (TestWorkRow row in TestRows)
            {
                if (row.ItemCode == code)
                {
                    string item = $"{row.ItemName}({row.Index})";
                    items.Add(item);
                }
            }

            return items;
        }

        private List<string> CreateReportBiasCHItems(string itemRef)
        {
            List<string> items = new List<string>();
            if (itemRef == "None") return items;

            string[] refs = itemRef.Trim().Split('(');
            if (refs.Length < 2) return items;

            string @ref = refs[refs.Length - 1];
            int testRowIndex;

            try
            {
                testRowIndex = int.Parse(@ref.Remove(@ref.Length - 1)) - 1;
            }
            catch
            {
                testRowIndex = -1;
            }

            if (testRowIndex < 0) return items;
            if (string.IsNullOrEmpty(TestRows[testRowIndex].BiasCH) == true) return items;
            if (TestRows[testRowIndex].BiasCH == "None") return items;

            string[] channels = TestRows[testRowIndex].BiasCH.Split(',');
            for (int i=0; i<channels.Length; i++)
            {
                items.Add($"SMU({channels[i]})");
            }

            return items;
        }

        public void AddRow()
        {
            if (Rows.Count >= 500)
            {
                MessageBox.Show("Report Work cannot be added any more because it is not over 500!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReportWorkRow row = new ReportWorkRow();

            if (Rows.Count == 0)
            {
                row.Index = 1;
                row.ItemName += $"-{row.Index}";
                Rows.Add(row);
                RecordIndex = 0;
            }
            else
            {
                if (RecordIndex < Rows.Count - 1)
                {
                    row.ItemName += $"-{RecordIndex + 2}";
                    Rows.Insert(RecordIndex + 1, row);
                }
                else
                {
                    row.ItemName += $"-{RecordIndex + 1}";
                    Rows.Add(row);
                    RecordIndex++;
                }

                ReorderIndex();
            }

            RefreshGridData();
        }

        public void DeleteRow()
        {
            if (Rows.Count <= 1)
            {
                MessageBox.Show("Report Work cannot delete any more because it is just one!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Rows.RemoveAt(RecordIndex);

            if (RecordIndex > Rows.Count - 1) RecordIndex = Rows.Count - 1;

            ReorderIndex();
            RefreshGridData();
        }

        private void ReorderIndex()
        {
            for (int i = 0; i < Rows.Count; i++)
            {
                Rows[i].Index = i + 1;
                string name = Rows[i].ItemCode.ToDescription();

                if (string.IsNullOrEmpty(Rows[i].ItemName) == true)
                {
                    Rows[i].ItemName = $"{name}-{i + 1}";
                }
                else
                {
                    if (Rows[i].ItemName.Substring(0, name.Length) == name)
                    {
                        if (Rows[i].ItemName.IndexOf('-') != -1)
                        {
                            string[] names = Rows[i].ItemName.Split('-');

                            if (names.Length == 2)
                            {
                                Rows[i].ItemName = $"{names[0]}-{i + 1}";
                            }
                        }
                    }
                }
            }
        }

        public bool Validation()
        {
            bool ret = false;

            foreach (ReportWorkRow row in Rows)
            {
                switch (row.ItemCode)
                {
                    case EReportItemCode.VF:
                    case EReportItemCode.IF:
                    case EReportItemCode.VR:
                    case EReportItemCode.IR:
                        ret = ValidationPower();
                        break;

                    case EReportItemCode.Die_Lv:
                    case EReportItemCode.Die_Lv_Uniformity:
                    case EReportItemCode.Die_Contrast:
                    case EReportItemCode.Die_Glare:
                    case EReportItemCode.Cell_Lv:
                    case EReportItemCode.Cell_Lv_Uniformity:
                    case EReportItemCode.Cell_Contrast:
                    case EReportItemCode.Die_X:
                    case EReportItemCode.Die_Y:
                    case EReportItemCode.Die_XY:
                    case EReportItemCode.Die_X_Uniformity:
                    case EReportItemCode.Die_Y_Uniformity:
                    case EReportItemCode.Cell_X:
                    case EReportItemCode.Cell_Y:
                    case EReportItemCode.Cell_XY:
                    case EReportItemCode.Cell_X_Uniformity:
                    case EReportItemCode.Cell_Y_Uniformity:
                        ret = ValidationLMK();
                        break;

                    case EReportItemCode.IC_ON:
                    case EReportItemCode.IC_OFF:
                    case EReportItemCode.IC_INIT:
                    case EReportItemCode.Safety_Check:
                    case EReportItemCode.EEPROM_Check:
                    case EReportItemCode.Watchdog_Enable:
                    case EReportItemCode.Watchdog_Disable:
                    case EReportItemCode.NTC_Check:
                        ret = ValidationDriverIC();
                        break;
                }
            }

            return ret;
        }

        private bool ValidationPower()
        {
            return true;
        }

        private bool ValidationLMK()
        {
            return true;
        }

        private bool ValidationDriverIC()
        {
            return true;
        }

        public void RefreshGridData()
        {
            workGrid.BeginUpdate();
            try
            {
                workGrid.RefreshDataSource();
            }
            finally
            {
                workGrid.EndUpdate();
            }
        }

        private void ResetAllRowBackground()
        {
            workGrid.BeginUpdate();

            try
            {
                foreach (BaseRow row in workGrid.Rows)
                {
                    row.Appearance.BackColor = Color.White;
                }
            }
            finally
            {
                workGrid.EndUpdate();
            }
        }
    }
}
