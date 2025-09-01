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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DpetDgv = new System.Windows.Forms.DataGridView();
            this.DeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DpetDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(57, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 50);
            this.panel1.TabIndex = 13;
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
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "부서";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(435, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 28);
            this.button8.TabIndex = 9;
            this.button8.Text = "닫기";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(348, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 28);
            this.button6.TabIndex = 7;
            this.button6.Text = "삭제";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "추가";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(284, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "수정";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnModify_Click);
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
            // DpetDgv
            // 
            this.DpetDgv.AllowUserToAddRows = false;
            this.DpetDgv.AllowUserToDeleteRows = false;
            this.DpetDgv.BackgroundColor = System.Drawing.Color.White;
            this.DpetDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DpetDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeptID});
            this.DpetDgv.Location = new System.Drawing.Point(66, 99);
            this.DpetDgv.Name = "DpetDgv";
            this.DpetDgv.ReadOnly = true;
            this.DpetDgv.RowTemplate.Height = 23;
            this.DpetDgv.Size = new System.Drawing.Size(466, 178);
            this.DpetDgv.TabIndex = 14;
            // 
            // DeptID
            // 
            this.DeptID.HeaderText = "부서ID";
            this.DeptID.Name = "DeptID";
            this.DeptID.ReadOnly = true;
            // 
            // ManageDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 347);
            this.Controls.Add(this.DpetDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageDeptForm";
            this.Text = "ManageDeptForm";
            this.Load += new System.EventHandler(this.DepartmentManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DpetDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView DpetDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptID;
    }
}