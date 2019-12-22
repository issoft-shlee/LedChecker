namespace IsSoft.Sec.LedChecker
{
    partial class DialogRankList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogRankList));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.rankGrid = new DevExpress.XtraGrid.GridControl();
            this.rankGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rankNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowGrid = new DevExpress.XtraGrid.GridControl();
            this.rankRowGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rankRowIndexColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowLower1Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowUpper1Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowLower2Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rankRowUpper2Column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.rankRowGrid);
            this.bgPanel.Controls.Add(this.rankGrid);
            this.bgPanel.Controls.Add(this.okButton);
            this.bgPanel.Controls.Add(this.cancelButton);
            this.bgPanel.Size = new System.Drawing.Size(712, 441);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(498, 403);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.okButton.Size = new System.Drawing.Size(100, 32);
            this.okButton.TabIndex = 2;
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
            this.cancelButton.Location = new System.Drawing.Point(602, 403);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // rankGrid
            // 
            this.rankGrid.Location = new System.Drawing.Point(12, 12);
            this.rankGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.rankGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rankGrid.MainView = this.rankGridView;
            this.rankGrid.Name = "rankGrid";
            this.rankGrid.Size = new System.Drawing.Size(202, 386);
            this.rankGrid.TabIndex = 0;
            this.rankGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rankGridView});
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
            this.rankNameColumn.VisibleIndex = 0;
            this.rankNameColumn.Width = 180;
            // 
            // rankRowGrid
            // 
            this.rankRowGrid.Location = new System.Drawing.Point(220, 12);
            this.rankRowGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.rankRowGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rankRowGrid.MainView = this.rankRowGridView;
            this.rankRowGrid.Name = "rankRowGrid";
            this.rankRowGrid.Size = new System.Drawing.Size(482, 386);
            this.rankRowGrid.TabIndex = 1;
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
            this.rankRowGridView.OptionsBehavior.Editable = false;
            this.rankRowGridView.OptionsBehavior.ReadOnly = true;
            this.rankRowGridView.OptionsCustomization.AllowColumnMoving = false;
            this.rankRowGridView.OptionsCustomization.AllowColumnResizing = false;
            this.rankRowGridView.OptionsCustomization.AllowFilter = false;
            this.rankRowGridView.OptionsCustomization.AllowGroup = false;
            this.rankRowGridView.OptionsCustomization.AllowSort = false;
            this.rankRowGridView.OptionsFilter.AllowFilterEditor = false;
            this.rankRowGridView.OptionsFind.AllowFindPanel = false;
            this.rankRowGridView.OptionsNavigation.AutoMoveRowFocus = false;
            this.rankRowGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.rankRowGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.rankRowGridView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.rankRowGridView.OptionsSelection.UseIndicatorForSelection = false;
            this.rankRowGridView.OptionsView.ColumnAutoWidth = false;
            this.rankRowGridView.OptionsView.ShowDetailButtons = false;
            this.rankRowGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.rankRowGridView.OptionsView.ShowGroupPanel = false;
            this.rankRowGridView.OptionsView.ShowIndicator = false;
            this.rankRowGridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            this.rankRowGridView.Tag = 1;
            // 
            // rankRowIndexColumn
            // 
            this.rankRowIndexColumn.AppearanceCell.Options.UseTextOptions = true;
            this.rankRowIndexColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rankRowIndexColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.rankRowIndexColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rankRowIndexColumn.Caption = "No.";
            this.rankRowIndexColumn.FieldName = "ROWINDEX";
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
            this.rankRowNameColumn.FieldName = "ROWNAME";
            this.rankRowNameColumn.Name = "rankRowNameColumn";
            this.rankRowNameColumn.OptionsColumn.AllowEdit = false;
            this.rankRowNameColumn.OptionsColumn.AllowFocus = false;
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
            this.rankRowNameColumn.OptionsColumn.ReadOnly = true;
            this.rankRowNameColumn.OptionsColumn.TabStop = false;
            this.rankRowNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.rankRowNameColumn.OptionsFilter.AllowFilter = false;
            this.rankRowNameColumn.Visible = true;
            this.rankRowNameColumn.VisibleIndex = 1;
            this.rankRowNameColumn.Width = 180;
            // 
            // rankRowLower1Column
            // 
            this.rankRowLower1Column.Caption = "From";
            this.rankRowLower1Column.DisplayFormat.FormatString = "F3";
            this.rankRowLower1Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankRowLower1Column.FieldName = "LOWER1";
            this.rankRowLower1Column.MinWidth = 60;
            this.rankRowLower1Column.Name = "rankRowLower1Column";
            this.rankRowLower1Column.OptionsColumn.AllowEdit = false;
            this.rankRowLower1Column.OptionsColumn.AllowFocus = false;
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
            this.rankRowLower1Column.OptionsColumn.ReadOnly = true;
            this.rankRowLower1Column.OptionsColumn.TabStop = false;
            this.rankRowLower1Column.OptionsFilter.AllowAutoFilter = false;
            this.rankRowLower1Column.OptionsFilter.AllowFilter = false;
            this.rankRowLower1Column.Visible = true;
            this.rankRowLower1Column.VisibleIndex = 2;
            this.rankRowLower1Column.Width = 60;
            // 
            // rankRowUpper1Column
            // 
            this.rankRowUpper1Column.Caption = "To";
            this.rankRowUpper1Column.DisplayFormat.FormatString = "F3";
            this.rankRowUpper1Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankRowUpper1Column.FieldName = "UPPER1";
            this.rankRowUpper1Column.MinWidth = 60;
            this.rankRowUpper1Column.Name = "rankRowUpper1Column";
            this.rankRowUpper1Column.OptionsColumn.AllowEdit = false;
            this.rankRowUpper1Column.OptionsColumn.AllowFocus = false;
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
            this.rankRowUpper1Column.OptionsColumn.ReadOnly = true;
            this.rankRowUpper1Column.OptionsColumn.TabStop = false;
            this.rankRowUpper1Column.OptionsFilter.AllowAutoFilter = false;
            this.rankRowUpper1Column.OptionsFilter.AllowFilter = false;
            this.rankRowUpper1Column.Visible = true;
            this.rankRowUpper1Column.VisibleIndex = 3;
            this.rankRowUpper1Column.Width = 60;
            // 
            // rankRowLower2Column
            // 
            this.rankRowLower2Column.Caption = "From";
            this.rankRowLower2Column.DisplayFormat.FormatString = "F3";
            this.rankRowLower2Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankRowLower2Column.FieldName = "LOWER2";
            this.rankRowLower2Column.MinWidth = 60;
            this.rankRowLower2Column.Name = "rankRowLower2Column";
            this.rankRowLower2Column.OptionsColumn.AllowEdit = false;
            this.rankRowLower2Column.OptionsColumn.AllowFocus = false;
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
            this.rankRowLower2Column.OptionsColumn.ReadOnly = true;
            this.rankRowLower2Column.OptionsColumn.TabStop = false;
            this.rankRowLower2Column.OptionsFilter.AllowAutoFilter = false;
            this.rankRowLower2Column.OptionsFilter.AllowFilter = false;
            this.rankRowLower2Column.Visible = true;
            this.rankRowLower2Column.VisibleIndex = 4;
            this.rankRowLower2Column.Width = 60;
            // 
            // rankRowUpper2Column
            // 
            this.rankRowUpper2Column.Caption = "To";
            this.rankRowUpper2Column.DisplayFormat.FormatString = "F3";
            this.rankRowUpper2Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rankRowUpper2Column.FieldName = "UPPER2";
            this.rankRowUpper2Column.MinWidth = 60;
            this.rankRowUpper2Column.Name = "rankRowUpper2Column";
            this.rankRowUpper2Column.OptionsColumn.AllowEdit = false;
            this.rankRowUpper2Column.OptionsColumn.AllowFocus = false;
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
            this.rankRowUpper2Column.OptionsColumn.ReadOnly = true;
            this.rankRowUpper2Column.OptionsColumn.TabStop = false;
            this.rankRowUpper2Column.OptionsFilter.AllowAutoFilter = false;
            this.rankRowUpper2Column.OptionsFilter.AllowFilter = false;
            this.rankRowUpper2Column.Visible = true;
            this.rankRowUpper2Column.VisibleIndex = 5;
            this.rankRowUpper2Column.Width = 60;
            // 
            // DialogRankList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(712, 441);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogRankList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rank";
            this.Load += new System.EventHandler(this.DialogRankList_Load);
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rankGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankRowGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private DevExpress.XtraGrid.GridControl rankGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView rankGridView;
        private DevExpress.XtraGrid.Columns.GridColumn rankNameColumn;
        private DevExpress.XtraGrid.GridControl rankRowGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView rankRowGridView;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowIndexColumn;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowLower1Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowUpper1Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowLower2Column;
        private DevExpress.XtraGrid.Columns.GridColumn rankRowUpper2Column;
    }
}
