using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

using Ulee.Controls;
using Ulee.Utils;
using DevExpress.XtraGrid.Views.Grid;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlWorkGrid : UlUserControlEng
    {
        public Int64 RecipeNo { get; set; }

        public string SmuString { get; set; }

        public List<WorkRow> Rows;

        public int RecordIndex { get; set; }

        public bool Editable
        {
            get { return workGrid.OptionsBehavior.Editable; }
            set { workGrid.OptionsBehavior.Editable = value; }
        }

        public CtrlWorkGrid()
        {
            Dock = DockStyle.Fill;
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            NameValue<EItemCode>[] itemCodes = EnumHelper.GetNameValues<EItemCode>();
            workItemCodeLookUp.DataSource = itemCodes;
            workItemCodeLookUp.DisplayMember = "Name";
            workItemCodeLookUp.ValueMember = "Value";
            workItemCodeLookUp.KeyMember = "Value";

            NameValue<EOutputType>[] outputTypes = EnumHelper.GetNameValues<EOutputType>();
            workOutputTypeLookUp.DataSource = outputTypes;
            workOutputTypeLookUp.DisplayMember = "Name";
            workOutputTypeLookUp.ValueMember = "Value";
            workOutputTypeLookUp.KeyMember = "Value";

            NameValue<EOutputCalc>[] outputCalcs = EnumHelper.GetNameValues<EOutputCalc>();
            workOutputCalcLookUp.DataSource = outputCalcs;
            workOutputCalcLookUp.DisplayMember = "Name";
            workOutputCalcLookUp.ValueMember = "Value";
            workOutputCalcLookUp.KeyMember = "Value";

            NameValue<ECorrelation>[] correlations = EnumHelper.GetNameValues<ECorrelation>();
            workCorrelationLookUp.DataSource = correlations;
            workCorrelationLookUp.DisplayMember = "Name";
            workCorrelationLookUp.ValueMember = "Value";
            workCorrelationLookUp.KeyMember = "Value";

            AddMeasureChLookUpItems("None");

            RecipeNo = -1;
            RecordIndex = 0;

            Rows = new List<WorkRow>();
            AddRow();

            workGrid.DataSource = Rows;
        }

        private void workItemCodeLookUp_EditValueChanged(object sender, EventArgs e)
        {
            //workGrid.SetCellValue(workGrid.VisibleRows[(int)EWorkItem.InputNo], workGrid.FocusedRecord, "");
        }

        private void workPatternButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (RecipeNo <= 0) return;

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
                    workGrid.SetCellValue(workGrid.VisibleRows[(int)EWorkItem.BiasCH], workGrid.FocusedRecord, SmuString);
                }
            }
        }

        private void workBiasCHButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (RecipeNo <= 0) return;

            DialogSmuSelector dialog = new DialogSmuSelector(AppRes.Properties.SmuCount, Rows[workGrid.FocusedRecord].BiasCH);

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    workGrid.SetCellValue(workGrid.FocusedRow, workGrid.FocusedRecord, dialog.Result);
                }
            }
        }

        private void workInputNoButton_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (RecipeNo <= 0) return;

            DialogInputNoEdit dialog = new DialogInputNoEdit(
                (string)workGrid.GetCellValue(workGrid.FocusedRow, workGrid.FocusedRecord));

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    ValidateInputNoValue(dialog.Result);
                }
            }
        }

        private void workGrid_MouseDown(object sender, MouseEventArgs e)
        {
            VGridHitInfo hit = workGrid.CalcHitInfo(e.Location);

            if (hit == null) return;

            switch (hit.HitInfoType)
            {
                case HitInfoTypeEnum.ValueCell:
                    // Is No cell clicked?
                    if (hit.Row.VisibleIndex == (int)EWorkItem.No)
                    {
                        RecordIndex = hit.RecordIndex;
                        ResetAllRowBackground();
                    }
                    if (hit.Row.VisibleIndex == (int)EWorkItem.MeasureCH)
                    {
                        string biasCh = (string)workGrid.GetCellValue(workGrid.VisibleRows[(int)EWorkItem.BiasCH], hit.RecordIndex);
                        AddMeasureChLookUpItems(biasCh);
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

        private void workMeasureChLookUp_Enter(object sender, EventArgs e)
        {
        }

        private void workInputNoTextEdit_Leave(object sender, EventArgs e)
        {
            int value1, value2;
            int recordNo = workGrid.FocusedRecord + 1;

            TextEdit textEdit = sender as TextEdit;
            string editValue = (string)textEdit.EditValue;
            string[] inputNos = editValue.Trim().Split(',');

            EItemCode code = (EItemCode)workGrid.GetCellValue(
                workGrid.VisibleRows[(int)EWorkItem.ItemCode], workGrid.FocusedRecord);

            switch (code)
            {
                case EItemCode.N_PULSE_M:
                case EItemCode.N_MINUS_M:
                case EItemCode.N_MULTIPLY_M:
                case EItemCode.N_DIVIDE_M:
                    if ((inputNos.Length != 2) ||
                        (int.TryParse(inputNos[0], out value1) == false) ||
                        (int.TryParse(inputNos[1], out value2) == false) ||
                        (value1 >= recordNo) ||
                        (value2 >= recordNo))
                    {
                        workGrid.SetCellValue(workGrid.FocusedRow, workGrid.FocusedRecord, "");
                    }
                    break;

                default:
                    if ((inputNos.Length != 1) ||
                        (int.TryParse(inputNos[0], out value1) == false) ||
                        (value1 > recordNo))
                    {
                        workGrid.SetCellValue(workGrid.FocusedRow, workGrid.FocusedRecord, "");
                    }
                    break;
            }
        }

        private void ValidateInputNoValue(string value, bool showConfirmMessage=true)
        {
            int value1, value2;

            int recordNo = workGrid.FocusedRecord + 1;
            string[] inputNos = value.Split(',');

            EItemCode code = (EItemCode)workGrid.GetCellValue(
                workGrid.VisibleRows[(int)EWorkItem.ItemCode], workGrid.FocusedRecord);

            switch (code)
            {
                case EItemCode.N_PULSE_M:
                case EItemCode.N_MINUS_M:
                case EItemCode.N_MULTIPLY_M:
                case EItemCode.N_DIVIDE_M:
                    if ((inputNos.Length == 2) &&
                        (int.TryParse(inputNos[0], out value1) == true) &&
                        (int.TryParse(inputNos[1], out value2) == true) &&
                        (value1 < recordNo) &&
                        (value2 < recordNo))
                    {
                        workGrid.SetCellValue(workGrid.VisibleRows[(int)EWorkItem.InputNo], workGrid.FocusedRecord, value);
                    }
                    else
                    {
                        if (showConfirmMessage == true)
                        {
                            MessageBox.Show("Invalid value! Try to key in again!",
                                AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        workGrid.SetCellValue(workGrid.VisibleRows[(int)EWorkItem.InputNo], workGrid.FocusedRecord, "");
                    }
                    break;

                default:
                    if ((inputNos.Length == 1) &&
                        (int.TryParse(inputNos[0], out value1) == true) &&
                        (value1 <= recordNo))
                    {
                        workGrid.SetCellValue(workGrid.VisibleRows[(int)EWorkItem.InputNo], workGrid.FocusedRecord, value);
                    }
                    else
                    {
                        if (showConfirmMessage == true)
                        {
                            MessageBox.Show("Invalid value! Try to key in again!",
                            AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        workGrid.SetCellValue(workGrid.VisibleRows[(int)EWorkItem.InputNo], workGrid.FocusedRecord, "");
                    }
                    break;
            }
        }

        private void AddMeasureChLookUpItems(string channel)
        {
            List<NameValue<string>> items = new List<NameValue<string>>();

            channel = channel.Trim();
            if ((channel == "") || channel == "None")
            {
                items.Add(new NameValue<string>("None", "None"));
                items.Add(new NameValue<string>("CAN", "CAN"));
            }
            else
            {
                string[] channels = channel.Split(',');

                items.Add(new NameValue<string>("None", "None"));
                for (int i=0; i<channels.Length; i++)
                {
                    items.Add(new NameValue<string>($"{channels[i]}", $"{channels[i]}"));
                }
                items.Add(new NameValue<string>("CAN", "CAN"));
            }

            workMeasureChLookUp.DataSource = items.ToArray();
            workMeasureChLookUp.DisplayMember = "Name";
            workMeasureChLookUp.ValueMember = "Value";
            workMeasureChLookUp.KeyMember = "Value";
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

            WorkRow row = new WorkRow();
            row.Index = 0;
            row.TestPattern = "None(-1)";
            row.BiasCH = "None";
            row.MeasureCH = "None";
            row.InputNo = "None";
            row.TestRange = 0;

            if (Rows.Count == 0)
            {
                Rows.Add(row);
                RecordIndex = 0;
            }
            else
            {
                if (RecordIndex < Rows.Count - 1)
                {
                    Rows.Insert(RecordIndex + 1, row);
                }
                else
                {
                    Rows.Add(row);
                    RecordIndex++;
                }
            }

            ReorderIndex();
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

        private void ReorderIndex()
        {
            for (int i = 0; i < Rows.Count; i++)
            {
                Rows[i].Index = i + 1;
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
