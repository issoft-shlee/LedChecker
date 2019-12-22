using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FirebirdSql.Data.FirebirdClient;

using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;

using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlConfigRank : UlUserControlEng
    {
        private Int64 recipeNo;

        private Int64 rankNo;

        private EDataSetMode mode;

        private GridBookmark bookmark;

        private CtrlConfigRight ctrlParent;

        private List<TestRankRow> rankRows;

        private RecipeDataSet recipeSet;

        private RankDataSet rankSet;

        private RankRowDataSet rankRowSet;

        public CtrlConfigRank(CtrlConfigRight parent)
        {
            recipeNo = 0;
            rankNo = 0;
            ctrlParent = parent;

            InitializeComponent();
            Initialize();
        }

        private void CtrlConfigRank_Load(object sender, EventArgs e)
        {
            rankGrid.DataSource = (rankSet.Empty == true) ? null : rankSet.DataSet.Tables[0];
            rankGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            rankGridView.OptionsView.EnableAppearanceEvenRow = true;
            rankItemCodeColumn.DisplayFormat.FormatType = FormatType.Custom;
            rankItemCodeColumn.DisplayFormat.Format = new ReportItemCodeFormat();

            rankRowGrid.DataSource = (rankRows.Count == 0) ? null : rankRows;
            rankRowGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            rankRowGridView.OptionsView.EnableAppearanceEvenRow = true;

            SetDataSetMode(EDataSetMode.View);
        }

        private void CtrlConfigRank_Enter(object sender, EventArgs e)
        {
            LoadRecipeComboItems();

            if (recipeCombo.Items.Count == 0) return;
            if (recipeNo <= 0) return;

            recipeCombo.SelectedValue = recipeNo;
            rankGridView.Focus();
        }

        private void CtrlConfigRank_Leave(object sender, EventArgs e)
        {
            if (recipeCombo.Items.Count == 0)
            {
                recipeNo = 0;
                return;
            }

            recipeNo = (Int64)recipeCombo.SelectedValue;
        }

        private void recipeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshRank();
        }

        private void rankGrid_DoubleClick(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;

            modifyButton.PerformClick();
        }

        private void rankGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            if (mode != EDataSetMode.View) return;

            DataRow row = rankGridView.GetDataRow(e.FocusedRowHandle);
            rankSet.Fetch(row);
            rankNo = rankSet.RecNo;

            SetEditValueFromDataSet();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;
            if (recipeCombo.SelectedIndex < 0) return;

            SetDataSetMode(EDataSetMode.New);
            ResetEditValue();
            itemCodeCombo.Focus();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;
            if (rankGridView.FocusedRowHandle < 0) return;

            SetDataSetMode(EDataSetMode.Modify);
            itemCodeCombo.Focus();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (rankGridView.FocusedRowHandle < 0) return;

            if (MessageBox.Show("Do you want to delete the rank focused?",
                AppRes.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            DeleteRank();
            SetDataSetMode(EDataSetMode.View);
            RefreshRank();
        }

        private void itemCodeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rankRows.Clear();
            rankRows.Add(CreateRankRow(1, itemCodeCombo.Text, 0, 0, 0, 0));
            RefreshRankRowData();
        }

        private void rankRowPluseButton_Click(object sender, EventArgs e)
        {
            int i = rankRows.Count - 1;

            if (rankRows.Count >= 50)
            {
                MessageBox.Show("Rank cannot be added any more because it is not over 50!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rankRows[i].Lower1 == rankRows[i].Upper1)
            {
                MessageBox.Show("Rank range is invalid! Please check it again!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rankRowLower2Column.Visible == true)
            {
                if (rankRows[i].Lower2 == rankRows[i].Upper2)
                {
                    MessageBox.Show("Rank range is invalid! Please check it again!",
                        AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            rankRows.Add(CreateRankRow(rankRows.Count+1, itemCodeCombo.Text, 
                rankRows[i].Upper1, rankRows[i].Upper1, rankRows[i].Upper2, rankRows[i].Upper2));
            RefreshRankRowData();
        }

        private void rankRowMinusButton_Click(object sender, EventArgs e)
        {
            if (rankRows.Count <= 1)
            {
                MessageBox.Show("Rank cannot delete any more because it is just one!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rankRows.RemoveAt(rankRows.Count-1);
            RefreshRankRowData();
        }

        private void Initialize()
        {
            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);
            rankSet = new RankDataSet(AppRes.DB.Connect, null, null);
            rankRowSet = new RankRowDataSet(AppRes.DB.Connect, null, null);

            rankRows = new List<TestRankRow>();

            mode = EDataSetMode.View;
            bookmark = new GridBookmark(rankGridView);

            NameValue<EReportItemCode>[] itemCodes = EnumHelper.GetNameValues<EReportItemCode>();
            itemCodeCombo.DataSource = itemCodes;
            itemCodeCombo.DisplayMember = "Name";
            itemCodeCombo.ValueMember = "Value";

            LoadRecipeComboItems();
        }

        private void DeleteRank()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                rankRowSet.RankNo = rankSet.RecNo;
                rankRowSet.Delete(trans);
                rankSet.Delete(trans);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void LoadRecipeComboItems()
        {
            recipeSet.Select();
            recipeCombo.DataSource = recipeSet.DataSet.Tables[0];
            recipeCombo.DisplayMember = "code";
            recipeCombo.ValueMember = "pk_recno";
        }

        private void SetEditValueFromDataSet()
        {
            if (rankSet.Empty == true)
            {
                itemCodeCombo.SelectedIndex = 0;
                nameEdit.Text = "";
                memoEdit.Text = "";
            }
            else
            {
                itemCodeCombo.SelectedValue = rankSet.ItemCode;
                nameEdit.Text = rankSet.Name;
                memoEdit.Text = rankSet.Memo;
            }

            rankRows.Clear();
            rankRowSet.Select(rankSet.RecNo);

            for (int i=0; i<rankRowSet.RowCount; i++)
            {
                rankRowSet.Fetch(i);

                TestRankRow row = new TestRankRow();
                row.Index = rankRowSet.Index;
                row.Name = rankRowSet.Name;
                row.Lower1 = rankRowSet.Lower1;
                row.Upper1 = rankRowSet.Upper1;
                row.Lower2 = rankRowSet.Lower2;
                row.Upper2 = rankRowSet.Upper2;

                rankRows.Add(row);
            }

            rankRowGrid.DataSource = (rankRows.Count == 0) ? null : rankRows;
            SetRankRowColumnVisible((EReportItemCode)itemCodeCombo.SelectedValue);

            RefreshRankRowData();
        }

        private void RefreshRankRowData()
        {
            AppHelper.RefreshGridData(rankRowGridView);
        }

        private void ResetEditValue()
        {
            itemCodeCombo.SelectedIndex = 0;
            nameEdit.Text = "";
            memoEdit.Text = "";

            SetRankRowColumnVisible((EReportItemCode)itemCodeCombo.SelectedValue);

            rankRows.Clear();
            rankRows.Add(CreateRankRow(1, itemCodeCombo.Text, 0, 0, 0, 0));

            rankRowGrid.DataSource = rankRows;
            RefreshRankRowData();
        }

        private TestRankRow CreateRankRow(int index, string name, 
            double lower1, double upper1, double lower2, double upper2)
        {
            TestRankRow row = new TestRankRow();

            row.Index = index;
            row.Name = $"{name}-{index}";
            row.Lower1 = lower1;
            row.Upper1 = upper1;
            row.Lower2 = lower2;
            row.Upper2 = upper2;

            return row;
        }

        private void RefreshRank()
        {
            if (recipeCombo.SelectedIndex < 0) return;

            DataRow row = ((DataTable)recipeCombo.DataSource).Rows[recipeCombo.SelectedIndex];
            recipeSet.Fetch(row);

            recipeNo = recipeSet.RecNo;

            bookmark.Get();
            rankSet.Select(recipeNo);

            if (rankSet.Empty == true)
            {
                rankGrid.DataSource = null;
                SetEditValueFromDataSet();
                SetEditReadOnly(true);
            }
            else
            {
                rankGrid.DataSource = rankSet.DataSet.Tables[0];
            }

            bookmark.Goto();
            rankGrid.Focus();
        }

        private void SetRankRowColumnVisible(EReportItemCode code)
        {
            switch (code)
            {
                case EReportItemCode.Die_XY:
                case EReportItemCode.Cell_XY:
                    rankRowLower2Column.Visible = true;
                    rankRowUpper2Column.Visible = true;
                    break;

                default:
                    rankRowLower2Column.Visible = false;
                    rankRowUpper2Column.Visible = false;
                    break;
            }
        }

        private void SetDataSetMode(EDataSetMode mode)
        {
            this.mode = mode;
            viewStatePanel.Text = mode.ToString().ToUpper();

            switch (mode)
            {
                case EDataSetMode.View:
                    ctrlParent.SetMenuEnabled(true);
                    ctrlParent.SetButtonEnabled(false);
                    viewStatePanel.BackColor = Color.Gray;
                    SetEditReadOnly(true);
                    break;

                case EDataSetMode.New:
                    ctrlParent.SetMenuEnabled(false);
                    ctrlParent.SetButtonEnabled(true);
                    viewStatePanel.BackColor = Color.DeepSkyBlue;
                    SetEditReadOnly(false);
                    break;

                case EDataSetMode.Modify:
                    ctrlParent.SetMenuEnabled(false);
                    ctrlParent.SetButtonEnabled(true);
                    viewStatePanel.BackColor = Color.DeepSkyBlue;
                    SetEditReadOnly(false);
                    break;
            }
        }

        private void SetEditReadOnly(bool enabled)
        {
            searchPanel.Enabled = enabled;

            itemCodeCombo.Enabled = !enabled;
            nameEdit.Properties.ReadOnly = enabled;
            memoEdit.Properties.ReadOnly = enabled;

            rankRowPluseButton.Enabled = !enabled;
            rankRowMinusButton.Enabled = !enabled;

            rankRowGridView.OptionsBehavior.ReadOnly = enabled;
        }

        public void Save()
        {
            nameEdit.Focus();

            if (nameEdit.Text.Trim() == "")
            {
                MessageBox.Show("You must fill Name field!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nameEdit.Focus();
                return;
            }

            foreach (TestRankRow row in rankRows)
            {
                if (string.IsNullOrWhiteSpace(row.Name) == true)
                {
                    MessageBox.Show("You must fill Rank Name field!",
                        AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    rankRowGridView.Focus();
                    return;
                }
            }

            switch (mode)
            {
                case EDataSetMode.New:
                    InsertRank();
                    break;

                case EDataSetMode.Modify:
                    UpdateRank();
                    break;
            }

            SetDataSetMode(EDataSetMode.View);
            RefreshRank();
        }

        public void Cancel()
        {
            SetDataSetMode(EDataSetMode.View);
            RefreshRank();
        }

        private void InsertRank()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                Int64 recNo = AppRes.DB.GetGenNo("GN_RANK");

                InsertRank(trans, rankSet, recNo);
                InsertRankRow(trans, rankRowSet, recNo);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void InsertRank(FbTransaction trans, RankDataSet set, Int64 recNo)
        {
            set.RecNo = recNo;
            set.RecipeNo = recipeNo;
            set.ItemCode = (EReportItemCode)itemCodeCombo.SelectedValue;
            set.Name = nameEdit.Text.Trim();
            set.Memo = memoEdit.Text.Trim();
            set.Insert(trans);
        }

        private void InsertRankRow(FbTransaction trans, RankRowDataSet set, Int64 rankNo)
        {
            foreach (TestRankRow row in rankRows)
            {
                set.RecNo = AppRes.DB.GetGenNo("GN_RANKROW");
                set.RankNo = rankNo;
                set.Index = row.Index;
                set.Name = row.Name.Trim();
                set.Lower1 = row.Lower1;
                set.Upper1 = row.Upper1;
                set.Lower2 = row.Lower2;
                set.Upper2 = row.Upper2;
                set.Insert(trans);
            }
        }

        private void UpdateRank()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                UpdateRank(trans, rankSet, rankNo);
                UpdateRankRow(trans, rankRowSet, rankNo);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void UpdateRank(FbTransaction trans, RankDataSet set, Int64 recNo)
        {
            set.RecNo = recNo;
            set.RecipeNo = recipeNo;
            set.ItemCode = (EReportItemCode)itemCodeCombo.SelectedValue;
            set.Name = nameEdit.Text.Trim();
            set.Memo = memoEdit.Text.Trim();
            set.Update(trans);
        }

        private void UpdateRankRow(FbTransaction trans, RankRowDataSet set, Int64 rankNo)
        {
            set.RankNo = rankNo;
            set.Delete(trans);

            InsertRankRow(trans, set, rankNo);
        }
    }
}
