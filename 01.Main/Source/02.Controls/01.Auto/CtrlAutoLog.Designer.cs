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
            this.totalLogEdit = new System.Windows.Forms.TextBox();
            this.logTab = new System.Windows.Forms.TabControl();
            this.totalLogPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.testLogEdit = new System.Windows.Forms.TextBox();
            this.bgPanel.SuspendLayout();
            this.logTab.SuspendLayout();
            this.totalLogPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgPanel
            // 
            this.bgPanel.BevelOuter = Ulee.Controls.EUlBevelStyle.None;
            this.bgPanel.Controls.Add(this.logTab);
            this.bgPanel.Size = new System.Drawing.Size(1728, 892);
            // 
            // totalLogEdit
            // 
            this.totalLogEdit.BackColor = System.Drawing.Color.FloralWhite;
            this.totalLogEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLogEdit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLogEdit.Location = new System.Drawing.Point(2, 2);
            this.totalLogEdit.MaxLength = 131071;
            this.totalLogEdit.Multiline = true;
            this.totalLogEdit.Name = "totalLogEdit";
            this.totalLogEdit.ReadOnly = true;
            this.totalLogEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.totalLogEdit.Size = new System.Drawing.Size(1716, 858);
            this.totalLogEdit.TabIndex = 5;
            this.totalLogEdit.TabStop = false;
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.totalLogPage);
            this.logTab.Controls.Add(this.tabPage2);
            this.logTab.Location = new System.Drawing.Point(0, 0);
            this.logTab.Margin = new System.Windows.Forms.Padding(4);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Drawing.Point(6, 4);
            this.logTab.SelectedIndex = 0;
            this.logTab.Size = new System.Drawing.Size(1728, 892);
            this.logTab.TabIndex = 6;
            // 
            // totalLogPage
            // 
            this.totalLogPage.Controls.Add(this.totalLogEdit);
            this.totalLogPage.Location = new System.Drawing.Point(4, 26);
            this.totalLogPage.Margin = new System.Windows.Forms.Padding(2);
            this.totalLogPage.Name = "totalLogPage";
            this.totalLogPage.Padding = new System.Windows.Forms.Padding(2);
            this.totalLogPage.Size = new System.Drawing.Size(1720, 862);
            this.totalLogPage.TabIndex = 0;
            this.totalLogPage.Text = "  TOTAL  ";
            this.totalLogPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.testLogEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1720, 862);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  TEST  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // testLogEdit
            // 
            this.testLogEdit.BackColor = System.Drawing.Color.FloralWhite;
            this.testLogEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testLogEdit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLogEdit.Location = new System.Drawing.Point(2, 2);
            this.testLogEdit.MaxLength = 131071;
            this.testLogEdit.Multiline = true;
            this.testLogEdit.Name = "testLogEdit";
            this.testLogEdit.ReadOnly = true;
            this.testLogEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.testLogEdit.Size = new System.Drawing.Size(1716, 858);
            this.testLogEdit.TabIndex = 6;
            this.testLogEdit.TabStop = false;
            // 
            // CtrlAutoLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CtrlAutoLog";
            this.Size = new System.Drawing.Size(1728, 892);
            this.Load += new System.EventHandler(this.CtrlAutoLog_Load);
            this.bgPanel.ResumeLayout(false);
            this.logTab.ResumeLayout(false);
            this.totalLogPage.ResumeLayout(false);
            this.totalLogPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalLogEdit;
        private System.Windows.Forms.TabControl logTab;
        private System.Windows.Forms.TabPage totalLogPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox testLogEdit;
    }
}
