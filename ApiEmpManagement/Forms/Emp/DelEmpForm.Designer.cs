namespace ApiEmpManagement.Forms.Emp
{
    partial class DelEmpForm
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.EmpNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmpCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmpDelTextLabel = new DevExpress.XtraEditors.LabelControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.EmpNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.EmpCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.EmpDelMainPanel = new DevExpress.XtraEditors.PanelControl();
            this.EmpDelLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDelMainPanel)).BeginInit();
            this.EmpDelMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.EmpNameLabel);
            this.panelControl2.Controls.Add(this.EmpCodeLabel);
            this.panelControl2.Controls.Add(this.EmpDelTextLabel);
            this.panelControl2.Controls.Add(this.BtnDelete);
            this.panelControl2.Controls.Add(this.BtnCancel);
            this.panelControl2.Controls.Add(this.EmpNameTextBox);
            this.panelControl2.Controls.Add(this.EmpCodeTextBox);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(436, 218);
            this.panelControl2.TabIndex = 4;
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmpNameLabel.Appearance.Options.UseFont = true;
            this.EmpNameLabel.Location = new System.Drawing.Point(47, 59);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(55, 21);
            this.EmpNameLabel.TabIndex = 0;
            this.EmpNameLabel.Text = "사원명 :";
            // 
            // EmpCodeLabel
            // 
            this.EmpCodeLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmpCodeLabel.Appearance.Options.UseFont = true;
            this.EmpCodeLabel.Location = new System.Drawing.Point(34, 27);
            this.EmpCodeLabel.Name = "EmpCodeLabel";
            this.EmpCodeLabel.Size = new System.Drawing.Size(71, 21);
            this.EmpCodeLabel.TabIndex = 0;
            this.EmpCodeLabel.Text = "사원코드 :";
            // 
            // EmpDelTextLabel
            // 
            this.EmpDelTextLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmpDelTextLabel.Appearance.Options.UseFont = true;
            this.EmpDelTextLabel.Location = new System.Drawing.Point(47, 110);
            this.EmpDelTextLabel.Name = "EmpDelTextLabel";
            this.EmpDelTextLabel.Size = new System.Drawing.Size(135, 21);
            this.EmpDelTextLabel.TabIndex = 1;
            this.EmpDelTextLabel.Text = "삭제하시겠습니까?";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDelete.Appearance.Options.UseBackColor = true;
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(173, 151);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(107, 27);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "삭제";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Appearance.Options.UseForeColor = true;
            this.BtnCancel.Location = new System.Drawing.Point(295, 151);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(107, 27);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "취소";
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.Location = new System.Drawing.Point(108, 56);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Properties.AllowFocused = false;
            this.EmpNameTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.EmpNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmpNameTextBox.Properties.Appearance.Options.UseBackColor = true;
            this.EmpNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.EmpNameTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.EmpNameTextBox.Properties.ReadOnly = true;
            this.EmpNameTextBox.Size = new System.Drawing.Size(114, 26);
            this.EmpNameTextBox.TabIndex = 2;
            // 
            // EmpCodeTextBox
            // 
            this.EmpCodeTextBox.Location = new System.Drawing.Point(108, 24);
            this.EmpCodeTextBox.Name = "EmpCodeTextBox";
            this.EmpCodeTextBox.Properties.AllowFocused = false;
            this.EmpCodeTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.EmpCodeTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmpCodeTextBox.Properties.Appearance.Options.UseBackColor = true;
            this.EmpCodeTextBox.Properties.Appearance.Options.UseFont = true;
            this.EmpCodeTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.EmpCodeTextBox.Properties.ReadOnly = true;
            this.EmpCodeTextBox.Size = new System.Drawing.Size(114, 26);
            this.EmpCodeTextBox.TabIndex = 2;
            // 
            // EmpDelMainPanel
            // 
            this.EmpDelMainPanel.Controls.Add(this.EmpDelLabel);
            this.EmpDelMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpDelMainPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpDelMainPanel.Name = "EmpDelMainPanel";
            this.EmpDelMainPanel.Size = new System.Drawing.Size(436, 39);
            this.EmpDelMainPanel.TabIndex = 3;
            // 
            // EmpDelLabel
            // 
            this.EmpDelLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.EmpDelLabel.Appearance.Options.UseFont = true;
            this.EmpDelLabel.Location = new System.Drawing.Point(12, 9);
            this.EmpDelLabel.Name = "EmpDelLabel";
            this.EmpDelLabel.Size = new System.Drawing.Size(65, 20);
            this.EmpDelLabel.TabIndex = 0;
            this.EmpDelLabel.Text = "사원 삭제";
            // 
            // DelEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 257);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.EmpDelMainPanel);
            this.Name = "DelEmpForm";
            this.Text = "DelEmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDelMainPanel)).EndInit();
            this.EmpDelMainPanel.ResumeLayout(false);
            this.EmpDelMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl EmpNameLabel;
        private DevExpress.XtraEditors.LabelControl EmpCodeLabel;
        private DevExpress.XtraEditors.LabelControl EmpDelTextLabel;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.TextEdit EmpNameTextBox;
        private DevExpress.XtraEditors.TextEdit EmpCodeTextBox;
        private DevExpress.XtraEditors.PanelControl EmpDelMainPanel;
        private DevExpress.XtraEditors.LabelControl EmpDelLabel;
    }
}