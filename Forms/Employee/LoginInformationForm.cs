using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class LoginInformationForm : Form
    {
        private string _empCode;

        public LoginInformationForm()
        {
            InitializeComponent();
        }

        public LoginInformationForm(string loginId, string pwd, string empCode) : this()
        {
            LoginIDTextBox.Text = loginId;
            PwdTextBox.Text = pwd;
            _empCode = empCode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_empCode))
            {
                MessageBox.Show("사원코드 정보가 없습니다.");
                return;
            }

            string loginId = LoginIDTextBox.Text;
            string pwd = PwdTextBox.Text;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeManageDB;Integrated Security=True";
            string query = @"UPDATE Employee SET LoginID = @LoginID, Pwd = @Pwd WHERE EmpCode = @EmpCode";

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LoginID", loginId);
                    cmd.Parameters.AddWithValue("@Pwd", pwd);
                    cmd.Parameters.AddWithValue("@EmpCode", _empCode);

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
