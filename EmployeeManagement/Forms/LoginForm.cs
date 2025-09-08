using EmployeeManagement.Models.Repository;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginIDTextBox.Focus();
            BtnLogin.Click += BtnLogin_Click;
            BtnClose.Click += BtnClose_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // 입력값 검증
            string loginId = LoginIDTextBox.Text;
            string password = PwdTextBox.Text;

            if (string.IsNullOrEmpty(loginId))
            {
                MessageBox.Show("로그인ID를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginIDTextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("비밀번호를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PwdTextBox.Focus();
                return;
            }

            // 로그인 검증
            var loginRepository = new LoginRepository();
            if (loginRepository.ValidateLogin(loginId, password))
            {
                MessageBox.Show("로그인 성공!", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인ID 또는 비밀번호가 올바르지 않습니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PwdTextBox.Clear();
                LoginIDTextBox.Focus();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
