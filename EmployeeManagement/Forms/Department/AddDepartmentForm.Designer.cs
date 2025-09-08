namespace EmployeeManagement.Forms.Department
{
    partial class AddDepartmentForm
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
            this.DeptNameTextBox = new System.Windows.Forms.TextBox();
            this.DeptCodeTextBox = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.MemoTextBox = new System.Windows.Forms.TextBox();
            this.MemoLabel = new System.Windows.Forms.Label();
            this.DeptNameLabel = new System.Windows.Forms.Label();
            this.DeptCodeLabel = new System.Windows.Forms.Label();
            this.AddDepartmentPanel = new System.Windows.Forms.Panel();
            this.AddDepartmentLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddDepartmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptNameTextBox.Location = new System.Drawing.Point(255, 133);
            this.DeptNameTextBox.MaxLength = 20;
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.Size = new System.Drawing.Size(164, 21);
            this.DeptNameTextBox.TabIndex = 37;
            // 
            // DeptCodeTextBox
            // 
            this.DeptCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptCodeTextBox.Location = new System.Drawing.Point(63, 133);
            this.DeptCodeTextBox.MaxLength = 10;
            this.DeptCodeTextBox.Name = "DeptCodeTextBox";
            this.DeptCodeTextBox.Size = new System.Drawing.Size(164, 21);
            this.DeptCodeTextBox.TabIndex = 36;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(282, 235);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(137, 32);
            this.BtnCancel.TabIndex = 35;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(132, 235);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(137, 32);
            this.BtnSave.TabIndex = 34;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = false;
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoTextBox.Location = new System.Drawing.Point(63, 190);
            this.MemoTextBox.MaxLength = 1000;
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(356, 21);
            this.MemoTextBox.TabIndex = 33;
            // 
            // MemoLabel
            // 
            this.MemoLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.MemoLabel.AutoSize = true;
            this.MemoLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MemoLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemoLabel.ForeColor = System.Drawing.Color.Black;
            this.MemoLabel.Location = new System.Drawing.Point(61, 175);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(31, 15);
            this.MemoLabel.TabIndex = 32;
            this.MemoLabel.Text = "메모";
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeptNameLabel.AutoSize = true;
            this.DeptNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeptNameLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.DeptNameLabel.Location = new System.Drawing.Point(253, 118);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(43, 15);
            this.DeptNameLabel.TabIndex = 31;
            this.DeptNameLabel.Text = "부서명";
            // 
            // DeptCodeLabel
            // 
            this.DeptCodeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeptCodeLabel.AutoSize = true;
            this.DeptCodeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeptCodeLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.DeptCodeLabel.Location = new System.Drawing.Point(61, 118);
            this.DeptCodeLabel.Name = "DeptCodeLabel";
            this.DeptCodeLabel.Size = new System.Drawing.Size(55, 15);
            this.DeptCodeLabel.TabIndex = 30;
            this.DeptCodeLabel.Text = "부서코드";
            // 
            // AddDepartmentPanel
            // 
            this.AddDepartmentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.AddDepartmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddDepartmentPanel.Controls.Add(this.AddDepartmentLabel);
            this.AddDepartmentPanel.Location = new System.Drawing.Point(45, 42);
            this.AddDepartmentPanel.Name = "AddDepartmentPanel";
            this.AddDepartmentPanel.Size = new System.Drawing.Size(419, 40);
            this.AddDepartmentPanel.TabIndex = 29;
            // 
            // AddDepartmentLabel
            // 
            this.AddDepartmentLabel.AutoSize = true;
            this.AddDepartmentLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddDepartmentLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddDepartmentLabel.Location = new System.Drawing.Point(3, 9);
            this.AddDepartmentLabel.Margin = new System.Windows.Forms.Padding(3);
            this.AddDepartmentLabel.Name = "AddDepartmentLabel";
            this.AddDepartmentLabel.Size = new System.Drawing.Size(80, 21);
            this.AddDepartmentLabel.TabIndex = 10;
            this.AddDepartmentLabel.Text = "부서 추가";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(419, 211);
            this.dataGridView1.TabIndex = 28;
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeptNameTextBox);
            this.Controls.Add(this.DeptCodeTextBox);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.MemoTextBox);
            this.Controls.Add(this.MemoLabel);
            this.Controls.Add(this.DeptNameLabel);
            this.Controls.Add(this.DeptCodeLabel);
            this.Controls.Add(this.AddDepartmentPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddDepartmentForm";
            this.Text = "AddDepartmentForm";
            this.AddDepartmentPanel.ResumeLayout(false);
            this.AddDepartmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DeptNameTextBox;
        private System.Windows.Forms.TextBox DeptCodeTextBox;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox MemoTextBox;
        private System.Windows.Forms.Label MemoLabel;
        private System.Windows.Forms.Label DeptNameLabel;
        private System.Windows.Forms.Label DeptCodeLabel;
        private System.Windows.Forms.Panel AddDepartmentPanel;
        private System.Windows.Forms.Label AddDepartmentLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}