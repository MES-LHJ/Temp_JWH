namespace EmployeeManagement.Forms
{
    partial class LoginForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.PwdTextBox = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LoginIDTextBox = new System.Windows.Forms.TextBox();
            this.PwdLabel = new System.Windows.Forms.Label();
            this.LoginIDLabel = new System.Windows.Forms.Label();
            this.LoginInfoPanel = new System.Windows.Forms.Panel();
            this.LoginInfoTime = new System.Windows.Forms.Label();
            this.LoginInfoDgv = new System.Windows.Forms.DataGridView();
            this.LoginInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginInfoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(295, 199);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(137, 32);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "종료";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwdTextBox.Location = new System.Drawing.Point(268, 137);
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.Size = new System.Drawing.Size(164, 21);
            this.PwdTextBox.TabIndex = 1;
            this.PwdTextBox.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(145, 199);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(137, 32);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LoginIDTextBox
            // 
            this.LoginIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginIDTextBox.Location = new System.Drawing.Point(76, 137);
            this.LoginIDTextBox.Name = "LoginIDTextBox";
            this.LoginIDTextBox.Size = new System.Drawing.Size(164, 21);
            this.LoginIDTextBox.TabIndex = 0;
            // 
            // PwdLabel
            // 
            this.PwdLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.PwdLabel.AutoSize = true;
            this.PwdLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PwdLabel.ForeColor = System.Drawing.Color.Black;
            this.PwdLabel.Location = new System.Drawing.Point(266, 122);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(53, 12);
            this.PwdLabel.TabIndex = 39;
            this.PwdLabel.Text = "비밀번호";
            // 
            // LoginIDLabel
            // 
            this.LoginIDLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.LoginIDLabel.AutoSize = true;
            this.LoginIDLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginIDLabel.ForeColor = System.Drawing.Color.Black;
            this.LoginIDLabel.Location = new System.Drawing.Point(74, 122);
            this.LoginIDLabel.Name = "LoginIDLabel";
            this.LoginIDLabel.Size = new System.Drawing.Size(52, 12);
            this.LoginIDLabel.TabIndex = 38;
            this.LoginIDLabel.Text = "로그인ID";
            // 
            // LoginInfoPanel
            // 
            this.LoginInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LoginInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginInfoPanel.Controls.Add(this.LoginInfoTime);
            this.LoginInfoPanel.Location = new System.Drawing.Point(58, 46);
            this.LoginInfoPanel.Name = "LoginInfoPanel";
            this.LoginInfoPanel.Size = new System.Drawing.Size(419, 40);
            this.LoginInfoPanel.TabIndex = 37;
            // 
            // LoginInfoTime
            // 
            this.LoginInfoTime.AutoSize = true;
            this.LoginInfoTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginInfoTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginInfoTime.Location = new System.Drawing.Point(14, 14);
            this.LoginInfoTime.Margin = new System.Windows.Forms.Padding(3);
            this.LoginInfoTime.Name = "LoginInfoTime";
            this.LoginInfoTime.Size = new System.Drawing.Size(55, 16);
            this.LoginInfoTime.TabIndex = 10;
            this.LoginInfoTime.Text = "로그인";
            // 
            // LoginInfoDgv
            // 
            this.LoginInfoDgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginInfoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoginInfoDgv.Location = new System.Drawing.Point(58, 83);
            this.LoginInfoDgv.Name = "LoginInfoDgv";
            this.LoginInfoDgv.RowTemplate.Height = 23;
            this.LoginInfoDgv.Size = new System.Drawing.Size(419, 173);
            this.LoginInfoDgv.TabIndex = 36;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(550, 302);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PwdTextBox);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LoginIDTextBox);
            this.Controls.Add(this.PwdLabel);
            this.Controls.Add(this.LoginIDLabel);
            this.Controls.Add(this.LoginInfoPanel);
            this.Controls.Add(this.LoginInfoDgv);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.LoginInfoPanel.ResumeLayout(false);
            this.LoginInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginInfoDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox PwdTextBox;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox LoginIDTextBox;
        private System.Windows.Forms.Label PwdLabel;
        private System.Windows.Forms.Label LoginIDLabel;
        private System.Windows.Forms.Panel LoginInfoPanel;
        private System.Windows.Forms.Label LoginInfoTime;
        private System.Windows.Forms.DataGridView LoginInfoDgv;
    }
}