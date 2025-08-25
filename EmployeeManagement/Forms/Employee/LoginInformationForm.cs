using System;
using System.Configuration;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Employee
{
    public partial class LoginInformationForm : Form
    {
        private string newEmpCode;

        public LoginInformationForm()
        {
            InitializeComponent();
        }

        public LoginInformationForm(string loginId, string pwd, string newEmpCode) : this()
        {
            LoginIDTextBox.Text = loginId;
            PwdTextBox.Text = pwd;
            this.newEmpCode = newEmpCode;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newEmpCode))
            {
                MessageBox.Show("사원코드 정보가 없습니다.");
                return;
            }

            string loginId = LoginIDTextBox.Text;
            string pwd = PwdTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = @"UPDATE Employee SET LoginID = @LoginID, Pwd = @Pwd WHERE EmpCode = @EmpCode";

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoginID", loginId);
                    cmd.Parameters.AddWithValue("@Pwd", pwd);
                    cmd.Parameters.AddWithValue("@EmpCode", newEmpCode);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("로그인 정보가 수정되었습니다.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("수정할 데이터를 찾을 수 없습니다.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
        }
    }
}
