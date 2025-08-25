using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class DeleteDepartmentForm : Form
    {
        public DeleteDepartmentForm(string deptCode, string deptName)
        {
            InitializeComponent();
            DeptCodeTextBox.Text = deptCode; // 부서코드
            DeptNameTextBox.Text = deptName; // 부서명
            DeptCodeTextBox.ReadOnly = true;
            DeptNameTextBox.ReadOnly = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string deptCode = DeptCodeTextBox.Text.Trim();

            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeManageDB;Integrated Security=True";
            string query = "DELETE FROM Department WHERE DeptCode = @DeptCode";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DeptCode", deptCode);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        // 삭제 성공
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
