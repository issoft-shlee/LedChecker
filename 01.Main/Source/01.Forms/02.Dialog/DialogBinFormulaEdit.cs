using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;

using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class DialogBinFormulaEdit : UlFormEng
    {
        private Int64 recipeNo;

        private EWorkType type;

        private string work;

        private EBinCondition condition;

        private string rank;

        private ReportWorkDataSet workSet;

        private RankRowDataSet rankRowSet;

        public string Result { get; private set; }

        public DialogBinFormulaEdit(Int64 recipeNo, EWorkType type, string formula)
        {
            this.recipeNo = recipeNo;
            this.type = type;

            InitializeComponent();
            Initialize(formula);
        }

        private void workGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (workGridView.FocusedRowHandle < 0)
            {
                rankGrid.DataSource = null;
                return;
            }

            DataRow row = workGridView.GetDataRow(workGridView.FocusedRowHandle);
            workSet.Fetch(row);

            Int64 rankNo = AppHelper.ExtractRecNo(workSet.Rank);
            EReportItemCode code = workSet.ItemCode;

            if (rankNo < 1)
            {
                rankGrid.DataSource = null;
                return;
            }

            rankRowSet.Select(rankNo);
            rankGrid.DataSource = (rankRowSet.Empty == true) ? null : rankRowSet.DataSet.Tables[0];
            rankGridView.ClearSelection();
            AppHelper.RefreshGridData(rankGridView);

            SetRankRowColumnVisible(code);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string workName = (string)workGridView.GetRowCellValue(workGridView.FocusedRowHandle, workItemNameColumn);
            string condition = (conditionCombo.SelectedIndex == 0) ? " = " : " <> ";
            string rankNames = AppHelper.CombineSelectedRowValues(rankGridView, "ROWNAME");

            Result = workName + condition + rankNames;
            Close();
        }

        private void Initialize(string formula)
        {
            string[] items;

            Result = "";

            conditionCombo.DataSource = EnumHelper.GetNameValues<EBinCondition>();
            conditionCombo.DisplayMember = "Name";
            conditionCombo.ValueMember = "Value";

            workSet = new ReportWorkDataSet(AppRes.DB.Connect, null, null);
            rankRowSet = new RankRowDataSet(AppRes.DB.Connect, null, null);

            condition = EBinCondition.Equal;

            if (string.IsNullOrWhiteSpace(formula) == false)
            {
                if (formula.Contains(" = ") == true)
                {
                    condition = EBinCondition.Equal;
                    items = formula.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                }
                else
                {
                    condition = EBinCondition.NotEqual;
                    items = formula.Split(new string[] { " <> " }, StringSplitOptions.RemoveEmptyEntries);
                }

                if (items.Length == 2)
                {
                    work = items[0];
                    rank = items[1];
                }
            }

            conditionCombo.SelectedValue = condition;

            workSet.Select(recipeNo, type);
            workGrid.DataSource = workSet.DataSet.Tables[0];

            workGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            workGridView.OptionsView.EnableAppearanceEvenRow = true;

            workItemCodeColumn.DisplayFormat.FormatType = FormatType.Custom;
            workItemCodeColumn.DisplayFormat.Format = new ReportItemCodeFormat();

            rankGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            rankGridView.OptionsView.EnableAppearanceEvenRow = true;

            if (string.IsNullOrWhiteSpace(work) == false)
            {
                for (int i = 0; i < workGridView.RowCount; i++)
                {
                    string name = (string)workGridView.GetRowCellValue(i, "ITEMNAME");

                    if (work == name)
                    {
                        workGridView.FocusedRowHandle = i;
                        break;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(rank) == false)
            {
                string[] ranks = rank.Split(',');

                if (ranks.Length > 0)
                {
                    for (int i = 0; i < rankGridView.RowCount; i++)
                    {
                        string name = (string)rankGridView.GetRowCellValue(i, "ROWNAME");

                        for (int j = 0; j < ranks.Length; j++)
                        {
                            if (ranks[j] == name)
                            {
                                rankGridView.SelectRow(i);
                                break;
                            }
                        }
                    }

                    if (rankGridView.SelectedRowsCount > 0)
                    {
                        rankGridView.FocusedRowHandle = rankGridView.GetSelectedRows()[0];
                    }
                }
            }
        }

        private void SetRankRowColumnVisible(EReportItemCode code)
        {
            switch (code)
            {
                case EReportItemCode.Die_XY:
                case EReportItemCode.Cell_XY:
                    rankLower2Column.Visible = true;
                    rankUpper2Column.Visible = true;
                    break;

                default:
                    rankLower2Column.Visible = false;
                    rankUpper2Column.Visible = false;
                    break;
            }
        }
    }
}
