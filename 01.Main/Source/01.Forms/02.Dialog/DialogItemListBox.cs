using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.Utils;
using DevExpress.XtraEditors;

using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class DialogItemListBox : UlFormEng
    {
        public string Result { get { return (string)itemListBox.SelectedValue; } }

        public BaseListBoxControl.SelectedItemCollection SelectedItems { get { return itemListBox.SelectedItems; } }

        public string DefaultItem { get; set; }

        public SelectionMode Mode { set { itemListBox.SelectionMode = value; } }

        public HorzAlignment HAlignment
        {
            set
            {
                itemListBox.Appearance.TextOptions.HAlignment = value;
                itemListBox.Appearance.Options.UseTextOptions = true;
                itemListBox.AppearanceDisabled.TextOptions.HAlignment = value;
                itemListBox.AppearanceDisabled.Options.UseTextOptions = true;
                itemListBox.AppearanceHighlight.TextOptions.HAlignment = value;
                itemListBox.AppearanceHighlight.Options.UseTextOptions = true;
                itemListBox.AppearanceSelected.TextOptions.HAlignment = value;
                itemListBox.AppearanceSelected.Options.UseTextOptions = true;
            }
        }

        public List<string> Items
        {
            set
            {
                itemListBox.Items.Clear();
                itemListBox.Items.AddRange(value.ToArray());
            }
        }

        public DialogItemListBox()
        {
            InitializeComponent();
        }

        private void DialogItemListBox_Shown(object sender, EventArgs e)
        {
            SetDefaultItem();
        }

        private void SetDefaultItem()
        {
            int index = -1;

            for (int i = 0; i < itemListBox.Items.Count; i++)
            {
                string item = (string)itemListBox.Items[i];

                if (item == DefaultItem)
                {
                    index = i;
                    break;
                }
            }

            itemListBox.SelectedIndex = index;
        }
    }
}
