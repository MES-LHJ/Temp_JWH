using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Employee
{
    public partial class AddEmployeeForm : Form
    {
        // 부서 정보 저장용
        private DataTable deptTable;

        public AddEmployeeForm()
        {
            InitializeComponent();
            LoadDeptCodes();
        }

        private void LoadDeptCodes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = "SELECT DeptCode, DeptName FROM Department";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            {
                deptTable = new DataTable();
                adapter.Fill(deptTable);

                DeptCodeComboBox.DisplayMember = "DeptCode";
                DeptCodeComboBox.ValueMember = "DeptCode";
                DeptCodeComboBox.DataSource = deptTable;
            }
        }

        private void DeptCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeptCodeComboBox.SelectedValue != null && deptTable != null)
            {
                DataRow[] rows = deptTable.Select($"DeptCode = '{DeptCodeComboBox.SelectedValue}'");
                if (rows.Length > 0)
                {
                    DeptNameTextBox.Text = rows[0]["DeptName"].ToString();
                }
                else
                {
                    DeptNameTextBox.Text = "";
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 입력값 읽기
            string deptCode = DeptCodeComboBox.SelectedValue?.ToString();
            string empCode = EmpCodeTextBox.Text.Trim();
            string empName = EmpNameTextBox.Text.Trim();
            string gender = RbtnGenderMale.Checked ? "남" : (RbtnGenderFemale.Checked ? "여" : "");
            string loginId = LoginIDTextBox.Text.Trim();
            string pwd = PwdTextBox.Text.Trim();
            string position = PositionTextBox.Text.Trim();
            string employmentType = EmploymentTypeTextBox.Text.Trim();
            string phone = PhoneTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string messengerId = MessengerIDTextBox.Text.Trim();
            string memo = MemoTextBox.Text;
        

            // 필수 입력값 체크
            if (string.IsNullOrEmpty(deptCode))
            {
                MessageBox.Show("부서코드를 선택하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DeptCodeComboBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(empCode))
            {
                MessageBox.Show("사원코드를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmpCodeTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(empName))
            {
                MessageBox.Show("사원명을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmpNameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(loginId))
            {
                MessageBox.Show("로그인ID를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginIDTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("비밀번호를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PwdTextBox.Focus();
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = @"INSERT INTO Employee
                                (EmpCode, EmpName, Gender, LoginID, Pwd, Position, EmploymentType, Phone, Email, MessengerID, Memo)
                             VALUES
                                (@EmpCode, @EmpName, @Gender, @LoginID, @Pwd, @Position, @EmploymentType, @Phone, @Email, @MessengerID, @Memo)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@EmpCode", SqlDbType.NVarChar, 10).Value = empCode;
                cmd.Parameters.Add("@EmpName",SqlDbType.NVarChar,20).Value = empName;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 2).Value = gender;
                cmd.Parameters.Add("@LoginID",SqlDbType.NVarChar,25).Value = loginId;
                cmd.Parameters.Add("@Pwd",SqlDbType.NVarChar,50).Value = pwd;
                cmd.Parameters.Add("@Position",SqlDbType.NVarChar,30).Value = position;
                cmd.Parameters.Add("@EmploymentType", SqlDbType.NVarChar,20).Value = employmentType;
                cmd.Parameters.Add("@Phone",SqlDbType.NVarChar,15).Value = phone;
                cmd.Parameters.Add("@Email",SqlDbType.NVarChar,40).Value = email;
                cmd.Parameters.Add("@MessengerID",SqlDbType.NVarChar,30).Value = messengerId;
                cmd.Parameters.Add("@Memo",SqlDbType.NVarChar,1000).Value = memo;
  

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("사원 정보가 저장되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("저장에 실패했습니다.");
                }
            }
        }
    }
}
