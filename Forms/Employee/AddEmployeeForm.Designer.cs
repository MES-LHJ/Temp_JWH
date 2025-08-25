namespace EmployeeManagement
{
    partial class AddEmployeeForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.EmpCodeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MemoLabel = new System.Windows.Forms.Label();
            this.DeptCodeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddEmployeeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoginIDTextBox = new System.Windows.Forms.TextBox();
            this.EmpNameTextBox = new System.Windows.Forms.TextBox();
            this.DeptNameTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.DeptNameLabel = new System.Windows.Forms.Label();
            this.DeptCodeComboBox = new System.Windows.Forms.ComboBox();
            this.EmpCodeLabel = new System.Windows.Forms.Label();
            this.EmpNameLabel = new System.Windows.Forms.Label();
            this.LoginIDLabel = new System.Windows.Forms.Label();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.EmploymentTypeLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.MessengerIDLabel = new System.Windows.Forms.Label();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.EmploymentTypeTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.MessengerIDTextBox = new System.Windows.Forms.TextBox();
            this.MemoTextBox = new System.Windows.Forms.TextBox();
            this.GenderPanel = new System.Windows.Forms.Panel();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.RbtnGenderFemale = new System.Windows.Forms.RadioButton();
            this.RbtnGenderMale = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GenderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(412, 318);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 32);
            this.button2.TabIndex = 35;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // EmpCodeTextBox
            // 
            this.EmpCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpCodeTextBox.Location = new System.Drawing.Point(73, 110);
            this.EmpCodeTextBox.Name = "EmpCodeTextBox";
            this.EmpCodeTextBox.Size = new System.Drawing.Size(152, 21);
            this.EmpCodeTextBox.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(261, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 32);
            this.button1.TabIndex = 33;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MemoLabel
            // 
            this.MemoLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.MemoLabel.AutoSize = true;
            this.MemoLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MemoLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.MemoLabel.ForeColor = System.Drawing.Color.Black;
            this.MemoLabel.Location = new System.Drawing.Point(73, 266);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(31, 15);
            this.MemoLabel.TabIndex = 30;
            this.MemoLabel.Text = "메모";
            // 
            // DeptCodeLabel
            // 
            this.DeptCodeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeptCodeLabel.AutoSize = true;
            this.DeptCodeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeptCodeLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.DeptCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.DeptCodeLabel.Location = new System.Drawing.Point(73, 51);
            this.DeptCodeLabel.Name = "DeptCodeLabel";
            this.DeptCodeLabel.Size = new System.Drawing.Size(55, 15);
            this.DeptCodeLabel.TabIndex = 28;
            this.DeptCodeLabel.Text = "부서코드";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddEmployeeLabel);
            this.panel1.Location = new System.Drawing.Point(63, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 31);
            this.panel1.TabIndex = 27;
            // 
            // AddEmployeeLabel
            // 
            this.AddEmployeeLabel.AutoSize = true;
            this.AddEmployeeLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddEmployeeLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddEmployeeLabel.Location = new System.Drawing.Point(3, 5);
            this.AddEmployeeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.AddEmployeeLabel.Name = "AddEmployeeLabel";
            this.AddEmployeeLabel.Size = new System.Drawing.Size(80, 21);
            this.AddEmployeeLabel.TabIndex = 10;
            this.AddEmployeeLabel.Text = "사원 추가";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(497, 319);
            this.dataGridView1.TabIndex = 26;
            // 
            // LoginIDTextBox
            // 
            this.LoginIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginIDTextBox.Location = new System.Drawing.Point(73, 153);
            this.LoginIDTextBox.Name = "LoginIDTextBox";
            this.LoginIDTextBox.Size = new System.Drawing.Size(152, 21);
            this.LoginIDTextBox.TabIndex = 50;
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpNameTextBox.Location = new System.Drawing.Point(232, 110);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Size = new System.Drawing.Size(152, 21);
            this.EmpNameTextBox.TabIndex = 47;
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptNameTextBox.Location = new System.Drawing.Point(232, 67);
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.ReadOnly = true;
            this.DeptNameTextBox.Size = new System.Drawing.Size(152, 21);
            this.DeptNameTextBox.TabIndex = 44;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PositionLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.PositionLabel.ForeColor = System.Drawing.Color.Black;
            this.PositionLabel.Location = new System.Drawing.Point(73, 180);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(31, 15);
            this.PositionLabel.TabIndex = 37;
            this.PositionLabel.Text = "직위";
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeptNameLabel.AutoSize = true;
            this.DeptNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeptNameLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.DeptNameLabel.ForeColor = System.Drawing.Color.Black;
            this.DeptNameLabel.Location = new System.Drawing.Point(232, 51);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(43, 15);
            this.DeptNameLabel.TabIndex = 37;
            this.DeptNameLabel.Text = "부서명";
            // 
            // DeptCodeComboBox
            // 
            this.DeptCodeComboBox.FormattingEnabled = true;
            this.DeptCodeComboBox.Location = new System.Drawing.Point(73, 67);
            this.DeptCodeComboBox.Name = "DeptCodeComboBox";
            this.DeptCodeComboBox.Size = new System.Drawing.Size(152, 20);
            this.DeptCodeComboBox.TabIndex = 37;
            // 
            // EmpCodeLabel
            // 
            this.EmpCodeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.EmpCodeLabel.AutoSize = true;
            this.EmpCodeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmpCodeLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.EmpCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.EmpCodeLabel.Location = new System.Drawing.Point(73, 94);
            this.EmpCodeLabel.Name = "EmpCodeLabel";
            this.EmpCodeLabel.Size = new System.Drawing.Size(55, 15);
            this.EmpCodeLabel.TabIndex = 35;
            this.EmpCodeLabel.Text = "사원코드";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.EmpNameLabel.AutoSize = true;
            this.EmpNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmpNameLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.EmpNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.EmpNameLabel.Location = new System.Drawing.Point(232, 94);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(43, 15);
            this.EmpNameLabel.TabIndex = 36;
            this.EmpNameLabel.Text = "사원명";
            // 
            // LoginIDLabel
            // 
            this.LoginIDLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.LoginIDLabel.AutoSize = true;
            this.LoginIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginIDLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.LoginIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.LoginIDLabel.Location = new System.Drawing.Point(73, 137);
            this.LoginIDLabel.Name = "LoginIDLabel";
            this.LoginIDLabel.Size = new System.Drawing.Size(55, 15);
            this.LoginIDLabel.TabIndex = 37;
            this.LoginIDLabel.Text = "로그인ID";
            // 
            // PwdLabel
            // 
            this.PwdLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PwdLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.PwdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.PwdLabel.Location = new System.Drawing.Point(232, 137);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(55, 15);
            this.PwdLabel.TabIndex = 38;
            this.PwdLabel.Text = "비밀번호";
            // 
            // EmploymentTypeLabel
            // 
            this.EmploymentTypeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.EmploymentTypeLabel.AutoSize = true;
            this.EmploymentTypeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmploymentTypeLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.EmploymentTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.EmploymentTypeLabel.Location = new System.Drawing.Point(232, 180);
            this.EmploymentTypeLabel.Name = "EmploymentTypeLabel";
            this.EmploymentTypeLabel.Size = new System.Drawing.Size(55, 15);
            this.EmploymentTypeLabel.TabIndex = 39;
            this.EmploymentTypeLabel.Text = "고용형태";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.PhoneLabel.ForeColor = System.Drawing.Color.Black;
            this.PhoneLabel.Location = new System.Drawing.Point(73, 223);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(55, 15);
            this.PhoneLabel.TabIndex = 40;
            this.PhoneLabel.Text = "휴대전화";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(232, 223);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(43, 15);
            this.EmailLabel.TabIndex = 41;
            this.EmailLabel.Text = "이메일";
            // 
            // MessengerIDLabel
            // 
            this.MessengerIDLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.MessengerIDLabel.AutoSize = true;
            this.MessengerIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessengerIDLabel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.MessengerIDLabel.ForeColor = System.Drawing.Color.Black;
            this.MessengerIDLabel.Location = new System.Drawing.Point(392, 223);
            this.MessengerIDLabel.Name = "MessengerIDLabel";
            this.MessengerIDLabel.Size = new System.Drawing.Size(55, 15);
            this.MessengerIDLabel.TabIndex = 42;
            this.MessengerIDLabel.Text = "메신저ID";
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwdTextBox.Location = new System.Drawing.Point(232, 153);
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.Size = new System.Drawing.Size(152, 21);
            this.PwdTextBox.TabIndex = 43;
            this.PwdTextBox.UseSystemPasswordChar = true;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionTextBox.Location = new System.Drawing.Point(73, 196);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(152, 21);
            this.PositionTextBox.TabIndex = 45;
            // 
            // EmploymentTypeTextBox
            // 
            this.EmploymentTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmploymentTypeTextBox.Location = new System.Drawing.Point(232, 196);
            this.EmploymentTypeTextBox.Name = "EmploymentTypeTextBox";
            this.EmploymentTypeTextBox.Size = new System.Drawing.Size(152, 21);
            this.EmploymentTypeTextBox.TabIndex = 48;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneTextBox.Location = new System.Drawing.Point(73, 239);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(152, 21);
            this.PhoneTextBox.TabIndex = 46;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Location = new System.Drawing.Point(232, 239);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(152, 21);
            this.EmailTextBox.TabIndex = 49;
            // 
            // MessengerIDTextBox
            // 
            this.MessengerIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessengerIDTextBox.Location = new System.Drawing.Point(392, 239);
            this.MessengerIDTextBox.Name = "MessengerIDTextBox";
            this.MessengerIDTextBox.Size = new System.Drawing.Size(155, 21);
            this.MessengerIDTextBox.TabIndex = 51;
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoTextBox.Location = new System.Drawing.Point(73, 281);
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(474, 21);
            this.MemoTextBox.TabIndex = 52;
            // 
            // GenderPanel
            // 
            this.GenderPanel.BackColor = System.Drawing.Color.White;
            this.GenderPanel.Controls.Add(this.GenderLabel);
            this.GenderPanel.Controls.Add(this.RbtnGenderFemale);
            this.GenderPanel.Controls.Add(this.RbtnGenderMale);
            this.GenderPanel.Location = new System.Drawing.Point(394, 85);
            this.GenderPanel.Name = "GenderPanel";
            this.GenderPanel.Size = new System.Drawing.Size(133, 64);
            this.GenderPanel.TabIndex = 62;
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
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 382);
            this.Controls.Add(this.LoginIDTextBox);
            this.Controls.Add(this.GenderPanel);
            this.Controls.Add(this.EmpNameTextBox);
            this.Controls.Add(this.MemoTextBox);
            this.Controls.Add(this.DeptNameTextBox);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeptNameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeptCodeComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeptCodeLabel);
            this.Controls.Add(this.EmpCodeTextBox);
            this.Controls.Add(this.LoginIDLabel);
            this.Controls.Add(this.EmpCodeLabel);
            this.Controls.Add(this.MessengerIDTextBox);
            this.Controls.Add(this.EmpNameLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.MemoLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmploymentTypeTextBox);
            this.Controls.Add(this.PwdLabel);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.EmploymentTypeLabel);
            this.Controls.Add(this.PwdTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.MessengerIDLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GenderPanel.ResumeLayout(false);
            this.GenderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox EmpCodeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MemoLabel;
        private System.Windows.Forms.Label DeptCodeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddEmployeeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label EmpCodeLabel;
        private System.Windows.Forms.Label EmpNameLabel;
        private System.Windows.Forms.Label LoginIDLabel;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.ComboBox DeptCodeComboBox;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label DeptNameLabel;
        private System.Windows.Forms.Label EmploymentTypeLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LoginIDTextBox;
        private System.Windows.Forms.TextBox EmpNameTextBox;
        private System.Windows.Forms.TextBox DeptNameTextBox;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox EmploymentTypeTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label MessengerIDLabel;
        private System.Windows.Forms.TextBox MessengerIDTextBox;
        private System.Windows.Forms.TextBox MemoTextBox;
        private System.Windows.Forms.Panel GenderPanel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton RbtnGenderFemale;
        private System.Windows.Forms.RadioButton RbtnGenderMale;
    }
}