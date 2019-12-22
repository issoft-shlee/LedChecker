using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public enum EPatternDispMode { String, StringAndLamp }

    public partial class CtrlPatternGrid : UlUserControlEng
    {
        private Font patternNoFont;

        private EPatternDispMode mode;

        public int XLength { get; set; }

        public int XMaxLength { get; set; }

        public int YHeight { get; set; }

        public int StringCount { get; set; }

        public int LedCount { get; set; }

        public List<PatternRow> PatternRows;

        public List<int> stringToSmus;

        public bool ReadOnly
        {
            get { return patternGridView.OptionsBehavior.ReadOnly; }
            set { patternGridView.OptionsBehavior.ReadOnly = value; }
        }

        public CtrlPatternGrid(
            EPatternDispMode mode = EPatternDispMode.String, List<int> stringToSmus = null, int xMaxLength = 50)
        {
            this.stringToSmus = stringToSmus;

            InitializeComponent();
            Initialize(mode, xMaxLength);
        }

        private void Initialize(EPatternDispMode mode, int xMaxLength)
        {
            this.mode = mode;
            patternGridView.RowHeight = (mode == EPatternDispMode.String) ? 25 : 34;

            XMaxLength = xMaxLength;
            Dock = DockStyle.Fill;

            patternNoFont = new Font("Arial", 8);

            PatternRows = new List<PatternRow>();
            patternGrid.DataSource = PatternRows;

            patternGridView.BeginUpdate();
            try
            {
                patternGridView.Columns.Clear();
                patternGridView.Columns.Add(CreateGridColumn(" ", "No", 14));

                for (int i = 0; i <XMaxLength; i++)
                {
                    patternGridView.Columns.Add(CreateGridColumn($"{i + 1}", $"F{i}", 42, true));
                }
            }
            finally
            {
                patternGridView.EndUpdate();
            }
        }

        private void patternGridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            int smuIndex = 0;
            GridView view = sender as GridView;

            if (e == null) return;
            if (e.Column == null) return;
            if (e.Column.FieldName == "No") return;

            LedProperty led = PatternRows[e.RowHandle].Leds[e.Column.AbsoluteIndex - 1];

            e.Appearance.Font = patternNoFont;
            e.Appearance.Options.UseTextOptions = true;
            e.Appearance.TextOptions.VAlignment = (mode == EPatternDispMode.String) ? VertAlignment.Center : VertAlignment.Top;

            switch (led.Type)
            {
                case ELedType.Disabled:
                    e.Appearance.BackColor = Color.White;
                    break;

                case ELedType.Enabled:
                    if ((stringToSmus.Count > 0) && (stringToSmus.Count >= led.StringIndex))
                    {
                        smuIndex = stringToSmus[led.StringIndex - 1];
                        if (smuIndex != -1)
                        {
                            e.Appearance.BackColor = Color.FromKnownColor(AppRes.Properties.SmuColors[smuIndex]);
                        }
                    }
                    break;

                case ELedType.Black:
                    e.Appearance.BackColor = Color.Black;
                    break;
            }

            e.Appearance.ForeColor = Color.Black;
            e.DefaultDraw();

            if (mode == EPatternDispMode.StringAndLamp)
            {
                switch (led.Type)
                {
                    case ELedType.Enabled:
                        e.Cache.DrawRectangle(e.Bounds.X + (e.Bounds.Width / 2 - 9), e.Bounds.Y + 22, 8, 8, Color.Gray, 1);
                        e.Cache.FillRectangle((led.TurnOn == true) ? Color.Red : Color.DarkGray, 
                            new Rectangle((e.Bounds.X + e.Bounds.Width / 2 - 8), e.Bounds.Y + 23, 6, 6));

                        e.Cache.DrawRectangle(e.Bounds.X + (e.Bounds.Width / 2 + 2), e.Bounds.Y + 22, 8, 8, Color.Gray, 1);
                        e.Cache.FillRectangle((led.Measuring == true) ? Color.Lime : Color.DarkGray, 
                            new Rectangle(e.Bounds.X + (e.Bounds.Width / 2 + 3), e.Bounds.Y + 23, 6, 6));
                        break;

                    case ELedType.Black:
                        e.Cache.DrawRectangle(e.Bounds.X + (e.Bounds.Width / 2 - 4), 
                            e.Bounds.Y + (e.Bounds.Height / 2 + 4), 8, 8, Color.Gray, 1);
                        e.Cache.FillRectangle((led.Measuring == true) ? Color.Lime : Color.DarkGray, 
                            new Rectangle(e.Bounds.X + (e.Bounds.Width / 2 - 3), e.Bounds.Y + (e.Bounds.Height / 2 + 5), 6, 6));
                        break;
                }
            }

            e.Handled = true;
        }

        private void patternGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo hit = view.CalcHitInfo(ea.Location);

            if (hit == null) return;
            if (ReadOnly == true) return;

            if (hit.HitTest == GridHitTest.RowCell)
            {
                int focusedRow = view.FocusedRowHandle;
                int focusedCol = view.FocusedColumn.AbsoluteIndex - 1;
                LedProperty led = PatternRows[focusedRow].Leds[focusedCol];

                switch (mode)
                {
                    case EPatternDispMode.String:
                        ShowLedDialog(led);
                        break;

                    case EPatternDispMode.StringAndLamp:
                        if (led.Type != ELedType.Disabled)
                        {
                            ShowLedDialog(led);
                        }
                        break;
                }

                RefreshGridData();
            }
        }

        private void ShowLedDialog(LedProperty led)
        {
            LedProperty newLed = new LedProperty();
            CopyLedProperty(led, newLed);

            DialogLedProperty dialog = new DialogLedProperty(mode, newLed, StringCount, LedCount);
            dialog.Text = $"LED - X:{led.X + 1}, Y:{led.Y + 1}";

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    if ((mode == EPatternDispMode.String) && (newLed.Type == ELedType.Enabled))
                    {
                        if (IsExistStringLedNo(newLed.StringIndex, newLed.LedIndex) == true)
                        {
                            MessageBox.Show("StringNo and LedNo are already existed!",
                                AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            CopyLedProperty(newLed, led);
                        }
                    }
                    else
                    {
                        CopyLedProperty(newLed, led);
                    }
                }
            }
        }

        private void CopyLedProperty(LedProperty from, LedProperty to)
        {
            to.RecNo = from.RecNo;
            to.Type = from.Type;
            to.X = from.X;
            to.Y = from.Y;
            to.StringIndex = from.StringIndex;
            to.LedIndex = from.LedIndex;
            to.TurnOn = from.TurnOn;
            to.Measuring = from.Measuring;
        }

        private bool IsExistStringLedNo(int stringNo, int ledNo)
        {
            foreach (PatternRow row in PatternRows)
            {
                foreach (LedProperty led in row.Leds)
                {
                    if ((led.StringIndex == stringNo) && (led.LedIndex == ledNo))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private GridColumn CreateGridColumn(string caption, string fieldName, int width, bool focus = false, bool edit = false)
        {
            GridColumn column = new GridColumn();

            column.Caption = caption;
            column.FieldName = fieldName;

            column.Width = width;

            column.AppearanceCell.Options.UseTextOptions = true;
            column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            column.AppearanceCell.TextOptions.VAlignment = VertAlignment.Center;

            column.AppearanceHeader.Options.UseTextOptions = true;
            column.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            column.AppearanceHeader.TextOptions.VAlignment = VertAlignment.Center;

            column.OptionsColumn.AllowEdit = edit;
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
            column.OptionsColumn.ReadOnly = !edit;
            column.OptionsColumn.ShowCaption = true;
            column.OptionsColumn.ShowInCustomizationForm = true;
            column.OptionsColumn.ShowInExpressionEditor = true;

            column.OptionsFilter.AllowAutoFilter = false;
            column.OptionsFilter.AllowFilter = false;

            return column;
        }

        public void ClearGrid()
        {
            for (int i = 0; i < patternGridView.Columns.Count; i++)
            {
                patternGridView.Columns[i].Visible = false;
            }

            PatternRows.Clear();
            AppHelper.RefreshGridData(patternGridView);
        }

        public void RefreshGrid()
        {
            PatternRows.Clear();

            for (int i = 0; i < YHeight; i++)
            {
                PatternRow row = new PatternRow(i, true);

                for (int j = 0; j < row.Leds.Length; j++)
                {
                    row.Leds[j].Type = ELedType.Disabled;
                }

                PatternRows.Add(row);
            }

            patternGridView.BeginUpdate();
            try
            {
                GridColumn col = patternGridView.Columns[0];
                col.AppearanceCell.BackColor = Color.FromArgb(245, 245, 247);
                col.AppearanceCell.Options.UseBackColor = true;
                col.VisibleIndex = 0;

                for (int i = 0; i < XMaxLength; i++)
                {
                    col = patternGridView.Columns[i + 1];
                    col.AppearanceCell.BackColor = Color.White;
                    col.AppearanceCell.Options.UseBackColor = true;
                    col.Visible = false;
                }

                for (int i = 0; i < XLength; i++)
                {
                    col = patternGridView.Columns[i + 1];
                    col.VisibleIndex = i + 1;
                }
            }
            finally
            {
                patternGridView.EndUpdate();
            }
        }

        public void RefreshGridData()
        {
            AppHelper.RefreshGridData(patternGridView);
        }
    }
}
