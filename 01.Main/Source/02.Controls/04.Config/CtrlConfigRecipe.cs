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

using FirebirdSql.Data.FirebirdClient;

using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlConfigRecipe : UlUserControlEng
    {
        private Int64 recipeNo;

        private EDataSetMode mode;

        private GridBookmark bookmark;

        private CtrlConfigRight ctrlParent;

        private CtrlPatternGrid ctrlPatternGrid;

        private List<StringRow> stringRows;

        private RecipeDataSet recipeSet;

        private MasterPatternDataSet masterSet;

        private MasterPatternLedDataSet masterLedSet;

        private SlavePatternDataSet slaveSet;

        private SlavePatternLedDataSet slaveLedSet;

        private SmuDataSet smuSet;

        private BinDataSet binSet;

        private List<int> stringToSmus;

        private List<RecipeBinRow> binRows;

        public CtrlConfigRecipe(CtrlConfigRight parent)
        {
            ctrlParent = parent;

            InitializeComponent();
            Initialize();
        }

        private void CtrlConfigRecipe_Load(object sender, EventArgs e)
        {
            recipeSet.Select();
            recipeGrid.DataSource = recipeSet.DataSet.Tables[0];
            recipeGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            recipeGridView.OptionsView.EnableAppearanceEvenRow = true;

            binGrid.DataSource = binRows;
            binGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            binGridView.OptionsView.EnableAppearanceEvenRow = true;

            SetDataSetMode(EDataSetMode.View);
        }

        private void CtrlConfigRecipe_Enter(object sender, EventArgs e)
        {
        }

        private void CtrlConfigRecipe_KeyPress(object sender, KeyPressEventArgs e)
        {
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

            RefreshStringToSmus();
            SetEditValueFromDataSet();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;

            RecipeDataSet set = recipeSet;
            bookmark.Get();

            if (string.IsNullOrWhiteSpace(findNameEdit.Text) == true)
                set.Select();
            else
                set.Select(findNameEdit.Text.Trim());

            bookmark.Goto();
            recipeGrid.Focus();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;

            SetDataSetMode(EDataSetMode.New);
            ResetEdit();
            nameEdit.Focus();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;
            if (recipeGridView.FocusedRowHandle < 0) return;

            SetDataSetMode(EDataSetMode.Modify);
            nameEdit.Focus();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the recipe focused?",
                AppRes.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            DeleteRecipe();
            SetDataSetMode(EDataSetMode.View);
            findButton.PerformClick();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int stringCount = (int)stringCountEdit.Value;

            RefreshStringToSmus(stringCount);

            ctrlPatternGrid.XLength = (int)xLengthEdit.Value;
            ctrlPatternGrid.YHeight = (int)yHeightEdit.Value;
            ctrlPatternGrid.StringCount = stringCount;
            ctrlPatternGrid.LedCount = (int)ledCountEdit.Value;
            ctrlPatternGrid.RefreshGrid();

            RefreshSmuGrid(AppRes.Properties.SmuCount, stringCount);
        }

        private void smuGridView_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if ((bool)e.Value == true)
            {
                foreach (GridColumn col in view.Columns)
                {
                    if (col.FieldName == "StringNo") continue;
                    if (col.FieldName == e.Column.FieldName) continue;

                    view.SetRowCellValue(e.RowHandle, col.FieldName, false);
                }
            }
        }

        private void smuGridView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            stringToSmus[e.RowHandle] = GetActiveSmuIndex(e.RowHandle);
        }

        private int GetActiveSmuIndex(int index)
        {
            int ret = -1;

            for (int i = 0; i < stringRows[index].Sets.Count * 8; i++)
            {
                if (stringRows[index].Sets[i] == true)
                {
                    ret = i;
                    break;
                }
            }

            return ret;
        }

        private void smuGridView_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            if (e.Column == null) return;

            if (e.Column.AppearanceHeader.BackColor != Color.Empty)
            {
                e.Info.AllowColoring = true;
            }
        }

        private void Initialize()
        {
            recipeNo = 0;

            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);
            masterSet = new MasterPatternDataSet(AppRes.DB.Connect, null, null);
            masterLedSet = new MasterPatternLedDataSet(AppRes.DB.Connect, null, null);
            slaveSet = new SlavePatternDataSet(AppRes.DB.Connect, null, null);
            slaveLedSet = new SlavePatternLedDataSet(AppRes.DB.Connect, null, null);
            smuSet = new SmuDataSet(AppRes.DB.Connect, null, null);
            binSet = new BinDataSet(AppRes.DB.Connect, null, null);

            mode = EDataSetMode.View;
            bookmark = new GridBookmark(recipeGridView);

            stringToSmus = new List<int>();
            stringRows = new List<StringRow>();

            ctrlPatternGrid = new CtrlPatternGrid(EPatternDispMode.String, stringToSmus);
            ctrlPatternGrid.XLength = (int)xLengthEdit.Value;
            ctrlPatternGrid.YHeight = (int)yHeightEdit.Value;
            ctrlPatternGrid.StringCount = (int)stringCountEdit.Value;
            ctrlPatternGrid.LedCount = (int)ledCountEdit.Value;

            patternGridPanel.Controls.Add(ctrlPatternGrid);

            smuGrid.DataSource = stringRows;

            smuGridView.BeginUpdate();
            try
            {
                smuGridView.Columns.Clear();
                smuGridView.Columns.Add(CreateGridColumn(" ", "StringNo", 64));

                for (int i=0; i<20; i++)
                {
                    smuGridView.Columns.Add(CreateGridColumn($"SMU{i + 1}", $"SMU{i + 1}", 64, true, true));
                }
            }
            finally
            {
                smuGridView.EndUpdate();
            }

            binRows = new List<RecipeBinRow>();

            for (int i=0; i<AppRes.Properties.BinCount; i++)
            {
                RecipeBinRow row = new RecipeBinRow();
                row.Clear(i + 1);
                binRows.Add(row);
            }

            binTypeLookUpEdit.DataSource = EnumHelper.GetNameValues<EBinType>();
            binTypeLookUpEdit.DisplayMember = "Name";
            binTypeLookUpEdit.ValueMember = "Value";
            binTypeLookUpEdit.KeyMember = "Value";
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
            if (IsAllBinNameEmpty() == true)
            {
                MessageBox.Show("You must fill Bin's Name field at least one more!",
                    AppRes.Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                binGridView.Focus();
                return;
            }

            switch (mode)
            {
                case EDataSetMode.New:
                    InsertRecipe();
                    break;

                case EDataSetMode.Modify:
                    UpdateRecipe();
                    break;
            }

            SetDataSetMode(EDataSetMode.View);
            findButton.PerformClick();
        }

        public void Cancel()
        {
            SetDataSetMode(EDataSetMode.View);
            findButton.PerformClick();
        }

        public bool IsAllBinNameEmpty()
        {
            bool ret = true;

            foreach (RecipeBinRow row in binRows)
            {
                if (string.IsNullOrWhiteSpace(row.Name) == false)
                {
                    ret = false;
                    break;
                }
            }

            return ret;
        }

        private void SetEditValueFromDataSet()
        {
            nameEdit.Text = recipeSet.Name;
            memoEdit.Text = recipeSet.Memo;
            st1XEdit.EditValue = recipeSet.ST1_X;
            st1YEdit.EditValue = recipeSet.ST1_Y;
            st1QREdit.Text = recipeSet.ST1_QR;
            st2XEdit.EditValue = recipeSet.ST2_X;
            st2YEdit.EditValue = recipeSet.ST2_Y;
            st2QREdit.Text = recipeSet.ST2_QR;

            masterSet.Select(recipeNo);
            masterSet.Fetch();

            Int64 masterPatternNo = masterSet.RecNo;
            xLengthEdit.Value = masterSet.XLength;
            yHeightEdit.Value = masterSet.YHeight;
            stringCountEdit.Value = masterSet.StrCount;
            ledCountEdit.Value = masterSet.LedCount;

            ctrlPatternGrid.XLength = masterSet.XLength;
            ctrlPatternGrid.YHeight = masterSet.YHeight;
            ctrlPatternGrid.StringCount = masterSet.StrCount;
            ctrlPatternGrid.LedCount = masterSet.LedCount;
            ctrlPatternGrid.RefreshGrid();

            masterLedSet.Select(masterPatternNo);

            for (int i=0; i<masterLedSet.RowCount; i++)
            {
                masterLedSet.Fetch(i);

                int x = masterLedSet.X;
                int y = masterLedSet.Y;

                ctrlPatternGrid.PatternRows[y].Leds[x].RecNo = masterLedSet.RecNo;
                ctrlPatternGrid.PatternRows[y].Leds[x].X = x;
                ctrlPatternGrid.PatternRows[y].Leds[x].Y = y;
                ctrlPatternGrid.PatternRows[y].Leds[x].StringIndex = masterLedSet.StrNo;
                ctrlPatternGrid.PatternRows[y].Leds[x].LedIndex = masterLedSet.LedNo;
                ctrlPatternGrid.PatternRows[y].Leds[x].Type = masterLedSet.Type;
            }
            ctrlPatternGrid.RefreshGridData();

            smuSet.Select(recipeNo);
            RefreshSmuGrid(AppRes.Properties.SmuCount, masterSet.StrCount);

            for (int i=0; i<smuSet.RowCount; i++)
            {
                smuSet.Fetch(i);

                stringRows[smuSet.StringNo].RecNo = smuSet.RecNo;
                stringRows[smuSet.StringNo].Sets.DDWord(0, smuSet.Sets);
            }
            RefreshSmuGridData();

            binSet.Select(recipeNo);

            for (int i=0; i<binSet.RowCount; i++)
            {
                binSet.Fetch(i);
                binRows[i].RecNo = binSet.RecNo;
                binRows[i].Type = binSet.Type;
                binRows[i].Index = binSet.Index;
                binRows[i].Name = binSet.Name;
                binRows[i].Mark = binSet.Mark;
            }
            AppHelper.RefreshGridData(binGridView);
        }

        private void InsertRecipe()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                Int64 recipeNo = AppRes.DB.GetGenNo("GN_RECIPE");
                InsertRecipe(trans, recipeSet, recipeNo);

                Int64 masterNo = AppRes.DB.GetGenNo("GN_MASTERPATTERN");
                InsertMasterPattern(trans, masterSet, masterNo, recipeNo);
                InsertMasterPatternLed(trans, masterLedSet, masterNo);

                InsertSmu(trans, smuSet, recipeNo);
                InsertBin(trans, binSet, recipeNo);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void UpdateRecipe()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                recipeSet.RecNo = recipeNo;

                UpdateRecipe(trans, recipeSet);
                UpdateMasterPatternLed(trans, masterLedSet);
                UpdateSmu(trans, smuSet);
                UpdateBin(trans, binSet);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void DeleteRecipe()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                Int64 recipeNo = recipeSet.RecNo;
                masterSet.Select(recipeNo, trans);

                for (int i=0; i<masterSet.RowCount; i++)
                {
                    masterSet.Fetch(i);

                    slaveSet.MasterPatternNo = masterSet.RecNo;
                    slaveSet.Select(masterSet.RecNo, trans);

                    for (int j=0; j<slaveSet.RowCount; j++)
                    {
                        slaveSet.Fetch(i);

                        slaveLedSet.SlavePatternNo = slaveSet.RecNo;
                        slaveLedSet.Delete(trans);
                    }

                    slaveSet.Delete(masterSet.RecNo, trans);

                    masterLedSet.MasterPatternNo = masterSet.RecNo;
                    masterLedSet.Delete(trans);
                }

                masterSet.RecipeNo = recipeNo;
                masterSet.Delete(trans);

                smuSet.RecipeNo = recipeNo;
                smuSet.Delete(trans);

                recipeSet.Delete(trans);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void InsertRecipe(FbTransaction trans, RecipeDataSet set, Int64 recNo)
        {
            set.RecNo = recNo;
            set.Name = nameEdit.Text.Trim();
            set.Memo = memoEdit.Text;
            set.ST1_X = double.Parse(st1XEdit.Text);
            set.ST1_Y = double.Parse(st1YEdit.Text);
            set.ST1_QR = st1QREdit.Text.Trim();
            set.ST2_X = double.Parse(st2XEdit.Text);
            set.ST2_Y = double.Parse(st2YEdit.Text);
            set.ST2_QR = st2QREdit.Text.Trim();
            set.Insert(trans);
        }

        private void UpdateRecipe(FbTransaction trans, RecipeDataSet set)
        {
            set.Name = nameEdit.Text.Trim();
            set.Memo = memoEdit.Text;
            set.ST1_X = double.Parse(st1XEdit.Text);
            set.ST1_Y = double.Parse(st1YEdit.Text);
            set.ST1_QR = st1QREdit.Text.Trim();
            set.ST2_X = double.Parse(st2XEdit.Text);
            set.ST2_Y = double.Parse(st2YEdit.Text);
            set.ST2_QR = st2QREdit.Text.Trim();
            set.Update(trans);
        }

        private void InsertMasterPattern(FbTransaction trans, MasterPatternDataSet set, Int64 masterNo, Int64 recipeNo)
        {
            set.RecNo = masterNo;
            set.RecipeNo = recipeNo;
            set.XLength = (int)xLengthEdit.Value;
            set.YHeight = (int)yHeightEdit.Value;
            set.StrCount = (int)stringCountEdit.Value;
            set.LedCount = (int)ledCountEdit.Value;
            set.Insert(trans);
        }

        private void InsertMasterPatternLed(FbTransaction trans, MasterPatternLedDataSet set, Int64 masterNo)
        {
            int height = ctrlPatternGrid.YHeight;
            int length = ctrlPatternGrid.XLength;

            for (int i=0; i<height; i++)
            {
                for (int j=0; j<length; j++)
                {
                    set.RecNo = AppRes.DB.GetGenNo("GN_MASTERPATTERN_LED");
                    set.MasterPatternNo = masterNo;
                    set.X = ctrlPatternGrid.PatternRows[i].Leds[j].X;
                    set.Y = ctrlPatternGrid.PatternRows[i].Leds[j].Y;
                    set.StrNo = ctrlPatternGrid.PatternRows[i].Leds[j].StringIndex;
                    set.LedNo = ctrlPatternGrid.PatternRows[i].Leds[j].LedIndex;
                    set.Type = ctrlPatternGrid.PatternRows[i].Leds[j].Type;
                    set.Insert(trans);
                }
            }
        }

        private void UpdateMasterPatternLed(FbTransaction trans, MasterPatternLedDataSet set)
        {
            int height = ctrlPatternGrid.YHeight;
            int length = ctrlPatternGrid.XLength;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    set.RecNo = ctrlPatternGrid.PatternRows[i].Leds[j].RecNo;
                    set.X = ctrlPatternGrid.PatternRows[i].Leds[j].X;
                    set.Y = ctrlPatternGrid.PatternRows[i].Leds[j].Y;
                    set.StrNo = ctrlPatternGrid.PatternRows[i].Leds[j].StringIndex;
                    set.LedNo = ctrlPatternGrid.PatternRows[i].Leds[j].LedIndex;
                    set.Type = ctrlPatternGrid.PatternRows[i].Leds[j].Type;
                    set.Update(trans);
                }
            }
        }

        private void InsertSmu(FbTransaction trans, SmuDataSet set, Int64 recipeNo)
        {
            foreach (StringRow row in stringRows)
            {
                set.RecNo = AppRes.DB.GetGenNo("GN_SMU");
                set.RecipeNo = recipeNo;
                set.StringNo = row.Index;
                set.Sets = row.Sets.DDWord(0);
                set.Insert(trans);
            }
        }

        private void UpdateSmu(FbTransaction trans, SmuDataSet set)
        {
            foreach (StringRow row in stringRows)
            {
                set.RecNo = row.RecNo;
                set.StringNo = row.Index;
                set.Sets = row.Sets.DDWord(0);
                set.Update(trans);
            }
        }

        private void InsertBin(FbTransaction trans, BinDataSet set, Int64 recipeNo)
        {
            foreach (RecipeBinRow row in binRows)
            {
                set.RecNo = AppRes.DB.GetGenNo("GN_BIN");
                set.RecipeNo = recipeNo;
                set.Type = row.Type;
                set.Index = row.Index;
                set.Name = row.Name;
                set.Mark = row.Mark;
                set.Insert(trans);
            }
        }

        private void UpdateBin(FbTransaction trans, BinDataSet set)
        {
            foreach (RecipeBinRow row in binRows)
            {
                set.RecNo = row.RecNo;
                set.RecipeNo = recipeNo;
                set.Type = row.Type;
                set.Index = row.Index;
                set.Name = row.Name;
                set.Mark = row.Mark;
                set.Update(trans);
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
                    SetPatternEditReadOnly(true);
                    break;

                case EDataSetMode.New:
                    ctrlParent.SetMenuEnabled(false);
                    ctrlParent.SetButtonEnabled(true);
                    viewStatePanel.BackColor = Color.DeepSkyBlue;
                    SetEditReadOnly(false);
                    SetPatternEditReadOnly(false);
                    break;

                case EDataSetMode.Modify:
                    ctrlParent.SetMenuEnabled(false);
                    ctrlParent.SetButtonEnabled(true);
                    viewStatePanel.BackColor = Color.DeepSkyBlue;
                    SetEditReadOnly(false);
                    SetPatternEditReadOnly(true);
                    break;
            }
        }

        private void ResetEdit()
        {
            nameEdit.Text = "";
            memoEdit.Text = "";
            st1XEdit.EditValue = 0;
            st1YEdit.EditValue = 0;
            st1QREdit.Text = "";
            st2XEdit.EditValue = 0;
            st2YEdit.EditValue = 0;
            st2QREdit.Text = "";
            xLengthEdit.Value = 1;
            yHeightEdit.Value = 1;
            stringCountEdit.Value = 1;
            ledCountEdit.Value = 1;

            ClearGrid();
        }

        private void SetEditReadOnly(bool enabled)
        {
            searchPanel.Enabled = enabled;

            nameEdit.Properties.ReadOnly = enabled;
            memoEdit.Properties.ReadOnly = enabled;
            st1XEdit.Properties.ReadOnly = enabled;
            st1YEdit.Properties.ReadOnly = enabled;
            st1QREdit.Properties.ReadOnly = enabled;
            st2XEdit.Properties.ReadOnly = enabled;
            st2YEdit.Properties.ReadOnly = enabled;
            st2QREdit.Properties.ReadOnly = enabled;

            smuGridView.OptionsBehavior.ReadOnly = enabled;
            (patternGridPanel.Controls[0] as CtrlPatternGrid).ReadOnly = enabled;
            binGridView.OptionsBehavior.ReadOnly = enabled;
        }

        private void SetPatternEditReadOnly(bool enabled)
        {
            xLengthEdit.Properties.ReadOnly = enabled;
            yHeightEdit.Properties.ReadOnly = enabled;
            stringCountEdit.Properties.ReadOnly = enabled;
            ledCountEdit.Properties.ReadOnly = enabled;
            createButton.Enabled = !enabled;
        }

        private void SetPatternControls()
        {
            xLengthEdit.Value = 1;
            yHeightEdit.Value = 1;
            stringCountEdit.Value = 1;
            ledCountEdit.Value = 1;
        }

        private void ClearGrid()
        {
            stringRows.Clear();
            for (int i = 0; i < smuGridView.Columns.Count; i++)
            {
                smuGridView.Columns[i].Visible = false;
            }
            AppHelper.RefreshGridData(smuGridView);

            for (int i=0; i<binRows.Count; i++)
            {
                binRows[i].Clear(i + 1);
            }

            (patternGridPanel.Controls[0] as CtrlPatternGrid).ClearGrid();

        }

        private void RefreshStringToSmus()
        {
            UlBinSets sets = new UlBinSets(8);

            stringToSmus.Clear();
            smuSet.Select(recipeNo);

            for (int i = 0; i < smuSet.RowCount; i++)
            {
                smuSet.Fetch(i);
                sets.DDWord(0, smuSet.Sets);

                if (sets.DDWord(0) == 0)
                {
                    stringToSmus.Add(-1);
                }
                else
                {
                    for (int j = 0; j < sets.Count * 8; j++)
                    {
                        if (sets[j] == true)
                        {
                            stringToSmus.Add(j);
                        }
                    }
                }
            }
        }

        private void RefreshSmuGridData()
        {
            AppHelper.RefreshGridData(smuGridView);
        }

        private void RefreshStringToSmus(int count)
        {
            stringToSmus.Clear();

            for (int i=0; i<count; i++)
            {
                stringToSmus.Add(-1);
            }
        }

        private void RefreshSmuGrid(int smuCount, int stringCount)
        {
            stringRows.Clear();

            for (int i = 0; i < stringCount; i++)
            {
                StringRow row = new StringRow(i);

                stringRows.Add(row);
            }

            smuGridView.BeginUpdate();

            try
            {
                GridColumn col = smuGridView.Columns[0];
                col.AppearanceCell.BackColor = Color.FromArgb(245, 245, 247);
                col.AppearanceCell.Options.UseBackColor = true;
                col.Visible = true;
                col.VisibleIndex = 1;

                for (int i = 0; i < smuCount; i++)
                {
                    col = smuGridView.Columns[i + 1];
                    col.AppearanceCell.BackColor = Color.White;
                    col.AppearanceCell.Options.UseBackColor = true;
                    col.AppearanceHeader.BackColor = Color.FromKnownColor(AppRes.Properties.SmuColors[i]);
                    col.AppearanceHeader.Options.UseBackColor = true;
                    col.Visible = true;
                    col.VisibleIndex = i + 2;
                }
            }
            finally
            {
                smuGridView.EndUpdate();
            }
        }

        private GridColumn CreateGridColumn(string caption, string fieldName, int width, bool focus = false, bool edit=false)
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
    }
}
