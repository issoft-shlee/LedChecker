using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FirebirdSql.Data.FirebirdClient;

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

        private CtrlBinGrid binGrid;

        private RecipeDataSet recipeSet;

        private BinDataSet binSet;

        private BinFormulaDataSet binFormulaSet;

        private List<BinRow> binRows;

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
            binGridPanel.Focus();
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
            binGrid.RecipeNo = recipeNo;

            SetBinValueFromDataSet();
        }

        private void Initialize()
        {
            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);
            binSet = new BinDataSet(AppRes.DB.Connect, null, null);
            binFormulaSet = new BinFormulaDataSet(AppRes.DB.Connect, null, null);

            mode = EDataSetMode.View;
            bookmark = new GridBookmark(recipeGridView);

            binRows = new List<BinRow>();

            BinRow row;
            for (int i=0; i<AppRes.Properties.BinCount; i++)
            {
                row = new BinRow();
                binRows.Add(row);
            }

            binGrid = new CtrlBinGrid(binRows);
            binGrid.RecipeNo = 0;
            binGrid.Type = EWorkType.Normal;
            binGridPanel.Controls.Add(binGrid);
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

                binRows[i].RecNo = binSet.RecNo;
                binRows[i].Type = binSet.Type;
                binRows[i].Index = binSet.Index;
                binRows[i].Name = binSet.Name;
                binRows[i].Mark = binSet.Mark;
                binRows[i].Clear();

                binFormulaSet.Select(binSet.RecNo);

                for (int j = 0; j < binFormulaSet.RowCount; j++)
                {
                    binFormulaSet.Fetch(j);

                    binRows[i].Formulas[j].RecNo = binFormulaSet.RecNo;
                    binRows[i].Formulas[j].Logic = binFormulaSet.Logic;
                    binRows[i].Formulas[j].Formula = binFormulaSet.Formula;
                }

            }

            binGrid.RefreshData();
        }

        private void SaveBins()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                if (binRows[0].Formulas[0].RecNo == 0)
                {
                    InsertBins(trans, binRows);
                }
                else
                {
                    UpdateBins(trans, binRows);
                }

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void InsertBins(FbTransaction trans, List<BinRow> binRows)
        {
            foreach (BinRow row in binRows)
            {
                foreach (BinFormula formula in row.Formulas)
                {
                    binFormulaSet.RecNo = AppRes.DB.GetGenNo("GN_BINFORMULA");
                    binFormulaSet.BinNo = row.RecNo;
                    binFormulaSet.Logic = formula.Logic;
                    binFormulaSet.Formula = formula.Formula;
                    binFormulaSet.Insert(trans);
                }
            }
        }

        private void UpdateBins(FbTransaction trans, List<BinRow> binRows)
        {
            foreach (BinRow row in binRows)
            {
                foreach (BinFormula formula in row.Formulas)
                {
                    binFormulaSet.RecNo = formula.RecNo;
                    binFormulaSet.BinNo = row.RecNo;
                    binFormulaSet.Logic = formula.Logic;
                    binFormulaSet.Formula = formula.Formula;
                    binFormulaSet.Update(trans);
                }
            }
        }

        private void SetEditReadOnly(bool enabled)
        {
            searchPanel.Enabled = enabled;

            binGrid.ReadOnly = enabled;
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
