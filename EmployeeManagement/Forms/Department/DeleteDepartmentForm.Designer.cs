namespace EmployeeManagement.Forms.Department
{
    partial class DeleteDepartmentForm
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
            this.DeptDelDgv = new System.Windows.Forms.DataGridView();
            this.DeptDelPanel = new System.Windows.Forms.Panel();
            this.DeptDelTitle = new System.Windows.Forms.Label();
            this.DeptDelLabel = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DeptCodeTextBox = new System.Windows.Forms.TextBox();
            this.DeptNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeptDelDgv)).BeginInit();
            this.DeptDelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeptDelDgv
            // 
            this.DeptDelDgv.BackgroundColor = System.Drawing.Color.White;
            this.DeptDelDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptDelDgv.Location = new System.Drawing.Point(48, 24);
            this.DeptDelDgv.Name = "DeptDelDgv";
            this.DeptDelDgv.RowTemplate.Height = 23;
            this.DeptDelDgv.Size = new System.Drawing.Size(313, 177);
            this.DeptDelDgv.TabIndex = 0;
            // 
            // DeptDelPanel
            // 
            this.DeptDelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.DeptDelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptDelPanel.Controls.Add(this.DeptDelTitle);
            this.DeptDelPanel.Location = new System.Drawing.Point(48, 24);
            this.DeptDelPanel.Name = "DeptDelPanel";
            this.DeptDelPanel.Size = new System.Drawing.Size(313, 35);
            this.DeptDelPanel.TabIndex = 1;
            // 
            // DeptDelTitle
            // 
            this.DeptDelTitle.AutoSize = true;
            this.DeptDelTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptDelTitle.Location = new System.Drawing.Point(3, 12);
            this.DeptDelTitle.Name = "DeptDelTitle";
            this.DeptDelTitle.Size = new System.Drawing.Size(59, 15);
            this.DeptDelTitle.TabIndex = 2;
            this.DeptDelTitle.Text = "부서 삭제";
            // 
            // DeptDelLabel
            // 
            this.DeptDelLabel.AutoSize = true;
            this.DeptDelLabel.BackColor = System.Drawing.Color.White;
            this.DeptDelLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptDelLabel.Location = new System.Drawing.Point(61, 76);
            this.DeptDelLabel.Name = "DeptDelLabel";
            this.DeptDelLabel.Size = new System.Drawing.Size(118, 68);
            this.DeptDelLabel.TabIndex = 2;
            this.DeptDelLabel.Text = "부서코드: \r\n부서명:\r\n\r\n삭제하시겠습니까?";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(236, 163);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(111, 30);
            this.BtnCancel.TabIndex = 60;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(110, 163);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(111, 29);
            this.BtnDelete.TabIndex = 61;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // DeptCodeTextBox
            // 
            this.DeptCodeTextBox.BackColor = System.Drawing.Color.White;
            this.DeptCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeptCodeTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptCodeTextBox.Location = new System.Drawing.Point(124, 76);
            this.DeptCodeTextBox.Name = "DeptCodeTextBox";
            this.DeptCodeTextBox.ReadOnly = true;
            this.DeptCodeTextBox.Size = new System.Drawing.Size(100, 16);
            this.DeptCodeTextBox.TabIndex = 62;
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.BackColor = System.Drawing.Color.White;
            this.DeptNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeptNameTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptNameTextBox.Location = new System.Drawing.Point(110, 93);
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.ReadOnly = true;
            this.DeptNameTextBox.Size = new System.Drawing.Size(100, 16);
            this.DeptNameTextBox.TabIndex = 63;
            // 
            // DeleteDepartmentForm
            // 
            this.ClientSize = new System.Drawing.Size(419, 222);
            this.Controls.Add(this.DeptNameTextBox);
            this.Controls.Add(this.DeptCodeTextBox);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.DeptDelLabel);
            this.Controls.Add(this.DeptDelPanel);
            this.Controls.Add(this.DeptDelDgv);
            this.Name = "DeleteDepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeptDelDgv)).EndInit();
            this.DeptDelPanel.ResumeLayout(false);
            this.DeptDelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DeptDelDgv;
        private System.Windows.Forms.Panel DeptDelPanel;
        private System.Windows.Forms.Label DeptDelTitle;
        private System.Windows.Forms.Label DeptDelLabel;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox DeptCodeTextBox;
        private System.Windows.Forms.TextBox DeptNameTextBox;
    }
}