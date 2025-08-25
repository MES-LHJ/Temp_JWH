using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class ModifyDepartmentForm : Form
    {
        private int deptId;

        public ModifyDepartmentForm(int deptId, string deptCode, string deptName, string memo)
        {
            InitializeComponent();
            this.deptId = deptId;
            DeptCodeTextBox.Text = deptCode;   // 부서코드
            DeptNameTextBox.Text = deptName;   // 부서명
            MemoTextBox.Text = memo;       // 메모를 '부서관리'에서 받아오는 생성자
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string newDeptCode = DeptCodeTextBox.Text.Trim();
            string newDeptName = DeptNameTextBox.Text.Trim();
            string newMemo = MemoTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = "UPDATE Department SET DeptCode = @DeptCode, DeptName = @DeptName, Memo = @Memo WHERE DeptID = @DeptID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@DeptCode", SqlDbType.NVarChar, 10).Value = newDeptCode;
                cmd.Parameters.Add("@DeptName",SqlDbType.NVarChar,20).Value = newDeptName;
                cmd.Parameters.Add("@Memo",SqlDbType.NVarChar,1000).Value = newMemo;
                cmd.Parameters.Add("@DeptID",SqlDbType.Int).Value = deptId;

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
