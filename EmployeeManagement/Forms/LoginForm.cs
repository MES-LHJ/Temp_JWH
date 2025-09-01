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
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // 폼 시작 시 로그인ID 텍스트박스에 포커스
            LoginIDTextBox.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 입력값 검증
            string loginId = LoginIDTextBox.Text.Trim();
            string password = PwdTextBox.Text.Trim();

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
            if (ValidateLogin(loginId, password))
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

        private bool ValidateLogin(string loginId, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = @"SELECT COUNT(*) FROM Employee WHERE LoginID = @LoginID AND Pwd = @Pwd";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoginID", loginId);
                    cmd.Parameters.AddWithValue("@Pwd", password);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터베이스 연결 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
