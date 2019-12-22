using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlConfigLot : UlUserControlEng
    {
        private List<PatternRow> patternRows;

        public CtrlConfigLot()
        {
            InitializeComponent();
            Initialize();
        }

        private void CtrlConfigLot_Load(object sender, EventArgs e)
        {

        }

        private void CtrlConfigLot_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void findButton_Click(object sender, EventArgs e)
        {

        }

        private void newButton_Click(object sender, EventArgs e)
        {

        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int xLength = (int)xLengthEdit.Value;
            int yHeight = (int)yHeightEdit.Value;

            RefreshPatternGrid(xLength, yHeight);
        }

        private void Initialize()
        {
            patternRows = new List<PatternRow>();
            patternGrid.DataSource = patternRows;

            patternGridView.BeginUpdate();
            try
            {
                patternGridView.Columns.Clear();
                patternGridView.Columns.Add(CreateGridColumn("No", "No", 32));

                for (int i = 0; i < xLengthEdit.Properties.MaxValue; i++)
                {
                    patternGridView.Columns.Add(CreateGridColumn($"{i + 1}", $"F{i}", 64, true));
                }
            }
            finally
            {
                patternGridView.EndUpdate();
            }
        }

        private void SetPatternControls()
        {
            xLengthEdit.Value = 1;
            yHeightEdit.Value = 1;
            stringCountEdit.Value = 1;
            ledCountEdit.Value = 1;
        }

        private void RefreshPatternGrid(int length, int height)
        {
            patternRows.Clear();

            for (int i=0; i<height; i++)
            {
                PatternRow row = new PatternRow(i);

                for (int j=0; j<length; j++)
                {
                    row.Leds[j].Enabled = true;
                }

                patternRows.Add(row);
            }

            patternGridView.BeginUpdate();

            try
            {
                patternGridView.Columns[0].AppearanceCell.BackColor = Color.FromArgb(245, 245, 247);
                patternGridView.Columns[0].AppearanceCell.Options.UseBackColor = true;
                patternGridView.Columns[0].Visible = true;

                for (int i = 0; i < length; i++)
                {
                    patternGridView.Columns[i + 1].AppearanceCell.BackColor = Color.White;
                    patternGridView.Columns[i + 1].AppearanceCell.Options.UseBackColor = true;
                    patternGridView.Columns[i + 1].Visible = true;
                }
            }
            finally
            {
                patternGridView.EndUpdate();
            }
        }

        private GridColumn CreateGridColumn(string caption, string fieldName, int width, bool focus = false, bool visible=false)
        {
            GridColumn column = new GridColumn();

            column.Caption = caption;
            column.FieldName = fieldName;

            column.Width = width;
            column.Visible = visible;

            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            column.AppearanceCell.TextOptions.VAlignment = VertAlignment.Center;

            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            column.AppearanceHeader.TextOptions.VAlignment = VertAlignment.Center;

            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.AllowFocus = focus;
            column.OptionsColumn.AllowGroup = DefaultBoolean.False;
            column.OptionsColumn.AllowIncrementalSearch = false;
            column.OptionsColumn.AllowMerge = DefaultBoolean.False;
            column.OptionsColumn.AllowMove = false;
            column.OptionsColumn.AllowShowHide = false;
            column.OptionsColumn.AllowSize = false;
            column.OptionsColumn.AllowSort = DefaultBoolean.False;
            column.OptionsColumn.FixedWidth = true;
            column.OptionsColumn.ImmediateUpdateRowPosition = DefaultBoolean.False;
            column.OptionsColumn.Printable = DefaultBoolean.False;
            column.OptionsColumn.ReadOnly = true;
            column.OptionsColumn.ShowCaption = true;
            column.OptionsColumn.ShowInCustomizationForm = true;
            column.OptionsColumn.ShowInExpressionEditor = true;

            column.OptionsFilter.AllowAutoFilter = false;
            column.OptionsFilter.AllowFilter = false;

            return column;
        }

        private void patternGridView_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            GridHitInfo hit = view.CalcHitInfo(e.Location);

            if (hit == null) return;

            switch (hit.HitTest)
            {
                case GridHitTest.RowCell:
                    DialogLedProperty dialog = new DialogLedProperty();
                    try
                    {
                        dialog.ShowDialog();
                    }
                    finally
                    {
                    }
                    break;
            }
        }
    }
}
