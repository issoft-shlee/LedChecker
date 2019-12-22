namespace IsSoft.Sec.LedChecker
{
    partial class CtrlReportPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.workBook = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.resultBook = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.resultPanel = new Ulee.Controls.UlPanel();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.resultPanel);
            this.bgPanel.Controls.Add(this.resultBook);
            this.bgPanel.Controls.Add(this.workBook);
            this.bgPanel.Size = new System.Drawing.Size(1700, 800);
            // 
            // workBook
            // 
            this.workBook.Location = new System.Drawing.Point(0, 0);
            this.workBook.LookAndFeel.SkinName = "DevExpress Style";
            this.workBook.LookAndFeel.UseDefaultLookAndFeel = false;
            this.workBook.Name = "workBook";
            this.workBook.Options.Behavior.Selection.AllowExtendSelection = false;
            this.workBook.Options.Behavior.Selection.AllowMultiSelection = false;
            this.workBook.Options.TabSelector.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetElementVisibility.Hidden;
            this.workBook.Options.VerticalScrollbar.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetScrollbarVisibility.Hidden;
            this.workBook.Options.View.ShowColumnHeaders = false;
            this.workBook.Options.View.ShowRowHeaders = false;
            this.workBook.ReadOnly = true;
            this.workBook.Size = new System.Drawing.Size(1708, 414);
            this.workBook.TabIndex = 0;
            this.workBook.TabStop = false;
            // 
            // resultBook
            // 
            this.resultBook.Location = new System.Drawing.Point(0, 444);
            this.resultBook.LookAndFeel.SkinName = "DevExpress Style";
            this.resultBook.LookAndFeel.UseDefaultLookAndFeel = false;
            this.resultBook.Name = "resultBook";
            this.resultBook.Options.Behavior.Selection.AllowExtendSelection = false;
            this.resultBook.Options.Behavior.Selection.AllowMultiSelection = false;
            this.resultBook.Options.TabSelector.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetElementVisibility.Hidden;
            this.resultBook.Options.View.ShowColumnHeaders = false;
            this.resultBook.Options.View.ShowRowHeaders = false;
            this.resultBook.ReadOnly = true;
            this.resultBook.Size = new System.Drawing.Size(1708, 356);
            this.resultBook.TabIndex = 1;
            this.resultBook.TabStop = false;
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(152)))));
            this.resultPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.resultPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.resultPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.resultPanel.ForeColor = System.Drawing.Color.White;
            this.resultPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.resultPanel.InnerColor2 = System.Drawing.Color.White;
            this.resultPanel.Location = new System.Drawing.Point(0, 421);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.resultPanel.OuterColor2 = System.Drawing.Color.White;
            this.resultPanel.Size = new System.Drawing.Size(148, 23);
            this.resultPanel.Spacing = 0;
            this.resultPanel.TabIndex = 2;
            this.resultPanel.Text = " Test Data";
            this.resultPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Left;
            this.resultPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // CtrlReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlReportPage";
            this.Size = new System.Drawing.Size(1700, 800);
            this.Load += new System.EventHandler(this.CtrlReportPage_Load);
            this.bgPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl workBook;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl resultBook;
        private Ulee.Controls.UlPanel resultPanel;
    }
}
