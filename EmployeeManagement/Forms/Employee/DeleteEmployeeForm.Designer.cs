namespace EmployeeManagement
{
    partial class DeleteEmployeeForm
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.EmpDelLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EmpDelTitle = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.EmpNameTextBox = new System.Windows.Forms.TextBox();
            this.EmpCodeTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(136, 174);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(111, 29);
            this.BtnDelete.TabIndex = 66;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(262, 174);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(111, 30);
            this.BtnCancel.TabIndex = 65;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // EmpDelLabel
            // 
            this.EmpDelLabel.AutoSize = true;
            this.EmpDelLabel.BackColor = System.Drawing.Color.White;
            this.EmpDelLabel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmpDelLabel.Location = new System.Drawing.Point(94, 96);
            this.EmpDelLabel.Name = "EmpDelLabel";
            this.EmpDelLabel.Size = new System.Drawing.Size(118, 68);
            this.EmpDelLabel.TabIndex = 64;
            this.EmpDelLabel.Text = "사원코드: \r\n사원명:\r\n\r\n삭제하시겠습니까?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.EmpDelTitle);
            this.panel2.Location = new System.Drawing.Point(75, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 35);
            this.panel2.TabIndex = 63;
            // 
            // EmpDelTitle
            // 
            this.EmpDelTitle.AutoSize = true;
            this.EmpDelTitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmpDelTitle.Location = new System.Drawing.Point(4, 9);
            this.EmpDelTitle.Name = "EmpDelTitle";
            this.EmpDelTitle.Size = new System.Drawing.Size(60, 17);
            this.EmpDelTitle.TabIndex = 2;
            this.EmpDelTitle.Text = "사원삭제";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(75, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(313, 177);
            this.dataGridView2.TabIndex = 62;
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.BackColor = System.Drawing.Color.White;
            this.EmpNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpNameTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmpNameTextBox.Location = new System.Drawing.Point(142, 114);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.ReadOnly = true;
            this.EmpNameTextBox.Size = new System.Drawing.Size(100, 16);
            this.EmpNameTextBox.TabIndex = 68;
            // 
            // EmpCodeTextBox
            // 
            this.EmpCodeTextBox.BackColor = System.Drawing.Color.White;
            this.EmpCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpCodeTextBox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmpCodeTextBox.Location = new System.Drawing.Point(156, 97);
            this.EmpCodeTextBox.Name = "EmpCodeTextBox";
            this.EmpCodeTextBox.ReadOnly = true;
            this.EmpCodeTextBox.Size = new System.Drawing.Size(100, 16);
            this.EmpCodeTextBox.TabIndex = 67;
            // 
            // DeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 242);
            this.Controls.Add(this.EmpNameTextBox);
            this.Controls.Add(this.EmpCodeTextBox);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.EmpDelLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DeleteEmployeeForm";
            this.Text = "DeleteEmployeeForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label EmpDelLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label EmpDelTitle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox EmpNameTextBox;
        private System.Windows.Forms.TextBox EmpCodeTextBox;
    }
}