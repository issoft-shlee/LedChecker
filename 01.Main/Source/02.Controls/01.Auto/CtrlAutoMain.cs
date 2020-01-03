﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Spreadsheet;

using Ulee.Utils;
using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlAutoMain : UlUserControlEng
    {
        private CtrlAutoRight ctrlParent;

        private TestContext context;

        private CtrlReportPage fullReportPage;

        private CtrlReportPage samplingReportPage;

        public int TotalMeter
        { set { totalMeter.Text = value.ToString(); } }

        public int OkMeter
        { set { okMeter.Text = value.ToString(); } }

        public int NgMeter
        { set { ngMeter.Text = value.ToString(); } }

        public double RatioMeter
        { set { ratioMeter.Text = $"{value:F1}"; } }

        public ETestDecision DecisionMeter
        {
            set
            {
                switch (value)
                {
                    case ETestDecision.Nt:
                        decisionMeter.BackColor = Color.White;
                        decisionMeter.ForeColor = Color.Black;
                        break;

                    case ETestDecision.Ok:
                        decisionMeter.BackColor = Color.Blue;
                        decisionMeter.ForeColor = Color.White;
                        break;

                    case ETestDecision.Ng:
                        decisionMeter.BackColor = Color.Red;
                        decisionMeter.ForeColor = Color.Yellow;
                        break;
                }

                decisionMeter.Text = EnumHelper.ToDescription(value);
            }
        }

        public CtrlAutoMain(CtrlAutoRight parent)
        {
            ctrlParent = parent;

            InitializeComponent();
            Initialize();
        }

        private void CtrlAutoMain_Load(object sender, EventArgs e)
        {
            TotalMeter = 0;
            OkMeter = 0;
            NgMeter = 0;
            RatioMeter = 0;
            DecisionMeter = ETestDecision.Nt;
        }

        private void CtrlAutoMain_Enter(object sender, EventArgs e)
        {
            if (context.Recipe.RecNo == 0)
            {
                recipePanel_DoubleClick(null, null);
            }
        }

        private void recipePanel_DoubleClick(object sender, EventArgs e)
        {
            if (AppRes.Busy == true) return;

            DialogRecipeList dialog = new DialogRecipeList();

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    context.Load(dialog.Result.RecNo);
                }
            }
        }

        private void Initialize()
        {
            context = new TestContext(ctrlParent.Handle);
            context.InvalidCounter += DoInvalidCounter;
            context.InvalidRecipe += DoInvalidRecipe;
            context.InvalidValue += DoInvalidValue;
            context.InvalidTestIndex += DoInvalidTestIndex;

            binBook.Document.LoadDocument(AppRes.Properties.FormBin);
            binBook.WorksheetDisplayArea.SetSize(0, 40, 2);

            fullReportPage = new CtrlReportPage();
            fullPage.Controls.Add(fullReportPage);

            samplingReportPage = new CtrlReportPage();
            samplingPage.Controls.Add(samplingReportPage);
        }

        private void SetBinItems(BinList bins)
        {
            Worksheet sheet = binBook.Document.Worksheets[0];

            binBook.BeginUpdate();
            try
            {
                sheet.ClearContents(sheet["A1:AN2"]);

                for (int i=0; i<40; i++)
                {
                    sheet.Cells[0, i].FillColor = Color.FromKnownColor(KnownColor.Transparent);
                    sheet.Cells[1, i].Value = "";
                }

                for (int i = 0; i < bins.Count; i++)
                {
                    sheet.Cells[0, i].Value = bins[i + 1].Name;
                    sheet.Cells[0, i].FillColor = bins[i + 1].Mark;
                }
            }
            finally
            {
                binBook.EndUpdate();
            }
        }

        private void DispTestCounter(TestCounter counter)
        {
            TotalMeter = counter.Total;
            OkMeter = counter.Ok;
            NgMeter = counter.Ng;
            RatioMeter = counter.OkRate;
        }

        private void DispBinCounter(List<BinCounter> bins)
        {
            Worksheet sheet = binBook.Document.Worksheets[0];

            binBook.BeginUpdate();
            try
            {
                for (int i=0; i<bins.Count; i++)
                {
                    sheet.Cells[1, i].Value = bins[i].Count;
                }
            }
            finally
            {
                binBook.EndUpdate();
            }
        }

        private void SetTestIndex(int index)
        {
            if (context.Value.Type == EWorkType.Full)
            {
                fullReportPage.SetWorkIndex(index);
            }
            else
            {
                samplingReportPage.SetWorkIndex(index);
            }
        }

        public void DoInvalidCounter(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(DoInvalidCounter);
                this.BeginInvoke(func, new object[] { sender, e });
            }
            else
            {
                CounterArgs args = e as CounterArgs;
                DispTestCounter(args.Counter);
                DispBinCounter(args.Counter.Bins);
            }
        }

        public void DoInvalidRecipe(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(DoInvalidRecipe);
                this.BeginInvoke(func, new object[] { sender, e });
            }
            else
            {
                RecipeArgs args = e as RecipeArgs;

                recipePanel.Text = args.Recipe.Code;
                SetBinItems(args.Recipe.Bin);
                fullReportPage.SetWorkObjects(args.Recipe.Work[EWorkType.Full]);
                samplingReportPage.SetWorkObjects(args.Recipe.Work[EWorkType.Sampling]);
            }
        }

        public void DoInvalidValue(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(DoInvalidValue);
                this.BeginInvoke(func, new object[] { sender, e });
            }
            else
            {
            }
        }

        public void DoInvalidTestIndex(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(DoInvalidTestIndex);
                this.BeginInvoke(func, new object[] { sender, e });
            }
            else
            {
                TestIndexArgs args = e as TestIndexArgs;
                SetTestIndex(args.Index);
            }
        }

        public void InitializeTest()
        {
            context.InitializeThread();
        }

        public void FinalizeTest()
        {
            context.FinalizeThread();
        }

        public void StartTest()
        {
            context.StartThread();
        }

        public void PauseTest()
        {
            context.SuspendThread();
        }

        public void StopTest()
        {
            context.TerminateThread();
        }
    }
}
