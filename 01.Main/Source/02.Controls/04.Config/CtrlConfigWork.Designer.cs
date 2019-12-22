namespace IsSoft.Sec.LedChecker
{
    partial class CtrlConfigWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlConfigWork));
            this.viewerPanel = new Ulee.Controls.UlPanel();
            this.workTab = new System.Windows.Forms.TabControl();
            this.workFullPage = new System.Windows.Forms.TabPage();
            this.fullReportPluseButton = new System.Windows.Forms.Button();
            this.fullReportMinusButton = new System.Windows.Forms.Button();
            this.fullTestPluseButton = new System.Windows.Forms.Button();
            this.fullTestMinusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fullReportPanel = new Ulee.Controls.UlPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fullTestPanel = new Ulee.Controls.UlPanel();
            this.workSamplingPage = new System.Windows.Forms.TabPage();
            this.samplingReportPluseButton = new System.Windows.Forms.Button();
            this.samplingReportMinusButton = new System.Windows.Forms.Button();
            this.samplingTestPluseButton = new System.Windows.Forms.Button();
            this.samplingTestMinusButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.samplingReportPanel = new Ulee.Controls.UlPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.samplingTestPanel = new Ulee.Controls.UlPanel();
            this.viewStatePanel = new Ulee.Controls.UlPanel();
            this.searchPanel = new Ulee.Controls.UlPanel();
            this.findButton = new System.Windows.Forms.Button();
            this.findNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.recipeGrid = new DevExpress.XtraGrid.GridControl();
            this.recipeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.recipeNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.recipeMemoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modifyButton = new System.Windows.Forms.Button();
            this.bgPanel.SuspendLayout();
            this.viewerPanel.SuspendLayout();
            this.workTab.SuspendLayout();
            this.workFullPage.SuspendLayout();
            this.workSamplingPage.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.findNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.viewerPanel);
            this.bgPanel.Controls.Add(this.searchPanel);
            this.bgPanel.Size = new System.Drawing.Size(1728, 946);
            // 
            // viewerPanel
            // 
            this.viewerPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.viewerPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.viewerPanel.Controls.Add(this.workTab);
            this.viewerPanel.Controls.Add(this.viewStatePanel);
            this.viewerPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewerPanel.InnerColor2 = System.Drawing.Color.White;
            this.viewerPanel.Location = new System.Drawing.Point(406, 0);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewerPanel.OuterColor2 = System.Drawing.Color.White;
            this.viewerPanel.Size = new System.Drawing.Size(1322, 946);
            this.viewerPanel.Spacing = 0;
            this.viewerPanel.TabIndex = 7;
            this.viewerPanel.TabStop = true;
            this.viewerPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewerPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // workTab
            // 
            this.workTab.Controls.Add(this.workFullPage);
            this.workTab.Controls.Add(this.workSamplingPage);
            this.workTab.Location = new System.Drawing.Point(6, 40);
            this.workTab.Name = "workTab";
            this.workTab.SelectedIndex = 0;
            this.workTab.Size = new System.Drawing.Size(1310, 898);
            this.workTab.TabIndex = 150;
            // 
            // workFullPage
            // 
            this.workFullPage.BackColor = System.Drawing.Color.White;
            this.workFullPage.Controls.Add(this.fullReportPluseButton);
            this.workFullPage.Controls.Add(this.fullReportMinusButton);
            this.workFullPage.Controls.Add(this.fullTestPluseButton);
            this.workFullPage.Controls.Add(this.fullTestMinusButton);
            this.workFullPage.Controls.Add(this.label2);
            this.workFullPage.Controls.Add(this.fullReportPanel);
            this.workFullPage.Controls.Add(this.label1);
            this.workFullPage.Controls.Add(this.fullTestPanel);
            this.workFullPage.Location = new System.Drawing.Point(4, 24);
            this.workFullPage.Name = "workFullPage";
            this.workFullPage.Padding = new System.Windows.Forms.Padding(3);
            this.workFullPage.Size = new System.Drawing.Size(1302, 870);
            this.workFullPage.TabIndex = 0;
            this.workFullPage.Text = "  Full  ";
            // 
            // fullReportPluseButton
            // 
            this.fullReportPluseButton.Image = ((System.Drawing.Image)(resources.GetObject("fullReportPluseButton.Image")));
            this.fullReportPluseButton.Location = new System.Drawing.Point(1248, 445);
            this.fullReportPluseButton.Name = "fullReportPluseButton";
            this.fullReportPluseButton.Size = new System.Drawing.Size(24, 24);
            this.fullReportPluseButton.TabIndex = 153;
            this.fullReportPluseButton.UseVisualStyleBackColor = true;
            this.fullReportPluseButton.Click += new System.EventHandler(this.fullReportPluseButton_Click);
            // 
            // fullReportMinusButton
            // 
            this.fullReportMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("fullReportMinusButton.Image")));
            this.fullReportMinusButton.Location = new System.Drawing.Point(1274, 445);
            this.fullReportMinusButton.Name = "fullReportMinusButton";
            this.fullReportMinusButton.Size = new System.Drawing.Size(24, 24);
            this.fullReportMinusButton.TabIndex = 152;
            this.fullReportMinusButton.UseVisualStyleBackColor = true;
            this.fullReportMinusButton.Click += new System.EventHandler(this.fullReportMinusButton_Click);
            // 
            // fullTestPluseButton
            // 
            this.fullTestPluseButton.Image = ((System.Drawing.Image)(resources.GetObject("fullTestPluseButton.Image")));
            this.fullTestPluseButton.Location = new System.Drawing.Point(1248, 7);
            this.fullTestPluseButton.Name = "fullTestPluseButton";
            this.fullTestPluseButton.Size = new System.Drawing.Size(24, 24);
            this.fullTestPluseButton.TabIndex = 151;
            this.fullTestPluseButton.UseVisualStyleBackColor = true;
            this.fullTestPluseButton.Click += new System.EventHandler(this.fullTestPluseButton_Click);
            // 
            // fullTestMinusButton
            // 
            this.fullTestMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("fullTestMinusButton.Image")));
            this.fullTestMinusButton.Location = new System.Drawing.Point(1274, 7);
            this.fullTestMinusButton.Name = "fullTestMinusButton";
            this.fullTestMinusButton.Size = new System.Drawing.Size(24, 24);
            this.fullTestMinusButton.TabIndex = 150;
            this.fullTestMinusButton.UseVisualStyleBackColor = true;
            this.fullTestMinusButton.Click += new System.EventHandler(this.fullTestMinusButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Report Procedure";
            // 
            // fullReportPanel
            // 
            this.fullReportPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.fullReportPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.fullReportPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.fullReportPanel.InnerColor2 = System.Drawing.Color.White;
            this.fullReportPanel.Location = new System.Drawing.Point(4, 468);
            this.fullReportPanel.Name = "fullReportPanel";
            this.fullReportPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.fullReportPanel.OuterColor2 = System.Drawing.Color.White;
            this.fullReportPanel.Size = new System.Drawing.Size(1294, 397);
            this.fullReportPanel.Spacing = 0;
            this.fullReportPanel.TabIndex = 3;
            this.fullReportPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.fullReportPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test Procedure";
            // 
            // fullTestPanel
            // 
            this.fullTestPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.fullTestPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.fullTestPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.fullTestPanel.InnerColor2 = System.Drawing.Color.White;
            this.fullTestPanel.Location = new System.Drawing.Point(4, 32);
            this.fullTestPanel.Name = "fullTestPanel";
            this.fullTestPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.fullTestPanel.OuterColor2 = System.Drawing.Color.White;
            this.fullTestPanel.Size = new System.Drawing.Size(1294, 401);
            this.fullTestPanel.Spacing = 0;
            this.fullTestPanel.TabIndex = 1;
            this.fullTestPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.fullTestPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // workSamplingPage
            // 
            this.workSamplingPage.BackColor = System.Drawing.Color.White;
            this.workSamplingPage.Controls.Add(this.samplingReportPluseButton);
            this.workSamplingPage.Controls.Add(this.samplingReportMinusButton);
            this.workSamplingPage.Controls.Add(this.samplingTestPluseButton);
            this.workSamplingPage.Controls.Add(this.samplingTestMinusButton);
            this.workSamplingPage.Controls.Add(this.label3);
            this.workSamplingPage.Controls.Add(this.samplingReportPanel);
            this.workSamplingPage.Controls.Add(this.label5);
            this.workSamplingPage.Controls.Add(this.samplingTestPanel);
            this.workSamplingPage.Location = new System.Drawing.Point(4, 24);
            this.workSamplingPage.Name = "workSamplingPage";
            this.workSamplingPage.Padding = new System.Windows.Forms.Padding(3);
            this.workSamplingPage.Size = new System.Drawing.Size(1302, 870);
            this.workSamplingPage.TabIndex = 1;
            this.workSamplingPage.Text = "  Sampling  ";
            // 
            // samplingReportPluseButton
            // 
            this.samplingReportPluseButton.Image = ((System.Drawing.Image)(resources.GetObject("samplingReportPluseButton.Image")));
            this.samplingReportPluseButton.Location = new System.Drawing.Point(1248, 445);
            this.samplingReportPluseButton.Name = "samplingReportPluseButton";
            this.samplingReportPluseButton.Size = new System.Drawing.Size(24, 24);
            this.samplingReportPluseButton.TabIndex = 157;
            this.samplingReportPluseButton.UseVisualStyleBackColor = true;
            this.samplingReportPluseButton.Click += new System.EventHandler(this.samplingReportPluseButton_Click);
            // 
            // samplingReportMinusButton
            // 
            this.samplingReportMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("samplingReportMinusButton.Image")));
            this.samplingReportMinusButton.Location = new System.Drawing.Point(1274, 445);
            this.samplingReportMinusButton.Name = "samplingReportMinusButton";
            this.samplingReportMinusButton.Size = new System.Drawing.Size(24, 24);
            this.samplingReportMinusButton.TabIndex = 156;
            this.samplingReportMinusButton.UseVisualStyleBackColor = true;
            this.samplingReportMinusButton.Click += new System.EventHandler(this.samplingReportMinusButton_Click);
            // 
            // samplingTestPluseButton
            // 
            this.samplingTestPluseButton.Image = ((System.Drawing.Image)(resources.GetObject("samplingTestPluseButton.Image")));
            this.samplingTestPluseButton.Location = new System.Drawing.Point(1248, 7);
            this.samplingTestPluseButton.Name = "samplingTestPluseButton";
            this.samplingTestPluseButton.Size = new System.Drawing.Size(24, 24);
            this.samplingTestPluseButton.TabIndex = 155;
            this.samplingTestPluseButton.UseVisualStyleBackColor = true;
            this.samplingTestPluseButton.Click += new System.EventHandler(this.samplingTestPluseButton_Click);
            // 
            // samplingTestMinusButton
            // 
            this.samplingTestMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("samplingTestMinusButton.Image")));
            this.samplingTestMinusButton.Location = new System.Drawing.Point(1274, 7);
            this.samplingTestMinusButton.Name = "samplingTestMinusButton";
            this.samplingTestMinusButton.Size = new System.Drawing.Size(24, 24);
            this.samplingTestMinusButton.TabIndex = 154;
            this.samplingTestMinusButton.UseVisualStyleBackColor = true;
            this.samplingTestMinusButton.Click += new System.EventHandler(this.samplingTestMinusButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Report Procedure";
            // 
            // samplingReportPanel
            // 
            this.samplingReportPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.samplingReportPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.samplingReportPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.samplingReportPanel.InnerColor2 = System.Drawing.Color.White;
            this.samplingReportPanel.Location = new System.Drawing.Point(4, 468);
            this.samplingReportPanel.Name = "samplingReportPanel";
            this.samplingReportPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.samplingReportPanel.OuterColor2 = System.Drawing.Color.White;
            this.samplingReportPanel.Size = new System.Drawing.Size(1294, 397);
            this.samplingReportPanel.Spacing = 0;
            this.samplingReportPanel.TabIndex = 7;
            this.samplingReportPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.samplingReportPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Test Procedure";
            // 
            // samplingTestPanel
            // 
            this.samplingTestPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.samplingTestPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.samplingTestPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.samplingTestPanel.InnerColor2 = System.Drawing.Color.White;
            this.samplingTestPanel.Location = new System.Drawing.Point(4, 32);
            this.samplingTestPanel.Name = "samplingTestPanel";
            this.samplingTestPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.samplingTestPanel.OuterColor2 = System.Drawing.Color.White;
            this.samplingTestPanel.Size = new System.Drawing.Size(1294, 401);
            this.samplingTestPanel.Spacing = 0;
            this.samplingTestPanel.TabIndex = 5;
            this.samplingTestPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.samplingTestPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // viewStatePanel
            // 
            this.viewStatePanel.BackColor = System.Drawing.Color.Gray;
            this.viewStatePanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.viewStatePanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.viewStatePanel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStatePanel.ForeColor = System.Drawing.Color.White;
            this.viewStatePanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewStatePanel.InnerColor2 = System.Drawing.Color.White;
            this.viewStatePanel.Location = new System.Drawing.Point(6, 6);
            this.viewStatePanel.Name = "viewStatePanel";
            this.viewStatePanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewStatePanel.OuterColor2 = System.Drawing.Color.White;
            this.viewStatePanel.Size = new System.Drawing.Size(1310, 28);
            this.viewStatePanel.Spacing = 0;
            this.viewStatePanel.TabIndex = 129;
            this.viewStatePanel.Text = "VIEW";
            this.viewStatePanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewStatePanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // searchPanel
            // 
            this.searchPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.searchPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.searchPanel.Controls.Add(this.findButton);
            this.searchPanel.Controls.Add(this.findNameEdit);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.recipeGrid);
            this.searchPanel.Controls.Add(this.modifyButton);
            this.searchPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.searchPanel.InnerColor2 = System.Drawing.Color.White;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.searchPanel.OuterColor2 = System.Drawing.Color.White;
            this.searchPanel.Size = new System.Drawing.Size(400, 946);
            this.searchPanel.Spacing = 0;
            this.searchPanel.TabIndex = 6;
            this.searchPanel.TabStop = true;
            this.searchPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.searchPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // findButton
            // 
            this.findButton.Image = ((System.Drawing.Image)(resources.GetObject("findButton.Image")));
            this.findButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findButton.Location = new System.Drawing.Point(200, 7);
            this.findButton.Name = "findButton";
            this.findButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.findButton.Size = new System.Drawing.Size(96, 24);
            this.findButton.TabIndex = 82;
            this.findButton.Text = "  Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findNameEdit
            // 
            this.findNameEdit.EditValue = "";
            this.findNameEdit.Location = new System.Drawing.Point(51, 8);
            this.findNameEdit.Name = "findNameEdit";
            this.findNameEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findNameEdit.Properties.Appearance.Options.UseFont = true;
            this.findNameEdit.Properties.MaxLength = 50;
            this.findNameEdit.Size = new System.Drawing.Size(145, 22);
            this.findNameEdit.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 83;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recipeGrid
            // 
            this.recipeGrid.Location = new System.Drawing.Point(6, 34);
            this.recipeGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.recipeGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.recipeGrid.MainView = this.recipeGridView;
            this.recipeGrid.Name = "recipeGrid";
            this.recipeGrid.Size = new System.Drawing.Size(387, 904);
            this.recipeGrid.TabIndex = 80;
            this.recipeGrid.TabStop = false;
            this.recipeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.recipeGridView});
            this.recipeGrid.DoubleClick += new System.EventHandler(this.recipeGrid_DoubleClick);
            // 
            // recipeGridView
            // 
            this.recipeGridView.Appearance.FixedLine.Options.UseFont = true;
            this.recipeGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.recipeGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.recipeGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.recipeGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.recipeGridView.Appearance.OddRow.Options.UseFont = true;
            this.recipeGridView.Appearance.Preview.Options.UseFont = true;
            this.recipeGridView.Appearance.Row.Options.UseFont = true;
            this.recipeGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.recipeGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.recipeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.recipeNameColumn,
            this.recipeMemoColumn});
            this.recipeGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.recipeGridView.GridControl = this.recipeGrid;
            this.recipeGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.recipeGridView.Name = "recipeGridView";
            this.recipeGridView.OptionsBehavior.Editable = false;
            this.recipeGridView.OptionsBehavior.ReadOnly = true;
            this.recipeGridView.OptionsView.ColumnAutoWidth = false;
            this.recipeGridView.OptionsView.ShowGroupPanel = false;
            this.recipeGridView.OptionsView.ShowIndicator = false;
            this.recipeGridView.Tag = 1;
            this.recipeGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.recipeGridView_FocusedRowChanged);
            // 
            // recipeNameColumn
            // 
            this.recipeNameColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameColumn.AppearanceCell.Options.UseFont = true;
            this.recipeNameColumn.AppearanceCell.Options.UseTextOptions = true;
            this.recipeNameColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.recipeNameColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameColumn.AppearanceHeader.Options.UseFont = true;
            this.recipeNameColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.recipeNameColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.recipeNameColumn.Caption = "Name";
            this.recipeNameColumn.FieldName = "CODE";
            this.recipeNameColumn.Name = "recipeNameColumn";
            this.recipeNameColumn.OptionsColumn.AllowEdit = false;
            this.recipeNameColumn.OptionsColumn.AllowFocus = false;
            this.recipeNameColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.recipeNameColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.recipeNameColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.recipeNameColumn.OptionsColumn.AllowMove = false;
            this.recipeNameColumn.OptionsColumn.AllowShowHide = false;
            this.recipeNameColumn.OptionsColumn.AllowSize = false;
            this.recipeNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.recipeNameColumn.OptionsColumn.FixedWidth = true;
            this.recipeNameColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.recipeNameColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.recipeNameColumn.OptionsColumn.ReadOnly = true;
            this.recipeNameColumn.OptionsColumn.TabStop = false;
            this.recipeNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.recipeNameColumn.OptionsFilter.AllowFilter = false;
            this.recipeNameColumn.Visible = true;
            this.recipeNameColumn.VisibleIndex = 0;
            this.recipeNameColumn.Width = 183;
            // 
            // recipeMemoColumn
            // 
            this.recipeMemoColumn.Caption = "Memo";
            this.recipeMemoColumn.FieldName = "MEMO";
            this.recipeMemoColumn.Name = "recipeMemoColumn";
            this.recipeMemoColumn.OptionsColumn.AllowEdit = false;
            this.recipeMemoColumn.OptionsColumn.AllowFocus = false;
            this.recipeMemoColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.recipeMemoColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.recipeMemoColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.recipeMemoColumn.OptionsColumn.AllowMove = false;
            this.recipeMemoColumn.OptionsColumn.AllowShowHide = false;
            this.recipeMemoColumn.OptionsColumn.AllowSize = false;
            this.recipeMemoColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.recipeMemoColumn.OptionsColumn.FixedWidth = true;
            this.recipeMemoColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.recipeMemoColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.recipeMemoColumn.OptionsColumn.ReadOnly = true;
            this.recipeMemoColumn.OptionsFilter.AllowAutoFilter = false;
            this.recipeMemoColumn.OptionsFilter.AllowFilter = false;
            this.recipeMemoColumn.Visible = true;
            this.recipeMemoColumn.VisibleIndex = 1;
            this.recipeMemoColumn.Width = 183;
            // 
            // modifyButton
            // 
            this.modifyButton.Image = ((System.Drawing.Image)(resources.GetObject("modifyButton.Image")));
            this.modifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyButton.Location = new System.Drawing.Point(298, 7);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.modifyButton.Size = new System.Drawing.Size(96, 24);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "      Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // CtrlConfigWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlConfigWork";
            this.Size = new System.Drawing.Size(1728, 946);
            this.Load += new System.EventHandler(this.CtrlConfigWork_Load);
            this.Enter += new System.EventHandler(this.CtrlConfigWork_Enter);
            this.bgPanel.ResumeLayout(false);
            this.viewerPanel.ResumeLayout(false);
            this.workTab.ResumeLayout(false);
            this.workFullPage.ResumeLayout(false);
            this.workFullPage.PerformLayout();
            this.workSamplingPage.ResumeLayout(false);
            this.workSamplingPage.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.findNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ulee.Controls.UlPanel viewerPanel;
        private Ulee.Controls.UlPanel viewStatePanel;
        private Ulee.Controls.UlPanel searchPanel;
        private DevExpress.XtraGrid.GridControl recipeGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView recipeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn recipeNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn recipeMemoColumn;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button findButton;
        public DevExpress.XtraEditors.TextEdit findNameEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl workTab;
        private System.Windows.Forms.TabPage workFullPage;
        private System.Windows.Forms.Button fullReportPluseButton;
        private System.Windows.Forms.Button fullReportMinusButton;
        private System.Windows.Forms.Button fullTestPluseButton;
        private System.Windows.Forms.Button fullTestMinusButton;
        private System.Windows.Forms.Label label2;
        private Ulee.Controls.UlPanel fullReportPanel;
        private System.Windows.Forms.Label label1;
        private Ulee.Controls.UlPanel fullTestPanel;
        private System.Windows.Forms.TabPage workSamplingPage;
        private System.Windows.Forms.Button samplingReportPluseButton;
        private System.Windows.Forms.Button samplingReportMinusButton;
        private System.Windows.Forms.Button samplingTestPluseButton;
        private System.Windows.Forms.Button samplingTestMinusButton;
        private System.Windows.Forms.Label label3;
        private Ulee.Controls.UlPanel samplingReportPanel;
        private System.Windows.Forms.Label label5;
        private Ulee.Controls.UlPanel samplingTestPanel;
    }
}
