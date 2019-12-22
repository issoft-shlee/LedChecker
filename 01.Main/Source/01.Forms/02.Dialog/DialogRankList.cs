using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Base;

using Ulee.Utils;
using Ulee.Controls;

namespace IsSoft.Sec.LedChecker
{
    public partial class DialogRankList : UlFormEng
    {
        private Int64 recipeNo;

        private Int64 recNo;

        private EReportItemCode code;

        private RankDataSet rankSet;

        private RankRowDataSet rankRowSet;

        public SelectedRankRow Result;

        public DialogRankList(Int64 recipeNo, Int64 recNo, EReportItemCode code)
        {
            Result = null;
            this.recipeNo = recipeNo;
            this.recNo = recNo;
            this.code = code;

            InitializeComponent();
            Initialize();
        }

        private void DialogRankList_Load(object sender, EventArgs e)
        {
            rankSet.Select(recipeNo, code);
            if (rankSet.Empty == true)
            {
                Result = new SelectedRankRow();
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            rankGrid.DataSource = rankSet.DataSet.Tables[0];
            rankGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            rankGridView.OptionsView.EnableAppearanceEvenRow = true;
            SetCurrentRowHandle();

            rankRowGrid.DataSource = rankRowSet.DataSet.Tables[0];
            rankRowGridView.Appearance.EvenRow.BackColor = Color.FromArgb(244, 244, 236);
            rankRowGridView.OptionsView.EnableAppearanceEvenRow = true;
        }

        private void rankGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DataRow row = rankGridView.GetDataRow(e.FocusedRowHandle);
            rankSet.Fetch(row);

            SetRankRowColumnVisible(rankSet.ItemCode);
            rankRowSet.Select(rankSet.RecNo);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Result = new SelectedRankRow();

            if (rankRowSet.Empty == true)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            Result.RecNo = rankSet.RecNo;
            Result.Name = rankSet.Name;

            for (int i=0; i<rankRowSet.RowCount; i++)
            {
                rankRowSet.Fetch(i);

                if (i == 0)
                {
                    Result.Lower = rankRowSet.Lower1;
                }
            }

            Result.Upper = rankRowSet.Upper1;
            Close();
        }

        private void Initialize()
        {
            rankSet = new RankDataSet(AppRes.DB.Connect, null, null);
            rankRowSet = new RankRowDataSet(AppRes.DB.Connect, null, null);

            Text = code.ToDescription() + " Rank";
        }

        private void SetCurrentRowHandle()
        {
            for (int i=0; i<rankSet.RowCount; i++)
            {
                rankSet.Fetch(i);

                if (rankSet.RecNo == recNo)
                {
                    rankGridView.FocusedRowHandle = i;
                    return;
                }
            }

            rankGridView.FocusedRowHandle = 0;
        }

        private void SetRankRowColumnVisible(EReportItemCode code)
        {
            switch (code)
            {
                case EReportItemCode.Die_XY:
                case EReportItemCode.Cell_XY:
                    rankRowLower1Column.Caption = "From(X)";
                    rankRowUpper1Column.Caption = "To(X)";
                    rankRowLower2Column.Caption = "From(Y)";
                    rankRowUpper2Column.Caption = "To(Y)";
                    rankRowLower2Column.Visible = true;
                    rankRowUpper2Column.Visible = true;
                    break;

                default:
                    rankRowLower1Column.Caption = "From";
                    rankRowUpper1Column.Caption = "To";
                    rankRowLower2Column.Visible = false;
                    rankRowUpper2Column.Visible = false;
                    break;
            }
        }
    }
}
