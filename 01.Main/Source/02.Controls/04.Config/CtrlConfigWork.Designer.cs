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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.testProcPanel = new Ulee.Controls.UlPanel();
            this.reportProcPanel = new Ulee.Controls.UlPanel();
            this.testPluseButton = new System.Windows.Forms.Button();
            this.testMinusButton = new System.Windows.Forms.Button();
            this.reportPluseButton = new System.Windows.Forms.Button();
            this.reportMinusButton = new System.Windows.Forms.Button();
            this.bgPanel.SuspendLayout();
            this.viewerPanel.SuspendLayout();
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
            this.viewerPanel.Controls.Add(this.reportPluseButton);
            this.viewerPanel.Controls.Add(this.reportMinusButton);
            this.viewerPanel.Controls.Add(this.testPluseButton);
            this.viewerPanel.Controls.Add(this.testMinusButton);
            this.viewerPanel.Controls.Add(this.reportProcPanel);
            this.viewerPanel.Controls.Add(this.testProcPanel);
            this.viewerPanel.Controls.Add(this.label2);
            this.viewerPanel.Controls.Add(this.label1);
            this.viewerPanel.Controls.Add(this.viewStatePanel);
            this.viewerPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewerPanel.InnerColor2 = System.Drawing.Color.White;
            this.viewerPanel.Location = new System.Drawing.Point(406, 0);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.viewerPanel.OuterColor2 = System.Drawing.Color.White;
            this.viewerPanel.Size = new System.Drawing.Size(1322, 946);
            this.viewerPanel.Spacing = 0;
            this.viewerPanel.TabIndex = 4;
            this.viewerPanel.TabStop = true;
            this.viewerPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.viewerPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Report Procedure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test Procedure";
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
            this.findButton.TabIndex = 1;
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
            this.findNameEdit.TabIndex = 0;
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
            this.recipeGrid.TabIndex = 3;
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
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "      Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // testProcPanel
            // 
            this.testProcPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.testProcPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.testProcPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.testProcPanel.InnerColor2 = System.Drawing.Color.White;
            this.testProcPanel.Location = new System.Drawing.Point(6, 64);
            this.testProcPanel.Name = "testProcPanel";
            this.testProcPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.testProcPanel.OuterColor2 = System.Drawing.Color.White;
            this.testProcPanel.Size = new System.Drawing.Size(1310, 546);
            this.testProcPanel.Spacing = 0;
            this.testProcPanel.TabIndex = 0;
            this.testProcPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.testProcPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // reportProcPanel
            // 
            this.reportProcPanel.BevelInner = Ulee.Controls.EUlBevelStyle.None;
            this.reportProcPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.reportProcPanel.InnerColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportProcPanel.InnerColor2 = System.Drawing.Color.White;
            this.reportProcPanel.Location = new System.Drawing.Point(6, 640);
            this.reportProcPanel.Name = "reportProcPanel";
            this.reportProcPanel.OuterColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.reportProcPanel.OuterColor2 = System.Drawing.Color.White;
            this.reportProcPanel.Size = new System.Drawing.Size(1310, 298);
            this.reportProcPanel.Spacing = 0;
            this.reportProcPanel.TabIndex = 1;
            this.reportProcPanel.TextHAlign = Ulee.Controls.EUlHoriAlign.Center;
            this.reportProcPanel.TextVAlign = Ulee.Controls.EUlVertAlign.Middle;
            // 
            // testPluseButton
            // 
            this.testPluseButton.Image = ((System.Drawing.Image)(resources.GetObject("testPluseButton.Image")));
            this.testPluseButton.Location = new System.Drawing.Point(1268, 38);
            this.testPluseButton.Name = "testPluseButton";
            this.testPluseButton.Size = new System.Drawing.Size(24, 24);
            this.testPluseButton.TabIndex = 130;
            this.testPluseButton.UseVisualStyleBackColor = true;
            this.testPluseButton.Click += new System.EventHandler(this.testPluseButton_Click);
            // 
            // testMinusButton
            // 
            this.testMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("testMinusButton.Image")));
            this.testMinusButton.Location = new System.Drawing.Point(1292, 38);
            this.testMinusButton.Name = "testMinusButton";
            this.testMinusButton.Size = new System.Drawing.Size(24, 24);
            this.testMinusButton.TabIndex = 131;
            this.testMinusButton.UseVisualStyleBackColor = true;
            this.testMinusButton.Click += new System.EventHandler(this.testMinusButton_Click);
            // 
            // reportPluseButton
            // 
            this.reportPluseButton.Image = ((System.Drawing.Image)(resources.GetObject("reportPluseButton.Image")));
            this.reportPluseButton.Location = new System.Drawing.Point(1268, 614);
            this.reportPluseButton.Name = "reportPluseButton";
            this.reportPluseButton.Size = new System.Drawing.Size(24, 24);
            this.reportPluseButton.TabIndex = 132;
            this.reportPluseButton.UseVisualStyleBackColor = true;
            this.reportPluseButton.Click += new System.EventHandler(this.reportPluseButton_Click);
            // 
            // reportMinusButton
            // 
            this.reportMinusButton.Image = ((System.Drawing.Image)(resources.GetObject("reportMinusButton.Image")));
            this.reportMinusButton.Location = new System.Drawing.Point(1292, 614);
            this.reportMinusButton.Name = "reportMinusButton";
            this.reportMinusButton.Size = new System.Drawing.Size(24, 24);
            this.reportMinusButton.TabIndex = 133;
            this.reportMinusButton.UseVisualStyleBackColor = true;
            this.reportMinusButton.Click += new System.EventHandler(this.reportMinusButton_Click);
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
            this.viewerPanel.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Ulee.Controls.UlPanel reportProcPanel;
        private Ulee.Controls.UlPanel testProcPanel;
        private System.Windows.Forms.Button reportPluseButton;
        private System.Windows.Forms.Button reportMinusButton;
        private System.Windows.Forms.Button testPluseButton;
        private System.Windows.Forms.Button testMinusButton;
    }
}
