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
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlConfigPattern : UlUserControlEng
    {
        private Int64 recipeNo;

        private Int64 masterNo;

        private EDataSetMode mode;

        private List<int> stringToSmus;

        private GridBookmark bookmark;

        private CtrlConfigRight ctrlParent;

        private CtrlPatternGrid ctrlPatternGrid;

        private RecipeDataSet recipeSet;

        private MasterPatternDataSet masterSet;

        private MasterPatternLedDataSet masterLedSet;

        private SlavePatternDataSet slaveSet;

        private SlavePatternLedDataSet slaveLedSet;

        private SmuDataSet smuSet;

        public CtrlConfigPattern(CtrlConfigRight parent)
        {
            recipeNo = 0;
            masterNo = 0;
            ctrlParent = parent;

            InitializeComponent();
            Initialize();
        }

        private void CtrlConfigPattern_Load(object sender, EventArgs e)
        {
            patternGrid.DataSource = (slaveSet.Empty == true) ? null : slaveSet.DataSet.Tables[0];
            patternGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            patternGridView.OptionsView.EnableAppearanceEvenRow = true;
        }

        private void CtrlConfigPattern_Enter(object sender, EventArgs e)
        {
            LoadRecipeComboItems();

            if (recipeCombo.Items.Count == 0) return;
            if (recipeNo <= 0) return;

            recipeCombo.SelectedValue = recipeNo;
            patternGridView.Focus();
        }

        private void CtrlConfigPattern_Leave(object sender, EventArgs e)
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
            RefreshPattern();
        }

        private void patternGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;
            if (mode != EDataSetMode.View) return;

            DataRow row = patternGridView.GetDataRow(e.FocusedRowHandle);
            slaveSet.Fetch(row);

            SetEditValueFromDataSet();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;
            if (recipeCombo.SelectedIndex < 0) return;

            SetDataSetMode(EDataSetMode.New);
            ResetEditValue();
            nameEdit.Focus();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;
            if (patternGridView.FocusedRowHandle < 0) return;

            SetDataSetMode(EDataSetMode.Modify);
            nameEdit.Focus();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the pattern focused?",
                AppRes.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            DeletePattern();
            SetDataSetMode(EDataSetMode.View);
            RefreshPattern();
        }

        private void patternGrid_DoubleClick(object sender, EventArgs e)
        {
            if (mode != EDataSetMode.View) return;

            modifyButton.PerformClick();
        }

        private void Initialize()
        {
            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);
            masterSet = new MasterPatternDataSet(AppRes.DB.Connect, null, null);
            masterLedSet = new MasterPatternLedDataSet(AppRes.DB.Connect, null, null);
            slaveSet = new SlavePatternDataSet(AppRes.DB.Connect, null, null);
            slaveLedSet = new SlavePatternLedDataSet(AppRes.DB.Connect, null, null);
            smuSet = new SmuDataSet(AppRes.DB.Connect, null, null);

            stringToSmus = new List<int>();

            mode = EDataSetMode.View;
            bookmark = new GridBookmark(patternGridView);

            ctrlPatternGrid = new CtrlPatternGrid(EPatternDispMode.StringAndLamp, stringToSmus);
            patternGridPanel.Controls.Add(ctrlPatternGrid);

            DispSmuColorButtons();
            LoadRecipeComboItems();
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

        private void RefreshPattern()
        {
            if (recipeCombo.SelectedIndex < 0)
            {
                masterNo = 0;
                return;
            }

            DataRow row = ((DataTable)recipeCombo.DataSource).Rows[recipeCombo.SelectedIndex];
            recipeSet.Fetch(row);

            recipeNo = recipeSet.RecNo;
            RefreshStringToSmus();

            masterSet.Select(recipeNo);
            masterSet.Fetch();
            masterNo = masterSet.RecNo;

            xLengthEdit.EditValue = masterSet.XLength;
            yHeightEdit.EditValue = masterSet.YHeight;
            stringCountEdit.EditValue = masterSet.StrCount;
            ledCountEdit.EditValue = masterSet.LedCount;

            ctrlPatternGrid.XLength = masterSet.XLength;
            ctrlPatternGrid.YHeight = masterSet.YHeight;
            ctrlPatternGrid.StringCount = masterSet.StrCount;
            ctrlPatternGrid.LedCount = masterSet.LedCount;

            bookmark.Get();
            slaveSet.Select(masterNo);

            if (slaveSet.Empty == true)
            {
                patternGrid.DataSource = null;
                SetEditValueFromDataSet();
                SetEditReadOnly(true);
            }
            else
            {
                patternGrid.DataSource = slaveSet.DataSet.Tables[0];
            }

            bookmark.Goto();
            patternGrid.Focus();
        }

        private void DispSmuColorButtons()
        {
            int i;

            UlPanel colorPanel = new UlPanel();
            colorPanel.Location = new Point(2, 2);
            colorPanel.Size = new Size(80, 28);
            colorPanel.Text = $"Disabled";
            colorPanel.BackColor = Color.White;
            colorPanel.BevelInner = EUlBevelStyle.None;
            colorPanel.BevelOuter = EUlBevelStyle.Single;
            smuColorPanel.Controls.Add(colorPanel);

            for (i=0; i<AppRes.Properties.SmuCount; i++)
            {
                colorPanel = new UlPanel();
                colorPanel.Location = new Point(i * 81 + 83, 2);
                colorPanel.Size = new Size(80, 28);
                colorPanel.Text = $"SMU{i+1}";
                colorPanel.BackColor = Color.FromKnownColor(AppRes.Properties.SmuColors[i]);
                colorPanel.BevelInner = EUlBevelStyle.None;
                colorPanel.BevelOuter = EUlBevelStyle.Single;
                smuColorPanel.Controls.Add(colorPanel);
            }

            colorPanel = new UlPanel();
            colorPanel.Location = new Point(i * 81 + 83, 2);
            colorPanel.Size = new Size(80, 28);
            colorPanel.Text = $"Black";
            colorPanel.ForeColor = Color.White;
            colorPanel.BackColor = Color.Black;
            colorPanel.BevelInner = EUlBevelStyle.None;
            colorPanel.BevelOuter = EUlBevelStyle.Single;
            smuColorPanel.Controls.Add(colorPanel);
        }

        private void LoadRecipeComboItems()
        {
            recipeSet.Select();
            recipeCombo.DataSource = recipeSet.DataSet.Tables[0];
            recipeCombo.DisplayMember = "code";
            recipeCombo.ValueMember = "pk_recno";
        }

        private void ResetEditValue()
        {
            nameEdit.Text = "";
            memoEdit.Text = "";

            ctrlPatternGrid.RefreshGrid();

            masterSet.Select((Int64)recipeCombo.SelectedValue);
            masterSet.Fetch();
            masterNo = masterSet.RecNo;

            masterLedSet.Select(masterNo);

            if (masterLedSet.Empty == false)
            {
                for (int i = 0; i < masterLedSet.RowCount; i++)
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
            }
        }

        private void SetEditValueFromDataSet()
        {
            Int64 slaveNo;

            if (slaveSet.Empty == false)
            {
                slaveNo = slaveSet.RecNo;
                nameEdit.Text = slaveSet.Name;
                memoEdit.Text = slaveSet.Memo;
            }
            else
            {
                slaveNo = 0;
                nameEdit.Text = "";
                memoEdit.Text = "";
            }

            nameEdit.Properties.ReadOnly = true;
            memoEdit.Properties.ReadOnly = true;

            ctrlPatternGrid.RefreshGrid();

            if (slaveNo > 0)
            {
                slaveLedSet.Select(slaveNo);

                if (slaveLedSet.Empty == false)
                {
                    for (int i = 0; i < slaveLedSet.RowCount; i++)
                    {
                        slaveLedSet.Fetch(i);

                        int x = slaveLedSet.X;
                        int y = slaveLedSet.Y;

                        ctrlPatternGrid.PatternRows[y].Leds[x].RecNo = slaveLedSet.RecNo;
                        ctrlPatternGrid.PatternRows[y].Leds[x].X = x;
                        ctrlPatternGrid.PatternRows[y].Leds[x].Y = y;
                        ctrlPatternGrid.PatternRows[y].Leds[x].StringIndex = slaveLedSet.StrNo;
                        ctrlPatternGrid.PatternRows[y].Leds[x].LedIndex = slaveLedSet.LedNo;
                        ctrlPatternGrid.PatternRows[y].Leds[x].TurnOn = slaveLedSet.TurnOn;
                        ctrlPatternGrid.PatternRows[y].Leds[x].Measuring = slaveLedSet.Measuring;
                        ctrlPatternGrid.PatternRows[y].Leds[x].Type = slaveLedSet.Type;
                    }

                    ctrlPatternGrid.RefreshGridData();
                }
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

            nameEdit.Properties.ReadOnly = enabled;
            memoEdit.Properties.ReadOnly = enabled;

            (patternGridPanel.Controls[0] as CtrlPatternGrid).ReadOnly = enabled;
        }

        private void InsertPattern()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                Int64 slaveNo = AppRes.DB.GetGenNo("GN_SLAVEPATTERN");

                InsertSlavePattern(trans, slaveSet, slaveNo);
                InsertSlavePatternLed(trans, slaveLedSet, slaveNo);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void InsertSlavePattern(FbTransaction trans, SlavePatternDataSet set, Int64 recNo)
        {
            set.RecNo = recNo;
            set.MasterPatternNo = masterNo;
            set.Name = nameEdit.Text.Trim();
            set.Memo = memoEdit.Text;
            set.Insert(trans);
        }

        private void InsertSlavePatternLed(FbTransaction trans, SlavePatternLedDataSet set, Int64 slaveNo)
        {
            int height = ctrlPatternGrid.YHeight;
            int length = ctrlPatternGrid.XLength;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    set.RecNo = AppRes.DB.GetGenNo("GN_SLAVEPATTERN_LED");
                    set.SlavePatternNo = slaveNo;
                    set.X = ctrlPatternGrid.PatternRows[i].Leds[j].X;
                    set.Y = ctrlPatternGrid.PatternRows[i].Leds[j].Y;
                    set.StrNo = ctrlPatternGrid.PatternRows[i].Leds[j].StringIndex;
                    set.LedNo = ctrlPatternGrid.PatternRows[i].Leds[j].LedIndex;
                    set.TurnOn = ctrlPatternGrid.PatternRows[i].Leds[j].TurnOn;
                    set.Measuring = ctrlPatternGrid.PatternRows[i].Leds[j].Measuring;
                    set.Type = ctrlPatternGrid.PatternRows[i].Leds[j].Type;
                    set.Insert(trans);
                }
            }
        }

        private void UpdatePatern()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                UpdateSlavePattern(trans, slaveSet);
                UpdateSlavePatternLed(trans, slaveLedSet, slaveSet.RecNo);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
        }

        private void UpdateSlavePattern(FbTransaction trans, SlavePatternDataSet set)
        {
            set.Name = nameEdit.Text.Trim();
            set.Memo = memoEdit.Text;
            set.Update(trans);
        }

        private void UpdateSlavePatternLed(FbTransaction trans, SlavePatternLedDataSet set, Int64 slaveNo)
        {
            int height = ctrlPatternGrid.YHeight;
            int length = ctrlPatternGrid.XLength;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    set.RecNo = ctrlPatternGrid.PatternRows[i].Leds[j].RecNo;
                    set.SlavePatternNo = slaveNo;
                    set.X = ctrlPatternGrid.PatternRows[i].Leds[j].X;
                    set.Y = ctrlPatternGrid.PatternRows[i].Leds[j].Y;
                    set.StrNo = ctrlPatternGrid.PatternRows[i].Leds[j].StringIndex;
                    set.LedNo = ctrlPatternGrid.PatternRows[i].Leds[j].LedIndex;
                    set.TurnOn = ctrlPatternGrid.PatternRows[i].Leds[j].TurnOn;
                    set.Measuring = ctrlPatternGrid.PatternRows[i].Leds[j].Measuring;
                    set.Type = ctrlPatternGrid.PatternRows[i].Leds[j].Type;
                    set.Update(trans);
                }
            }
        }

        private void DeletePattern()
        {
            FbTransaction trans = AppRes.DB.BeginTrans();

            try
            {
                slaveLedSet.SlavePatternNo = slaveSet.RecNo;
                slaveLedSet.Delete(trans);
                slaveSet.Delete(trans);

                AppRes.DB.CommitTrans();
            }
            catch
            {
                AppRes.DB.RollbackTrans();
            }
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

            switch (mode)
            {
                case EDataSetMode.New:
                    InsertPattern();
                    break;

                case EDataSetMode.Modify:
                    UpdatePatern();
                    break;
            }

            SetDataSetMode(EDataSetMode.View);
            RefreshPattern();
        }

        public void Cancel()
        {
            SetDataSetMode(EDataSetMode.View);
            RefreshPattern();
        }
    }
}
