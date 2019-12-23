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
    public partial class DialogRecipeList : UlFormEng
    {
        public DialogSelectedItem Result { get; set; }

        private RecipeDataSet recipeSet;

        public DialogRecipeList()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Result = new DialogSelectedItem();
            recipeSet = new RecipeDataSet(AppRes.DB.Connect, null, null);

            recipeSet.Select();
            recipeGrid.DataSource = recipeSet.DataSet.Tables[0];
            recipeGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            recipeGridView.OptionsView.EnableAppearanceEvenRow = true;
        }

        private void recipeGrid_DoubleClick(object sender, EventArgs e)
        {
            if (recipeGridView.FocusedRowHandle < 0) return;

            okButton.PerformClick();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (recipeGridView.FocusedRowHandle < 0) return;

            DataRow row = recipeGridView.GetDataRow(recipeGridView.FocusedRowHandle);
            recipeSet.Fetch(row);

            Result.RecNo = recipeSet.RecNo;
            Result.Name = recipeSet.Name;

            Close();
        }
    }
}
