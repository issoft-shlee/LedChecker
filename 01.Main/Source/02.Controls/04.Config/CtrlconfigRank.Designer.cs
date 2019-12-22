namespace IsSoft.Sec.LedChecker
{
    partial class CtrlConfigRank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlConfigRank));
            this.viewerPanel = new Ulee.Controls.UlPanel();
            this.rankGroup = new System.Windows.Forms.GroupBox();
            this.rankRowPluseButton = new System.Windows.Forms.Button();
            this.rankRowMinusButton = new System.Windows.Forms.Button();
            this.rankRowGrid = new DevExpress.XtraGrid.GridControl();
            this.rankRowGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rankRowIndexColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowT50TextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rankRowLower1Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRow7F3TextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.rankRowUpper1Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowLower2Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowUpper2Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemCodeCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewStatePanel = new Ulee.Controls.UlPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameEdit = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit = new DevExpress.XtraEditors.TextEdit();
            this.searchPanel = new Ulee.Controls.UlPanel();
            this.recipeCombo = new System.Windows.Forms.ComboBox();
            this.rankGrid = new DevExpress.XtraGrid.GridControl();
            this.rankGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rankItemCodeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            this.viewerPanel.SuspendLayout();
            this.rankGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowT50TextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRow7F3TextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).BeginInit();
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
            this.viewerPanel.Controls.Add(this.rankGroup);
            this.viewerPanel.Controls.Add(this.itemCodeCombo);
            this.viewerPanel.Controls.Add(this.label3);
            this.viewerPanel.Controls.Add(this.viewStatePanel);
            this.viewerPanel.Controls.Add(this.label2);
            this.viewerPanel.Controls.Add(this.label1);
            this.viewerPanel.Controls.Add(this.nameEdit);
            this.viewerPanel.Controls.Add(this.memoEdit);
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
            // rankGroup
            // 
            this.rankGroup.Controls.Add(this.rankRowPluseButton);
            this.rankGroup.Controls.Add(this.rankRowMinusButton);
            this.rankGroup.Controls.Add(this.rankRowGrid);
            this.rankGroup.Location = new System.Drawing.Point(8, 74);
            this.rankGroup.Name = "rankGroup";
            this.rankGroup.Size = new System.Drawing.Size(1306, 864);
            this.rankGroup.TabIndex = 3;
            this.rankGroup.TabStop = false;
            this.rankGroup.Text = "  Ranking  ";
            // 
            // rankRowPluseButton
            // 
            this.rankRowPluseButton.Image = ((System.Drawing.Image)(resources.GetObject("rankRowPluseButton.Image")));
            this.rankRowPluseButton.Location = new System.Drawing.Point(1278, 24);
            this.rankRowPluseButton.Name = "rankRowPluseButton";
            this.rankRowPluseButton.Size = new System.Drawing.Size(24, 24);
            this.rankRowPluseButton.TabIndex = 1;
            this.rankRowPluseButton.UseVisualStyleBackColor = true;
            this.rankRowPluseButton.Click += new System.EventHandler(this.rankRowPluseButton_Click);
            // 
            // rankRowMinusButton
            // 
            this.rankRowMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("rankRowMinusButton.Image")));
            this.rankRowMinusButton.Location = new System.Drawing.Point(1278, 50);
            this.rankRowMinusButton.Name = "rankRowMinusButton";
            this.rankRowMinusButton.Size = new System.Drawing.Size(24, 24);
            this.rankRowMinusButton.TabIndex = 2;
            this.rankRowMinusButton.UseVisualStyleBackColor = true;
            this.rankRowMinusButton.Click += new System.EventHandler(this.rankRowMinusButton_Click);
            // 
            // rankRowGrid
            // 
            this.rankRowGrid.Location = new System.Drawing.Point(8, 24);
            this.rankRowGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.rankRowGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rankRowGrid.MainView = this.rankRowGridView;
            this.rankRowGrid.Name = "rankRowGrid";
            this.rankRowGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rankRowT50TextEdit,
            this.rankRow7F3TextEdit});
            this.rankRowGrid.Size = new System.Drawing.Size(1266, 832);
            this.rankRowGrid.TabIndex = 0;
            this.rankRowGrid.TabStop = false;
            this.rankRowGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rankRowGridView});
            // 
            // rankRowGridView
            // 
            this.rankRowGridView.Appearance.FixedLine.Options.UseFont = true;
            this.rankRowGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankRowGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.rankRowGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.rankRowGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.rankRowGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.rankRowGridView.Appearance.OddRow.Options.UseFont = true;
            this.rankRowGridView.Appearance.Preview.Options.UseFont = true;
            this.rankRowGridView.Appearance.Row.Options.UseFont = true;
            this.rankRowGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.rankRowGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.rankRowGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.rankRowIndexColumn,
            this.rankRowNameColumn,
            this.rankRowLower1Column,
            this.rankRowUpper1Column,
            this.rankRowLower2Column,
            this.rankRowUpper2Column});
            this.rankRowGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.rankRowGridView.GridControl = this.rankRowGrid;
            this.rankRowGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.rankRowGridView.Name = "rankRowGridView";
            this.rankRowGridView.OptionsView.ColumnAutoWidth = false;
            this.rankRowGridView.OptionsView.ShowGroupPanel = false;
            this.rankRowGridView.OptionsView.ShowIndicator = false;
            this.rankRowGridView.Tag = 1;
            // 
            // rankRowIndexColumn
            // 
            this.rankRowIndexColumn.AppearanceCell.Options.UseTextOptions = true;
            this.rankRowIndexColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rankRowIndexColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.rankRowIndexColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rankRowIndexColumn.Caption = "No.";
            this.rankRowIndexColumn.FieldName = "Index";
            this.rankRowIndexColumn.Name = "rankRowIndexColumn";
            this.rankRowIndexColumn.OptionsColumn.AllowEdit = false;
            this.rankRowIndexColumn.OptionsColumn.AllowFocus = false;
            this.rankRowIndexColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowIndexColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.rankRowIndexColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowIndexColumn.OptionsColumn.AllowMove = false;
            this.rankRowIndexColumn.OptionsColumn.AllowShowHide = false;
            this.rankRowIndexColumn.OptionsColumn.AllowSize = false;
            this.rankRowIndexColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowIndexColumn.OptionsColumn.FixedWidth = true;
            this.rankRowIndexColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowIndexColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowIndexColumn.OptionsColumn.TabStop = false;
            this.rankRowIndexColumn.OptionsFilter.AllowAutoFilter = false;
            this.rankRowIndexColumn.OptionsFilter.AllowFilter = false;
            this.rankRowIndexColumn.Visible = true;
            this.rankRowIndexColumn.VisibleIndex = 0;
            this.rankRowIndexColumn.Width = 40;
            // 
            // rankRowNameColumn
            // 
            this.rankRowNameColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankRowNameColumn.AppearanceCell.Options.UseFont = true;
            this.rankRowNameColumn.AppearanceCell.Options.UseTextOptions = true;
            this.rankRowNameColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rankRowNameColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankRowNameColumn.AppearanceHeader.Options.UseFont = true;
            this.rankRowNameColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.rankRowNameColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rankRowNameColumn.Caption = "Rank Name";
            this.rankRowNameColumn.ColumnEdit = this.rankRowT50TextEdit;
            this.rankRowNameColumn.FieldName = "Name";
            this.rankRowNameColumn.Name = "rankRowNameColumn";
            this.rankRowNameColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowNameColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.rankRowNameColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowNameColumn.OptionsColumn.AllowMove = false;
            this.rankRowNameColumn.OptionsColumn.AllowShowHide = false;
            this.rankRowNameColumn.OptionsColumn.AllowSize = false;
            this.rankRowNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowNameColumn.OptionsColumn.FixedWidth = true;
            this.rankRowNameColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowNameColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowNameColumn.OptionsColumn.TabStop = false;
            this.rankRowNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.rankRowNameColumn.OptionsFilter.AllowFilter = false;
            this.rankRowNameColumn.Visible = true;
            this.rankRowNameColumn.VisibleIndex = 1;
            this.rankRowNameColumn.Width = 360;
            // 
            // rankRowT50TextEdit
            // 
            this.rankRowT50TextEdit.AutoHeight = false;
            this.rankRowT50TextEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.rankRowT50TextEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rankRowT50TextEdit.MaxLength = 50;
            this.rankRowT50TextEdit.Name = "rankRowT50TextEdit";
            // 
            // rankRowLower1Column
            // 
            this.rankRowLower1Column.Caption = "From";
            this.rankRowLower1Column.ColumnEdit = this.rankRow7F3TextEdit;
            this.rankRowLower1Column.FieldName = "Lower1";
            this.rankRowLower1Column.MinWidth = 120;
            this.rankRowLower1Column.Name = "rankRowLower1Column";
            this.rankRowLower1Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower1Column.OptionsColumn.AllowIncrementalSearch = false;
            this.rankRowLower1Column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower1Column.OptionsColumn.AllowMove = false;
            this.rankRowLower1Column.OptionsColumn.AllowShowHide = false;
            this.rankRowLower1Column.OptionsColumn.AllowSize = false;
            this.rankRowLower1Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower1Column.OptionsColumn.FixedWidth = true;
            this.rankRowLower1Column.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower1Column.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower1Column.OptionsFilter.AllowAutoFilter = false;
            this.rankRowLower1Column.OptionsFilter.AllowFilter = false;
            this.rankRowLower1Column.Visible = true;
            this.rankRowLower1Column.VisibleIndex = 2;
            this.rankRowLower1Column.Width = 120;
            // 
            // rankRow7F3TextEdit
            // 
            this.rankRow7F3TextEdit.AutoHeight = false;
            this.rankRow7F3TextEdit.DisplayFormat.FormatString = "F3";
            this.rankRow7F3TextEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankRow7F3TextEdit.EditFormat.FormatString = "F3";
            this.rankRow7F3TextEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankRow7F3TextEdit.Mask.EditMask = "F3";
            this.rankRow7F3TextEdit.MaxLength = 7;
            this.rankRow7F3TextEdit.Name = "rankRow7F3TextEdit";
            // 
            // rankRowUpper1Column
            // 
            this.rankRowUpper1Column.Caption = "To";
            this.rankRowUpper1Column.ColumnEdit = this.rankRow7F3TextEdit;
            this.rankRowUpper1Column.FieldName = "Upper1";
            this.rankRowUpper1Column.MinWidth = 120;
            this.rankRowUpper1Column.Name = "rankRowUpper1Column";
            this.rankRowUpper1Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper1Column.OptionsColumn.AllowIncrementalSearch = false;
            this.rankRowUpper1Column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper1Column.OptionsColumn.AllowMove = false;
            this.rankRowUpper1Column.OptionsColumn.AllowShowHide = false;
            this.rankRowUpper1Column.OptionsColumn.AllowSize = false;
            this.rankRowUpper1Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper1Column.OptionsColumn.FixedWidth = true;
            this.rankRowUpper1Column.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper1Column.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper1Column.OptionsFilter.AllowAutoFilter = false;
            this.rankRowUpper1Column.OptionsFilter.AllowFilter = false;
            this.rankRowUpper1Column.Visible = true;
            this.rankRowUpper1Column.VisibleIndex = 3;
            this.rankRowUpper1Column.Width = 120;
            // 
            // rankRowLower2Column
            // 
            this.rankRowLower2Column.Caption = "From";
            this.rankRowLower2Column.ColumnEdit = this.rankRow7F3TextEdit;
            this.rankRowLower2Column.FieldName = "Lower2";
            this.rankRowLower2Column.MinWidth = 120;
            this.rankRowLower2Column.Name = "rankRowLower2Column";
            this.rankRowLower2Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower2Column.OptionsColumn.AllowIncrementalSearch = false;
            this.rankRowLower2Column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower2Column.OptionsColumn.AllowMove = false;
            this.rankRowLower2Column.OptionsColumn.AllowShowHide = false;
            this.rankRowLower2Column.OptionsColumn.AllowSize = false;
            this.rankRowLower2Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower2Column.OptionsColumn.FixedWidth = true;
            this.rankRowLower2Column.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower2Column.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowLower2Column.OptionsFilter.AllowAutoFilter = false;
            this.rankRowLower2Column.OptionsFilter.AllowFilter = false;
            this.rankRowLower2Column.Visible = true;
            this.rankRowLower2Column.VisibleIndex = 4;
            this.rankRowLower2Column.Width = 120;
            // 
            // rankRowUpper2Column
            // 
            this.rankRowUpper2Column.Caption = "To";
            this.rankRowUpper2Column.ColumnEdit = this.rankRow7F3TextEdit;
            this.rankRowUpper2Column.FieldName = "Upper2";
            this.rankRowUpper2Column.MinWidth = 120;
            this.rankRowUpper2Column.Name = "rankRowUpper2Column";
            this.rankRowUpper2Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper2Column.OptionsColumn.AllowIncrementalSearch = false;
            this.rankRowUpper2Column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper2Column.OptionsColumn.AllowMove = false;
            this.rankRowUpper2Column.OptionsColumn.AllowShowHide = false;
            this.rankRowUpper2Column.OptionsColumn.AllowSize = false;
            this.rankRowUpper2Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper2Column.OptionsColumn.FixedWidth = true;
            this.rankRowUpper2Column.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper2Column.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankRowUpper2Column.OptionsFilter.AllowAutoFilter = false;
            this.rankRowUpper2Column.OptionsFilter.AllowFilter = false;
            this.rankRowUpper2Column.Visible = true;
            this.rankRowUpper2Column.VisibleIndex = 5;
            this.rankRowUpper2Column.Width = 120;
            // 
            // itemCodeCombo
            // 
            this.itemCodeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCodeCombo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCodeCombo.FormattingEnabled = true;
            this.itemCodeCombo.ItemHeight = 15;
            this.itemCodeCombo.Location = new System.Drawing.Point(86, 42);
            this.itemCodeCombo.Name = "itemCodeCombo";
            this.itemCodeCombo.Size = new System.Drawing.Size(200, 23);
            this.itemCodeCombo.TabIndex = 0;
            this.itemCodeCombo.SelectedIndexChanged += new System.EventHandler(this.itemCodeCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 130;
            this.label3.Text = "Item Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "Memo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameEdit
            // 
            this.nameEdit.EditValue = "";
            this.nameEdit.Location = new System.Drawing.Point(398, 43);
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
            this.nameEdit.Size = new System.Drawing.Size(200, 22);
            this.nameEdit.TabIndex = 1;
            // 
            // memoEdit
            // 
            this.memoEdit.EditValue = "";
            this.memoEdit.Location = new System.Drawing.Point(710, 42);
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
            this.memoEdit.Size = new System.Drawing.Size(200, 22);
            this.memoEdit.TabIndex = 2;
            // 
            // searchPanel
            // 
            this.searchPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.searchPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Lowered;
            this.searchPanel.Controls.Add(this.recipeCombo);
            this.searchPanel.Controls.Add(this.rankGrid);
            this.searchPanel.Controls.Add(this.deleteButton);
            this.searchPanel.Controls.Add(this.copyButton);
            this.searchPanel.Controls.Add(this.modifyButton);
            this.searchPanel.Controls.Add(this.newButton);
            this.searchPanel.Controls.Add(this.label4);
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
            // recipeCombo
            // 
            this.recipeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipeCombo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeCombo.FormattingEnabled = true;
            this.recipeCombo.Location = new System.Drawing.Point(56, 8);
            this.recipeCombo.Name = "recipeCombo";
            this.recipeCombo.Size = new System.Drawing.Size(337, 23);
            this.recipeCombo.TabIndex = 81;
            this.recipeCombo.SelectedIndexChanged += new System.EventHandler(this.recipeCombo_SelectedIndexChanged);
            // 
            // rankGrid
            // 
            this.rankGrid.Location = new System.Drawing.Point(6, 62);
            this.rankGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.rankGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rankGrid.MainView = this.rankGridView;
            this.rankGrid.Name = "rankGrid";
            this.rankGrid.Size = new System.Drawing.Size(387, 876);
            this.rankGrid.TabIndex = 80;
            this.rankGrid.TabStop = false;
            this.rankGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rankGridView});
            this.rankGrid.DoubleClick += new System.EventHandler(this.rankGrid_DoubleClick);
            // 
            // rankGridView
            // 
            this.rankGridView.Appearance.FixedLine.Options.UseFont = true;
            this.rankGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.rankGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.rankGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.rankGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.rankGridView.Appearance.OddRow.Options.UseFont = true;
            this.rankGridView.Appearance.Preview.Options.UseFont = true;
            this.rankGridView.Appearance.Row.Options.UseFont = true;
            this.rankGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.rankGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.rankGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.rankItemCodeColumn,
            this.rankNameColumn});
            this.rankGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.rankGridView.GridControl = this.rankGrid;
            this.rankGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.rankGridView.Name = "rankGridView";
            this.rankGridView.OptionsBehavior.Editable = false;
            this.rankGridView.OptionsBehavior.ReadOnly = true;
            this.rankGridView.OptionsView.ColumnAutoWidth = false;
            this.rankGridView.OptionsView.ShowGroupPanel = false;
            this.rankGridView.OptionsView.ShowIndicator = false;
            this.rankGridView.Tag = 1;
            this.rankGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.rankGridView_FocusedRowChanged);
            // 
            // rankItemCodeColumn
            // 
            this.rankItemCodeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.rankItemCodeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rankItemCodeColumn.Caption = "Item Code";
            this.rankItemCodeColumn.FieldName = "ITEMCODE";
            this.rankItemCodeColumn.Name = "rankItemCodeColumn";
            this.rankItemCodeColumn.OptionsColumn.AllowEdit = false;
            this.rankItemCodeColumn.OptionsColumn.AllowFocus = false;
            this.rankItemCodeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankItemCodeColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.rankItemCodeColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankItemCodeColumn.OptionsColumn.AllowMove = false;
            this.rankItemCodeColumn.OptionsColumn.AllowShowHide = false;
            this.rankItemCodeColumn.OptionsColumn.AllowSize = false;
            this.rankItemCodeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankItemCodeColumn.OptionsColumn.FixedWidth = true;
            this.rankItemCodeColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankItemCodeColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankItemCodeColumn.OptionsColumn.ReadOnly = true;
            this.rankItemCodeColumn.OptionsColumn.TabStop = false;
            this.rankItemCodeColumn.OptionsFilter.AllowAutoFilter = false;
            this.rankItemCodeColumn.OptionsFilter.AllowFilter = false;
            this.rankItemCodeColumn.Visible = true;
            this.rankItemCodeColumn.VisibleIndex = 0;
            this.rankItemCodeColumn.Width = 183;
            // 
            // rankNameColumn
            // 
            this.rankNameColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankNameColumn.AppearanceCell.Options.UseFont = true;
            this.rankNameColumn.AppearanceCell.Options.UseTextOptions = true;
            this.rankNameColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rankNameColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankNameColumn.AppearanceHeader.Options.UseFont = true;
            this.rankNameColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.rankNameColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.rankNameColumn.Caption = "Name";
            this.rankNameColumn.FieldName = "RANKNAME";
            this.rankNameColumn.Name = "rankNameColumn";
            this.rankNameColumn.OptionsColumn.AllowEdit = false;
            this.rankNameColumn.OptionsColumn.AllowFocus = false;
            this.rankNameColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankNameColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.rankNameColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankNameColumn.OptionsColumn.AllowMove = false;
            this.rankNameColumn.OptionsColumn.AllowShowHide = false;
            this.rankNameColumn.OptionsColumn.AllowSize = false;
            this.rankNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankNameColumn.OptionsColumn.FixedWidth = true;
            this.rankNameColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankNameColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankNameColumn.OptionsColumn.ReadOnly = true;
            this.rankNameColumn.OptionsColumn.TabStop = false;
            this.rankNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.rankNameColumn.OptionsFilter.AllowFilter = false;
            this.rankNameColumn.Visible = true;
            this.rankNameColumn.VisibleIndex = 1;
            this.rankNameColumn.Width = 183;
            // 
            // deleteButton
            // 
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(298, 34);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.deleteButton.Size = new System.Drawing.Size(96, 24);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "    Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyButton.Location = new System.Drawing.Point(201, 34);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(95, 24);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "    Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Image = ((System.Drawing.Image)(resources.GetObject("modifyButton.Image")));
            this.modifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyButton.Location = new System.Drawing.Point(103, 34);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.modifyButton.Size = new System.Drawing.Size(96, 24);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "      Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // newButton
            // 
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.Location = new System.Drawing.Point(6, 34);
            this.newButton.Name = "newButton";
            this.newButton.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.newButton.Size = new System.Drawing.Size(95, 24);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "  New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 79;
            this.label4.Text = "Recipe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CtrlConfigRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlConfigRank";
            this.Size = new System.Drawing.Size(1728, 946);
            this.Load += new System.EventHandler(this.CtrlConfigRank_Load);
            this.Enter += new System.EventHandler(this.CtrlConfigRank_Enter);
            this.Leave += new System.EventHandler(this.CtrlConfigRank_Leave);
            this.bgPanel.ResumeLayout(false);
            this.viewerPanel.ResumeLayout(false);
            this.viewerPanel.PerformLayout();
            this.rankGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rankRowGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowT50TextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRow7F3TextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).EndInit();
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rankGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ulee.Controls.UlPanel viewerPanel;
        private Ulee.Controls.UlPanel viewStatePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.TextEdit nameEdit;
        public DevExpress.XtraEditors.TextEdit memoEdit;
        private Ulee.Controls.UlPanel searchPanel;
        private System.Windows.Forms.ComboBox recipeCombo;
        private DevExpress.XtraGrid.GridControl rankGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView rankGridView;
        private DevExpress.XtraGrid.Columns.GridColumn rankItemCodeColumn;
        private DevExpress.XtraGrid.Columns.GridColumn rankNameColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemCodeCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox rankGroup;
        private DevExpress.XtraGrid.GridControl rankRowGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView rankRowGridView;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowIndexColumn;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowNameColumn;
        private System.Windows.Forms.Button rankRowPluseButton;
        private System.Windows.Forms.Button rankRowMinusButton;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowLower1Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowUpper1Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowLower2Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowUpper2Column;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rankRowT50TextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rankRow7F3TextEdit;
    }
}
