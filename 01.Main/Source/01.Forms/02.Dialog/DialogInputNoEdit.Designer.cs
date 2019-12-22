namespace IsSoft.Sec.LedChecker
{
    partial class DialogInputNoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogInputNoEdit));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.inputNoEdit = new DevExpress.XtraEditors.TextEdit();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputNoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.inputNoEdit);
            this.bgPanel.Controls.Add(this.okButton);
            this.bgPanel.Controls.Add(this.cancelButton);
            this.bgPanel.Size = new System.Drawing.Size(234, 115);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(16, 74);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.okButton.Size = new System.Drawing.Size(100, 32);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(118, 74);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // inputNoEdit
            // 
            this.inputNoEdit.EditValue = "";
            this.inputNoEdit.Location = new System.Drawing.Point(16, 29);
            this.inputNoEdit.Name = "inputNoEdit";
            this.inputNoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNoEdit.Properties.Appearance.Options.UseFont = true;
            this.inputNoEdit.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNoEdit.Properties.AppearanceDisabled.Options.UseFont = true;
            this.inputNoEdit.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNoEdit.Properties.AppearanceFocused.Options.UseFont = true;
            this.inputNoEdit.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNoEdit.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.inputNoEdit.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.inputNoEdit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.inputNoEdit.Properties.MaxLength = 30;
            this.inputNoEdit.Size = new System.Drawing.Size(202, 22);
            this.inputNoEdit.TabIndex = 0;
            // 
            // DialogInputNoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(234, 115);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogInputNoEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputNoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        public DevExpress.XtraEditors.TextEdit inputNoEdit;
    }
}
