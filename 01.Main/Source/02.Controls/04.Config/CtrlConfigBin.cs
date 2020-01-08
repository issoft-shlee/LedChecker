using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FirebirdSql.Data.FirebirdClient;

using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlConfigBin : UlUserControlEng
    {
        private Int64 recipeNo;

        private EDataSetMode mode;

        private GridBookmark bookmark;

        private CtrlConfigRight ctrlParent;

        private CtrlBinGrid fullBin;

        private CtrlBinGrid samplingBin;

        private RecipeDataSet recipeSet;

        private BinDataSet binSet;

        private BinFormulaDataSet binFormulaSet;

        private List<BinRow> fullBinRows;

        private List<BinRow> samplingBinRows;

        public CtrlConfigBin(CtrlConfigRight parent)
        {
            ctrlParent = parent;

            InitializeComponent();
            Initialize();
        }

        private void CtrlConfigBin_Load(object sender, EventArgs e)
        {
            recipeSet.Select();
            recipeGrid.DataSource = recipeSet.DataSet.Tables[0];
            recipeGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            recipeGridView.OptionsView.EnableAppearanceEvenRow = true;

            SetDataSetMode(EDataSetMode.View);
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
            binTab.Focus();
        }

        private void recipeGrid_DoubleClick(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;

            modifyButton.PerformClick();
        }

        private void recipeGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            if (mode != EDataSetMode.View) return;

            DataRow row = recipeGridView.GetDataRow(e.FocusedRowHandle);
            recipeSet.Fetch(row);

            recipeNo = recipeSet.RecNo;
            fullBin.RecipeNo = recipeNo;
            samplingBin.RecipeNo = recipeNo;

            SetBinValueFromDataSet();
        }

        private void Initialize()
        {
            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);
            binSet = new BinDataSet(AppRes.DB.Connect, null, null);
            binFormulaSet = new BinFormulaDataSet(AppRes.DB.Connect, null, null);

            mode = EDataSetMode.View;
            bookmark = new GridBookmark(recipeGridView);

            fullBinRows = new List<BinRow>();
            samplingBinRows = new List<BinRow>();

            BinRow row;
            for (int i=0; i<AppRes.Properties.BinCount; i++)
            {
                row = new BinRow();
                fullBinRows.Add(row);

                row = new BinRow();
                samplingBinRows.Add(row);
            }

            fullBin = new CtrlBinGrid(fullBinRows);
            fullBin.RecipeNo = 0;
            fullBin.Type = EWorkType.Normal;
            binFullPage.Controls.Add(fullBin);

            samplingBin = new CtrlBinGrid(samplingBinRows);
            samplingBin.RecipeNo = 0;
            samplingBin.Type = EWorkType.Sampling;
            binSamplingPage.Controls.Add(samplingBin);
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

        private void SetBinValueFromDataSet()
        {
            binSet.Select(recipeNo);

            for (int i = 0; i < binSet.RowCount; i++)
            {
                binSet.Fetch(i);

                fullBinRows[i].RecNo = binSet.RecNo;
                fullBinRows[i].Type = binSet.Type;
                fullBinRows[i].Index = binSet.Index;
                fullBinRows[i].Name = binSet.Name;
                fullBinRows[i].Mark = binSet.Mark;
                fullBinRows[i].Clear();

                binFormulaSet.Select(binSet.RecNo, EWorkType.Normal);

                for (int j = 0; j < binFormulaSet.RowCount; j++)
                {
                    binFormulaSet.Fetch(j);

                    fullBinRows[i].Formulas[j].RecNo = binFormulaSet.RecNo;
                    fullBinRows[i].Formulas[j].Logic = binFormulaSet.Logic;
                    fullBinRows[i].Formulas[j].Formula = binFormulaSet.Formula;
                }

                samplingBinRows[i].RecNo = binSet.RecNo;
                samplingBinRows[i].Type = binSet.Type;
                samplingBinRows[i].Index = binSet.Index;
                samplingBinRows[i].Name = binSet.Name;
                samplingBinRows[i].Mark = binSet.Mark;
                samplingBinRows[i].Clear();

                binFormulaSet.Select(binSet.RecNo, EWorkType.Sampling);

                for (int j = 0; j < binFormulaSet.RowCount; j++)
                {
                    binFormulaSet.Fetch(j);

                    samplingBinRows[i].Formulas[j].RecNo = binFormulaSet.RecNo;
                    samplingBinRows[i].Formulas[j].Logic = binFormulaSet.Logic;
                    samplingBinRows[i].Formulas[j].Formula = binFormulaSet.Formula;
                }
            }

            fullBin.RefreshData();
            samplingBin.RefreshData();
        }

        private void SaveBins()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                if (fullBinRows[0].Formulas[0].RecNo == 0)
                {
                    InsertBins(trans, fullBinRows, EWorkType.Normal);
                    InsertBins(trans, samplingBinRows, EWorkType.Sampling);
                }
                else
                {
                    UpdateBins(trans, fullBinRows, EWorkType.Normal);
                    UpdateBins(trans, samplingBinRows, EWorkType.Sampling);
                }

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void InsertBins(FbTransaction trans, List<BinRow> binRows, EWorkType type)
        {
            foreach (BinRow row in binRows)
            {
                foreach (BinFormula formula in row.Formulas)
                {
                    binFormulaSet.RecNo = AppRes.DB.GetGenNo("GN_BINFORMULA");
                    binFormulaSet.BinNo = row.RecNo;
                    binFormulaSet.WorkType = type; 
                    binFormulaSet.Logic = formula.Logic;
                    binFormulaSet.Formula = formula.Formula;
                    binFormulaSet.Insert(trans);
                }
            }
        }

        private void UpdateBins(FbTransaction trans, List<BinRow> binRows, EWorkType type)
        {
            foreach (BinRow row in binRows)
            {
                foreach (BinFormula formula in row.Formulas)
                {
                    binFormulaSet.RecNo = formula.RecNo;
                    binFormulaSet.BinNo = row.RecNo;
                    binFormulaSet.WorkType = type;
                    binFormulaSet.Logic = formula.Logic;
                    binFormulaSet.Formula = formula.Formula;
                    binFormulaSet.Update(trans);
                }
            }
        }

        private void SetEditReadOnly(bool enabled)
        {
            searchPanel.Enabled = enabled;

            fullBin.ReadOnly = enabled;
            samplingBin.ReadOnly = enabled;
        }

        public void Save()
        {
            findNameEdit.Focus();
            SaveBins();

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
