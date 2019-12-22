namespace IsSoft.Sec.LedChecker
{
    partial class DialogSmuSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogSmuSelector));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.smuGrid = new DevExpress.XtraGrid.GridControl();
            this.smuGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smuGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.smuGrid);
            this.bgPanel.Controls.Add(this.okButton);
            this.bgPanel.Controls.Add(this.cancelButton);
            this.bgPanel.Size = new System.Drawing.Size(842, 99);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(634, 60);
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
            this.cancelButton.Location = new System.Drawing.Point(736, 60);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // smuGrid
            // 
            this.smuGrid.Location = new System.Drawing.Point(6, 6);
            this.smuGrid.MainView = this.smuGridView;
            this.smuGrid.Name = "smuGrid";
            this.smuGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.smuGrid.Size = new System.Drawing.Size(830, 50);
            this.smuGrid.TabIndex = 98;
            this.smuGrid.TabStop = false;
            this.smuGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.smuGridView,
            this.gridView1});
            // 
            // smuGridView
            // 
            this.smuGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.FixedLine.Options.UseFont = true;
            this.smuGridView.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smuGridView.Appearance.FocusedCell.Options.UseFont = true;
            this.smuGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.FocusedRow.Options.UseFont = true;
            this.smuGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.smuGridView.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.HideSelectionRow.Options.UseFont = true;
            this.smuGridView.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.OddRow.Options.UseFont = true;
            this.smuGridView.Appearance.Preview.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.Preview.Options.UseFont = true;
            this.smuGridView.Appearance.Row.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.Row.Options.UseFont = true;
            this.smuGridView.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.SelectedRow.Options.UseFont = true;
            this.smuGridView.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 9F);
            this.smuGridView.Appearance.ViewCaption.Options.UseFont = true;
            this.smuGridView.ColumnPanelRowHeight = 20;
            this.smuGridView.CustomizationFormBounds = new System.Drawing.Rectangle(1710, 580, 210, 186);
            this.smuGridView.GridControl = this.smuGrid;
            this.smuGridView.Name = "smuGridView";
            this.smuGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.smuGridView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.smuGridView.OptionsSelection.InvertSelection = true;
            this.smuGridView.OptionsView.ColumnAutoWidth = false;
            this.smuGridView.OptionsView.ShowGroupPanel = false;
            this.smuGridView.OptionsView.ShowIndicator = false;
            this.smuGridView.RowHeight = 25;
            this.smuGridView.Tag = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.smuGrid;
            this.gridView1.Name = "gridView1";
            // 
            // DialogSmuSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(842, 99);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogSmuSelector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bias Channel";
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smuGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private DevExpress.XtraGrid.GridControl smuGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView smuGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
