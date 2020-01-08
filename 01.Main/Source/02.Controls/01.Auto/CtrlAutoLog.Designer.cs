namespace IsSoft.Sec.LedChecker
{
    partial class CtrlAutoLog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logEdit = new System.Windows.Forms.TextBox();
            this.bgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelInner = Ulee.Controls.EUlBevelStyle.Raised;
            this.bgPanel.Controls.Add(this.logEdit);
            this.bgPanel.Size = new System.Drawing.Size(1728, 892);
            // 
            // logEdit
            // 
            this.logEdit.BackColor = System.Drawing.Color.FloralWhite;
            this.logEdit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logEdit.Location = new System.Drawing.Point(6, 6);
            this.logEdit.MaxLength = 131071;
            this.logEdit.Multiline = true;
            this.logEdit.Name = "logEdit";
            this.logEdit.ReadOnly = true;
            this.logEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logEdit.Size = new System.Drawing.Size(1716, 880);
            this.logEdit.TabIndex = 5;
            this.logEdit.TabStop = false;
            // 
            // CtrlAutoLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CtrlAutoLog";
            this.Size = new System.Drawing.Size(1728, 892);
            this.Load += new System.EventHandler(this.CtrlAutoLog_Load);
            this.bgPanel.ResumeLayout(false);
            this.bgPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logEdit;
    }
}
