namespace IsSoft.Sec.LedChecker
{
    partial class FormLedCheckerMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLedCheckerMain));
            this.verPanel = new Ulee.Controls.UlPanel();
            this.userPanel = new Ulee.Controls.UlPanel();
            this.ulPanel1 = new Ulee.Controls.UlPanel();
            this.datePanel = new Ulee.Controls.UlPanel();
            this.timePanel = new Ulee.Controls.UlPanel();
            this.messagePanel = new Ulee.Controls.UlPanel();
            this.menuPanel = new Ulee.Controls.UlPanel();
            this.homeButton = new DevExpress.XtraEditors.SimpleButton();
            this.testButton = new DevExpress.XtraEditors.SimpleButton();
            this.resetButton = new DevExpress.XtraEditors.SimpleButton();
            this.viewButton = new DevExpress.XtraEditors.SimpleButton();
            this.configButton = new DevExpress.XtraEditors.SimpleButton();
            this.hideButton = new DevExpress.XtraEditors.SimpleButton();
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.manualButton = new DevExpress.XtraEditors.SimpleButton();
            this.viewPanel = new Ulee.Controls.UlPanel();
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.mainTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Raised;
            this.bgPanel.Controls.Add(this.viewPanel);
            this.bgPanel.Controls.Add(this.menuPanel);
            this.bgPanel.Controls.Add(this.messagePanel);
            this.bgPanel.Controls.Add(this.datePanel);
            this.bgPanel.Controls.Add(this.timePanel);
            this.bgPanel.Controls.Add(this.ulPanel1);
            this.bgPanel.Controls.Add(this.userPanel);
            this.bgPanel.Controls.Add(this.verPanel);
            this.bgPanel.Size = new System.Drawing.Size(1920, 1050);
            // 
            // verPanel
            // 
            this.verPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.verPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.verPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.verPanel.InnerColor2 = System.Drawing.Color.White;
            this.verPanel.Location = new System.Drawing.Point(8, 29);
            this.verPanel.Name = "verPanel";
            this.verPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.verPanel.OuterColor2 = System.Drawing.Color.White;
            this.verPanel.Size = new System.Drawing.Size(84, 19);
            this.verPanel.Spacing = 0;
            this.verPanel.TabIndex = 0;
            this.verPanel.Text = "1.0.0.0";
            this.verPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.verPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // userPanel
            // 
            this.userPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.userPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.userPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.userPanel.InnerColor2 = System.Drawing.Color.White;
            this.userPanel.Location = new System.Drawing.Point(8, 8);
            this.userPanel.Name = "userPanel";
            this.userPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.userPanel.OuterColor2 = System.Drawing.Color.White;
            this.userPanel.Size = new System.Drawing.Size(84, 19);
            this.userPanel.Spacing = 0;
            this.userPanel.TabIndex = 1;
            this.userPanel.Text = "admin";
            this.userPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.userPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ulPanel1
            // 
            this.ulPanel1.BackColor = System.Drawing.Color.Navy;
            this.ulPanel1.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel1.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ulPanel1.ForeColor = System.Drawing.Color.White;
            this.ulPanel1.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel1.Location = new System.Drawing.Point(96, 8);
            this.ulPanel1.Name = "ulPanel1";
            this.ulPanel1.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel1.Size = new System.Drawing.Size(1728, 40);
            this.ulPanel1.Spacing = 0;
            this.ulPanel1.TabIndex = 2;
            this.ulPanel1.Text = "Samsung Electronics LED Function Checker";
            this.ulPanel1.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel1.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // datePanel
            // 
            this.datePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.datePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.datePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.datePanel.InnerColor2 = System.Drawing.Color.White;
            this.datePanel.Location = new System.Drawing.Point(1828, 8);
            this.datePanel.Name = "datePanel";
            this.datePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.datePanel.OuterColor2 = System.Drawing.Color.White;
            this.datePanel.Size = new System.Drawing.Size(84, 19);
            this.datePanel.Spacing = 0;
            this.datePanel.TabIndex = 4;
            this.datePanel.Text = "2019-10-30";
            this.datePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.datePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // timePanel
            // 
            this.timePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.timePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.timePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.timePanel.InnerColor2 = System.Drawing.Color.White;
            this.timePanel.Location = new System.Drawing.Point(1828, 29);
            this.timePanel.Name = "timePanel";
            this.timePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.timePanel.OuterColor2 = System.Drawing.Color.White;
            this.timePanel.Size = new System.Drawing.Size(84, 19);
            this.timePanel.Spacing = 0;
            this.timePanel.TabIndex = 3;
            this.timePanel.Text = "10:10:10";
            this.timePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.timePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.Black;
            this.messagePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.messagePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.messagePanel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.messagePanel.ForeColor = System.Drawing.Color.White;
            this.messagePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.messagePanel.InnerColor2 = System.Drawing.Color.White;
            this.messagePanel.Location = new System.Drawing.Point(8, 1002);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.messagePanel.OuterColor2 = System.Drawing.Color.White;
            this.messagePanel.Size = new System.Drawing.Size(1904, 40);
            this.messagePanel.Spacing = 0;
            this.messagePanel.TabIndex = 5;
            this.messagePanel.Text = "Ready";
            this.messagePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.messagePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Silver;
            this.menuPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.menuPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Controls.Add(this.testButton);
            this.menuPanel.Controls.Add(this.resetButton);
            this.menuPanel.Controls.Add(this.viewButton);
            this.menuPanel.Controls.Add(this.configButton);
            this.menuPanel.Controls.Add(this.hideButton);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.manualButton);
            this.menuPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.InnerColor2 = System.Drawing.Color.White;
            this.menuPanel.Location = new System.Drawing.Point(8, 52);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.menuPanel.OuterColor2 = System.Drawing.Color.White;
            this.menuPanel.Size = new System.Drawing.Size(84, 946);
            this.menuPanel.Spacing = 0;
            this.menuPanel.TabIndex = 6;
            this.menuPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.menuPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // homeButton
            // 
            this.homeButton.AllowFocus = false;
            this.homeButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Appearance.Options.UseFont = true;
            this.homeButton.Appearance.Options.UseTextOptions = true;
            this.homeButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.homeButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.AppearanceDisabled.Options.UseFont = true;
            this.homeButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.AppearanceHovered.Options.UseFont = true;
            this.homeButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.AppearancePressed.Options.UseFont = true;
            this.homeButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.ImageOptions.Image")));
            this.homeButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.homeButton.Location = new System.Drawing.Point(2, 706);
            this.homeButton.LookAndFeel.SkinName = "DevExpress Style";
            this.homeButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 58);
            this.homeButton.TabIndex = 31;
            this.homeButton.TabStop = false;
            this.homeButton.Text = "HOME POS";
            // 
            // testButton
            // 
            this.testButton.AllowFocus = false;
            this.testButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.Appearance.Options.UseFont = true;
            this.testButton.Appearance.Options.UseTextOptions = true;
            this.testButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.testButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.AppearanceDisabled.Options.UseFont = true;
            this.testButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.AppearanceHovered.Options.UseFont = true;
            this.testButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.AppearancePressed.Options.UseFont = true;
            this.testButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("testButton.ImageOptions.Image")));
            this.testButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.testButton.Location = new System.Drawing.Point(2, 2);
            this.testButton.LookAndFeel.SkinName = "DevExpress Style";
            this.testButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(80, 58);
            this.testButton.TabIndex = 3;
            this.testButton.TabStop = false;
            this.testButton.Text = "AUTO";
            // 
            // resetButton
            // 
            this.resetButton.AllowFocus = false;
            this.resetButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Appearance.Options.UseFont = true;
            this.resetButton.Appearance.Options.UseTextOptions = true;
            this.resetButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.resetButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.AppearanceDisabled.Options.UseFont = true;
            this.resetButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.AppearanceHovered.Options.UseFont = true;
            this.resetButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.AppearancePressed.Options.UseFont = true;
            this.resetButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resetButton.ImageOptions.Image")));
            this.resetButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.resetButton.Location = new System.Drawing.Point(2, 766);
            this.resetButton.LookAndFeel.SkinName = "DevExpress Style";
            this.resetButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(80, 58);
            this.resetButton.TabIndex = 32;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "RESET";
            // 
            // viewButton
            // 
            this.viewButton.AllowFocus = false;
            this.viewButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Appearance.Options.UseFont = true;
            this.viewButton.Appearance.Options.UseTextOptions = true;
            this.viewButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.viewButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.AppearanceDisabled.Options.UseFont = true;
            this.viewButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.AppearanceHovered.Options.UseFont = true;
            this.viewButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.AppearancePressed.Options.UseFont = true;
            this.viewButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("viewButton.ImageOptions.Image")));
            this.viewButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.viewButton.Location = new System.Drawing.Point(2, 122);
            this.viewButton.LookAndFeel.SkinName = "DevExpress Style";
            this.viewButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(80, 58);
            this.viewButton.TabIndex = 8;
            this.viewButton.TabStop = false;
            this.viewButton.Text = "VIEW";
            // 
            // configButton
            // 
            this.configButton.AllowFocus = false;
            this.configButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configButton.Appearance.Options.UseFont = true;
            this.configButton.Appearance.Options.UseTextOptions = true;
            this.configButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.configButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configButton.AppearanceDisabled.Options.UseFont = true;
            this.configButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configButton.AppearanceHovered.Options.UseFont = true;
            this.configButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configButton.AppearancePressed.Options.UseFont = true;
            this.configButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("configButton.ImageOptions.Image")));
            this.configButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.configButton.Location = new System.Drawing.Point(2, 182);
            this.configButton.LookAndFeel.SkinName = "DevExpress Style";
            this.configButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.configButton.Name = "configButton";
            this.configButton.Size = new System.Drawing.Size(80, 58);
            this.configButton.TabIndex = 7;
            this.configButton.TabStop = false;
            this.configButton.Text = "CONFIG";
            // 
            // hideButton
            // 
            this.hideButton.AllowFocus = false;
            this.hideButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.Appearance.Options.UseFont = true;
            this.hideButton.Appearance.Options.UseTextOptions = true;
            this.hideButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.hideButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.AppearanceDisabled.Options.UseFont = true;
            this.hideButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.AppearanceHovered.Options.UseFont = true;
            this.hideButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.AppearancePressed.Options.UseFont = true;
            this.hideButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("hideButton.ImageOptions.Image")));
            this.hideButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.hideButton.Location = new System.Drawing.Point(2, 826);
            this.hideButton.LookAndFeel.SkinName = "DevExpress Style";
            this.hideButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(80, 58);
            this.hideButton.TabIndex = 6;
            this.hideButton.TabStop = false;
            this.hideButton.Text = "HIDE";
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AllowFocus = false;
            this.exitButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Appearance.Options.UseFont = true;
            this.exitButton.Appearance.Options.UseTextOptions = true;
            this.exitButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.exitButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.AppearanceDisabled.Options.UseFont = true;
            this.exitButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.AppearanceHovered.Options.UseFont = true;
            this.exitButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.AppearancePressed.Options.UseFont = true;
            this.exitButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.ImageOptions.Image")));
            this.exitButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.exitButton.Location = new System.Drawing.Point(2, 886);
            this.exitButton.LookAndFeel.SkinName = "DevExpress Style";
            this.exitButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 58);
            this.exitButton.TabIndex = 5;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "EXIT";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.AllowFocus = false;
            this.manualButton.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualButton.Appearance.Options.UseFont = true;
            this.manualButton.Appearance.Options.UseTextOptions = true;
            this.manualButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.manualButton.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualButton.AppearanceDisabled.Options.UseFont = true;
            this.manualButton.AppearanceHovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualButton.AppearanceHovered.Options.UseFont = true;
            this.manualButton.AppearancePressed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualButton.AppearancePressed.Options.UseFont = true;
            this.manualButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("manualButton.ImageOptions.Image")));
            this.manualButton.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.manualButton.Location = new System.Drawing.Point(2, 62);
            this.manualButton.LookAndFeel.SkinName = "DevExpress Style";
            this.manualButton.LookAndFeel.UseDefaultLookAndFeel = false;
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(80, 58);
            this.manualButton.TabIndex = 4;
            this.manualButton.TabStop = false;
            this.manualButton.Text = "MANUAL";
            // 
            // viewPanel
            // 
            this.viewPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.viewPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.InnerColor2 = System.Drawing.Color.White;
            this.viewPanel.Location = new System.Drawing.Point(96, 52);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewPanel.OuterColor2 = System.Drawing.Color.White;
            this.viewPanel.Size = new System.Drawing.Size(1816, 946);
            this.viewPanel.Spacing = 0;
            this.viewPanel.TabIndex = 7;
            this.viewPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.BalloonTipText = "LED Checker";
            this.mainNotifyIcon.ContextMenuStrip = this.mainTrayMenu;
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "LED Checker";
            this.mainNotifyIcon.Visible = true;
            // 
            // mainTrayMenu
            // 
            this.mainTrayMenu.Font = new System.Drawing.Font("Arial", 9F);
            this.mainTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUpMenuItem});
            this.mainTrayMenu.Name = "mainTrayMenu";
            this.mainTrayMenu.Size = new System.Drawing.Size(106, 26);
            // 
            // showUpMenuItem
            // 
            this.showUpMenuItem.Name = "showUpMenuItem";
            this.showUpMenuItem.Size = new System.Drawing.Size(105, 22);
            this.showUpMenuItem.Text = "Show";
            this.showUpMenuItem.Click += new System.EventHandler(this.showUpMenuItem_Click);
            // 
            // FormLedCheckerMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLedCheckerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Samsung Electronics LED Function Checker Ver 1.00";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLedCheckerMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLedCheckerMain_FormClosed);
            this.Load += new System.EventHandler(this.FormLedCheckerMain_Load);
            this.Shown += new System.EventHandler(this.FormLedCheckerMain_Shown);
            this.Controls.SetChildIndex(this.bgPanel, 0);
            this.bgPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.mainTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ulee.Controls.UlPanel datePanel;
        private Ulee.Controls.UlPanel timePanel;
        private Ulee.Controls.UlPanel ulPanel1;
        private Ulee.Controls.UlPanel userPanel;
        private Ulee.Controls.UlPanel verPanel;
        private Ulee.Controls.UlPanel messagePanel;
        private Ulee.Controls.UlPanel menuPanel;
        private Ulee.Controls.UlPanel viewPanel;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraEditors.SimpleButton manualButton;
        private DevExpress.XtraEditors.SimpleButton testButton;
        private DevExpress.XtraEditors.SimpleButton hideButton;
        private DevExpress.XtraEditors.SimpleButton configButton;
        private DevExpress.XtraEditors.SimpleButton viewButton;
        private DevExpress.XtraEditors.SimpleButton resetButton;
        private DevExpress.XtraEditors.SimpleButton homeButton;
        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip mainTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem showUpMenuItem;
    }
}