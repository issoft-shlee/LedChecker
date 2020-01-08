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

        private void testPluseButton_Click(object sender, EventArgs e)
        {
            CtrlTestWorkGrid ctrl =testProcPanel.Controls[0] as CtrlTestWorkGrid;
            ctrl.AddRow();
        }

        private void testMinusButton_Click(object sender, EventArgs e)
        {
            CtrlTestWorkGrid ctrl = testProcPanel.Controls[0] as CtrlTestWorkGrid;
            ctrl.DeleteRow();
        }

        private void reportPluseButton_Click(object sender, EventArgs e)
        {
            CtrlReportWorkGrid ctrl = reportProcPanel.Controls[0] as CtrlReportWorkGrid;
            ctrl.AddRow();
        }

        private void reportMinusButton_Click(object sender, EventArgs e)
        {
            CtrlReportWorkGrid ctrl = reportProcPanel.Controls[0] as CtrlReportWorkGrid;
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
            testProcPanel.Controls.Add(ctrlTestWork);

            ctrlReportWork = new CtrlReportWorkGrid();
            ctrlReportWork.TestRows = ctrlTestWork.Rows;
            reportProcPanel.Controls.Add(ctrlReportWork);

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

            CtrlTestWorkGrid testGrid = testProcPanel.Controls[0] as CtrlTestWorkGrid;
            testGrid.RecipeNo = recipeNo;
            testGrid.SmuString = smuString;
            testGrid.Rows.Clear();

            testWorkSet.Select(recipeNo);

            if (testWorkSet.Empty == true)
            {
                testGrid.AddRow();
            }
            else
            {
                for (int i = 0; i < testWorkSet.RowCount; i++)
                {
                    testWorkSet.Fetch(i);
                    testGrid.AddRow();
                    SetTestWorkGridRow(testGrid.Rows[i], testWorkSet);
                }
            }

            testGrid.RefreshGridData();

            CtrlReportWorkGrid reportGrid = reportProcPanel.Controls[0] as CtrlReportWorkGrid;
            reportGrid.RecipeNo = recipeNo;
            reportGrid.SmuString = smuString;
            reportGrid.Rows.Clear();

            reportWorkSet.Select(recipeNo);

            if (reportWorkSet.Empty == true)
            {
                reportGrid.AddRow();
            }
            else
            {
                for (int i = 0; i < reportWorkSet.RowCount; i++)
                {
                    reportWorkSet.Fetch(i);
                    reportGrid.AddRow();
                    SetReportWorkGridRow(reportGrid.Rows[i], reportWorkSet);
                }
            }

            reportGrid.RefreshGridData();
        }

        private void SetTestWorkGridRow(TestWorkRow row, TestWorkDataSet set)
        {
            row.TestPattern = slaveSet.GetNameRecNoString(set.SlavePatternNo);
            row.Index = set.Index;
            row.ItemType = set.ItemType;
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
            row.LvGain = set.LvGain;
            row.LvOffset = set.LvOffset;
            row.CxGain = set.CxGain;
            row.CxOffset = set.CxOffset;
            row.CyGain = set.CyGain;
            row.CyOffset = set.CyOffset;
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

            (testProcPanel.Controls[0] as CtrlTestWorkGrid).Editable = !enabled;
            testPluseButton.Enabled = !enabled;
            testMinusButton.Enabled = !enabled;

            (reportProcPanel.Controls[0] as CtrlReportWorkGrid).Editable = !enabled;
            reportPluseButton.Enabled = !enabled;
            reportMinusButton.Enabled = !enabled;
        }

        private void InsertTestWork(FbTransaction trans, TestWorkDataSet set, Int64 recipeNo)
        {
            CtrlTestWorkGrid workGrid;

            workGrid = testProcPanel.Controls[0] as CtrlTestWorkGrid;
            foreach (TestWorkRow row in workGrid.Rows)
            {
                SetTestWorkDataSet(trans, set, row);
            }
        }

        private void SetTestWorkDataSet(FbTransaction trans, TestWorkDataSet set, TestWorkRow row)
        {
            set.RecNo = AppRes.DB.GetGenNo("GN_TESTWORK");
            set.RecipeNo = recipeNo;
            set.SlavePatternNo = AppHelper.ExtractRecNo(row.TestPattern);
            set.Index = row.Index;
            set.ItemType = row.ItemType;
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
            set.LvGain = row.LvGain;
            set.LvOffset = row.LvOffset;
            set.CxGain = row.CxGain;
            set.CxOffset = row.CxOffset;
            set.CyGain = row.CyGain;
            set.CyOffset = row.CyOffset;

            set.Insert(trans);
        }

        private void InsertReportWork(FbTransaction trans, ReportWorkDataSet set, Int64 recipeNo)
        {
            CtrlReportWorkGrid workGrid;

            workGrid = reportProcPanel.Controls[0] as CtrlReportWorkGrid;
            foreach (ReportWorkRow row in workGrid.Rows)
            {
                SetReportWorkDataSet(trans, set, row);
            }
        }

        private void SetReportWorkDataSet(FbTransaction trans, ReportWorkDataSet set, ReportWorkRow row)
        {
            set.RecNo = AppRes.DB.GetGenNo("GN_REPORTWORK");
            set.RecipeNo = recipeNo;
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
            testPluseButton.Focus();
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
