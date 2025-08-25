using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class ModifyDepartmentForm : Form
    {
        private string deptCode;

        public ModifyDepartmentForm(string deptCode, string deptName, string memo)
        {
            InitializeComponent();
            this.deptCode = deptCode;
            DeptCodeTextBox.Text = deptCode;   // 부서코드
            DeptNameTextBox.Text = deptName;   // 부서명
            MemoTextBox.Text = memo;       // 메모를 '부서관리'에서 받아오는 생성자
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string newDeptName = DeptNameTextBox.Text.Trim();
            string newMemo = MemoTextBox.Text.Trim();

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeManageDB;Integrated Security=True";
            string query = "UPDATE Department SET DeptName = @DeptName, Memo = @Memo WHERE DeptCode = @DeptCode";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DeptCode", deptCode);
                cmd.Parameters.AddWithValue("@DeptName", newDeptName);
                cmd.Parameters.AddWithValue("@Memo", newMemo);

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("수정 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("수정 실패");
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
