namespace IsSoft.Sec.LedChecker
{
    partial class CtrlAutoBin
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
            this.binBook = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.bgPanel.Controls.Add(this.binBook);
            this.bgPanel.Font = new System.Drawing.Font("Arial", 20F);
            this.bgPanel.Size = new System.Drawing.Size(1728, 892);
            // 
            // binBook
            // 
            this.binBook.Location = new System.Drawing.Point(6, 6);
            this.binBook.LookAndFeel.SkinName = "DevExpress Style";
            this.binBook.LookAndFeel.UseDefaultLookAndFeel = false;
            this.binBook.Name = "binBook";
            this.binBook.Options.HorizontalScrollbar.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetScrollbarVisibility.Hidden;
            this.binBook.Options.TabSelector.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetElementVisibility.Hidden;
            this.binBook.Options.VerticalScrollbar.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetScrollbarVisibility.Hidden;
            this.binBook.Options.View.ShowColumnHeaders = false;
            this.binBook.Options.View.ShowRowHeaders = false;
            this.binBook.ReadOnly = true;
            this.binBook.Size = new System.Drawing.Size(1716, 880);
            this.binBook.TabIndex = 1;
            this.binBook.TabStop = false;
            this.binBook.Text = "binSheet";
            // 
            // CtrlAutoBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlAutoBin";
            this.Size = new System.Drawing.Size(1728, 892);
            this.bgPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl binBook;
    }
}
