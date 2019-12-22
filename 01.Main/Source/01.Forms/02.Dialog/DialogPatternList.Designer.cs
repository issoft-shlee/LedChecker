namespace IsSoft.Sec.LedChecker
{
    partial class DialogPatternList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogPatternList));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchPanel = new Ulee.Controls.UlPanel();
            this.patternGrid = new DevExpress.XtraGrid.GridControl();
            this.patternGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.recipeNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.recipeMemoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.viewerPanel = new Ulee.Controls.UlPanel();
            this.patternGroup = new System.Windows.Forms.GroupBox();
            this.smuColorPanel = new Ulee.Controls.UlPanel();
            this.ulPanel3 = new Ulee.Controls.UlPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ulPanel1 = new Ulee.Controls.UlPanel();
            this.ledCountEdit = new DevExpress.XtraEditors.TextEdit();
            this.stringCountEdit = new DevExpress.XtraEditors.TextEdit();
            this.yHeightEdit = new DevExpress.XtraEditors.TextEdit();
            this.xLengthEdit = new DevExpress.XtraEditors.TextEdit();
            this.patternGridPanel = new Ulee.Controls.UlPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ulPanel2 = new Ulee.Controls.UlPanel();
            this.ulPanel4 = new Ulee.Controls.UlPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameEdit = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit = new DevExpress.XtraEditors.TextEdit();
            this.bgPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patternGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternGridView)).BeginInit();
            this.viewerPanel.SuspendLayout();
            this.patternGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringCountEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yHeightEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLengthEdit.Properties)).BeginInit();
            this.ulPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.viewerPanel);
            this.bgPanel.Controls.Add(this.searchPanel);
            this.bgPanel.Controls.Add(this.okButton);
            this.bgPanel.Controls.Add(this.cancelButton);
            this.bgPanel.Size = new System.Drawing.Size(1734, 557);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(1528, 520);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.okButton.Size = new System.Drawing.Size(100, 32);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(1630, 520);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.searchPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.searchPanel.Controls.Add(this.patternGrid);
            this.searchPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.searchPanel.InnerColor2 = System.Drawing.Color.White;
            this.searchPanel.Location = new System.Drawing.Point(4, 4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.searchPanel.OuterColor2 = System.Drawing.Color.White;
            this.searchPanel.Size = new System.Drawing.Size(400, 514);
            this.searchPanel.Spacing = 0;
            this.searchPanel.TabIndex = 8;
            this.searchPanel.TabStop = true;
            this.searchPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.searchPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // patternGrid
            // 
            this.patternGrid.Location = new System.Drawing.Point(6, 6);
            this.patternGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.patternGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.patternGrid.MainView = this.patternGridView;
            this.patternGrid.Name = "patternGrid";
            this.patternGrid.Size = new System.Drawing.Size(387, 500);
            this.patternGrid.TabIndex = 80;
            this.patternGrid.TabStop = false;
            this.patternGrid.UseDisabledStatePainter = false;
            this.patternGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.patternGridView});
            this.patternGrid.DoubleClick += new System.EventHandler(this.patternGrid_DoubleClick);
            // 
            // patternGridView
            // 
            this.patternGridView.Appearance.EvenRow.Options.UseFont = true;
            this.patternGridView.Appearance.FixedLine.Options.UseFont = true;
            this.patternGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.patternGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.patternGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.patternGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.patternGridView.Appearance.OddRow.Options.UseFont = true;
            this.patternGridView.Appearance.Preview.Options.UseFont = true;
            this.patternGridView.Appearance.Row.Options.UseFont = true;
            this.patternGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.patternGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.patternGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.recipeNameColumn,
            this.recipeMemoColumn});
            this.patternGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.patternGridView.GridControl = this.patternGrid;
            this.patternGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.patternGridView.Name = "patternGridView";
            this.patternGridView.OptionsBehavior.Editable = false;
            this.patternGridView.OptionsBehavior.ReadOnly = true;
            this.patternGridView.OptionsFilter.AllowFilterEditor = false;
            this.patternGridView.OptionsView.ColumnAutoWidth = false;
            this.patternGridView.OptionsView.ShowGroupPanel = false;
            this.patternGridView.OptionsView.ShowIndicator = false;
            this.patternGridView.Tag = 1;
            this.patternGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.patternGridView_FocusedRowChanged);
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
            this.recipeNameColumn.FieldName = "PATTERNNAME";
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
            // viewerPanel
            // 
            this.viewerPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.viewerPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.viewerPanel.Controls.Add(this.patternGroup);
            this.viewerPanel.Controls.Add(this.label2);
            this.viewerPanel.Controls.Add(this.label1);
            this.viewerPanel.Controls.Add(this.nameEdit);
            this.viewerPanel.Controls.Add(this.memoEdit);
            this.viewerPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewerPanel.InnerColor2 = System.Drawing.Color.White;
            this.viewerPanel.Location = new System.Drawing.Point(408, 4);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewerPanel.OuterColor2 = System.Drawing.Color.White;
            this.viewerPanel.Size = new System.Drawing.Size(1322, 514);
            this.viewerPanel.Spacing = 0;
            this.viewerPanel.TabIndex = 9;
            this.viewerPanel.TabStop = true;
            this.viewerPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewerPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // patternGroup
            // 
            this.patternGroup.Controls.Add(this.smuColorPanel);
            this.patternGroup.Controls.Add(this.ulPanel3);
            this.patternGroup.Controls.Add(this.label5);
            this.patternGroup.Controls.Add(this.label3);
            this.patternGroup.Controls.Add(this.ulPanel1);
            this.patternGroup.Controls.Add(this.ledCountEdit);
            this.patternGroup.Controls.Add(this.stringCountEdit);
            this.patternGroup.Controls.Add(this.yHeightEdit);
            this.patternGroup.Controls.Add(this.xLengthEdit);
            this.patternGroup.Controls.Add(this.patternGridPanel);
            this.patternGroup.Controls.Add(this.label14);
            this.patternGroup.Controls.Add(this.label15);
            this.patternGroup.Controls.Add(this.label13);
            this.patternGroup.Controls.Add(this.label12);
            this.patternGroup.Controls.Add(this.ulPanel2);
            this.patternGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternGroup.Location = new System.Drawing.Point(10, 44);
            this.patternGroup.Name = "patternGroup";
            this.patternGroup.Size = new System.Drawing.Size(1302, 462);
            this.patternGroup.TabIndex = 144;
            this.patternGroup.TabStop = false;
            this.patternGroup.Text = " Pattern ";
            this.patternGroup.UseCompatibleTextRendering = true;
            // 
            // smuColorPanel
            // 
            this.smuColorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.smuColorPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.smuColorPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.smuColorPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.smuColorPanel.InnerColor2 = System.Drawing.Color.White;
            this.smuColorPanel.Location = new System.Drawing.Point(10, 420);
            this.smuColorPanel.Name = "smuColorPanel";
            this.smuColorPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.smuColorPanel.OuterColor2 = System.Drawing.Color.White;
            this.smuColorPanel.Size = new System.Drawing.Size(1282, 32);
            this.smuColorPanel.Spacing = 0;
            this.smuColorPanel.TabIndex = 154;
            this.smuColorPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.smuColorPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ulPanel3
            // 
            this.ulPanel3.BackColor = System.Drawing.Color.Red;
            this.ulPanel3.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel3.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel3.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel3.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel3.Location = new System.Drawing.Point(1120, 24);
            this.ulPanel3.Name = "ulPanel3";
            this.ulPanel3.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel3.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel3.Size = new System.Drawing.Size(14, 14);
            this.ulPanel3.Spacing = 0;
            this.ulPanel3.TabIndex = 149;
            this.ulPanel3.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel3.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1228, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 152;
            this.label5.Text = "Measuring";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1141, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 151;
            this.label3.Text = "Turn On";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // ulPanel1
            // 
            this.ulPanel1.BackColor = System.Drawing.Color.Black;
            this.ulPanel1.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel1.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel1.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel1.Location = new System.Drawing.Point(1119, 23);
            this.ulPanel1.Name = "ulPanel1";
            this.ulPanel1.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel1.Size = new System.Drawing.Size(16, 16);
            this.ulPanel1.Spacing = 0;
            this.ulPanel1.TabIndex = 149;
            this.ulPanel1.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel1.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ledCountEdit
            // 
            this.ledCountEdit.EditValue = "1";
            this.ledCountEdit.Location = new System.Drawing.Point(705, 20);
            this.ledCountEdit.Name = "ledCountEdit";
            this.ledCountEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledCountEdit.Properties.Appearance.Options.UseFont = true;
            this.ledCountEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledCountEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.ledCountEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledCountEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.ledCountEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledCountEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.ledCountEdit.Properties.DisplayFormat.FormatString = "F0";
            this.ledCountEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ledCountEdit.Properties.EditFormat.FormatString = "F0";
            this.ledCountEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ledCountEdit.Properties.Mask.EditMask = "F0";
            this.ledCountEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ledCountEdit.Properties.MaxLength = 3;
            this.ledCountEdit.Properties.ReadOnly = true;
            this.ledCountEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ledCountEdit.Size = new System.Drawing.Size(68, 22);
            this.ledCountEdit.TabIndex = 148;
            this.ledCountEdit.TabStop = false;
            // 
            // stringCountEdit
            // 
            this.stringCountEdit.EditValue = "1";
            this.stringCountEdit.Location = new System.Drawing.Point(463, 20);
            this.stringCountEdit.Name = "stringCountEdit";
            this.stringCountEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringCountEdit.Properties.Appearance.Options.UseFont = true;
            this.stringCountEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringCountEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.stringCountEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringCountEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.stringCountEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringCountEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.stringCountEdit.Properties.DisplayFormat.FormatString = "F0";
            this.stringCountEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.stringCountEdit.Properties.EditFormat.FormatString = "F0";
            this.stringCountEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.stringCountEdit.Properties.Mask.EditMask = "F0";
            this.stringCountEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.stringCountEdit.Properties.MaxLength = 3;
            this.stringCountEdit.Properties.ReadOnly = true;
            this.stringCountEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stringCountEdit.Size = new System.Drawing.Size(68, 22);
            this.stringCountEdit.TabIndex = 147;
            this.stringCountEdit.TabStop = false;
            // 
            // yHeightEdit
            // 
            this.yHeightEdit.EditValue = "1";
            this.yHeightEdit.Location = new System.Drawing.Point(265, 20);
            this.yHeightEdit.Name = "yHeightEdit";
            this.yHeightEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yHeightEdit.Properties.Appearance.Options.UseFont = true;
            this.yHeightEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yHeightEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.yHeightEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yHeightEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.yHeightEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yHeightEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.yHeightEdit.Properties.DisplayFormat.FormatString = "F0";
            this.yHeightEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.yHeightEdit.Properties.EditFormat.FormatString = "F0";
            this.yHeightEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.yHeightEdit.Properties.Mask.EditMask = "F0";
            this.yHeightEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.yHeightEdit.Properties.MaxLength = 3;
            this.yHeightEdit.Properties.ReadOnly = true;
            this.yHeightEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yHeightEdit.Size = new System.Drawing.Size(68, 22);
            this.yHeightEdit.TabIndex = 146;
            this.yHeightEdit.TabStop = false;
            // 
            // xLengthEdit
            // 
            this.xLengthEdit.EditValue = "1";
            this.xLengthEdit.Location = new System.Drawing.Point(79, 20);
            this.xLengthEdit.Name = "xLengthEdit";
            this.xLengthEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLengthEdit.Properties.Appearance.Options.UseFont = true;
            this.xLengthEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLengthEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.xLengthEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLengthEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.xLengthEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLengthEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.xLengthEdit.Properties.DisplayFormat.FormatString = "F0";
            this.xLengthEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xLengthEdit.Properties.EditFormat.FormatString = "F0";
            this.xLengthEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.xLengthEdit.Properties.Mask.EditMask = "F0";
            this.xLengthEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.xLengthEdit.Properties.MaxLength = 3;
            this.xLengthEdit.Properties.ReadOnly = true;
            this.xLengthEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xLengthEdit.Size = new System.Drawing.Size(68, 22);
            this.xLengthEdit.TabIndex = 145;
            this.xLengthEdit.TabStop = false;
            // 
            // patternGridPanel
            // 
            this.patternGridPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.patternGridPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.patternGridPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.patternGridPanel.InnerColor2 = System.Drawing.Color.White;
            this.patternGridPanel.Location = new System.Drawing.Point(10, 48);
            this.patternGridPanel.Name = "patternGridPanel";
            this.patternGridPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.patternGridPanel.OuterColor2 = System.Drawing.Color.White;
            this.patternGridPanel.Size = new System.Drawing.Size(1282, 368);
            this.patternGridPanel.Spacing = 0;
            this.patternGridPanel.TabIndex = 98;
            this.patternGridPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.patternGridPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(570, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 22);
            this.label14.TabIndex = 93;
            this.label14.Text = "LED Count per String";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(375, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 22);
            this.label15.TabIndex = 91;
            this.label15.Text = "String Count";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.UseCompatibleTextRendering = true;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(195, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 22);
            this.label13.TabIndex = 89;
            this.label13.Text = "Y-Height";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 22);
            this.label12.TabIndex = 87;
            this.label12.Text = "X-Length";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // ulPanel2
            // 
            this.ulPanel2.BackColor = System.Drawing.Color.Black;
            this.ulPanel2.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel2.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel2.Controls.Add(this.ulPanel4);
            this.ulPanel2.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel2.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel2.Location = new System.Drawing.Point(1206, 23);
            this.ulPanel2.Name = "ulPanel2";
            this.ulPanel2.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel2.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel2.Size = new System.Drawing.Size(16, 16);
            this.ulPanel2.Spacing = 0;
            this.ulPanel2.TabIndex = 150;
            this.ulPanel2.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel2.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // ulPanel4
            // 
            this.ulPanel4.BackColor = System.Drawing.Color.Lime;
            this.ulPanel4.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel4.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel4.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel4.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel4.Location = new System.Drawing.Point(1, 1);
            this.ulPanel4.Name = "ulPanel4";
            this.ulPanel4.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel4.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel4.Size = new System.Drawing.Size(14, 14);
            this.ulPanel4.Spacing = 0;
            this.ulPanel4.TabIndex = 150;
            this.ulPanel4.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel4.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(323, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 22);
            this.label2.TabIndex = 83;
            this.label2.Text = "Memo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 81;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // nameEdit
            // 
            this.nameEdit.EditValue = "";
            this.nameEdit.Location = new System.Drawing.Point(89, 12);
            this.nameEdit.Name = "nameEdit";
            this.nameEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEdit.Properties.Appearance.Options.UseFont = true;
            this.nameEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.nameEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.nameEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.nameEdit.Properties.MaxLength = 50;
            this.nameEdit.Properties.ReadOnly = true;
            this.nameEdit.Size = new System.Drawing.Size(200, 22);
            this.nameEdit.TabIndex = 1;
            // 
            // memoEdit
            // 
            this.memoEdit.EditValue = "";
            this.memoEdit.Location = new System.Drawing.Point(400, 12);
            this.memoEdit.Name = "memoEdit";
            this.memoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit.Properties.Appearance.Options.UseFont = true;
            this.memoEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.memoEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.memoEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.memoEdit.Properties.MaxLength = 50;
            this.memoEdit.Properties.ReadOnly = true;
            this.memoEdit.Size = new System.Drawing.Size(200, 22);
            this.memoEdit.TabIndex = 2;
            // 
            // DialogPatternList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1734, 557);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPatternList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Pattern";
            this.Load += new System.EventHandler(this.DialogPatternList_Load);
            this.bgPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patternGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternGridView)).EndInit();
            this.viewerPanel.ResumeLayout(false);
            this.patternGroup.ResumeLayout(false);
            this.patternGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringCountEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yHeightEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLengthEdit.Properties)).EndInit();
            this.ulPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private Ulee.Controls.UlPanel searchPanel;
        private DevExpress.XtraGrid.GridControl patternGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView patternGridView;
        private DevExpress.XtraGrid.Columns.GridColumn recipeNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn recipeMemoColumn;
        private Ulee.Controls.UlPanel viewerPanel;
        private System.Windows.Forms.GroupBox patternGroup;
        private Ulee.Controls.UlPanel ulPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Ulee.Controls.UlPanel ulPanel1;
        public DevExpress.XtraEditors.TextEdit ledCountEdit;
        public DevExpress.XtraEditors.TextEdit stringCountEdit;
        public DevExpress.XtraEditors.TextEdit yHeightEdit;
        public DevExpress.XtraEditors.TextEdit xLengthEdit;
        private Ulee.Controls.UlPanel patternGridPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Ulee.Controls.UlPanel ulPanel2;
        private Ulee.Controls.UlPanel ulPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.TextEdit nameEdit;
        public DevExpress.XtraEditors.TextEdit memoEdit;
        private Ulee.Controls.UlPanel smuColorPanel;
    }
}
