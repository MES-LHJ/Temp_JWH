namespace NewEmpManagement.Forms.Department
{
    partial class AddDeptForm
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
            this.DeptAddMainPanel = new DevExpress.XtraEditors.GroupControl();
            this.UDeptCodeLookUpBox = new DevExpress.XtraEditors.LookUpEdit();
            this.upperDepartmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.MemoTextBox = new DevExpress.XtraEditors.TextEdit();
            this.Memo = new DevExpress.XtraEditors.LabelControl();
            this.DeptNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.UDeptNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.UdeptNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.UDeptCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.DeptAddPanel = new DevExpress.XtraEditors.PanelControl();
            this.DeptAddLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.DeptAddMainPanel)).BeginInit();
            this.DeptAddMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptCodeLookUpBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDepartmentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptAddPanel)).BeginInit();
            this.DeptAddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeptAddMainPanel
            // 
            this.DeptAddMainPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.DeptAddMainPanel.Appearance.Options.UseBackColor = true;
            this.DeptAddMainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DeptAddMainPanel.Controls.Add(this.UDeptCodeLookUpBox);
            this.DeptAddMainPanel.Controls.Add(this.BtnCancel);
            this.DeptAddMainPanel.Controls.Add(this.BtnSave);
            this.DeptAddMainPanel.Controls.Add(this.MemoTextBox);
            this.DeptAddMainPanel.Controls.Add(this.Memo);
            this.DeptAddMainPanel.Controls.Add(this.DeptNameTextBox);
            this.DeptAddMainPanel.Controls.Add(this.UDeptNameTextBox);
            this.DeptAddMainPanel.Controls.Add(this.UdeptNameLabel);
            this.DeptAddMainPanel.Controls.Add(this.DeptNameLabel);
            this.DeptAddMainPanel.Controls.Add(this.DeptCodeLabel);
            this.DeptAddMainPanel.Controls.Add(this.UDeptCodeLabel);
            this.DeptAddMainPanel.Controls.Add(this.DeptCodeTextBox);
            this.DeptAddMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeptAddMainPanel.Location = new System.Drawing.Point(0, 43);
            this.DeptAddMainPanel.Name = "DeptAddMainPanel";
            this.DeptAddMainPanel.Size = new System.Drawing.Size(459, 321);
            this.DeptAddMainPanel.TabIndex = 3;
            this.DeptAddMainPanel.Text = "groupControl1";
            // 
            // UDeptCodeLookUpBox
            // 
            this.UDeptCodeLookUpBox.Location = new System.Drawing.Point(33, 58);
            this.UDeptCodeLookUpBox.Name = "UDeptCodeLookUpBox";
            this.UDeptCodeLookUpBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UDeptCodeLookUpBox.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UDeptCode", "상위부서코드", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UDeptName", "Name", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.UDeptCodeLookUpBox.Properties.DataSource = this.upperDepartmentModelBindingSource;
            this.UDeptCodeLookUpBox.Properties.DisplayMember = "UDeptCode";
            this.UDeptCodeLookUpBox.Properties.NullText = "";
            this.UDeptCodeLookUpBox.Properties.ValueMember = "UDeptID";
            this.UDeptCodeLookUpBox.Size = new System.Drawing.Size(178, 22);
            this.UDeptCodeLookUpBox.TabIndex = 9;
            // 
            // upperDepartmentModelBindingSource
            // 
            this.upperDepartmentModelBindingSource.DataSource = typeof(NewEmpManagement.Models.UpperDepartmentModel);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Appearance.Options.UseForeColor = true;
            this.BtnCancel.Location = new System.Drawing.Point(311, 253);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(107, 29);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "취소";
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(182)))));
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            // Memo
            // 
            this.Memo.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Memo.Appearance.Options.UseFont = true;
            this.Memo.Location = new System.Drawing.Point(33, 175);
            this.Memo.Name = "Memo";
            this.Memo.Size = new System.Drawing.Size(32, 21);
            this.Memo.TabIndex = 0;
            this.Memo.Text = "메모";
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
            // UdeptNameLabel
            // 
            this.UdeptNameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UdeptNameLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.UdeptNameLabel.Appearance.Options.UseFont = true;
            this.UdeptNameLabel.Appearance.Options.UseForeColor = true;
            this.UdeptNameLabel.Location = new System.Drawing.Point(249, 35);
            this.UdeptNameLabel.Name = "UdeptNameLabel";
            this.UdeptNameLabel.Size = new System.Drawing.Size(80, 21);
            this.UdeptNameLabel.TabIndex = 0;
            this.UdeptNameLabel.Text = "상위부서명";
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeptNameLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.DeptNameLabel.Appearance.Options.UseFont = true;
            this.DeptNameLabel.Appearance.Options.UseForeColor = true;
            this.DeptNameLabel.Location = new System.Drawing.Point(249, 102);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(48, 21);
            this.DeptNameLabel.TabIndex = 0;
            this.DeptNameLabel.Text = "부서명";
            // 
            // DeptCodeLabel
            // 
            this.DeptCodeLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeptCodeLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.DeptCodeLabel.Appearance.Options.UseFont = true;
            this.DeptCodeLabel.Appearance.Options.UseForeColor = true;
            this.DeptCodeLabel.Location = new System.Drawing.Point(33, 102);
            this.DeptCodeLabel.Name = "DeptCodeLabel";
            this.DeptCodeLabel.Size = new System.Drawing.Size(64, 21);
            this.DeptCodeLabel.TabIndex = 0;
            this.DeptCodeLabel.Text = "부서코드";
            // 
            // UDeptCodeLabel
            // 
            this.UDeptCodeLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDeptCodeLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.UDeptCodeLabel.Appearance.Options.UseFont = true;
            this.UDeptCodeLabel.Appearance.Options.UseForeColor = true;
            this.UDeptCodeLabel.Location = new System.Drawing.Point(33, 35);
            this.UDeptCodeLabel.Name = "UDeptCodeLabel";
            this.UDeptCodeLabel.Size = new System.Drawing.Size(96, 21);
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
            // DeptAddPanel
            // 
            this.DeptAddPanel.Controls.Add(this.DeptAddLabel);
            this.DeptAddPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeptAddPanel.Location = new System.Drawing.Point(0, 0);
            this.DeptAddPanel.Name = "DeptAddPanel";
            this.DeptAddPanel.Size = new System.Drawing.Size(459, 43);
            this.DeptAddPanel.TabIndex = 2;
            // 
            // DeptAddLabel
            // 
            this.DeptAddLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptAddLabel.Appearance.Options.UseFont = true;
            this.DeptAddLabel.Location = new System.Drawing.Point(12, 13);
            this.DeptAddLabel.Name = "DeptAddLabel";
            this.DeptAddLabel.Size = new System.Drawing.Size(73, 23);
            this.DeptAddLabel.TabIndex = 0;
            this.DeptAddLabel.Text = "부서 추가";
            // 
            // AddDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 364);
            this.Controls.Add(this.DeptAddMainPanel);
            this.Controls.Add(this.DeptAddPanel);
            this.Name = "AddDeptForm";
            this.Text = "AddDeptForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeptAddMainPanel)).EndInit();
            this.DeptAddMainPanel.ResumeLayout(false);
            this.DeptAddMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptCodeLookUpBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDepartmentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptAddPanel)).EndInit();
            this.DeptAddPanel.ResumeLayout(false);
            this.DeptAddPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl DeptAddMainPanel;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.TextEdit MemoTextBox;
        private DevExpress.XtraEditors.LabelControl Memo;
        private DevExpress.XtraEditors.TextEdit DeptNameTextBox;
        private DevExpress.XtraEditors.TextEdit UDeptNameTextBox;
        private DevExpress.XtraEditors.LabelControl UdeptNameLabel;
        private DevExpress.XtraEditors.LabelControl DeptNameLabel;
        private DevExpress.XtraEditors.LabelControl DeptCodeLabel;
        private DevExpress.XtraEditors.LabelControl UDeptCodeLabel;
        private DevExpress.XtraEditors.TextEdit DeptCodeTextBox;
        private DevExpress.XtraEditors.PanelControl DeptAddPanel;
        private DevExpress.XtraEditors.LabelControl DeptAddLabel;
        private DevExpress.XtraEditors.LookUpEdit UDeptCodeLookUpBox;
        private System.Windows.Forms.BindingSource upperDepartmentModelBindingSource;
    }
}