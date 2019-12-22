namespace IsSoft.Sec.LedChecker
{
    partial class CtrlAutoRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlAutoRight));
            this.menuPanel = new Ulee.Controls.UlPanel();
            this.startButton = new DevExpress.XtraEditors.SimpleButton();
            this.stopButton = new DevExpress.XtraEditors.SimpleButton();
            this.stateButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainButton = new DevExpress.XtraEditors.SimpleButton();
            this.viewPanel = new Ulee.Controls.UlPanel();
            this.bgPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.viewPanel);
            this.bgPanel.Controls.Add(this.menuPanel);
            this.bgPanel.Size = new System.Drawing.Size(1816, 946);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Silver;
            this.menuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.menuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.menuPanel.Controls.Add(this.startButton);
            this.menuPanel.Controls.Add(this.stopButton);
            this.menuPanel.Controls.Add(this.stateButton);
            this.menuPanel.Controls.Add(this.mainButton);
            this.menuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.InnerColor2 = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(1732, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.OuterColor2 = System.Drawing.Color.White;
            this.menuPanel.Size = new System.Drawing.Size(84, 946);
            this.menuPanel.Spacing = 0;
            this.menuPanel.TabIndex = 7;
            this.menuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.menuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // startButton
            // 
            this.startButton.AllowFocus = false;
            this.startButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Appearance.Options.UseTextOptions = true;
            this.startButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.startButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("startButton.ImageOptions.Image")));
            this.startButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.startButton.ImageOptions.ImageToTextIndent = 10;
            this.startButton.Location = new System.Drawing.Point(2, 826);
            this.startButton.LookAndFeel.SkinName = "DevExpress Style";
            this.startButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 58);
            this.startButton.TabIndex = 29;
            this.startButton.TabStop = false;
            this.startButton.Text = "START";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AllowFocus = false;
            this.stopButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Appearance.Options.UseTextOptions = true;
            this.stopButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.stopButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.ImageOptions.Image")));
            this.stopButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.stopButton.ImageOptions.ImageToTextIndent = 10;
            this.stopButton.Location = new System.Drawing.Point(2, 886);
            this.stopButton.LookAndFeel.SkinName = "DevExpress Style";
            this.stopButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(80, 58);
            this.stopButton.TabIndex = 28;
            this.stopButton.TabStop = false;
            this.stopButton.Text = "STOP";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // stateButton
            // 
            this.stateButton.AllowFocus = false;
            this.stateButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateButton.Appearance.Options.UseTextOptions = true;
            this.stateButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.stateButton.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.stateButton.ImageOptions.ImageToTextIndent = 12;
            this.stateButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.stateButton.Location = new System.Drawing.Point(2, 62);
            this.stateButton.LookAndFeel.SkinName = "DevExpress Style";
            this.stateButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.stateButton.Name = "stateButton";
            this.stateButton.Size = new System.Drawing.Size(80, 58);
            this.stateButton.TabIndex = 4;
            this.stateButton.TabStop = false;
            this.stateButton.Text = "STATE";
            // 
            // mainButton
            // 
            this.mainButton.AllowFocus = false;
            this.mainButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Appearance.Options.UseTextOptions = true;
            this.mainButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.mainButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.mainButton.Location = new System.Drawing.Point(2, 2);
            this.mainButton.LookAndFeel.SkinName = "DevExpress Style";
            this.mainButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(80, 58);
            this.mainButton.TabIndex = 3;
            this.mainButton.TabStop = false;
            this.mainButton.Text = "MAIN";
            // 
            // viewPanel
            // 
            this.viewPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.InnerColor2 = System.Drawing.Color.White;
            this.viewPanel.Location = new System.Drawing.Point(0, 0);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.OuterColor2 = System.Drawing.Color.White;
            this.viewPanel.Size = new System.Drawing.Size(1728, 946);
            this.viewPanel.Spacing = 0;
            this.viewPanel.TabIndex = 8;
            this.viewPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // CtrlAutoRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlAutoRight";
            this.Size = new System.Drawing.Size(1816, 946);
            this.bgPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ulee.Controls.UlPanel menuPanel;
        private DevExpress.XtraEditors.SimpleButton stateButton;
        private DevExpress.XtraEditors.SimpleButton mainButton;
        private Ulee.Controls.UlPanel viewPanel;
        private DevExpress.XtraEditors.SimpleButton startButton;
        private DevExpress.XtraEditors.SimpleButton stopButton;
    }
}
