namespace IsSoft.Sec.LedChecker
{
    partial class CtrlAutoMain
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
            this.reportPagePanel = new Ulee.Controls.UlPanel();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.bgPanel.Controls.Add(this.reportPagePanel);
            this.bgPanel.Size = new System.Drawing.Size(1728, 892);
            // 
            // reportPagePanel
            // 
            this.reportPagePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.reportPagePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.reportPagePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportPagePanel.InnerColor2 = System.Drawing.Color.White;
            this.reportPagePanel.Location = new System.Drawing.Point(6, 6);
            this.reportPagePanel.Name = "reportPagePanel";
            this.reportPagePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportPagePanel.OuterColor2 = System.Drawing.Color.White;
            this.reportPagePanel.Size = new System.Drawing.Size(1716, 880);
            this.reportPagePanel.Spacing = 0;
            this.reportPagePanel.TabIndex = 17;
            this.reportPagePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.reportPagePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // CtrlAutoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlAutoMain";
            this.Size = new System.Drawing.Size(1728, 892);
            this.Load += new System.EventHandler(this.CtrlAutoMain_Load);
            this.Enter += new System.EventHandler(this.CtrlAutoMain_Enter);
            this.bgPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Ulee.Controls.UlPanel reportPagePanel;
    }
}
