using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Base;

using FirebirdSql.Data.FirebirdClient;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlConfigWork : UlUserControlEng
    {
        private Int64 recipeNo;

        private EDataSetMode mode;

        private CtrlConfigRight ctrlParent;

        private GridBookmark bookmark;

        private RecipeDataSet recipeSet;

        private SlavePatternDataSet slaveSet;

        private TestWorkDataSet testWorkSet;

        private ReportWorkDataSet reportWorkSet;

        private RankDataSet rankSet;

        private SmuDataSet smuSet;

        public CtrlConfigWork(CtrlConfigRight parent)
        {
            ctrlParent = parent;

            InitializeComponent();
            Initialize();
        }

        private void CtrlConfigWork_Load(object sender, EventArgs e)
        {
            recipeSet.Select();

            recipeGrid.DataSource = (recipeSet.Empty == true) ? null : recipeSet.DataSet.Tables[0];
            recipeGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            recipeGridView.OptionsView.EnableAppearanceEvenRow = true;

            SetDataSetMode(EDataSetMode.View);
            findButton.PerformClick();
        }

        private void CtrlConfigWork_Enter(object sender, EventArgs e)
        {
            findButton.PerformClick();
        }

        private void recipeGrid_DoubleClick(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;

            modifyButton.PerformClick();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;

            bookmark.Get();

            if (string.IsNullOrWhiteSpace(findNameEdit.Text) == true)
                recipeSet.Select();
            else
                recipeSet.Select(findNameEdit.Text.Trim());

            bookmark.Goto();
            recipeGrid.Focus();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;
            if (recipeGridView.FocusedRowHandle < 0) return;

            SetDataSetMode(EDataSetMode.Modify);
        }

        private void fullTestPluseButton_Click(object sender, EventArgs e)
        {
            CtrlTestWorkGrid ctrl = fullTestPanel.Controls[0] as CtrlTestWorkGrid;
            ctrl.AddRow();
        }

        private void fullTestMinusButton_Click(object sender, EventArgs e)
        {
            CtrlTestWorkGrid ctrl = fullTestPanel.Controls[0] as CtrlTestWorkGrid;
            ctrl.DeleteRow();
        }

        private void fullReportPluseButton_Click(object sender, EventArgs e)
        {
            CtrlReportWorkGrid ctrl = fullReportPanel.Controls[0] as CtrlReportWorkGrid;
            ctrl.AddRow();
        }

        private void fullReportMinusButton_Click(object sender, EventArgs e)
        {
            CtrlReportWorkGrid ctrl = fullReportPanel.Controls[0] as CtrlReportWorkGrid;
            ctrl.DeleteRow();
        }

        private void samplingTestPluseButton_Click(object sender, EventArgs e)
        {
            CtrlTestWorkGrid ctrl = samplingTestPanel.Controls[0] as CtrlTestWorkGrid;
            ctrl.AddRow();
        }

        private void samplingTestMinusButton_Click(object sender, EventArgs e)
        {
            CtrlTestWorkGrid ctrl = samplingTestPanel.Controls[0] as CtrlTestWorkGrid;
            ctrl.DeleteRow();
        }

        private void samplingReportPluseButton_Click(object sender, EventArgs e)
        {
            CtrlReportWorkGrid ctrl = samplingReportPanel.Controls[0] as CtrlReportWorkGrid;
            ctrl.AddRow();
        }

        private void samplingReportMinusButton_Click(object sender, EventArgs e)
        {
            CtrlReportWorkGrid ctrl = samplingReportPanel.Controls[0] as CtrlReportWorkGrid;
            ctrl.DeleteRow();
        }

        private void recipeGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            if (mode != EDataSetMode.View) return;

            DataRow row = recipeGridView.GetDataRow(e.FocusedRowHandle);
            recipeSet.Fetch(row);
            recipeNo = recipeSet.RecNo;
            recipeGrid.DataSource = recipeSet.DataSet.Tables[0];

            SetEditValueFromDataSet();
        }

        private void Initialize()
        {
            CtrlTestWorkGrid ctrlTestWork;
            CtrlReportWorkGrid ctrlReportWork;

            recipeNo = 0;

            mode = EDataSetMode.View;
            bookmark = new GridBookmark(recipeGridView);

            ctrlTestWork = new CtrlTestWorkGrid();
            fullTestPanel.Controls.Add(ctrlTestWork);

            ctrlReportWork = new CtrlReportWorkGrid();
            ctrlReportWork.TestRows = ctrlTestWork.Rows;
            fullReportPanel.Controls.Add(ctrlReportWork);

            ctrlTestWork = new CtrlTestWorkGrid();
            samplingTestPanel.Controls.Add(ctrlTestWork);

            ctrlReportWork = new CtrlReportWorkGrid();
            ctrlReportWork.TestRows = ctrlTestWork.Rows;
            samplingReportPanel.Controls.Add(ctrlReportWork);

            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);
            slaveSet = new SlavePatternDataSet(AppRes.DB.Connect, null, null);
            testWorkSet = new TestWorkDataSet(AppRes.DB.Connect, null, null);
            reportWorkSet = new ReportWorkDataSet(AppRes.DB.Connect, null, null);
            rankSet = new RankDataSet(AppRes.DB.Connect, null, null);
            smuSet = new SmuDataSet(AppRes.DB.Connect, null, null);
        }

        private string GetSmuString()
        {
            string ret = "None";

            smuSet.Select(recipeNo);

            if (smuSet.Empty == false)
            {
                ret = "";

                for (int i=0; i<smuSet.RowCount; i++)
                {
                    smuSet.Fetch(i);

                    if (smuSet.Sets > 0)
                    {
                        if (ret == "")
                        {
                            ret = $"{i + 1}";
                        }
                        else
                        {
                            ret += $",{i + 1}";
                        }
                    }
                }
            }

            return ret;
        }

        private void SetEditValueFromDataSet()
        {
            string smuString = GetSmuString();

            CtrlTestWorkGrid fullTestGrid = fullTestPanel.Controls[0] as CtrlTestWorkGrid;
            fullTestGrid.RecipeNo = recipeNo;
            fullTestGrid.SmuString = smuString;
            fullTestGrid.Rows.Clear();

            testWorkSet.Select(recipeNo, EWorkType.Full);

            if (testWorkSet.Empty == true)
            {
                fullTestGrid.AddRow();
            }
            else
            {
                for (int i = 0; i < testWorkSet.RowCount; i++)
                {
                    testWorkSet.Fetch(i);
                    fullTestGrid.AddRow();
                    SetTestWorkGridRow(fullTestGrid.Rows[i], testWorkSet);
                }
            }

            fullTestGrid.RefreshGridData();

            CtrlReportWorkGrid fullReportGrid = fullReportPanel.Controls[0] as CtrlReportWorkGrid;
            fullReportGrid.RecipeNo = recipeNo;
            fullReportGrid.SmuString = smuString;
            fullReportGrid.Rows.Clear();

            reportWorkSet.Select(recipeNo, EWorkType.Full);

            if (reportWorkSet.Empty == true)
            {
                fullReportGrid.AddRow();
            }
            else
            {
                for (int i = 0; i < reportWorkSet.RowCount; i++)
                {
                    reportWorkSet.Fetch(i);
                    fullReportGrid.AddRow();
                    SetReportWorkGridRow(fullReportGrid.Rows[i], reportWorkSet);
                }
            }

            fullReportGrid.RefreshGridData();

            CtrlTestWorkGrid samplingTestGrid = samplingTestPanel.Controls[0] as CtrlTestWorkGrid;
            samplingTestGrid.RecipeNo = recipeNo;
            samplingTestGrid.SmuString = smuString;
            samplingTestGrid.Rows.Clear();

            testWorkSet.Select(recipeNo, EWorkType.Sampling);

            if (testWorkSet.Empty == true)
            {
                samplingTestGrid.AddRow();
            }
            else
            {
                for (int i = 0; i < testWorkSet.RowCount; i++)
                {
                    testWorkSet.Fetch(i);
                    samplingTestGrid.AddRow();
                    SetTestWorkGridRow(samplingTestGrid.Rows[i], testWorkSet);
                }
            }

            samplingTestGrid.RefreshGridData();

            CtrlReportWorkGrid samplingReportGrid = samplingReportPanel.Controls[0] as CtrlReportWorkGrid;
            samplingReportGrid.RecipeNo = recipeNo;
            samplingReportGrid.SmuString = smuString;
            samplingReportGrid.Rows.Clear();

            reportWorkSet.Select(recipeNo, EWorkType.Sampling);

            if (reportWorkSet.Empty == true)
            {
                samplingReportGrid.AddRow();
            }
            else
            {
                for (int i = 0; i < reportWorkSet.RowCount; i++)
                {
                    reportWorkSet.Fetch(i);
                    samplingReportGrid.AddRow();
                    SetReportWorkGridRow(samplingReportGrid.Rows[i], reportWorkSet);
                }
            }

            samplingReportGrid.RefreshGridData();
        }

        private void SetTestWorkGridRow(TestWorkRow row, TestWorkDataSet set)
        {
            row.TestPattern = slaveSet.GetNameRecNoString(set.SlavePatternNo);
            row.Index = set.Index;
            row.ItemCode = set.ItemCode;
            row.ItemName = set.ItemName;
            row.ItemRef = set.ItemRef;
            row.BiasValue = set.BiasValue;
            row.BiasRange = set.BiasRange;
            row.BiasCH = set.BiasCH;
            row.ApplyTime = set.ApplyTime;
            row.TransientTime = set.TransientTime;
            row.HumCounter = set.HumCount;
            row.Optical = set.Optical;
            row.IntegVL = set.IntegVL;
            row.IntegX1 = set.IntegX1;
            row.IntegX2 = set.IntegX2;
            row.IntegZ = set.IntegZ;
            row.Gain = set.Gain;
            row.Offset = set.Offset;
        }

        private void SetReportWorkGridRow(ReportWorkRow row, ReportWorkDataSet set)
        {
            row.Index = set.Index;
            row.ItemCode = set.ItemCode;
            row.ItemName = set.ItemName;
            row.ItemRef = set.ItemRef;
            row.BiasCH = set.BiasCH;
            row.Rank = set.Rank;
            row.Lower = set.Lower;
            row.Upper = set.Upper;
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

            (fullTestPanel.Controls[0] as CtrlTestWorkGrid).Editable = !enabled;
            fullTestPluseButton.Enabled = !enabled;
            fullTestMinusButton.Enabled = !enabled;

            (fullReportPanel.Controls[0] as CtrlReportWorkGrid).Editable = !enabled;
            fullReportPluseButton.Enabled = !enabled;
            fullReportMinusButton.Enabled = !enabled;

            (samplingTestPanel.Controls[0] as CtrlTestWorkGrid).Editable = !enabled;
            samplingTestPluseButton.Enabled = !enabled;
            samplingTestMinusButton.Enabled = !enabled;

            (samplingReportPanel.Controls[0] as CtrlReportWorkGrid).Editable = !enabled;
            samplingReportPluseButton.Enabled = !enabled;
            samplingReportMinusButton.Enabled = !enabled;
        }

        private void InsertTestWork(FbTransaction trans, TestWorkDataSet set, Int64 recipeNo)
        {
            CtrlTestWorkGrid workGrid;

            workGrid = fullTestPanel.Controls[0] as CtrlTestWorkGrid;
            foreach (TestWorkRow row in workGrid.Rows)
            {
                SetTestWorkDataSet(trans, set, row, EWorkType.Full);
            }

            workGrid = samplingTestPanel.Controls[0] as CtrlTestWorkGrid;
            foreach (TestWorkRow row in workGrid.Rows)
            {
                SetTestWorkDataSet(trans, set, row, EWorkType.Sampling);
            }
        }

        private void SetTestWorkDataSet(FbTransaction trans, TestWorkDataSet set, TestWorkRow row, EWorkType type)
        {
            set.RecNo = AppRes.DB.GetGenNo("GN_TESTWORK");
            set.RecipeNo = recipeNo;
            set.SlavePatternNo = AppHelper.ExtractRecNo(row.TestPattern);
            set.Type = type;
            set.Index = row.Index;
            set.ItemCode = row.ItemCode;
            set.ItemName = row.ItemName;
            set.ItemRef = row.ItemRef;
            set.BiasValue = row.BiasValue;
            set.BiasRange = row.BiasRange;
            set.BiasCH = row.BiasCH;
            set.ApplyTime = row.ApplyTime;
            set.TransientTime = row.TransientTime;
            set.HumCount = row.HumCounter;
            set.Optical = row.Optical;
            set.IntegVL = row.IntegVL;
            set.IntegX1 = row.IntegX1;
            set.IntegX2 = row.IntegX2;
            set.IntegZ = row.IntegZ;
            set.Gain = row.Gain;
            set.Offset = row.Offset;

            set.Insert(trans);
        }

        private void InsertReportWork(FbTransaction trans, ReportWorkDataSet set, Int64 recipeNo)
        {
            CtrlReportWorkGrid workGrid;

            workGrid = fullReportPanel.Controls[0] as CtrlReportWorkGrid;
            foreach (ReportWorkRow row in workGrid.Rows)
            {
                SetReportWorkDataSet(trans, set, row, EWorkType.Full);
            }

            workGrid = samplingReportPanel.Controls[0] as CtrlReportWorkGrid;
            foreach (ReportWorkRow row in workGrid.Rows)
            {
                SetReportWorkDataSet(trans, set, row, EWorkType.Sampling);
            }
        }

        private void SetReportWorkDataSet(FbTransaction trans, ReportWorkDataSet set, ReportWorkRow row, EWorkType type)
        {
            set.RecNo = AppRes.DB.GetGenNo("GN_REPORTWORK");
            set.RecipeNo = recipeNo;
            set.Type = type;
            set.Index = row.Index;
            set.ItemCode = row.ItemCode;
            set.ItemName = row.ItemName;
            set.ItemRef = row.ItemRef;
            set.BiasCH = row.BiasCH;
            set.Rank = row.Rank;
            set.Lower = row.Lower;
            set.Upper = row.Upper;

            set.Insert(trans);
        }

        private void UpdateWork()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                testWorkSet.RecipeNo = recipeNo;
                testWorkSet.Delete(trans);

                reportWorkSet.RecipeNo = recipeNo;
                reportWorkSet.Delete(trans);

                InsertTestWork(trans, testWorkSet, recipeNo);
                InsertReportWork(trans, reportWorkSet, recipeNo);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        public void Save()
        {
            fullTestPluseButton.Focus();
            UpdateWork();
            SetDataSetMode(EDataSetMode.View);
            findButton.PerformClick();
        }

        public void Cancel()
        {
            SetDataSetMode(EDataSetMode.View);
            findButton.PerformClick();
        }
    }
}
