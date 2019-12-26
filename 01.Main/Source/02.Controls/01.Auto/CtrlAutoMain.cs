using System;
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
        private RecipeObject recipe;

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

        public CtrlAutoMain()
        {
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
            if (recipe == null) recipePanel_DoubleClick(null, null);
        }

        private void recipePanel_DoubleClick(object sender, EventArgs e)
        {
            DialogRecipeList dialog = new DialogRecipeList();

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                if (dialog.DialogResult == DialogResult.OK)
                {
                    LoadRecipe(dialog.Result.RecNo);
                }
            }
        }

        private void Initialize()
        {
            recipe = null;

            binBook.Document.LoadDocument(AppRes.Properties.FormBin);
            binBook.WorksheetDisplayArea.SetSize(0, 40, 2);

            fullReportPage = new CtrlReportPage();
            fullPage.Controls.Add(fullReportPage);

            samplingReportPage = new CtrlReportPage();
            samplingPage.Controls.Add(samplingReportPage);
        }

        private void LoadRecipe(Int64 recipeNo)
        {
            if ((recipe != null) && (recipe.RecNo == recipeNo)) return;

            recipe = new RecipeItem();
            recipe.Load(recipeNo);

            recipePanel.Text = recipe.Code;
            SetBinItems(recipe.Bin);
            fullReportPage.SetWorkItems(recipe.Work[EWorkType.Full]);
            samplingReportPage.SetWorkItems(recipe.Work[EWorkType.Sampling]);
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
                }

                for (int i = 0; i < bins.Count; i++)
                {
                    sheet.Cells[0, i].Value = bins[i + 1].Name;
                    sheet.Cells[0, i].FillColor = bins[i + 1].Mark;
                    sheet.Cells[1, i].Value = (bins[i + 1].Name == "") ? "" : "0";
                }
            }
            finally
            {
                binBook.EndUpdate();
            }
        }
    }
}
