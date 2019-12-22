using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class DialogSmuSelector : UlFormEng
    {
        private List<StringRow> stringRows;

        private int count;

        private string sets;

        public string Result { get; private set; }

        public DialogSmuSelector(int count, string sets)
        {
            this.count = count;
            this.sets = sets;

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            int index;
            stringRows = new List<StringRow>();
            StringRow row = new StringRow(0);

            if ((string.IsNullOrWhiteSpace(sets) == true) || (sets == "None"))
            {
                row.Sets.DDWord(0, 0);
            }
            else
            {
                string[] states = sets.Trim().Split(',');

                for (int i=0; i<states.Length; i++)
                {
                    try
                    {
                        index = int.Parse(states[i].Trim()) - 1;
                        row.Sets[index] = true;
                    }
                    catch
                    {
                    }
                }

            }

            stringRows.Add(row);

            smuGrid.DataSource = stringRows;
            smuGridView.BeginUpdate();

            try
            {
                smuGridView.Columns.Clear();

                for (int i = 0; i < count; i++)
                {
                    smuGridView.Columns.Add(CreateGridColumn(i + 1, $"SMU{i + 1}", $"SMU{i + 1}", 64, true, true));
                }
            }
            finally
            {
                smuGridView.EndUpdate();
            }
        }

        private GridColumn CreateGridColumn(
            int index, string caption, string fieldName, int width, bool focus = false, bool edit = false)
        {
            GridColumn column = new GridColumn();

            column.Caption = caption;
            column.FieldName = fieldName;
            column.Width = width;

            column.VisibleIndex = index;
            column.Visible = true;

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

        private string GetResultString()
        {
            string str = string.Empty;

            for (int i = 0; i < count; i++)
            {
                if (stringRows[0].Sets[i] == true)
                {
                    if (string.IsNullOrEmpty(str) == true)
                    {
                        str = $"{i + 1}";
                    }
                    else
                    {
                        str += $",{i + 1}";
                    }
                }
            }

            if (string.IsNullOrEmpty(str) == true)
            {
                str = "None";
            }

            return str;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Result = GetResultString();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Result = "None";
            Close();
        }
    }
}