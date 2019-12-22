using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Base;

using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class DialogPatternList : UlFormEng
    {
        private Int64 recipeNo;

        private List<int> stringToSmus;

        private CtrlPatternGrid ctrlPatternGrid;

        public TestPatternRow Result { get; set; }

        private MasterPatternDataSet masterSet;

        private SlavePatternDataSet slaveSet;

        private SlavePatternLedDataSet slaveLedSet;

        private SmuDataSet smuSet;

        public DialogPatternList(Int64 recipeNo)
        {
            this.recipeNo = recipeNo;

            InitializeComponent();
            Initialize();
        }

        private void DialogPatternList_Load(object sender, EventArgs e)
        {
            masterSet.Select(recipeNo);
            masterSet.Fetch();
            Int64 masterNo = masterSet.RecNo;

            xLengthEdit.EditValue = masterSet.XLength;
            yHeightEdit.EditValue = masterSet.YHeight;
            stringCountEdit.EditValue = masterSet.StrCount;
            ledCountEdit.EditValue = masterSet.LedCount;

            ctrlPatternGrid.XLength = masterSet.XLength;
            ctrlPatternGrid.YHeight = masterSet.YHeight;
            ctrlPatternGrid.StringCount = masterSet.StrCount;
            ctrlPatternGrid.LedCount = masterSet.LedCount;

            slaveSet.SelectIncludeNone(masterNo);

            patternGrid.DataSource = slaveSet.DataSet.Tables[0];
            patternGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            patternGridView.OptionsView.EnableAppearanceEvenRow = true;
        }

        private void patternGrid_DoubleClick(object sender, EventArgs e)
        {
            if (slaveSet.Empty == true) return;

            okButton.PerformClick();
        }

        private void patternGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0) return;

            DataRow row = patternGridView.GetDataRow(e.FocusedRowHandle);
            slaveSet.Fetch(row);

            SetEditValueFromDataSet();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (slaveSet.RecNo == 0)
            {
                Result = new TestPatternRow(0, "None", "None");
            }
            else
            {
                string smu = GetActiveSmus(slaveSet.RecNo);
                Result = new TestPatternRow(slaveSet.RecNo, slaveSet.Name, smu);
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Result = null;
            Close();
        }

        private void Initialize()
        {
            masterSet = new MasterPatternDataSet(AppRes.DB.Connect, null, null);
            slaveSet = new SlavePatternDataSet(AppRes.DB.Connect, null, null);
            slaveLedSet = new SlavePatternLedDataSet(AppRes.DB.Connect, null, null);
            smuSet = new SmuDataSet(AppRes.DB.Connect, null, null);

            stringToSmus = new List<int>();
            RefreshStringToSmus();
            DispSmuColorButtons();

            ctrlPatternGrid = new CtrlPatternGrid(EPatternDispMode.StringAndLamp, stringToSmus);
            patternGridPanel.Controls.Add(ctrlPatternGrid);
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

            for (i = 0; i < AppRes.Properties.SmuCount; i++)
            {
                colorPanel = new UlPanel();
                colorPanel.Location = new Point(i * 81 + 83, 2);
                colorPanel.Size = new Size(80, 28);
                colorPanel.Text = $"SMU{i + 1}";
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

        private string GetActiveSmus(Int64 slaveNo)
        {
            string ret = "";
            UInt64 smu = 0;
            List<UInt64> smus = GetSmuSets();

            slaveLedSet.Select(slaveNo);

            if (slaveLedSet.Empty == false)
            {
                for (int i = 0; i < slaveLedSet.RowCount; i++)
                {
                    slaveLedSet.Fetch(i);

                    if (slaveLedSet.TurnOn == true)
                    {
                        smu |= smus[slaveLedSet.StrNo - 1];
                    }
                }
            }

            UlBinSets smuSets = new UlBinSets(8);
            smuSets.DDWord(0, smu);

            for (int i=0; i<smuSets.Count*8; i++)
            {
                if (smuSets[i] == true)
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

            return ret;
        }

        private List<UInt64> GetSmuSets()
        {
            List<UInt64> smus = new List<UInt64>();

            smuSet.Select(recipeNo);
            for (int i=0; i<smuSet.RowCount; i++)
            {
                smuSet.Fetch(i);
                smus.Add(smuSet.Sets);
            }

            return smus;
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
                    for (int j=0; j<sets.Count*8; j++)
                    {
                        if (sets[j] == true)
                        {
                            stringToSmus.Add(j);
                        } 
                    }
                }
            }
        }

        private void SetEditValueFromDataSet()
        {
            Int64 slaveNo;

            if ((slaveSet.RecNo < 1) || (slaveSet.Empty == true))
            {
                slaveNo = 0;
                nameEdit.Text = "";
                memoEdit.Text = "";
            }
            else
            {
                slaveNo = slaveSet.RecNo;
                nameEdit.Text = slaveSet.Name;
                memoEdit.Text = slaveSet.Memo;
            }
 
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
    }
}
