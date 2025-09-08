namespace EmployeeManagement.Forms.Department
{
    partial class ManageDeptForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnChart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeptDgv = new System.Windows.Forms.DataGridView();
            this.deptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteEmployeeFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteEmployeeFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnChart);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.BtnModify);
            this.panel1.Location = new System.Drawing.Point(57, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 50);
            this.panel1.TabIndex = 13;
            // 
            // BtnChart
            // 
            this.BtnChart.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnChart.Location = new System.Drawing.Point(156, 11);
            this.BtnChart.Name = "BtnChart";
            this.BtnChart.Size = new System.Drawing.Size(58, 28);
            this.BtnChart.TabIndex = 13;
            this.BtnChart.Text = "차트";
            this.BtnChart.UseVisualStyleBackColor = true;
            this.BtnChart.Click += new System.EventHandler(this.BtnChart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagement.Properties.Resources.free_icon_user_6607993__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 36);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "부서";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnClose.Location = new System.Drawing.Point(435, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 28);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "닫기";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDelete.Location = new System.Drawing.Point(348, 11);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(58, 28);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnAdd.Location = new System.Drawing.Point(220, 11);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(58, 28);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnModify.Location = new System.Drawing.Point(284, 11);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(58, 28);
            this.BtnModify.TabIndex = 5;
            this.BtnModify.Text = "수정";
            this.BtnModify.UseVisualStyleBackColor = true;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(490, 224);
            this.dataGridView1.TabIndex = 12;
            // 
            // DeptDgv
            // 
            this.DeptDgv.AllowUserToAddRows = false;
            this.DeptDgv.AllowUserToDeleteRows = false;
            this.DeptDgv.AutoGenerateColumns = false;
            this.DeptDgv.BackgroundColor = System.Drawing.Color.White;
            this.DeptDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptIDDataGridViewTextBoxColumn,
            this.deptCodeDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn});
            this.DeptDgv.DataSource = this.departmentModelBindingSource;
            this.DeptDgv.Location = new System.Drawing.Point(66, 99);
            this.DeptDgv.Name = "DeptDgv";
            this.DeptDgv.ReadOnly = true;
            this.DeptDgv.RowTemplate.Height = 23;
            this.DeptDgv.Size = new System.Drawing.Size(466, 178);
            this.DeptDgv.TabIndex = 14;
            // 
            // deptIDDataGridViewTextBoxColumn
            // 
            this.deptIDDataGridViewTextBoxColumn.DataPropertyName = "DeptID";
            this.deptIDDataGridViewTextBoxColumn.HeaderText = "부서ID";
            this.deptIDDataGridViewTextBoxColumn.Name = "deptIDDataGridViewTextBoxColumn";
            this.deptIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptCodeDataGridViewTextBoxColumn
            // 
            this.deptCodeDataGridViewTextBoxColumn.DataPropertyName = "DeptCode";
            this.deptCodeDataGridViewTextBoxColumn.HeaderText = "부서코드";
            this.deptCodeDataGridViewTextBoxColumn.Name = "deptCodeDataGridViewTextBoxColumn";
            this.deptCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "부서명";
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "메모";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentModelBindingSource
            // 
            this.departmentModelBindingSource.DataSource = typeof(EmployeeManagement.Models.DepartmentModel);
            // 
            // deleteEmployeeFormBindingSource
            // 
            this.deleteEmployeeFormBindingSource.DataSource = typeof(EmployeeManagement.DeleteEmployeeForm);
            // 
            // ManageDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 347);
            this.Controls.Add(this.DeptDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageDeptForm";
            this.Text = "ManageDeptForm";
            this.Load += new System.EventHandler(this.DepartmentManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteEmployeeFormBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView DeptDgv;
        private System.Windows.Forms.BindingSource departmentModelBindingSource;
        private System.Windows.Forms.BindingSource deleteEmployeeFormBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnChart;
    }
}