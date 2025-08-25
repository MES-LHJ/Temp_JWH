namespace EmployeeManagement.Forms.Employee
{
    partial class ModifyEmployeeForm
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
            this.MemoTextBox = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.EmpModifyPanel = new System.Windows.Forms.Panel();
            this.EmpModifyLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MessengerIDTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmploymentTypeTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.MessengerIdLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmploymentTypeLabel = new System.Windows.Forms.Label();
            this.MemoLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.EmpCodeLabel = new System.Windows.Forms.Label();
            this.EmpCodeTextBox = new System.Windows.Forms.TextBox();
            this.DeptCodeLabel = new System.Windows.Forms.Label();
            this.DeptCodeComboBox = new System.Windows.Forms.ComboBox();
            this.DeptNameLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.DeptNameTextBox = new System.Windows.Forms.TextBox();
            this.EmpNameTextBox = new System.Windows.Forms.TextBox();
            this.RbtnGenderMale = new System.Windows.Forms.RadioButton();
            this.RbtnGenderFemale = new System.Windows.Forms.RadioButton();
            this.GenderPanel = new System.Windows.Forms.Panel();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.EmpModifyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GenderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoTextBox.Location = new System.Drawing.Point(72, 244);
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(474, 21);
            this.MemoTextBox.TabIndex = 58;
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(411, 270);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(137, 32);
            this.BtnClose.TabIndex = 56;
            this.BtnClose.Text = "닫기";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(260, 270);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(137, 32);
            this.BtnSave.TabIndex = 55;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // EmpModifyPanel
            // 
            this.EmpModifyPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.EmpModifyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpModifyPanel.Controls.Add(this.EmpModifyLabel);
            this.EmpModifyPanel.Location = new System.Drawing.Point(62, 12);
            this.EmpModifyPanel.Name = "EmpModifyPanel";
            this.EmpModifyPanel.Size = new System.Drawing.Size(497, 31);
            this.EmpModifyPanel.TabIndex = 54;
            // 
            // EmpModifyLabel
            // 
            this.EmpModifyLabel.AutoSize = true;
            this.EmpModifyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EmpModifyLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmpModifyLabel.Location = new System.Drawing.Point(3, 5);
            this.EmpModifyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.EmpModifyLabel.Name = "EmpModifyLabel";
            this.EmpModifyLabel.Size = new System.Drawing.Size(80, 21);
            this.EmpModifyLabel.TabIndex = 10;
            this.EmpModifyLabel.Text = "사원 수정";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(497, 276);
            this.dataGridView1.TabIndex = 53;
            // 
            // MessengerIDTextBox
            // 
            this.MessengerIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessengerIDTextBox.Location = new System.Drawing.Point(391, 200);
            this.MessengerIDTextBox.Name = "MessengerIDTextBox";
            this.MessengerIDTextBox.Size = new System.Drawing.Size(147, 21);
            this.MessengerIDTextBox.TabIndex = 51;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Location = new System.Drawing.Point(231, 200);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(147, 21);
            this.EmailTextBox.TabIndex = 49;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneTextBox.Location = new System.Drawing.Point(72, 200);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(147, 21);
            this.PhoneTextBox.TabIndex = 46;
            // 
            // EmploymentTypeTextBox
            // 
            this.EmploymentTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmploymentTypeTextBox.Location = new System.Drawing.Point(231, 157);
            this.EmploymentTypeTextBox.Name = "EmploymentTypeTextBox";
            this.EmploymentTypeTextBox.Size = new System.Drawing.Size(147, 21);
            this.EmploymentTypeTextBox.TabIndex = 48;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionTextBox.Location = new System.Drawing.Point(72, 157);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(147, 21);
            this.PositionTextBox.TabIndex = 45;
            // 
            // MessengerIdLabel
            // 
            this.MessengerIdLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.MessengerIdLabel.AutoSize = true;
            this.MessengerIdLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessengerIdLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MessengerIdLabel.ForeColor = System.Drawing.Color.Black;
            this.MessengerIdLabel.Location = new System.Drawing.Point(391, 184);
            this.MessengerIdLabel.Name = "MessengerIdLabel";
            this.MessengerIdLabel.Size = new System.Drawing.Size(55, 15);
            this.MessengerIdLabel.TabIndex = 42;
            this.MessengerIdLabel.Text = "메신저ID";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(231, 184);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(43, 15);
            this.EmailLabel.TabIndex = 41;
            this.EmailLabel.Text = "이메일";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.Black;
            this.PhoneLabel.Location = new System.Drawing.Point(72, 184);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(55, 15);
            this.PhoneLabel.TabIndex = 40;
            this.PhoneLabel.Text = "휴대전화";
            // 
            // EmploymentTypeLabel
            // 
            this.EmploymentTypeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.EmploymentTypeLabel.AutoSize = true;
            this.EmploymentTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmploymentTypeLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmploymentTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.EmploymentTypeLabel.Location = new System.Drawing.Point(231, 141);
            this.EmploymentTypeLabel.Name = "EmploymentTypeLabel";
            this.EmploymentTypeLabel.Size = new System.Drawing.Size(55, 15);
            this.EmploymentTypeLabel.TabIndex = 39;
            this.EmploymentTypeLabel.Text = "고용형태";
            // 
            // MemoLabel
            // 
            this.MemoLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.MemoLabel.AutoSize = true;
            this.MemoLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MemoLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemoLabel.ForeColor = System.Drawing.Color.Black;
            this.MemoLabel.Location = new System.Drawing.Point(72, 227);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(31, 15);
            this.MemoLabel.TabIndex = 30;
            this.MemoLabel.Text = "메모";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmpNameLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmpNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.EmpNameLabel.Location = new System.Drawing.Point(231, 98);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(43, 15);
            this.EmpNameLabel.TabIndex = 36;
            this.EmpNameLabel.Text = "사원명";
            // 
            // EmpCodeLabel
            // 
            this.EmpCodeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.EmpCodeLabel.AutoSize = true;
            this.EmpCodeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmpCodeLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EmpCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.EmpCodeLabel.Location = new System.Drawing.Point(72, 98);
            this.EmpCodeLabel.Name = "EmpCodeLabel";
            this.EmpCodeLabel.Size = new System.Drawing.Size(55, 15);
            this.EmpCodeLabel.TabIndex = 35;
            this.EmpCodeLabel.Text = "사원코드";
            // 
            // EmpCodeTextBox
            // 
            this.EmpCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpCodeTextBox.Location = new System.Drawing.Point(72, 114);
            this.EmpCodeTextBox.Name = "EmpCodeTextBox";
            this.EmpCodeTextBox.Size = new System.Drawing.Size(147, 21);
            this.EmpCodeTextBox.TabIndex = 34;
            // 
            // DeptCodeLabel
            // 
            this.DeptCodeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeptCodeLabel.AutoSize = true;
            this.DeptCodeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeptCodeLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.DeptCodeLabel.Location = new System.Drawing.Point(72, 55);
            this.DeptCodeLabel.Name = "DeptCodeLabel";
            this.DeptCodeLabel.Size = new System.Drawing.Size(55, 15);
            this.DeptCodeLabel.TabIndex = 28;
            this.DeptCodeLabel.Text = "부서코드";
            // 
            // DeptCodeComboBox
            // 
            this.DeptCodeComboBox.FormattingEnabled = true;
            this.DeptCodeComboBox.Location = new System.Drawing.Point(72, 71);
            this.DeptCodeComboBox.Name = "DeptCodeComboBox";
            this.DeptCodeComboBox.Size = new System.Drawing.Size(147, 20);
            this.DeptCodeComboBox.TabIndex = 37;
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeptNameLabel.AutoSize = true;
            this.DeptNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeptNameLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptNameLabel.ForeColor = System.Drawing.Color.Black;
            this.DeptNameLabel.Location = new System.Drawing.Point(231, 55);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(43, 15);
            this.DeptNameLabel.TabIndex = 37;
            this.DeptNameLabel.Text = "부서명";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PositionLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PositionLabel.ForeColor = System.Drawing.Color.Black;
            this.PositionLabel.Location = new System.Drawing.Point(72, 141);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(31, 15);
            this.PositionLabel.TabIndex = 37;
            this.PositionLabel.Text = "직위";
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptNameTextBox.Location = new System.Drawing.Point(231, 71);
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.ReadOnly = true;
            this.DeptNameTextBox.Size = new System.Drawing.Size(147, 21);
            this.DeptNameTextBox.TabIndex = 44;
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpNameTextBox.Location = new System.Drawing.Point(231, 114);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Size = new System.Drawing.Size(147, 21);
            this.EmpNameTextBox.TabIndex = 47;
            // 
            // RbtnGenderMale
            // 
            this.RbtnGenderMale.AutoSize = true;
            this.RbtnGenderMale.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RbtnGenderMale.Location = new System.Drawing.Point(15, 30);
            this.RbtnGenderMale.Name = "RbtnGenderMale";
            this.RbtnGenderMale.Size = new System.Drawing.Size(37, 19);
            this.RbtnGenderMale.TabIndex = 59;
            this.RbtnGenderMale.TabStop = true;
            this.RbtnGenderMale.Text = "남";
            this.RbtnGenderMale.UseVisualStyleBackColor = true;
            // 
            // RbtnGenderFemale
            // 
            this.RbtnGenderFemale.AutoSize = true;
            this.RbtnGenderFemale.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RbtnGenderFemale.Location = new System.Drawing.Point(70, 30);
            this.RbtnGenderFemale.Name = "RbtnGenderFemale";
            this.RbtnGenderFemale.Size = new System.Drawing.Size(37, 19);
            this.RbtnGenderFemale.TabIndex = 60;
            this.RbtnGenderFemale.TabStop = true;
            this.RbtnGenderFemale.Text = "여";
            this.RbtnGenderFemale.UseVisualStyleBackColor = true;
            // 
            // GenderPanel
            // 
            this.GenderPanel.BackColor = System.Drawing.Color.White;
            this.GenderPanel.Controls.Add(this.GenderLabel);
            this.GenderPanel.Controls.Add(this.RbtnGenderFemale);
            this.GenderPanel.Controls.Add(this.RbtnGenderMale);
            this.GenderPanel.Location = new System.Drawing.Point(393, 89);
            this.GenderPanel.Name = "GenderPanel";
            this.GenderPanel.Size = new System.Drawing.Size(133, 64);
            this.GenderPanel.TabIndex = 61;
            this.GenderPanel.Tag = "";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenderLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GenderLabel.ForeColor = System.Drawing.Color.Black;
            this.GenderLabel.Location = new System.Drawing.Point(3, 9);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(31, 15);
            this.GenderLabel.TabIndex = 62;
            this.GenderLabel.Text = "성별";
            // 
            // ModifyEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 358);
            this.Controls.Add(this.GenderPanel);
            this.Controls.Add(this.EmpNameTextBox);
            this.Controls.Add(this.MemoTextBox);
            this.Controls.Add(this.DeptNameTextBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DeptNameLabel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DeptCodeComboBox);
            this.Controls.Add(this.EmpModifyPanel);
            this.Controls.Add(this.DeptCodeLabel);
            this.Controls.Add(this.EmpCodeTextBox);
            this.Controls.Add(this.EmpCodeLabel);
            this.Controls.Add(this.MessengerIDTextBox);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.MemoLabel);
            this.Controls.Add(this.EmploymentTypeLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmploymentTypeTextBox);
            this.Controls.Add(this.MessengerIdLabel);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModifyEmployeeForm";
            this.Text = "ModifyEmployeeForm";
            this.EmpModifyPanel.ResumeLayout(false);
            this.EmpModifyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GenderPanel.ResumeLayout(false);
            this.GenderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MemoTextBox;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel EmpModifyPanel;
        private System.Windows.Forms.Label EmpModifyLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox MessengerIDTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmploymentTypeTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label MessengerIdLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmploymentTypeLabel;
        private System.Windows.Forms.Label MemoLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label EmpCodeLabel;
        private System.Windows.Forms.TextBox EmpCodeTextBox;
        private System.Windows.Forms.Label DeptCodeLabel;
        private System.Windows.Forms.ComboBox DeptCodeComboBox;
        private System.Windows.Forms.Label DeptNameLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox DeptNameTextBox;
        private System.Windows.Forms.TextBox EmpNameTextBox;
        private System.Windows.Forms.RadioButton RbtnGenderMale;
        private System.Windows.Forms.RadioButton RbtnGenderFemale;
        private System.Windows.Forms.Panel GenderPanel;
        private System.Windows.Forms.Label GenderLabel;
    }
}