using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using Ulee.Controls;
using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    public partial class DialogLedProperty : UlFormEng
    {
        private bool initializing;

        private EPatternDispMode mode;

        private LedProperty led;

        public DialogLedProperty(EPatternDispMode mode, LedProperty led, int stringMax, int ledMax)
        {
            this.mode = mode;
            this.led = led;

            InitializeComponent();
            Initialize(stringMax, ledMax);
        }

        private void DialogLedProperty_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                led.Type = (ELedType)typeCombo.SelectedValue;

                switch (led.Type)
                {
                    case ELedType.Disabled:
                        led.StringIndex = 0;
                        led.LedIndex = 0;
                        led.TurnOn = false;
                        led.Measuring = false;
                        break;

                    case ELedType.Enabled:
                        led.StringIndex = (int)stringNoEdit.Value;
                        led.LedIndex = (int)ledNoEdit.Value;
                        led.TurnOn = turnOnCheck.Checked;
                        led.Measuring = measuringCheck.Checked;
                        break;

                    case ELedType.Black:
                        led.StringIndex = 0;
                        led.LedIndex = 0;
                        led.TurnOn = false;
                        led.Measuring = measuringCheck.Checked;
                        break;
                }
            }
        }

        private void recipeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initializing == true) return;

            SetControlsEnabled();
        }

        private void Initialize(int stringMax, int ledMax)
        {
            initializing = true;

            stringNoEdit.Properties.MaxValue = stringMax;
            ledNoEdit.Properties.MaxValue = ledMax;
            typeCombo.Enabled = (mode == EPatternDispMode.String) ? true : false;

            switch (led.Type)
            {
                case ELedType.Disabled:
                    stringNoEdit.Value = 1;
                    ledNoEdit.Value = 1;
                    turnOnCheck.Checked = false;
                    measuringCheck.Checked = false;
                    break;

                case ELedType.Enabled:
                    stringNoEdit.Value = (led.StringIndex == 0) ? 1 : led.StringIndex;
                    ledNoEdit.Value = (led.LedIndex == 0) ? 1 : led.LedIndex;
                    turnOnCheck.Checked = led.TurnOn;
                    measuringCheck.Checked = led.Measuring;
                    break;

                case ELedType.Black:
                    stringNoEdit.Value = 1;
                    ledNoEdit.Value = 1;
                    turnOnCheck.Checked = false;
                    measuringCheck.Checked = false;
                    break;
            }

            typeCombo.DataSource = EnumHelper.GetNameValues<ELedType>();
            typeCombo.DisplayMember = "Name";
            typeCombo.ValueMember = "Value";
            typeCombo.SelectedValue = led.Type;
            SetControlsEnabled();

            initializing = false;
        }

        private void SetControlsEnabled()
        {
            if (mode == EPatternDispMode.String)
            {
                switch ((ELedType)typeCombo.SelectedValue)
                {
                    case ELedType.Disabled:
                    case ELedType.Black:
                        stringNoEdit.Properties.ReadOnly = true;
                        ledNoEdit.Properties.ReadOnly = true;
                        turnOnCheck.Enabled = false;
                        measuringCheck.Enabled = false;
                        break;

                    case ELedType.Enabled:
                        stringNoEdit.Properties.ReadOnly = false;
                        ledNoEdit.Properties.ReadOnly = false;
                        turnOnCheck.Enabled = false;
                        measuringCheck.Enabled = false;
                        break;
                }
            }
            else
            {
                switch ((ELedType)typeCombo.SelectedValue)
                {
                    case ELedType.Disabled:
                        stringNoEdit.Properties.ReadOnly = true;
                        ledNoEdit.Properties.ReadOnly = true;
                        turnOnCheck.Enabled = false;
                        measuringCheck.Enabled = false;
                        break;

                    case ELedType.Enabled:
                        stringNoEdit.Properties.ReadOnly = true;
                        ledNoEdit.Properties.ReadOnly = true;
                        turnOnCheck.Enabled = true;
                        measuringCheck.Enabled = true;
                        break;

                    case ELedType.Black:
                        stringNoEdit.Properties.ReadOnly = true;
                        ledNoEdit.Properties.ReadOnly = true;
                        turnOnCheck.Enabled = false;
                        measuringCheck.Enabled = true;
                        break;
                }
            }
        }
    }
}
   