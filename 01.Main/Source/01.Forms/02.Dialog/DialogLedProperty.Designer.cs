namespace IsSoft.Sec.LedChecker
{
    partial class DialogLedProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogLedProperty));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.stringNoEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ledNoEdit = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.turnOnCheck = new System.Windows.Forms.CheckBox();
            this.measuringCheck = new System.Windows.Forms.CheckBox();
            this.enabledGroup = new System.Windows.Forms.GroupBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stringNoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNoEdit.Properties)).BeginInit();
            this.enabledGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.Controls.Add(this.typeCombo);
            this.bgPanel.Controls.Add(this.label4);
            this.bgPanel.Controls.Add(this.enabledGroup);
            this.bgPanel.Controls.Add(this.okButton);
            this.bgPanel.Controls.Add(this.cancelButton);
            this.bgPanel.Size = new System.Drawing.Size(398, 191);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Image = ((System.Drawing.Image)(resources.GetObject("okButton.Image")));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(180, 152);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.okButton.Size = new System.Drawing.Size(100, 32);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(282, 152);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.cancelButton.Size = new System.Drawing.Size(100, 32);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // stringNoEdit
            // 
            this.stringNoEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stringNoEdit.EnterMoveNextControl = true;
            this.stringNoEdit.Location = new System.Drawing.Point(85, 34);
            this.stringNoEdit.Name = "stringNoEdit";
            this.stringNoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.stringNoEdit.Properties.Appearance.Options.UseFont = true;
            this.stringNoEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stringNoEdit.Properties.IsFloatValue = false;
            this.stringNoEdit.Properties.Mask.EditMask = "N0";
            this.stringNoEdit.Properties.MaxLength = 3;
            this.stringNoEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.stringNoEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stringNoEdit.Size = new System.Drawing.Size(68, 22);
            this.stringNoEdit.TabIndex = 0;
            // 
            // ledNoEdit
            // 
            this.ledNoEdit.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ledNoEdit.EnterMoveNextControl = true;
            this.ledNoEdit.Location = new System.Drawing.Point(274, 34);
            this.ledNoEdit.Name = "ledNoEdit";
            this.ledNoEdit.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9F);
            this.ledNoEdit.Properties.Appearance.Options.UseFont = true;
            this.ledNoEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ledNoEdit.Properties.IsFloatValue = false;
            this.ledNoEdit.Properties.Mask.EditMask = "N0";
            this.ledNoEdit.Properties.MaxLength = 3;
            this.ledNoEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ledNoEdit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ledNoEdit.Size = new System.Drawing.Size(68, 22);
            this.ledNoEdit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "String No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 105;
            this.label1.Text = "LED No.";
            // 
            // turnOnCheck
            // 
            this.turnOnCheck.AutoSize = true;
            this.turnOnCheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnOnCheck.Location = new System.Drawing.Point(21, 68);
            this.turnOnCheck.Name = "turnOnCheck";
            this.turnOnCheck.Size = new System.Drawing.Size(70, 19);
            this.turnOnCheck.TabIndex = 2;
            this.turnOnCheck.Text = "Turn On";
            this.turnOnCheck.UseVisualStyleBackColor = true;
            // 
            // measuringCheck
            // 
            this.measuringCheck.AutoSize = true;
            this.measuringCheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measuringCheck.Location = new System.Drawing.Point(220, 68);
            this.measuringCheck.Name = "measuringCheck";
            this.measuringCheck.Size = new System.Drawing.Size(84, 19);
            this.measuringCheck.TabIndex = 3;
            this.measuringCheck.Text = "Measuring";
            this.measuringCheck.UseVisualStyleBackColor = true;
            // 
            // enabledGroup
            // 
            this.enabledGroup.Controls.Add(this.measuringCheck);
            this.enabledGroup.Controls.Add(this.label1);
            this.enabledGroup.Controls.Add(this.turnOnCheck);
            this.enabledGroup.Controls.Add(this.stringNoEdit);
            this.enabledGroup.Controls.Add(this.ledNoEdit);
            this.enabledGroup.Controls.Add(this.label3);
            this.enabledGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabledGroup.Location = new System.Drawing.Point(16, 38);
            this.enabledGroup.Name = "enabledGroup";
            this.enabledGroup.Size = new System.Drawing.Size(366, 108);
            this.enabledGroup.TabIndex = 106;
            this.enabledGroup.TabStop = false;
            // 
            // typeCombo
            // 
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(63, 13);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(319, 23);
            this.typeCombo.TabIndex = 108;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.recipeCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 107;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // DialogLedProperty
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(398, 191);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogLedProperty";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LED Properties";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogLedProperty_FormClosed);
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stringNoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNoEdit.Properties)).EndInit();
            this.enabledGroup.ResumeLayout(false);
            this.enabledGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        public DevExpress.XtraEditors.SpinEdit stringNoEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.SpinEdit ledNoEdit;
        private System.Windows.Forms.CheckBox measuringCheck;
        private System.Windows.Forms.CheckBox turnOnCheck;
        private System.Windows.Forms.GroupBox enabledGroup;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Label label4;
    }
}
