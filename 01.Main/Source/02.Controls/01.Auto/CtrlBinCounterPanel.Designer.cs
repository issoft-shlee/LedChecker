namespace IsSoft.Sec.LedChecker
{
    partial class CtrlBinCounterPanel
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
            this.captionPanel = new Ulee.Controls.UlPanel();
            this.textPanel = new Ulee.Controls.UlPanel();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Single;
            this.bgPanel.Controls.Add(this.textPanel);
            this.bgPanel.Controls.Add(this.captionPanel);
            this.bgPanel.Size = new System.Drawing.Size(83, 48);
            // 
            // captionPanel
            // 
            this.captionPanel.BackColor = System.Drawing.Color.Blue;
            this.captionPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.captionPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.captionPanel.ForeColor = System.Drawing.Color.White;
            this.captionPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.captionPanel.InnerColor2 = System.Drawing.Color.White;
            this.captionPanel.Location = new System.Drawing.Point(4, 4);
            this.captionPanel.Name = "captionPanel";
            this.captionPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.captionPanel.OuterColor2 = System.Drawing.Color.White;
            this.captionPanel.Size = new System.Drawing.Size(75, 18);
            this.captionPanel.Spacing = 0;
            this.captionPanel.TabIndex = 0;
            this.captionPanel.Text = "Bin-1";
            this.captionPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.captionPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.Black;
            this.textPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.textPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.textPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.textPanel.ForeColor = System.Drawing.Color.White;
            this.textPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.textPanel.InnerColor2 = System.Drawing.Color.White;
            this.textPanel.Location = new System.Drawing.Point(4, 24);
            this.textPanel.Name = "textPanel";
            this.textPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.textPanel.OuterColor2 = System.Drawing.Color.White;
            this.textPanel.Size = new System.Drawing.Size(75, 20);
            this.textPanel.Spacing = 0;
            this.textPanel.TabIndex = 1;
            this.textPanel.Text = "100";
            this.textPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.textPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // CtrlBinCounterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlBinCounterPanel";
            this.Size = new System.Drawing.Size(83, 48);
            this.bgPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ulee.Controls.UlPanel textPanel;
        private Ulee.Controls.UlPanel captionPanel;
    }
}
