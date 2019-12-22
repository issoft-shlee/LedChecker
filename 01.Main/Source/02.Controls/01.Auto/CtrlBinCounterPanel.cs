using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class CtrlBinCounterPanel : UlUserControlEng
    {
        public string Caption
        {
            get { return captionPanel.Text; }
            set { captionPanel.Text = value; }
        }

        public Color CaptionBackColor
        {
            get { return captionPanel.BackColor; }
            set { captionPanel.BackColor = value; }
        }

        public Color CaptionForeColor
        {
            get { return captionPanel.ForeColor; }
            set { captionPanel.ForeColor = value; }
        }

        public int Value
        {
            get
            {
                int value = 0;

                if (string.IsNullOrWhiteSpace(textPanel.Text) == false)
                {
                    try
                    {
                        value = int.Parse(textPanel.Text.Trim());
                    }
                    catch
                    {
                        value = 0;
                    }
                }

                return value;
            }

            set { textPanel.Text = value.ToString(); }
        }

        public Color ValueBackColor
        {
            get { return textPanel.BackColor; }
            set { textPanel.BackColor = value; }
        }

        public Color ValueForeColor
        {
            get { return textPanel.ForeColor; }
            set { textPanel.ForeColor = value; }
        }

        public CtrlBinCounterPanel()
        {
            InitializeComponent();
        }
    }
}
