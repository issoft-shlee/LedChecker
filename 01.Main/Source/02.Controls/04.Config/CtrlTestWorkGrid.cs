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
    public partial class CtrlTestWorkGrid : UlUserControlEng
    {
        public Int64 RecipeNo { get; set; }

        public string SmuString { get; set; }

        public List<TestWorkRow> Rows;

        public int RecordIndex { get; set; }

        public bool Editable
        {
            get { return workGrid.OptionsBehavior.Editable; }
            set { workGrid.OptionsBehavior.Editable = value; }
        }

        public bool SimpleView
        { set { SetSimpleView(value); } }

        public CtrlTestWorkGrid()
        {
            Dock = DockStyle.Fill;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            NameValue<ETestItemCode>[] itemCodes = EnumHelper.GetNameValues<ETestItemCode>();
            workItemCodeLookUp.DataSource = itemCodes;
            workItemCodeLookUp.DisplayMember = "Name";
            workItemCodeLookUp.ValueMember = "Value";
            workItemCodeLookUp.KeyMember = "Value";

            NameValue<EOpticalType>[] opticals = EnumHelper.GetNameValues<EOpticalType>();
            workOpticalLookUp.DataSource = opticals;
            workOpticalLookUp.DisplayMember = "Name";
            workOpticalLookUp.ValueMember = "Value";
            workOpticalLookUp.KeyMember = "Value";

            RecipeNo = 0;
            RecordIndex = 0;

            Rows = new List<TestWorkRow>();
            AddRow();

            workGrid.DataSource = Rows;
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

        private void workItemCodeLookUp_CloseUp(object sender, CloseUpEventArgs e)
        {
            ETestItemCode code = (ETestItemCode)e.Value;

            workGrid.SetCellValue(workGrid.VisibleRows[(int)ETestWorkItem.ItemName], 
                workGrid.FocusedRecord, $"{code.ToDescription()}-{workGrid.FocusedRecord + 1}");

            workGrid.SetCellValue(workGrid.VisibleRows[(int)ETestWorkItem.ItemRef],
                workGrid.FocusedRecord, "None");
        }

        private void workReferenceButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int record = workGrid.FocusedRecord;
            int index = (int)GetCellValue(ETestWorkItem.No, record);
            ETestItemCode code = (ETestItemCode)GetCellValue(ETestWorkItem.ItemCode, record);
            string refNo = (string)GetCellValue(ETestWorkItem.ItemRef, record);

            if ((code != ETestItemCode.LMK_Luminance) && (code != ETestItemCode.LMK_Color)) return;

            List<string> items = CreateItemRefItems(code, index);
            if (items.Count == 0)
            {
                workGrid.SetCellValue(workGrid.VisibleRows[(int)ETestWorkItem.ItemRef], record, $"None");
                return;
            }

            DialogItemListBox dialog = new DialogItemListBox();
            dialog.Text = "Item Reference";
            dialog.Items = items;
            dialog.DefaultItem = (string)workGrid.GetCellValue(workGrid.VisibleRows[(int)ETestWorkItem.ItemRef], record);
            dialog.Mode = SelectionMode.MultiSimple;
            dialog.HAlignment = HorzAlignment.Center;

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    string result = "";
                    foreach (string item in dialog.SelectedItems)
                    {
                        if (result == "") result = item;
                        else result += $",{item}";
                    }

                    if (result == "") result = "None";

                    workGrid.SetCellValue(workGrid.VisibleRows[(int)ETestWorkItem.ItemRef], record, result);

                    SetCellValue(ETestWorkItem.TestPattern, record, "None(0)");
                    SetCellValue(ETestWorkItem.BiasCH, record, "None");
                    SetCellValue(ETestWorkItem.BiasRange, record, "None");
                    SetCellValue(ETestWorkItem.BiasValue, record, "None");
                    SetCellValue(ETestWorkItem.ApplyTime, record, 0.0);
                    SetCellValue(ETestWorkItem.TransientTime, record, 0.0);
                    SetCellValue(ETestWorkItem.HumCounter, record, 0);
                    //SetCellValue(ETestWorkItem.Optical, record, EOpticalType.None);
                    SetCellValue(ETestWorkItem.Integ_VL, record, 0.0001);
                    SetCellValue(ETestWorkItem.Integ_X1, record, 0.0001);
                    SetCellValue(ETestWorkItem.Integ_X2, record, 0.0001);
                    SetCellValue(ETestWorkItem.Integ_Z, record, 0.0001);
                    SetCellValue(ETestWorkItem.Gain, record, 1.0);
                    SetCellValue(ETestWorkItem.Offet, record, 0.0);
                }
            }
        }

        private void workBiasRangeButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            string refNo = (string)GetCellValue(ETestWorkItem.ItemRef, workGrid.FocusedRecord);
            if (refNo != "None") return;

            string smu = (string)GetCellValue(ETestWorkItem.BiasCH, workGrid.FocusedRecord);
            string[] smus = smu.Split(',');

            if ((smu == "None") || (smus.Length == 0))
            {
                SetCellValue(ETestWorkItem.BiasRange, workGrid.FocusedRecord, "None");
                return;
            }

            ETestItemCode code = (ETestItemCode)GetCellValue(ETestWorkItem.ItemCode, workGrid.FocusedRecord);
            string range = (string)GetCellValue(ETestWorkItem.BiasRange, workGrid.FocusedRecord);
            if (string.IsNullOrEmpty(range) == true) range = "";

            switch (code)
            {
                case ETestItemCode.VF:
                case ETestItemCode.VR:
                    ShowBiasDialog("Bias Range(V)", range, smus.Length);
                    break;

                case ETestItemCode.IF:
                case ETestItemCode.IR:
                    ShowBiasDialog("Bias Range(A)", range, smus.Length);
                    break;
            }
        }

        private void workBiasValueButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            string refNo = (string)GetCellValue(ETestWorkItem.ItemRef, workGrid.FocusedRecord);
            if (refNo != "None") return;

            string smu = (string)GetCellValue(ETestWorkItem.BiasCH, workGrid.FocusedRecord);
            string[] smus = smu.Split(',');

            if ((smu == "None") || (smus.Length == 0))
            {
                SetCellValue(ETestWorkItem.BiasValue, workGrid.FocusedRecord, "None");
                return;
            }

            ETestItemCode code = (ETestItemCode)GetCellValue(ETestWorkItem.ItemCode, workGrid.FocusedRecord);
            string bias = (string)GetCellValue(ETestWorkItem.BiasValue, workGrid.FocusedRecord);
            if (string.IsNullOrEmpty(bias) == true) bias = "";

            switch (code)
            {
                case ETestItemCode.IF:
                case ETestItemCode.IR:
                    ShowBiasDialog("Bias Value(V)", bias, smus.Length);
                    break;

                default:
                    ShowBiasDialog("Bias Value(A)", bias, smus.Length);
                    break;
            }
        }

        private void workPatternButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (RecipeNo <= 0) return;

            ETestItemCode code = (ETestItemCode)GetCellValue(ETestWorkItem.ItemCode, workGrid.FocusedRecord);
            if (code >= ETestItemCode.IC_ON) return;

            string refNo = (string)GetCellValue(ETestWorkItem.ItemRef, workGrid.FocusedRecord);
            if (refNo != "None") return;

            DialogPatternList dialog = new DialogPatternList(RecipeNo);
            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    workGrid.SetCellValue(workGrid.FocusedRow, workGrid.FocusedRecord, $"{dialog.Result.Name}({dialog.Result.RecNo})");
                    workGrid.SetCellValue(workGrid.VisibleRows[(int)ETestWorkItem.BiasCH], workGrid.FocusedRecord, dialog.Result.Smu);

                    if (dialog.Result.RecNo < 1)
                    {
                        workGrid.SetCellValue(workGrid.VisibleRows[(int)ETestWorkItem.BiasRange], workGrid.FocusedRecord, "None");
                        workGrid.SetCellValue(workGrid.VisibleRows[(int)ETestWorkItem.BiasValue], workGrid.FocusedRecord, "None");
                    }
                }
            }
        }

        private void workOpticalSpinEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            ETestItemCode code = (ETestItemCode)GetCellValue(ETestWorkItem.ItemCode, workGrid.FocusedRecord);
            if ((code != ETestItemCode.LMK_Luminance) && (code != ETestItemCode.LMK_Color))
            {
                e.Cancel = true;
                return;
            }

            string refNo = (string)GetCellValue(ETestWorkItem.ItemRef, workGrid.FocusedRecord);
            if (refNo != "None")
            {
                e.Cancel = true;
                return;
            }

            if (code == ETestItemCode.LMK_Luminance)
            {
                if (workGrid.FocusedRow != workGrid.VisibleRows[(int)ETestWorkItem.Integ_VL])
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void workTextEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            string refNo = (string)GetCellValue(ETestWorkItem.ItemRef, workGrid.FocusedRecord);
            if (refNo != "None")
            {
                e.Cancel = true;
                return;
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

        private void SetSimpleView(bool enabled)
        {
            workNull1Row.Visible = !enabled;
            workHumCounterRow.Visible = !enabled;
            workNull2Row.Visible = !enabled;
            workIntegVLRow.Visible = !enabled;
            workIntegX1Row.Visible = !enabled;
            workIntegX2Row.Visible = !enabled;
            workIntegZRow.Visible = !enabled;
            workNull3Row.Visible = !enabled;
            workGainRow.Visible = !enabled;
            workOffsetRow.Visible = !enabled;
        }

        private List<string> CreateItemRefItems(ETestItemCode code, int index)
        {
            List<string> items = new List<string>();

            foreach (TestWorkRow row in Rows)
            {
                if ((row.Index < index) && (row.ItemCode == code) && (row.TestPattern != "None(0)"))
                {
                    string item = $"{row.Index}";
                    items.Add(item);
                }
            }

            return items;
        }

        private void ShowBiasDialog(string caption, string value, int length)
        {
            DialogInputNoEdit dialog = new DialogInputNoEdit(value);
            dialog.FormText = caption;
            dialog.MaxLength = 50;

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    double fValue = double.NaN;
                    string[] ranges = dialog.Result.Split(',');

                    if (ranges.Length == length)
                    {
                        foreach (string s in ranges)
                        {
                            try
                            {
                                fValue = double.Parse(s);
                            }
                            catch
                            {
                                fValue = double.NaN;
                            }

                            if (double.IsNaN(fValue) == true) break;
                        }
                    }

                    ETestWorkItem workItem = (caption.Substring(0, 10) == "Bias Range") ? ETestWorkItem.BiasRange : ETestWorkItem.BiasValue;
                    value = (double.IsNaN(fValue) == false) ? dialog.Result : "None";

                    SetCellValue(workItem, workGrid.FocusedRecord, value);
                }
            }
        }

        private object GetCellValue(ETestWorkItem item, int record)
        {
            return workGrid.GetCellValue(workGrid.VisibleRows[(int)item], record);
        }

        private void SetCellValue(ETestWorkItem item, int record, object value)
        {
            workGrid.SetCellValue(workGrid.VisibleRows[(int)item], record, value);
        }

        private bool DuplicatedString(string[] strings, string str)
        {
            int i = 0;

            foreach(string s in strings)
            {
                if (s == str) i++;
            }

            return (i > 1) ? true : false;
        }

        public void ClearGrid()
        {
            Rows.Clear();
            AddRow();
        }

        public void AddRow()
        {
            if (Rows.Count >= 500)
            {
                MessageBox.Show("Test Work cannot be added any more because it is not over 500!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TestWorkRow row = new TestWorkRow();

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
                MessageBox.Show("Test Work cannot delete any more because it is just one!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Rows.RemoveAt(RecordIndex);

            if (RecordIndex > Rows.Count - 1) RecordIndex = Rows.Count - 1;

            ReorderIndex();
            RefreshGridData();
        }

        public bool Validation()
        {
            bool ret = false;

            foreach (TestWorkRow row in Rows)
            {
                switch (row.ItemCode)
                {
                    case ETestItemCode.VF:
                    case ETestItemCode.IF:
                    case ETestItemCode.VR:
                    case ETestItemCode.IR:
                        ret = ValidationPower();
                        break;

                    case ETestItemCode.LMK_Pattern:
                    case ETestItemCode.LMK_Luminance:
                    case ETestItemCode.LMK_Color:
                        ret = ValidationLMK();
                        break;

                    case ETestItemCode.IC_ON:
                    case ETestItemCode.IC_OFF:
                    case ETestItemCode.IC_INIT:
                    case ETestItemCode.Safety_Check:
                    case ETestItemCode.EEPROM_Check:
                    case ETestItemCode.Watchdog_Enable:
                    case ETestItemCode.Watchdog_Disable:
                    case ETestItemCode.NTC_Check:
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
