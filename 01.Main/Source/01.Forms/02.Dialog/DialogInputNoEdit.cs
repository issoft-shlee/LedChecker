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
    public partial class DialogInputNoEdit : UlFormEng
    {
        public string Result { get { return inputNoEdit.Text.Trim(); } }

        public string FormText { set { Text = value; } }

        public int MaxLength { set { inputNoEdit.Properties.MaxLength = value; } }

        public DialogInputNoEdit(string text)
        {
            InitializeComponent();

            text = (text.ToLower() == "none") ? "" : text;
            inputNoEdit.Text = text.Trim();

            inputNoEdit.Focus();
        }
    }
}
