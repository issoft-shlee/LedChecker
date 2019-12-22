namespace IsSoft.Sec.LedChecker
{
    partial class DialogBinFormulaEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBinFormulaEdit));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.workGrid = new DevExpress.XtraGrid.GridControl();
            this.workGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.workIndexColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.workItemCodeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.workItemNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.workItemRefColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.workBiasCHColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.conditionCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rankGrid = new DevExpress.XtraGrid.GridControl();
            this.rankGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rankIndexColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankLower1Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankUpper1Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankLower2Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankUpper2Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ulPanel1 = new Ulee.Controls.UlPanel();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.Single;
            this.bgPanel.Controls.Add(this.ulPanel1);
            this.bgPanel.Controls.Add(this.groupBox2);
            this.bgPanel.Controls.Add(this.groupBox1);
            this.bgPanel.Controls.Add(this.conditionCombo);
            this.bgPanel.Controls.Add(this.okButton);
            this.bgPanel.Controls.Add(this.cancelButton);
            this.bgPanel.Size = new System.Drawing.Size(1270, 559);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(1056, 520);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.okButton.Size = new System.Drawing.Size(100, 32);
            this.okButton.TabIndex = 3;
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
            this.cancelButton.Location = new System.Drawing.Point(1158, 520);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // workGrid
            // 
            this.workGrid.Location = new System.Drawing.Point(10, 24);
            this.workGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.workGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.workGrid.MainView = this.workGridView;
            this.workGrid.Name = "workGrid";
            this.workGrid.Size = new System.Drawing.Size(604, 468);
            this.workGrid.TabIndex = 0;
            this.workGrid.TabStop = false;
            this.workGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.workGridView});
            // 
            // workGridView
            // 
            this.workGridView.Appearance.FixedLine.Options.UseFont = true;
            this.workGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.workGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Bisque;
            this.workGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.workGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.workGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.workGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Bisque;
            this.workGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.workGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.workGridView.Appearance.OddRow.Options.UseFont = true;
            this.workGridView.Appearance.Preview.Options.UseFont = true;
            this.workGridView.Appearance.Row.Options.UseFont = true;
            this.workGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.workGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.workGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.workIndexColumn,
            this.workItemCodeColumn,
            this.workItemNameColumn,
            this.workItemRefColumn,
            this.workBiasCHColumn});
            this.workGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.workGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.workGridView.GridControl = this.workGrid;
            this.workGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.workGridView.Name = "workGridView";
            this.workGridView.OptionsBehavior.Editable = false;
            this.workGridView.OptionsBehavior.ReadOnly = true;
            this.workGridView.OptionsHint.ShowColumnHeaderHints = false;
            this.workGridView.OptionsHint.ShowFooterHints = false;
            this.workGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.workGridView.OptionsView.ColumnAutoWidth = false;
            this.workGridView.OptionsView.ShowGroupPanel = false;
            this.workGridView.OptionsView.ShowIndicator = false;
            this.workGridView.Tag = 1;
            this.workGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.workGridView_FocusedRowChanged);
            // 
            // workIndexColumn
            // 
            this.workIndexColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workIndexColumn.AppearanceCell.Options.UseFont = true;
            this.workIndexColumn.AppearanceCell.Options.UseTextOptions = true;
            this.workIndexColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.workIndexColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workIndexColumn.AppearanceHeader.Options.UseFont = true;
            this.workIndexColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.workIndexColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.workIndexColumn.Caption = "No.";
            this.workIndexColumn.FieldName = "WORKNO";
            this.workIndexColumn.Name = "workIndexColumn";
            this.workIndexColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.workIndexColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.workIndexColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.workIndexColumn.OptionsColumn.AllowMove = false;
            this.workIndexColumn.OptionsColumn.AllowShowHide = false;
            this.workIndexColumn.OptionsColumn.AllowSize = false;
            this.workIndexColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.workIndexColumn.OptionsColumn.FixedWidth = true;
            this.workIndexColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.workIndexColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.workIndexColumn.OptionsColumn.ReadOnly = true;
            this.workIndexColumn.OptionsColumn.TabStop = false;
            this.workIndexColumn.OptionsFilter.AllowAutoFilter = false;
            this.workIndexColumn.OptionsFilter.AllowFilter = false;
            this.workIndexColumn.Visible = true;
            this.workIndexColumn.VisibleIndex = 0;
            this.workIndexColumn.Width = 40;
            // 
            // workItemCodeColumn
            // 
            this.workItemCodeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.workItemCodeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.workItemCodeColumn.Caption = "Item Code";
            this.workItemCodeColumn.FieldName = "ITEMCODE";
            this.workItemCodeColumn.Name = "workItemCodeColumn";
            this.workItemCodeColumn.OptionsColumn.AllowEdit = false;
            this.workItemCodeColumn.OptionsColumn.AllowFocus = false;
            this.workItemCodeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.workItemCodeColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.workItemCodeColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.workItemCodeColumn.OptionsColumn.AllowMove = false;
            this.workItemCodeColumn.OptionsColumn.AllowShowHide = false;
            this.workItemCodeColumn.OptionsColumn.AllowSize = false;
            this.workItemCodeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.workItemCodeColumn.OptionsColumn.FixedWidth = true;
            this.workItemCodeColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.workItemCodeColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.workItemCodeColumn.OptionsColumn.ReadOnly = true;
            this.workItemCodeColumn.OptionsFilter.AllowAutoFilter = false;
            this.workItemCodeColumn.OptionsFilter.AllowFilter = false;
            this.workItemCodeColumn.Visible = true;
            this.workItemCodeColumn.VisibleIndex = 1;
            this.workItemCodeColumn.Width = 130;
            // 
            // workItemNameColumn
            // 
            this.workItemNameColumn.Caption = "Item Name";
            this.workItemNameColumn.FieldName = "ITEMNAME";
            this.workItemNameColumn.Name = "workItemNameColumn";
            this.workItemNameColumn.Visible = true;
            this.workItemNameColumn.VisibleIndex = 2;
            this.workItemNameColumn.Width = 180;
            // 
            // workItemRefColumn
            // 
            this.workItemRefColumn.Caption = "Item Reference";
            this.workItemRefColumn.FieldName = "ITEMREF";
            this.workItemRefColumn.Name = "workItemRefColumn";
            this.workItemRefColumn.Visible = true;
            this.workItemRefColumn.VisibleIndex = 3;
            this.workItemRefColumn.Width = 130;
            // 
            // workBiasCHColumn
            // 
            this.workBiasCHColumn.Caption = "Bias-CH";
            this.workBiasCHColumn.FieldName = "BIASCH";
            this.workBiasCHColumn.Name = "workBiasCHColumn";
            this.workBiasCHColumn.Visible = true;
            this.workBiasCHColumn.VisibleIndex = 4;
            this.workBiasCHColumn.Width = 100;
            // 
            // conditionCombo
            // 
            this.conditionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionCombo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionCombo.FormattingEnabled = true;
            this.conditionCombo.Location = new System.Drawing.Point(642, 46);
            this.conditionCombo.Name = "conditionCombo";
            this.conditionCombo.Size = new System.Drawing.Size(108, 23);
            this.conditionCombo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.workGrid);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Work Item  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rankGrid);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(756, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 502);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Rank  ";
            // 
            // rankGrid
            // 
            this.rankGrid.Location = new System.Drawing.Point(10, 24);
            this.rankGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.rankGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rankGrid.MainView = this.rankGridView;
            this.rankGrid.Name = "rankGrid";
            this.rankGrid.Size = new System.Drawing.Size(482, 468);
            this.rankGrid.TabIndex = 0;
            this.rankGrid.TabStop = false;
            this.rankGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rankGridView});
            // 
            // rankGridView
            // 
            this.rankGridView.Appearance.FixedLine.Options.UseFont = true;
            this.rankGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.rankGridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.Bisque;
            this.rankGridView.Appearance.FocusedRow.Options.UseBackColor = true;
            this.rankGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.rankGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.rankGridView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Bisque;
            this.rankGridView.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.rankGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.rankGridView.Appearance.OddRow.Options.UseFont = true;
            this.rankGridView.Appearance.Preview.Options.UseFont = true;
            this.rankGridView.Appearance.Row.Options.UseFont = true;
            this.rankGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.Bisque;
            this.rankGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.rankGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.rankGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.rankGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.rankIndexColumn,
            this.rankNameColumn,
            this.rankLower1Column,
            this.rankUpper1Column,
            this.rankLower2Column,
            this.rankUpper2Column});
            this.rankGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.rankGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.rankGridView.GridControl = this.rankGrid;
            this.rankGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.rankGridView.Name = "rankGridView";
            this.rankGridView.OptionsBehavior.Editable = false;
            this.rankGridView.OptionsBehavior.ReadOnly = true;
            this.rankGridView.OptionsHint.ShowColumnHeaderHints = false;
            this.rankGridView.OptionsHint.ShowFooterHints = false;
            this.rankGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.rankGridView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.rankGridView.OptionsSelection.MultiSelect = true;
            this.rankGridView.OptionsView.ColumnAutoWidth = false;
            this.rankGridView.OptionsView.ShowGroupPanel = false;
            this.rankGridView.OptionsView.ShowIndicator = false;
            this.rankGridView.Tag = 1;
            // 
            // rankIndexColumn
            // 
            this.rankIndexColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankIndexColumn.AppearanceCell.Options.UseFont = true;
            this.rankIndexColumn.AppearanceCell.Options.UseTextOptions = true;
            this.rankIndexColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rankIndexColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankIndexColumn.AppearanceHeader.Options.UseFont = true;
            this.rankIndexColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.rankIndexColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rankIndexColumn.Caption = "No.";
            this.rankIndexColumn.FieldName = "ROWINDEX";
            this.rankIndexColumn.Name = "rankIndexColumn";
            this.rankIndexColumn.OptionsColumn.AllowEdit = false;
            this.rankIndexColumn.OptionsColumn.AllowFocus = false;
            this.rankIndexColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankIndexColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.rankIndexColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankIndexColumn.OptionsColumn.AllowMove = false;
            this.rankIndexColumn.OptionsColumn.AllowShowHide = false;
            this.rankIndexColumn.OptionsColumn.AllowSize = false;
            this.rankIndexColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankIndexColumn.OptionsColumn.FixedWidth = true;
            this.rankIndexColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.rankIndexColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.rankIndexColumn.OptionsColumn.ReadOnly = true;
            this.rankIndexColumn.OptionsColumn.TabStop = false;
            this.rankIndexColumn.OptionsFilter.AllowAutoFilter = false;
            this.rankIndexColumn.OptionsFilter.AllowFilter = false;
            this.rankIndexColumn.Visible = true;
            this.rankIndexColumn.VisibleIndex = 0;
            this.rankIndexColumn.Width = 40;
            // 
            // rankNameColumn
            // 
            this.rankNameColumn.Caption = "Name";
            this.rankNameColumn.FieldName = "ROWNAME";
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
            this.rankNameColumn.Width = 180;
            // 
            // rankLower1Column
            // 
            this.rankLower1Column.Caption = "From";
            this.rankLower1Column.DisplayFormat.FormatString = "F3";
            this.rankLower1Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankLower1Column.FieldName = "LOWER1";
            this.rankLower1Column.Name = "rankLower1Column";
            this.rankLower1Column.OptionsColumn.AllowEdit = false;
            this.rankLower1Column.OptionsColumn.AllowFocus = false;
            this.rankLower1Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankLower1Column.OptionsColumn.AllowIncrementalSearch = false;
            this.rankLower1Column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankLower1Column.OptionsColumn.AllowMove = false;
            this.rankLower1Column.OptionsColumn.AllowShowHide = false;
            this.rankLower1Column.OptionsColumn.AllowSize = false;
            this.rankLower1Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankLower1Column.OptionsColumn.FixedWidth = true;
            this.rankLower1Column.OptionsColumn.ReadOnly = true;
            this.rankLower1Column.OptionsColumn.TabStop = false;
            this.rankLower1Column.OptionsFilter.AllowAutoFilter = false;
            this.rankLower1Column.OptionsFilter.AllowFilter = false;
            this.rankLower1Column.Visible = true;
            this.rankLower1Column.VisibleIndex = 2;
            this.rankLower1Column.Width = 60;
            // 
            // rankUpper1Column
            // 
            this.rankUpper1Column.Caption = "To";
            this.rankUpper1Column.DisplayFormat.FormatString = "F3";
            this.rankUpper1Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankUpper1Column.FieldName = "UPPER1";
            this.rankUpper1Column.Name = "rankUpper1Column";
            this.rankUpper1Column.OptionsColumn.AllowEdit = false;
            this.rankUpper1Column.OptionsColumn.AllowFocus = false;
            this.rankUpper1Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankUpper1Column.OptionsColumn.AllowIncrementalSearch = false;
            this.rankUpper1Column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankUpper1Column.OptionsColumn.AllowMove = false;
            this.rankUpper1Column.OptionsColumn.AllowShowHide = false;
            this.rankUpper1Column.OptionsColumn.AllowSize = false;
            this.rankUpper1Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankUpper1Column.OptionsColumn.FixedWidth = true;
            this.rankUpper1Column.OptionsColumn.ReadOnly = true;
            this.rankUpper1Column.OptionsColumn.TabStop = false;
            this.rankUpper1Column.OptionsFilter.AllowAutoFilter = false;
            this.rankUpper1Column.OptionsFilter.AllowFilter = false;
            this.rankUpper1Column.Visible = true;
            this.rankUpper1Column.VisibleIndex = 3;
            this.rankUpper1Column.Width = 60;
            // 
            // rankLower2Column
            // 
            this.rankLower2Column.Caption = "From";
            this.rankLower2Column.DisplayFormat.FormatString = "F3";
            this.rankLower2Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankLower2Column.FieldName = "LOWER2";
            this.rankLower2Column.Name = "rankLower2Column";
            this.rankLower2Column.OptionsColumn.AllowEdit = false;
            this.rankLower2Column.OptionsColumn.AllowFocus = false;
            this.rankLower2Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankLower2Column.OptionsColumn.AllowIncrementalSearch = false;
            this.rankLower2Column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankLower2Column.OptionsColumn.AllowMove = false;
            this.rankLower2Column.OptionsColumn.AllowShowHide = false;
            this.rankLower2Column.OptionsColumn.AllowSize = false;
            this.rankLower2Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankLower2Column.OptionsColumn.FixedWidth = true;
            this.rankLower2Column.OptionsColumn.ReadOnly = true;
            this.rankLower2Column.OptionsColumn.TabStop = false;
            this.rankLower2Column.OptionsFilter.AllowAutoFilter = false;
            this.rankLower2Column.OptionsFilter.AllowFilter = false;
            this.rankLower2Column.Visible = true;
            this.rankLower2Column.VisibleIndex = 4;
            this.rankLower2Column.Width = 60;
            // 
            // rankUpper2Column
            // 
            this.rankUpper2Column.Caption = "To";
            this.rankUpper2Column.DisplayFormat.FormatString = "F3";
            this.rankUpper2Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankUpper2Column.FieldName = "UPPER2";
            this.rankUpper2Column.Name = "rankUpper2Column";
            this.rankUpper2Column.OptionsColumn.AllowEdit = false;
            this.rankUpper2Column.OptionsColumn.AllowFocus = false;
            this.rankUpper2Column.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.rankUpper2Column.OptionsColumn.AllowIncrementalSearch = false;
            this.rankUpper2Column.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.rankUpper2Column.OptionsColumn.AllowMove = false;
            this.rankUpper2Column.OptionsColumn.AllowShowHide = false;
            this.rankUpper2Column.OptionsColumn.AllowSize = false;
            this.rankUpper2Column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.rankUpper2Column.OptionsColumn.FixedWidth = true;
            this.rankUpper2Column.OptionsColumn.ReadOnly = true;
            this.rankUpper2Column.OptionsColumn.TabStop = false;
            this.rankUpper2Column.OptionsFilter.AllowAutoFilter = false;
            this.rankUpper2Column.OptionsFilter.AllowFilter = false;
            this.rankUpper2Column.Visible = true;
            this.rankUpper2Column.VisibleIndex = 5;
            this.rankUpper2Column.Width = 60;
            // 
            // ulPanel1
            // 
            this.ulPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ulPanel1.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel1.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.ulPanel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ulPanel1.ForeColor = System.Drawing.Color.White;
            this.ulPanel1.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.InnerColor2 = System.Drawing.Color.White;
            this.ulPanel1.Location = new System.Drawing.Point(642, 19);
            this.ulPanel1.Name = "ulPanel1";
            this.ulPanel1.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ulPanel1.OuterColor2 = System.Drawing.Color.White;
            this.ulPanel1.Size = new System.Drawing.Size(108, 24);
            this.ulPanel1.Spacing = 0;
            this.ulPanel1.TabIndex = 113;
            this.ulPanel1.Text = "Condition";
            this.ulPanel1.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.ulPanel1.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // DialogBinFormulaEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1270, 559);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBinFormulaEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bin Formula";
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rankGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private DevExpress.XtraGrid.GridControl workGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView workGridView;
        private DevExpress.XtraGrid.Columns.GridColumn workIndexColumn;
        private DevExpress.XtraGrid.Columns.GridColumn workItemCodeColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox conditionCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl rankGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView rankGridView;
        private DevExpress.XtraGrid.Columns.GridColumn rankIndexColumn;
        private DevExpress.XtraGrid.Columns.GridColumn rankNameColumn;
        private Ulee.Controls.UlPanel ulPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn workItemNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn workItemRefColumn;
        private DevExpress.XtraGrid.Columns.GridColumn workBiasCHColumn;
        private DevExpress.XtraGrid.Columns.GridColumn rankLower1Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankUpper1Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankLower2Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankUpper2Column;
    }
}
