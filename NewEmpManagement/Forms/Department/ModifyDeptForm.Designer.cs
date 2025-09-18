namespace NewEmpManagement.Forms.Department
{
    partial class ModifyDeptForm
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
            this.components = new System.ComponentModel.Container();
            this.DeptModifyMainPanel = new DevExpress.XtraEditors.GroupControl();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.MemoTextBox = new DevExpress.XtraEditors.TextEdit();
            this.MemoLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.UDeptNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.UDpetNameLable = new DevExpress.XtraEditors.LabelControl();
            this.DeptNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.UDeptCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.DeptModifyPanel = new DevExpress.XtraEditors.PanelControl();
            this.DeptModifyLabel = new DevExpress.XtraEditors.LabelControl();
            this.UDeptCodeLookUpBox = new DevExpress.XtraEditors.LookUpEdit();
            this.upperDepartmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DeptModifyMainPanel)).BeginInit();
            this.DeptModifyMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptModifyPanel)).BeginInit();
            this.DeptModifyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptCodeLookUpBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDepartmentModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptModifyMainPanel
            // 
            this.DeptModifyMainPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.DeptModifyMainPanel.Appearance.Options.UseBackColor = true;
            this.DeptModifyMainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DeptModifyMainPanel.Controls.Add(this.BtnCancel);
            this.DeptModifyMainPanel.Controls.Add(this.BtnSave);
            this.DeptModifyMainPanel.Controls.Add(this.MemoTextBox);
            this.DeptModifyMainPanel.Controls.Add(this.MemoLabel);
            this.DeptModifyMainPanel.Controls.Add(this.DeptNameTextBox);
            this.DeptModifyMainPanel.Controls.Add(this.UDeptNameTextBox);
            this.DeptModifyMainPanel.Controls.Add(this.UDpetNameLable);
            this.DeptModifyMainPanel.Controls.Add(this.DeptNameLabel);
            this.DeptModifyMainPanel.Controls.Add(this.DeptCodeLabel);
            this.DeptModifyMainPanel.Controls.Add(this.UDeptCodeLabel);
            this.DeptModifyMainPanel.Controls.Add(this.DeptCodeTextBox);
            this.DeptModifyMainPanel.Controls.Add(this.UDeptCodeLookUpBox);
            this.DeptModifyMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeptModifyMainPanel.Location = new System.Drawing.Point(0, 43);
            this.DeptModifyMainPanel.Name = "DeptModifyMainPanel";
            this.DeptModifyMainPanel.Size = new System.Drawing.Size(485, 331);
            this.DeptModifyMainPanel.TabIndex = 5;
            this.DeptModifyMainPanel.Text = "groupControl1";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(59)))), ((int)(((byte)(22)))));
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(311, 253);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(107, 29);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "취소";
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.BtnSave.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Appearance.Options.UseBackColor = true;
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.Appearance.Options.UseForeColor = true;
            this.BtnSave.Location = new System.Drawing.Point(182, 253);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(107, 29);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "저장";
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.Location = new System.Drawing.Point(33, 199);
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(394, 22);
            this.MemoTextBox.TabIndex = 1;
            // 
            // MemoLabel
            // 
            this.MemoLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemoLabel.Appearance.Options.UseFont = true;
            this.MemoLabel.Location = new System.Drawing.Point(33, 175);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(26, 17);
            this.MemoLabel.TabIndex = 0;
            this.MemoLabel.Text = "메모";
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.Location = new System.Drawing.Point(249, 126);
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.DeptNameTextBox.TabIndex = 1;
            // 
            // UDeptNameTextBox
            // 
            this.UDeptNameTextBox.Location = new System.Drawing.Point(249, 60);
            this.UDeptNameTextBox.Name = "UDeptNameTextBox";
            this.UDeptNameTextBox.Properties.ReadOnly = true;
            this.UDeptNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.UDeptNameTextBox.TabIndex = 1;
            // 
            // UDpetNameLable
            // 
            this.UDpetNameLable.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UDpetNameLable.Appearance.ForeColor = System.Drawing.Color.Red;
            this.UDpetNameLable.Appearance.Options.UseFont = true;
            this.UDpetNameLable.Appearance.Options.UseForeColor = true;
            this.UDpetNameLable.Location = new System.Drawing.Point(249, 35);
            this.UDpetNameLable.Name = "UDpetNameLable";
            this.UDpetNameLable.Size = new System.Drawing.Size(65, 17);
            this.UDpetNameLable.TabIndex = 0;
            this.UDpetNameLable.Text = "상위부서명";
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptNameLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.DeptNameLabel.Appearance.Options.UseFont = true;
            this.DeptNameLabel.Appearance.Options.UseForeColor = true;
            this.DeptNameLabel.Location = new System.Drawing.Point(249, 102);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(39, 17);
            this.DeptNameLabel.TabIndex = 0;
            this.DeptNameLabel.Text = "부서명";
            // 
            // DeptCodeLabel
            // 
            this.DeptCodeLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptCodeLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.DeptCodeLabel.Appearance.Options.UseFont = true;
            this.DeptCodeLabel.Appearance.Options.UseForeColor = true;
            this.DeptCodeLabel.Location = new System.Drawing.Point(33, 102);
            this.DeptCodeLabel.Name = "DeptCodeLabel";
            this.DeptCodeLabel.Size = new System.Drawing.Size(52, 17);
            this.DeptCodeLabel.TabIndex = 0;
            this.DeptCodeLabel.Text = "부서코드";
            // 
            // UDeptCodeLabel
            // 
            this.UDeptCodeLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UDeptCodeLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.UDeptCodeLabel.Appearance.Options.UseFont = true;
            this.UDeptCodeLabel.Appearance.Options.UseForeColor = true;
            this.UDeptCodeLabel.Location = new System.Drawing.Point(33, 35);
            this.UDeptCodeLabel.Name = "UDeptCodeLabel";
            this.UDeptCodeLabel.Size = new System.Drawing.Size(78, 17);
            this.UDeptCodeLabel.TabIndex = 0;
            this.UDeptCodeLabel.Text = "상위부서코드";
            // 
            // DeptCodeTextBox
            // 
            this.DeptCodeTextBox.Location = new System.Drawing.Point(33, 126);
            this.DeptCodeTextBox.Name = "DeptCodeTextBox";
            this.DeptCodeTextBox.Size = new System.Drawing.Size(178, 22);
            this.DeptCodeTextBox.TabIndex = 1;
            // 
            // DeptModifyPanel
            // 
            this.DeptModifyPanel.Controls.Add(this.DeptModifyLabel);
            this.DeptModifyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeptModifyPanel.Location = new System.Drawing.Point(0, 0);
            this.DeptModifyPanel.Name = "DeptModifyPanel";
            this.DeptModifyPanel.Size = new System.Drawing.Size(485, 43);
            this.DeptModifyPanel.TabIndex = 4;
            // 
            // DeptModifyLabel
            // 
            this.DeptModifyLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptModifyLabel.Appearance.Options.UseFont = true;
            this.DeptModifyLabel.Location = new System.Drawing.Point(12, 13);
            this.DeptModifyLabel.Name = "DeptModifyLabel";
            this.DeptModifyLabel.Size = new System.Drawing.Size(65, 20);
            this.DeptModifyLabel.TabIndex = 0;
            this.DeptModifyLabel.Text = "부서 수정";
            // 
            // UDeptCodeLookUpBox
            // 
            this.UDeptCodeLookUpBox.Location = new System.Drawing.Point(33, 60);
            this.UDeptCodeLookUpBox.Name = "UDeptCodeLookUpBox";
            this.UDeptCodeLookUpBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UDeptCodeLookUpBox.Properties.DataSource = this.upperDepartmentModelBindingSource;
            this.UDeptCodeLookUpBox.Properties.DisplayMember = "UDeptCode";
            this.UDeptCodeLookUpBox.Properties.NullText = "";
            this.UDeptCodeLookUpBox.Properties.PopupSizeable = false;
            this.UDeptCodeLookUpBox.Properties.ValueMember = "UDeptID";
            this.UDeptCodeLookUpBox.Size = new System.Drawing.Size(178, 22);
            this.UDeptCodeLookUpBox.TabIndex = 1;
            // 
            // upperDepartmentModelBindingSource
            // 
            this.upperDepartmentModelBindingSource.DataSource = typeof(NewEmpManagement.Models.UpperDepartmentModel);
            // 
            // ModifyDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 374);
            this.Controls.Add(this.DeptModifyMainPanel);
            this.Controls.Add(this.DeptModifyPanel);
            this.Name = "ModifyDeptForm";
            this.Text = "ModifyDeptForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeptModifyMainPanel)).EndInit();
            this.DeptModifyMainPanel.ResumeLayout(false);
            this.DeptModifyMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptModifyPanel)).EndInit();
            this.DeptModifyPanel.ResumeLayout(false);
            this.DeptModifyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptCodeLookUpBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDepartmentModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl DeptModifyMainPanel;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.TextEdit MemoTextBox;
        private DevExpress.XtraEditors.LabelControl MemoLabel;
        private DevExpress.XtraEditors.TextEdit DeptNameTextBox;
        private DevExpress.XtraEditors.TextEdit UDeptNameTextBox;
        private DevExpress.XtraEditors.LabelControl UDpetNameLable;
        private DevExpress.XtraEditors.LabelControl DeptNameLabel;
        private DevExpress.XtraEditors.LabelControl DeptCodeLabel;
        private DevExpress.XtraEditors.LabelControl UDeptCodeLabel;
        private DevExpress.XtraEditors.TextEdit DeptCodeTextBox;
        private DevExpress.XtraEditors.PanelControl DeptModifyPanel;
        private DevExpress.XtraEditors.LabelControl DeptModifyLabel;
        private DevExpress.XtraEditors.LookUpEdit UDeptCodeLookUpBox;
        private System.Windows.Forms.BindingSource upperDepartmentModelBindingSource;
    }
}