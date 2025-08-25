using System;
using System.Configuration;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class DeleteEmployeeForm : Form
    {
        public DeleteEmployeeForm()
        {
            InitializeComponent();
        }

        public DeleteEmployeeForm(string empCode, string empName) : this()
        {
            EmpCodeTextBox.Text = empCode;
            EmpNameTextBox.Text = empName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string empCode = EmpCodeTextBox.Text;

            if (string.IsNullOrWhiteSpace(empCode))
            {
                MessageBox.Show("사원코드가 없습니다.");
                return;
            }

            var result = MessageBox.Show("정말로 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = "DELETE FROM Employee WHERE EmpCode = @EmpCode";

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpCode", empCode);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("삭제가 완료되었습니다.");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("삭제할 데이터를 찾을 수 없습니다.");
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
