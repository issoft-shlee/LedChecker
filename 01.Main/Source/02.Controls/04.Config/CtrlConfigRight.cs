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
    public partial class CtrlConfigRight : UlUserControlEng
    {
        public CtrlConfigRight()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            DefMenu = new UlMenu(viewPanel);
            DefMenu.Add(new CtrlConfigRecipe(this), recipeButton);
            DefMenu.Add(new CtrlConfigPattern(this), patternButton);
            DefMenu.Add(new CtrlConfigRank(this), rankButton);
            DefMenu.Add(new CtrlConfigWork(this), workButton);
            DefMenu.Add(new CtrlConfigBin(this), binButton);
            DefMenu.Index = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            switch (DefMenu.Index)
            {
                case 0:
                    (DefMenu.ActiveControl as CtrlConfigRecipe).Save();
                    break;

                case 1:
                    (DefMenu.ActiveControl as CtrlConfigPattern).Save();
                    break;

                case 2:
                    (DefMenu.ActiveControl as CtrlConfigRank).Save();
                    break;

                case 3:
                    (DefMenu.ActiveControl as CtrlConfigWork).Save();
                    break;

                case 4:
                    (DefMenu.ActiveControl as CtrlConfigBin).Save();
                    break;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            switch (DefMenu.Index)
            {
                case 0:
                    (DefMenu.ActiveControl as CtrlConfigRecipe).Cancel();
                    break;

                case 1:
                    (DefMenu.ActiveControl as CtrlConfigPattern).Cancel();
                    break;

                case 2:
                    (DefMenu.ActiveControl as CtrlConfigRank).Cancel();
                    break;

                case 3:
                    (DefMenu.ActiveControl as CtrlConfigWork).Cancel();
                    break;

                case 4:
                    (DefMenu.ActiveControl as CtrlConfigBin).Cancel();
                    break;
            }
        }

        public void SetButtonEnabled(bool enabled)
        {
            saveButton.Enabled = enabled;
            cancelButton.Enabled = enabled;
        }

        public void SetMenuEnabled(bool enabled)
        {
            DefMenu.Enabled = enabled;
        }
    }
}
