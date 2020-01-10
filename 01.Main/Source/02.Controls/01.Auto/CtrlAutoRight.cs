using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public enum ETestModeLamp { Auto, Manual }

    public enum ETestTypeLamp { None, Normal, Sampling }

    public enum ETestButtonState { Started, Paused, Stopped }

    public partial class CtrlAutoRight : UlUserControlEng
    {
        private ETestModeLamp mode;

        private ETestTypeLamp type;

        private TestContext context;

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

        public CtrlAutoRight()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            context = new TestContext(this.Handle);
            context.InvalidCounter += DoInvalidCounter;
            context.InvalidRecipe += DoInvalidRecipe;
            context.InvalidValue += DoInvalidValue;
            context.InvalidTestIndex += DoInvalidTestIndex;

            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlAutoMain(context), mainButton);
            DefMenu.Add(new CtrlAutoBin(context), binButton);
            DefMenu.Add(new CtrlAutoLog(), logButton);
            DefMenu.Index = 0;

            SetModeLamp(ETestModeLamp.Auto);
            SetTypeLamp(ETestTypeLamp.None);
            SetButtonState(ETestButtonState.Stopped);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case AppRes.WM_TEST_NORMAL_TERMINATED:
                    FinalizeTest();
                    break;

                case AppRes.WM_TEST_ABNORMAL_TERMINATED:
                    FinalizeTest();
                    break;
            }

            base.WndProc(ref m);
        }

        private void CtrlAutoRight_Load(object sender, EventArgs e)
        {
            TotalMeter = 0;
            OkMeter = 0;
            NgMeter = 0;
            RatioMeter = 0;
            DecisionMeter = ETestDecision.Nt;
        }

        private void CtrlAutoRight_Enter(object sender, EventArgs e)
        {
            if (context.Recipe.RecNo == 0)
            {
                recipePanel_DoubleClick(null, null);
            }
        }

        private void autoLamp_Click(object sender, EventArgs e)
        {
            if (AppRes.Busy == true) return;

            SetModeLamp(ETestModeLamp.Auto);
        }

        private void manualLamp_Click(object sender, EventArgs e)
        {
            if (AppRes.Busy == true) return;

            SetModeLamp(ETestModeLamp.Manual);
        }

        private void normalLamp_Click(object sender, EventArgs e)
        {
            if (AppRes.Busy == true) return;

            SetTypeLamp((type == ETestTypeLamp.Normal) ? ETestTypeLamp.None : ETestTypeLamp.Normal);
        }

        private void samplingLamp_Click(object sender, EventArgs e)
        {
            if (AppRes.Busy == true) return;

            SetTypeLamp((type == ETestTypeLamp.Sampling) ? ETestTypeLamp.None : ETestTypeLamp.Sampling);
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

        private void startButton_Click(object sender, EventArgs e)
        {
            DefMenu.Index = 0;
            SetButtonState(ETestButtonState.Started);
            (DefMenu[2] as CtrlAutoLog).Clear();
            SetTypeLamp(ETestTypeLamp.Normal);
            context.StartThread();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            SetButtonState(ETestButtonState.Paused);
            context.SuspendThread();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            context.TerminateThread();
        }

        private void FinalizeTest()
        {
            SetButtonState(ETestButtonState.Stopped);
            SetTypeLamp(ETestTypeLamp.None);
            context.FinalizeThread();
        }

        private void SetButtonState(ETestButtonState state)
        {
            switch (state)
            {
                case ETestButtonState.Started:
                    startButton.Enabled = false;
                    pauseButton.Enabled = true;
                    stopButton.Enabled = true;
                    break;

                case ETestButtonState.Paused:
                    startButton.Enabled = true;
                    pauseButton.Enabled = false;
                    stopButton.Enabled = true;
                    break;

                case ETestButtonState.Stopped:
                    startButton.Enabled = true;
                    pauseButton.Enabled = false;
                    stopButton.Enabled = false;
                    break;
            }
        }

        private void SetModeLamp(ETestModeLamp mode)
        {
            this.mode = mode;

            switch (mode)
            {
                case ETestModeLamp.Auto:
                    autoLamp.BackColor = Color.Lime;
                    manualLamp.BackColor = Color.Black;
                    break;

                case ETestModeLamp.Manual:
                    autoLamp.BackColor = Color.Black;
                    manualLamp.BackColor = Color.Lime;
                    break;
            }
        }

        private void SetTypeLamp(ETestTypeLamp type)
        {
            this.type = type;

            switch (type)
            {
                case ETestTypeLamp.None:
                    normalLamp.BackColor = Color.Black;
                    samplingLamp.BackColor = Color.Black;
                    break;

                case ETestTypeLamp.Normal:
                    normalLamp.BackColor = Color.Violet;
                    samplingLamp.BackColor = Color.Black;
                    break;

                case ETestTypeLamp.Sampling:
                    normalLamp.BackColor = Color.Black;
                    samplingLamp.BackColor = Color.Violet;
                    break;
            }
        }

        private void DispTestCounter(TestCounter counter)
        {
            TotalMeter = counter.Total;
            OkMeter = counter.Ok;
            NgMeter = counter.Ng;
            RatioMeter = counter.OkRate;
        }

        public void DoInvalidCounter(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(DoInvalidCounter);
                this.BeginInvoke(func, new object[] { sender, e });
                return;
            }

            CounterArgs args = e as CounterArgs;

            DispTestCounter(args.Counter);
            (DefMenu[1] as CtrlAutoBin).DispBinCounter(args.Counter.Bins);
        }

        public void DoInvalidRecipe(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(DoInvalidRecipe);
                this.BeginInvoke(func, new object[] { sender, e });
                return;
            }

            recipePanel.Text = context.Recipe.Code;

            (DefMenu[0] as CtrlAutoMain).SetWorkObjects();
            (DefMenu[1] as CtrlAutoBin).SetBinItems();
        }

        public void DoInvalidValue(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(DoInvalidValue);
                this.BeginInvoke(func, new object[] { sender, e });
                return;
            }
        }

        public void DoInvalidTestIndex(object sender, EventArgs e)
        {
            if (this.InvokeRequired == true)
            {
                EventHandler func = new EventHandler(DoInvalidTestIndex);
                this.BeginInvoke(func, new object[] { sender, e });
                return;
            }

            TestIndexArgs args = e as TestIndexArgs;

            (DefMenu[0] as CtrlAutoMain).SetTestIndex(args.Index);
        }
    }
}
