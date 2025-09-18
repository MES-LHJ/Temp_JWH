namespace NewEmpManagement.Forms.Department
{
    partial class DeleteDeptForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DeptNameLable = new DevExpress.XtraEditors.LabelControl();
            this.DeptCodeLable = new DevExpress.XtraEditors.LabelControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.DeptNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.DeptCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.DeptDelMainLabel = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DeptDelLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.DeptNameLable);
            this.groupControl1.Controls.Add(this.DeptCodeLable);
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.BtnCancel);
            this.groupControl1.Controls.Add(this.DeptNameTextBox);
            this.groupControl1.Controls.Add(this.DeptCodeTextBox);
            this.groupControl1.Controls.Add(this.DeptDelMainLabel);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(424, 226);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // DeptNameLable
            // 
            this.DeptNameLable.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptNameLable.Appearance.Options.UseFont = true;
            this.DeptNameLable.Location = new System.Drawing.Point(42, 75);
            this.DeptNameLable.Name = "DeptNameLable";
            this.DeptNameLable.Size = new System.Drawing.Size(47, 17);
            this.DeptNameLable.TabIndex = 11;
            this.DeptNameLable.Text = "부서명 :";
            // 
            // DeptCodeLable
            // 
            this.DeptCodeLable.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCodeLable.Appearance.Options.UseFont = true;
            this.DeptCodeLable.Location = new System.Drawing.Point(29, 41);
            this.DeptCodeLable.Name = "DeptCodeLable";
            this.DeptCodeLable.Size = new System.Drawing.Size(65, 17);
            this.DeptCodeLable.TabIndex = 12;
            this.DeptCodeLable.Text = "부서 코드 :";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(59)))), ((int)(((byte)(22)))));
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Appearance.Options.UseBackColor = true;
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(168, 174);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(107, 29);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "삭제";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Appearance.Options.UseForeColor = true;
            this.BtnCancel.Location = new System.Drawing.Point(290, 174);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(107, 29);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "취소";
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.Location = new System.Drawing.Point(103, 72);
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.DeptNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptNameTextBox.Properties.Appearance.Options.UseBackColor = true;
            this.DeptNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.DeptNameTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DeptNameTextBox.Properties.ReadOnly = true;
            this.DeptNameTextBox.Size = new System.Drawing.Size(114, 20);
            this.DeptNameTextBox.TabIndex = 14;
            this.DeptNameTextBox.TabStop = false;
            // 
            // DeptCodeTextBox
            // 
            this.DeptCodeTextBox.Location = new System.Drawing.Point(103, 38);
            this.DeptCodeTextBox.Name = "DeptCodeTextBox";
            this.DeptCodeTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.DeptCodeTextBox.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCodeTextBox.Properties.Appearance.Options.UseBackColor = true;
            this.DeptCodeTextBox.Properties.Appearance.Options.UseFont = true;
            this.DeptCodeTextBox.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.DeptCodeTextBox.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.DeptCodeTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DeptCodeTextBox.Properties.ReadOnly = true;
            this.DeptCodeTextBox.Size = new System.Drawing.Size(114, 20);
            this.DeptCodeTextBox.TabIndex = 15;
            this.DeptCodeTextBox.TabStop = false;
            // 
            // DeptDelMainLabel
            // 
            this.DeptDelMainLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptDelMainLabel.Appearance.Options.UseFont = true;
            this.DeptDelMainLabel.Location = new System.Drawing.Point(42, 130);
            this.DeptDelMainLabel.Name = "DeptDelMainLabel";
            this.DeptDelMainLabel.Size = new System.Drawing.Size(110, 17);
            this.DeptDelMainLabel.TabIndex = 13;
            this.DeptDelMainLabel.Text = "삭제하시겠습니까?";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.DeptDelLabel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(424, 43);
            this.panelControl1.TabIndex = 4;
            // 
            // DeptDelLabel
            // 
            this.DeptDelLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptDelLabel.Appearance.Options.UseFont = true;
            this.DeptDelLabel.Location = new System.Drawing.Point(12, 13);
            this.DeptDelLabel.Name = "DeptDelLabel";
            this.DeptDelLabel.Size = new System.Drawing.Size(65, 20);
            this.DeptDelLabel.TabIndex = 0;
            this.DeptDelLabel.Text = "부서 삭제";
            // 
            // DeleteDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 269);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "DeleteDeptForm";
            this.Text = "DeleteDeptForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl DeptDelLabel;
        private DevExpress.XtraEditors.LabelControl DeptNameLable;
        private DevExpress.XtraEditors.LabelControl DeptCodeLable;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.TextEdit DeptNameTextBox;
        private DevExpress.XtraEditors.TextEdit DeptCodeTextBox;
        private DevExpress.XtraEditors.LabelControl DeptDelMainLabel;
    }
}