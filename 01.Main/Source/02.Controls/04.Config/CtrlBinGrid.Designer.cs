namespace IsSoft.Sec.LedChecker
{
    partial class CtrlBinGrid
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
            this.binGrid = new DevExpress.XtraGrid.GridControl();
            this.binGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.binIndexColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.binNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.binT20TextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.binMarkColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.binColorEdit = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            this.binFormulaButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.binLogicLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.binTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binT20TextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binColorEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binFormulaButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binLogicLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.binGrid);
            // 
            // binGrid
            // 
            this.binGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.binGrid.Location = new System.Drawing.Point(0, 0);
            this.binGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.binGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.binGrid.MainView = this.binGridView;
            this.binGrid.Name = "binGrid";
            this.binGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.binT20TextEdit,
            this.binColorEdit,
            this.binFormulaButtonEdit,
            this.binLogicLookUpEdit});
            this.binGrid.Size = new System.Drawing.Size(300, 300);
            this.binGrid.TabIndex = 0;
            this.binGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.binGridView});
            // 
            // binGridView
            // 
            this.binGridView.ActiveFilterEnabled = false;
            this.binGridView.Appearance.Empty.Options.UseFont = true;
            this.binGridView.Appearance.EvenRow.Options.UseFont = true;
            this.binGridView.Appearance.FilterCloseButton.Options.UseFont = true;
            this.binGridView.Appearance.FilterPanel.Options.UseFont = true;
            this.binGridView.Appearance.FixedLine.Options.UseFont = true;
            this.binGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binGridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.binGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.binGridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.binGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.binGridView.Appearance.FooterPanel.Options.UseFont = true;
            this.binGridView.Appearance.GroupButton.Options.UseFont = true;
            this.binGridView.Appearance.GroupFooter.Options.UseFont = true;
            this.binGridView.Appearance.GroupPanel.Options.UseFont = true;
            this.binGridView.Appearance.GroupRow.Options.UseFont = true;
            this.binGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.binGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.binGridView.Appearance.OddRow.Options.UseFont = true;
            this.binGridView.Appearance.Preview.Options.UseFont = true;
            this.binGridView.Appearance.Row.Options.UseFont = true;
            this.binGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.binGridView.Appearance.TopNewRow.Options.UseFont = true;
            this.binGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.binGridView.ColumnPanelRowHeight = 20;
            this.binGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.binIndexColumn,
            this.binNameColumn,
            this.binMarkColumn,
            this.binTypeColumn});
            this.binGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.binGridView.GridControl = this.binGrid;
            this.binGridView.Name = "binGridView";
            this.binGridView.OptionsCustomization.AllowColumnMoving = false;
            this.binGridView.OptionsCustomization.AllowFilter = false;
            this.binGridView.OptionsCustomization.AllowGroup = false;
            this.binGridView.OptionsCustomization.AllowSort = false;
            this.binGridView.OptionsFilter.AllowFilterEditor = false;
            this.binGridView.OptionsFind.AllowFindPanel = false;
            this.binGridView.OptionsFind.ShowClearButton = false;
            this.binGridView.OptionsFind.ShowCloseButton = false;
            this.binGridView.OptionsFind.ShowFindButton = false;
            this.binGridView.OptionsFind.ShowSearchNavButtons = false;
            this.binGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.binGridView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.binGridView.OptionsSelection.InvertSelection = true;
            this.binGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.binGridView.OptionsView.ColumnAutoWidth = false;
            this.binGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.binGridView.OptionsView.ShowGroupPanel = false;
            this.binGridView.OptionsView.ShowIndicator = false;
            this.binGridView.RowHeight = 24;
            this.binGridView.Tag = 1;
            // 
            // binIndexColumn
            // 
            this.binIndexColumn.AppearanceCell.Options.UseTextOptions = true;
            this.binIndexColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binIndexColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.binIndexColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binIndexColumn.Caption = "Bin";
            this.binIndexColumn.FieldName = "Index";
            this.binIndexColumn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.binIndexColumn.Name = "binIndexColumn";
            this.binIndexColumn.OptionsColumn.AllowEdit = false;
            this.binIndexColumn.OptionsColumn.AllowFocus = false;
            this.binIndexColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.binIndexColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.binIndexColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.binIndexColumn.OptionsColumn.AllowMove = false;
            this.binIndexColumn.OptionsColumn.AllowShowHide = false;
            this.binIndexColumn.OptionsColumn.AllowSize = false;
            this.binIndexColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.binIndexColumn.OptionsColumn.FixedWidth = true;
            this.binIndexColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.binIndexColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.binIndexColumn.OptionsColumn.TabStop = false;
            this.binIndexColumn.OptionsFilter.AllowAutoFilter = false;
            this.binIndexColumn.OptionsFilter.AllowFilter = false;
            this.binIndexColumn.Visible = true;
            this.binIndexColumn.VisibleIndex = 0;
            this.binIndexColumn.Width = 40;
            // 
            // binNameColumn
            // 
            this.binNameColumn.Caption = "Name";
            this.binNameColumn.FieldName = "Name";
            this.binNameColumn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.binNameColumn.Name = "binNameColumn";
            this.binNameColumn.OptionsColumn.AllowEdit = false;
            this.binNameColumn.OptionsColumn.AllowFocus = false;
            this.binNameColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.binNameColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.binNameColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.binNameColumn.OptionsColumn.AllowMove = false;
            this.binNameColumn.OptionsColumn.AllowShowHide = false;
            this.binNameColumn.OptionsColumn.AllowSize = false;
            this.binNameColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.binNameColumn.OptionsColumn.FixedWidth = true;
            this.binNameColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.binNameColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.binNameColumn.OptionsFilter.AllowAutoFilter = false;
            this.binNameColumn.OptionsFilter.AllowFilter = false;
            this.binNameColumn.Visible = true;
            this.binNameColumn.VisibleIndex = 1;
            this.binNameColumn.Width = 100;
            // 
            // binT20TextEdit
            // 
            this.binT20TextEdit.AutoHeight = false;
            this.binT20TextEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.binT20TextEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.binT20TextEdit.MaxLength = 20;
            this.binT20TextEdit.Name = "binT20TextEdit";
            // 
            // binMarkColumn
            // 
            this.binMarkColumn.AppearanceCell.Options.UseTextOptions = true;
            this.binMarkColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binMarkColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.binMarkColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binMarkColumn.Caption = "Mark";
            this.binMarkColumn.ColumnEdit = this.binColorEdit;
            this.binMarkColumn.FieldName = "Mark";
            this.binMarkColumn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.binMarkColumn.Name = "binMarkColumn";
            this.binMarkColumn.OptionsColumn.AllowEdit = false;
            this.binMarkColumn.OptionsColumn.AllowFocus = false;
            this.binMarkColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.binMarkColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.binMarkColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.binMarkColumn.OptionsColumn.AllowMove = false;
            this.binMarkColumn.OptionsColumn.AllowShowHide = false;
            this.binMarkColumn.OptionsColumn.AllowSize = false;
            this.binMarkColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.binMarkColumn.OptionsColumn.FixedWidth = true;
            this.binMarkColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.binMarkColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.binMarkColumn.OptionsFilter.AllowAutoFilter = false;
            this.binMarkColumn.OptionsFilter.AllowFilter = false;
            this.binMarkColumn.Visible = true;
            this.binMarkColumn.VisibleIndex = 2;
            this.binMarkColumn.Width = 48;
            // 
            // binColorEdit
            // 
            this.binColorEdit.Appearance.Options.UseFont = true;
            this.binColorEdit.Appearance.Options.UseTextOptions = true;
            this.binColorEdit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binColorEdit.AppearanceDropDown.Options.UseTextOptions = true;
            this.binColorEdit.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binColorEdit.AppearanceFocused.Options.UseTextOptions = true;
            this.binColorEdit.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binColorEdit.AppearanceReadOnly.Options.UseTextOptions = true;
            this.binColorEdit.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binColorEdit.AutoHeight = false;
            this.binColorEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.binColorEdit.ColorAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binColorEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.binColorEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.binColorEdit.Name = "binColorEdit";
            this.binColorEdit.ShowColorDialog = false;
            this.binColorEdit.ShowCustomColors = false;
            this.binColorEdit.ShowMoreColorsButton = false;
            this.binColorEdit.ShowPopupShadow = false;
            this.binColorEdit.ShowSystemColors = false;
            // 
            // binFormulaButtonEdit
            // 
            this.binFormulaButtonEdit.AutoHeight = false;
            this.binFormulaButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.binFormulaButtonEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.binFormulaButtonEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.binFormulaButtonEdit.Name = "binFormulaButtonEdit";
            this.binFormulaButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.binFormulaButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.binFormulaButtonEdit_ButtonClick);
            // 
            // binLogicLookUpEdit
            // 
            this.binLogicLookUpEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.binLogicLookUpEdit.AutoHeight = false;
            this.binLogicLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.binLogicLookUpEdit.BestFitRowCount = 2;
            this.binLogicLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.binLogicLookUpEdit.DropDownRows = 2;
            this.binLogicLookUpEdit.HideSelection = false;
            this.binLogicLookUpEdit.LookAndFeel.SkinName = "DevExpress Style";
            this.binLogicLookUpEdit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.binLogicLookUpEdit.Name = "binLogicLookUpEdit";
            this.binLogicLookUpEdit.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.binLogicLookUpEdit.ShowFooter = false;
            this.binLogicLookUpEdit.ShowHeader = false;
            this.binLogicLookUpEdit.UseReadOnlyAppearance = false;
            // 
            // binTypeColumn
            // 
            this.binTypeColumn.AppearanceCell.Options.UseTextOptions = true;
            this.binTypeColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binTypeColumn.AppearanceHeader.Options.UseTextOptions = true;
            this.binTypeColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.binTypeColumn.Caption = "Type";
            this.binTypeColumn.FieldName = "Type";
            this.binTypeColumn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.binTypeColumn.Name = "binTypeColumn";
            this.binTypeColumn.OptionsColumn.AllowEdit = false;
            this.binTypeColumn.OptionsColumn.AllowFocus = false;
            this.binTypeColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.binTypeColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.binTypeColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.binTypeColumn.OptionsColumn.AllowMove = false;
            this.binTypeColumn.OptionsColumn.AllowShowHide = false;
            this.binTypeColumn.OptionsColumn.AllowSize = false;
            this.binTypeColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.binTypeColumn.OptionsColumn.FixedWidth = true;
            this.binTypeColumn.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.binTypeColumn.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.binTypeColumn.OptionsFilter.AllowAutoFilter = false;
            this.binTypeColumn.OptionsFilter.AllowFilter = false;
            this.binTypeColumn.Visible = true;
            this.binTypeColumn.VisibleIndex = 3;
            this.binTypeColumn.Width = 48;
            // 
            // CtrlBinGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlBinGrid";
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.binGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binT20TextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binColorEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binFormulaButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binLogicLookUpEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl binGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView binGridView;
        private DevExpress.XtraGrid.Columns.GridColumn binIndexColumn;
        private DevExpress.XtraGrid.Columns.GridColumn binNameColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit binT20TextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn binMarkColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorEdit binColorEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit binFormulaButtonEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit binLogicLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn binTypeColumn;
    }
}
