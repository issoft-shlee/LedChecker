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
            this.recipePanel = new Ulee.Controls.UlPanel();
            this.decisionMeter = new Ulee.Controls.UlPanel();
            this.ratioMeter = new Ulee.Controls.UlPanel();
            this.ngMeter = new Ulee.Controls.UlPanel();
            this.ratioPanel = new Ulee.Controls.UlPanel();
            this.ulPanel6 = new Ulee.Controls.UlPanel();
            this.okMeter = new Ulee.Controls.UlPanel();
            this.totalMeter = new Ulee.Controls.UlPanel();
            this.ulPanel4 = new Ulee.Controls.UlPanel();
            this.ulPanel1 = new Ulee.Controls.UlPanel();
            this.ulPanel2 = new Ulee.Controls.UlPanel();
            this.ulPanel3 = new Ulee.Controls.UlPanel();
            this.lotPanel = new Ulee.Controls.UlPanel();
            this.pcbPanel = new Ulee.Controls.UlPanel();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.bgPanel.Controls.Add(this.pcbPanel);
            this.bgPanel.Controls.Add(this.lotPanel);
            this.bgPanel.Controls.Add(this.ulPanel3);
            this.bgPanel.Controls.Add(this.ulPanel2);
            this.bgPanel.Controls.Add(this.ngMeter);
            this.bgPanel.Controls.Add(this.decisionMeter);
            this.bgPanel.Controls.Add(this.ratioMeter);
            this.bgPanel.Controls.Add(this.ratioPanel);
            this.bgPanel.Controls.Add(this.ulPanel6);
            this.bgPanel.Controls.Add(this.okMeter);
            this.bgPanel.Controls.Add(this.totalMeter);
            this.bgPanel.Controls.Add(this.ulPanel4);
            this.bgPanel.Controls.Add(this.ulPanel1);
            this.bgPanel.Controls.Add(this.recipePanel);
            this.bgPanel.Controls.Add(this.binBook);
            this.bgPanel.Font = new System.Drawing.Font("Arial", 20F);
            this.bgPanel.Size = new System.Drawing.Size(1728, 946);
            // 
            // binBook
            // 
            this.binBook.Location = new System.Drawing.Point(6, 98);
            this.binBook.LookAndFeel.SkinName = "DevExpress Style";
            this.binBook.LookAndFeel.UseDefaultLookAndFeel = false;
            this.binBook.Name = "binBook";
            this.binBook.Options.HorizontalScrollbar.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetScrollbarVisibility.Hidden;
            this.binBook.Options.TabSelector.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetElementVisibility.Hidden;
            this.binBook.Options.VerticalScrollbar.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetScrollbarVisibility.Hidden;
            this.binBook.Options.View.ShowColumnHeaders = false;
            this.binBook.Options.View.ShowRowHeaders = false;
            this.binBook.ReadOnly = true;
            this.binBook.Size = new System.Drawing.Size(1716, 842);
            this.binBook.TabIndex = 1;
            this.binBook.TabStop = false;
            this.binBook.Text = "binSheet";
            // 
            // recipePanel
            // 
            this.recipePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.recipePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.recipePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.recipePanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Bold);
            this.recipePanel.ForeColor = System.Drawing.Color.Blue;
            this.recipePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.recipePanel.InnerColor2 = System.Drawing.Color.White;
            this.recipePanel.Location = new System.Drawing.Point(6, 6);
            this.recipePanel.Name = "recipePanel";
            this.recipePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.recipePanel.OuterColor2 = System.Drawing.Color.White;
            this.recipePanel.Size = new System.Drawing.Size(450, 86);
            this.recipePanel.Spacing = 0;
            this.recipePanel.TabIndex = 2;
            this.recipePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.recipePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // decisionMeter
            // 
            this.decisionMeter.BackColor = System.Drawing.Color.Blue;
            this.decisionMeter.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.decisionMeter.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.decisionMeter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40F);
            this.decisionMeter.ForeColor = System.Drawing.Color.White;
            this.decisionMeter.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.decisionMeter.InnerColor2 = System.Drawing.Color.White;
            this.decisionMeter.Location = new System.Drawing.Point(1602, 6);
            this.decisionMeter.Name = "decisionMeter";
            this.decisionMeter.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.decisionMeter.OuterColor2 = System.Drawing.Color.White;
            this.decisionMeter.Size = new System.Drawing.Size(120, 86);
            this.decisionMeter.Spacing = 0;
            this.decisionMeter.TabIndex = 21;
            this.decisionMeter.Text = "OK";
            this.decisionMeter.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.decisionMeter.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ratioMeter
            // 
            this.ratioMeter.BackColor = System.Drawing.Color.Black;
            this.ratioMeter.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ratioMeter.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.ratioMeter.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ratioMeter.ForeColor = System.Drawing.Color.Lime;
            this.ratioMeter.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ratioMeter.InnerColor2 = System.Drawing.Color.White;
            this.ratioMeter.Location = new System.Drawing.Point(1478, 51);
            this.ratioMeter.Name = "ratioMeter";
            this.ratioMeter.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ratioMeter.OuterColor2 = System.Drawing.Color.White;
            this.ratioMeter.Size = new System.Drawing.Size(120, 41);
            this.ratioMeter.Spacing = 0;
            this.ratioMeter.TabIndex = 20;
            this.ratioMeter.Text = "0.0";
            this.ratioMeter.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ratioMeter.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ngMeter
            // 
            this.ngMeter.BackColor = System.Drawing.Color.Black;
            this.ngMeter.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ngMeter.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.ngMeter.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ngMeter.ForeColor = System.Drawing.Color.Lime;
            this.ngMeter.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ngMeter.InnerColor2 = System.Drawing.Color.White;
            this.ngMeter.Location = new System.Drawing.Point(1354, 51);
            this.ngMeter.Name = "ngMeter";
            this.ngMeter.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ngMeter.OuterColor2 = System.Drawing.Color.White;
            this.ngMeter.Size = new System.Drawing.Size(120, 41);
            this.ngMeter.Spacing = 0;
            this.ngMeter.TabIndex = 18;
            this.ngMeter.Text = "0";
            this.ngMeter.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ngMeter.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ratioPanel
            // 
            this.ratioPanel.BackColor = System.Drawing.Color.Navy;
            this.ratioPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ratioPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Single;
            this.ratioPanel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ratioPanel.ForeColor = System.Drawing.Color.White;
            this.ratioPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ratioPanel.InnerColor2 = System.Drawing.Color.White;
            this.ratioPanel.Location = new System.Drawing.Point(1478, 6);
            this.ratioPanel.Name = "ratioPanel";
            this.ratioPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ratioPanel.OuterColor2 = System.Drawing.Color.White;
            this.ratioPanel.Size = new System.Drawing.Size(120, 41);
            this.ratioPanel.Spacing = 0;
            this.ratioPanel.TabIndex = 19;
            this.ratioPanel.Text = "Ratio";
            this.ratioPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ratioPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ulPanel6
            // 
            this.ulPanel6.BackColor = System.Drawing.Color.Red;
            this.ulPanel6.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel6.BevelOuter = Ulee.Controls.EUlBevelStyle.Single;
            this.ulPanel6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ulPanel6.ForeColor = System.Drawing.Color.White;
            this.ulPanel6.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel6.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel6.Location = new System.Drawing.Point(1354, 6);
            this.ulPanel6.Name = "ulPanel6";
            this.ulPanel6.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel6.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel6.Size = new System.Drawing.Size(120, 41);
            this.ulPanel6.Spacing = 0;
            this.ulPanel6.TabIndex = 17;
            this.ulPanel6.Text = "NG";
            this.ulPanel6.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel6.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // okMeter
            // 
            this.okMeter.BackColor = System.Drawing.Color.Black;
            this.okMeter.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.okMeter.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.okMeter.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.okMeter.ForeColor = System.Drawing.Color.Lime;
            this.okMeter.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.okMeter.InnerColor2 = System.Drawing.Color.White;
            this.okMeter.Location = new System.Drawing.Point(1230, 51);
            this.okMeter.Name = "okMeter";
            this.okMeter.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.okMeter.OuterColor2 = System.Drawing.Color.White;
            this.okMeter.Size = new System.Drawing.Size(120, 41);
            this.okMeter.Spacing = 0;
            this.okMeter.TabIndex = 16;
            this.okMeter.Text = "0";
            this.okMeter.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.okMeter.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // totalMeter
            // 
            this.totalMeter.BackColor = System.Drawing.Color.Black;
            this.totalMeter.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.totalMeter.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.totalMeter.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.totalMeter.ForeColor = System.Drawing.Color.Lime;
            this.totalMeter.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.totalMeter.InnerColor2 = System.Drawing.Color.White;
            this.totalMeter.Location = new System.Drawing.Point(1106, 51);
            this.totalMeter.Name = "totalMeter";
            this.totalMeter.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.totalMeter.OuterColor2 = System.Drawing.Color.White;
            this.totalMeter.Size = new System.Drawing.Size(120, 41);
            this.totalMeter.Spacing = 0;
            this.totalMeter.TabIndex = 14;
            this.totalMeter.Text = "0";
            this.totalMeter.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.totalMeter.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ulPanel4
            // 
            this.ulPanel4.BackColor = System.Drawing.Color.Blue;
            this.ulPanel4.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel4.BevelOuter = Ulee.Controls.EUlBevelStyle.Single;
            this.ulPanel4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ulPanel4.ForeColor = System.Drawing.Color.White;
            this.ulPanel4.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel4.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel4.Location = new System.Drawing.Point(1230, 6);
            this.ulPanel4.Name = "ulPanel4";
            this.ulPanel4.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel4.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel4.Size = new System.Drawing.Size(120, 41);
            this.ulPanel4.Spacing = 0;
            this.ulPanel4.TabIndex = 15;
            this.ulPanel4.Text = "OK";
            this.ulPanel4.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel4.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ulPanel1
            // 
            this.ulPanel1.BackColor = System.Drawing.Color.Navy;
            this.ulPanel1.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel1.BevelOuter = Ulee.Controls.EUlBevelStyle.Single;
            this.ulPanel1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ulPanel1.ForeColor = System.Drawing.Color.White;
            this.ulPanel1.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel1.Location = new System.Drawing.Point(1106, 6);
            this.ulPanel1.Name = "ulPanel1";
            this.ulPanel1.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel1.Size = new System.Drawing.Size(120, 41);
            this.ulPanel1.Spacing = 0;
            this.ulPanel1.TabIndex = 13;
            this.ulPanel1.Text = "TOTAL";
            this.ulPanel1.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel1.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ulPanel2
            // 
            this.ulPanel2.BackColor = System.Drawing.Color.Navy;
            this.ulPanel2.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel2.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.ulPanel2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ulPanel2.ForeColor = System.Drawing.Color.White;
            this.ulPanel2.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel2.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel2.Location = new System.Drawing.Point(460, 6);
            this.ulPanel2.Name = "ulPanel2";
            this.ulPanel2.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel2.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel2.Size = new System.Drawing.Size(122, 41);
            this.ulPanel2.Spacing = 0;
            this.ulPanel2.TabIndex = 22;
            this.ulPanel2.Text = "LOT ID";
            this.ulPanel2.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel2.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ulPanel3
            // 
            this.ulPanel3.BackColor = System.Drawing.Color.Navy;
            this.ulPanel3.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel3.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.ulPanel3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.ulPanel3.ForeColor = System.Drawing.Color.White;
            this.ulPanel3.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel3.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel3.Location = new System.Drawing.Point(460, 51);
            this.ulPanel3.Name = "ulPanel3";
            this.ulPanel3.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel3.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel3.Size = new System.Drawing.Size(122, 41);
            this.ulPanel3.Spacing = 0;
            this.ulPanel3.TabIndex = 23;
            this.ulPanel3.Text = "PCB ID";
            this.ulPanel3.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel3.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // lotPanel
            // 
            this.lotPanel.BackColor = System.Drawing.Color.White;
            this.lotPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.lotPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.lotPanel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lotPanel.ForeColor = System.Drawing.Color.Black;
            this.lotPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lotPanel.InnerColor2 = System.Drawing.Color.White;
            this.lotPanel.Location = new System.Drawing.Point(586, 6);
            this.lotPanel.Name = "lotPanel";
            this.lotPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lotPanel.OuterColor2 = System.Drawing.Color.White;
            this.lotPanel.Size = new System.Drawing.Size(516, 41);
            this.lotPanel.Spacing = 0;
            this.lotPanel.TabIndex = 24;
            this.lotPanel.Text = " 0";
            this.lotPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Left;
            this.lotPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // pcbPanel
            // 
            this.pcbPanel.BackColor = System.Drawing.Color.White;
            this.pcbPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.pcbPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.pcbPanel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.pcbPanel.ForeColor = System.Drawing.Color.Black;
            this.pcbPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.pcbPanel.InnerColor2 = System.Drawing.Color.White;
            this.pcbPanel.Location = new System.Drawing.Point(586, 51);
            this.pcbPanel.Name = "pcbPanel";
            this.pcbPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.pcbPanel.OuterColor2 = System.Drawing.Color.White;
            this.pcbPanel.Size = new System.Drawing.Size(516, 41);
            this.pcbPanel.Spacing = 0;
            this.pcbPanel.TabIndex = 25;
            this.pcbPanel.Text = " 0";
            this.pcbPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Left;
            this.pcbPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // CtrlAutoBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlAutoBin";
            this.Size = new System.Drawing.Size(1728, 946);
            this.bgPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl binBook;
        private Ulee.Controls.UlPanel recipePanel;
        private Ulee.Controls.UlPanel pcbPanel;
        private Ulee.Controls.UlPanel lotPanel;
        private Ulee.Controls.UlPanel ulPanel3;
        private Ulee.Controls.UlPanel ulPanel2;
        private Ulee.Controls.UlPanel ngMeter;
        private Ulee.Controls.UlPanel decisionMeter;
        private Ulee.Controls.UlPanel ratioMeter;
        private Ulee.Controls.UlPanel ratioPanel;
        private Ulee.Controls.UlPanel ulPanel6;
        private Ulee.Controls.UlPanel okMeter;
        private Ulee.Controls.UlPanel totalMeter;
        private Ulee.Controls.UlPanel ulPanel4;
        private Ulee.Controls.UlPanel ulPanel1;
    }
}
