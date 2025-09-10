using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Models.Repository
{
    public class LoginRepository
    {
        public bool ValidateLogin(string loginId, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = @"SELECT COUNT(*) FROM Employee WHERE LoginID = @LoginID AND Pwd = @Pwd";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.LoginID), loginId);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Pwd), password);

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
