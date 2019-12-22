namespace IsSoft.Sec.LedChecker
{
    partial class CtrlPatternGrid
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
            this.patternGrid = new DevExpress.XtraGrid.GridControl();
            this.patternGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patternGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.patternGrid);
            // 
            // patternGrid
            // 
            this.patternGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patternGrid.Location = new System.Drawing.Point(0, 0);
            this.patternGrid.LookAndFeel.SkinName = "DevExpress Style";
            this.patternGrid.LookAndFeel.UseDefaultLookAndFeel = false;
            this.patternGrid.MainView = this.patternGridView;
            this.patternGrid.Name = "patternGrid";
            this.patternGrid.Size = new System.Drawing.Size(300, 300);
            this.patternGrid.TabIndex = 97;
            this.patternGrid.TabStop = false;
            this.patternGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.patternGridView});
            // 
            // patternGridView
            // 
            this.patternGridView.Appearance.FixedLine.Options.UseFont = true;
            this.patternGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patternGridView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.patternGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.patternGridView.Appearance.FocusedCell.Options.UseForeColor = true;
            this.patternGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.patternGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.patternGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.patternGridView.Appearance.OddRow.Options.UseFont = true;
            this.patternGridView.Appearance.Preview.Options.UseFont = true;
            this.patternGridView.Appearance.Row.Options.UseFont = true;
            this.patternGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.patternGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.patternGridView.ColumnPanelRowHeight = 20;
            this.patternGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.patternGridView.GridControl = this.patternGrid;
            this.patternGridView.Name = "patternGridView";
            this.patternGridView.OptionsBehavior.Editable = false;
            this.patternGridView.OptionsBehavior.ReadOnly = true;
            this.patternGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.patternGridView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.patternGridView.OptionsSelection.InvertSelection = true;
            this.patternGridView.OptionsView.ColumnAutoWidth = false;
            this.patternGridView.OptionsView.ShowGroupPanel = false;
            this.patternGridView.OptionsView.ShowIndicator = false;
            this.patternGridView.RowHeight = 25;
            this.patternGridView.Tag = 1;
            this.patternGridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.patternGridView_CustomDrawCell);
            this.patternGridView.DoubleClick += new System.EventHandler(this.patternGridView_DoubleClick);
            // 
            // CtrlPatternGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.Name = "CtrlPatternGrid";
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patternGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patternGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl patternGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView patternGridView;
    }
}
