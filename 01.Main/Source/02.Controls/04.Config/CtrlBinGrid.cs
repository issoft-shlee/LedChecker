using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;

using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlBinGrid : UlUserControlEng
    {
        private List<BinRow> bins;

        public Int64 RecipeNo { get; set; }

        public EWorkType Type { get; set; }

        public bool ReadOnly
        {
            get { return binGridView.OptionsBehavior.ReadOnly; }
            set { binGridView.OptionsBehavior.ReadOnly = value; }
        }

        public CtrlBinGrid(List<BinRow> bins)
        {
            this.bins = bins;
            RecipeNo = 0;
            Type = EWorkType.Normal;

            InitializeComponent();
            Initialize();
        }

        private void binFormulaButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string sFormula = "";

            if (ReadOnly == true) return;

            // if name field is empty, can't key in
            string name = (string)binGridView.GetRowCellValue(binGridView.FocusedRowHandle, binGridView.VisibleColumns[1]);
            if (string.IsNullOrWhiteSpace(name) == true) return;

            // if prior formula field is empty, can't key in
            if (binGridView.FocusedColumn.VisibleIndex > 4)
            {
                sFormula = (string)binGridView.GetRowCellValue(
                    binGridView.FocusedRowHandle, binGridView.VisibleColumns[binGridView.FocusedColumn.VisibleIndex - 2]);

                if (string.IsNullOrWhiteSpace(sFormula) == true) return;
            }

            sFormula = (string)binGridView.GetRowCellValue(
                binGridView.FocusedRowHandle, binGridView.VisibleColumns[binGridView.FocusedColumn.VisibleIndex]);

            DialogBinFormulaEdit dialog = new DialogBinFormulaEdit(RecipeNo, Type, sFormula);

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    binGridView.SetRowCellValue(binGridView.FocusedRowHandle, binGridView.FocusedColumn, dialog.Result);
                }
            }
        }

        private void Initialize()
        {
            Dock = DockStyle.Fill;

            binLogicLookUpEdit.DataSource = EnumHelper.GetNameValues<EBinLogic>();
            binLogicLookUpEdit.DisplayMember = "Name";
            binLogicLookUpEdit.ValueMember = "Value";
            binLogicLookUpEdit.KeyMember = "Value";

            binGridView.BeginUpdate();
            try
            {
                for (int i = 0; i < AppRes.Properties.FormulaCount; i++)
                {
                    binGridView.Columns.Add(CreateGridColumn($"Logic", $"Logic{i + 1}", 
                        binLogicLookUpEdit, 52, 52, i, (i==0) ? false : true, HorzAlignment.Center, true, false, false));

                    binGridView.Columns.Add(CreateGridColumn($"Formula", $"Formula{i + 1}",
                        binFormulaButtonEdit, 200, 100, i, true, HorzAlignment.Near, true, true, false));
                }
            }
            finally
            {
                binGridView.EndUpdate();
            }

            binGrid.DataSource = bins;
            binGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            binGridView.OptionsView.EnableAppearanceEvenRow = true;
        }

        private GridColumn CreateGridColumn(string caption, string fieldName, 
            RepositoryItem colEdit, int width, int minWidth, int tag=0, bool visible=true, 
            HorzAlignment hAlign=HorzAlignment.Near, bool edit=true, bool size=true, bool fixedWidth=false)
        {
            GridColumn column = new GridColumn();

            column.Caption = caption;
            column.FieldName = fieldName;
            column.ColumnEdit = colEdit;
            column.Width = width;
            column.MinWidth = minWidth;
            column.Tag = tag;

            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = hAlign;

            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = hAlign;

            column.OptionsColumn.AllowEdit = edit;
            column.OptionsColumn.AllowFocus = edit;
            column.OptionsColumn.AllowGroup = DefaultBoolean.False;
            column.OptionsColumn.AllowIncrementalSearch = false;
            column.OptionsColumn.AllowMerge = DefaultBoolean.False;
            column.OptionsColumn.AllowMove = false;
            column.OptionsColumn.AllowShowHide = false;
            column.OptionsColumn.AllowSize = size;
            column.OptionsColumn.AllowSort = DefaultBoolean.False;
            column.OptionsColumn.FixedWidth = fixedWidth;
            column.OptionsColumn.ImmediateUpdateRowPosition = DefaultBoolean.False;
            column.OptionsColumn.Printable = DefaultBoolean.False;
            column.OptionsColumn.ReadOnly = !edit;
            column.OptionsColumn.ShowCaption = true;

            column.Visible = visible;

            column.OptionsFilter.AllowAutoFilter = false;
            column.OptionsFilter.AllowFilter = false;

            return column;
        }

        public void RefreshData()
        {
            AppHelper.RefreshGridData(binGridView);
        }
    }
}
