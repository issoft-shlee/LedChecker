namespace IsSoft.Sec.LedChecker
{
    partial class DialogRecipeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogRecipeList));
            this.recipeGrid = new DevExpress.XtraGrid.GridControl();
            this.recipeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.recipeNameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.recipeMemoColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.okButton);
            this.bgPanel.Controls.Add(this.cancelButton);
            this.bgPanel.Controls.Add(this.recipeGrid);
            this.bgPanel.Size = new System.Drawing.Size(412, 461);
            // 
            // recipeGrid
            // 
            this.recipeGrid.Location = new System.Drawing.Point(12, 12);
            this.recipeGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.recipeGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.recipeGrid.MainView = this.recipeGridView;
            this.recipeGrid.Name = "recipeGrid";
            this.recipeGrid.Size = new System.Drawing.Size(388, 400);
            this.recipeGrid.TabIndex = 0;
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
            this.recipeMemoColumn.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeMemoColumn.AppearanceCell.Options.UseFont = true;
            this.recipeMemoColumn.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeMemoColumn.AppearanceHeader.Options.UseFont = true;
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
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(196, 418);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.okButton.Size = new System.Drawing.Size(100, 32);
            this.okButton.TabIndex = 1;
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
            this.cancelButton.Location = new System.Drawing.Point(300, 418);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // DialogRecipeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(412, 461);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogRecipeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recipe";
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl recipeGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView recipeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn recipeNameColumn;
        private DevExpress.XtraGrid.Columns.GridColumn recipeMemoColumn;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
