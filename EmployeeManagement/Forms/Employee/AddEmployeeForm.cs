using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;

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

        private void LoadDeptCodes() // 부서코드, 부서명 콤보박스에 데이터 로드
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = "SELECT DeptID, DeptCode, DeptName FROM Department";

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
                    DeptNameTextBox.Text = string.Empty;
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e) // 저장 버튼 누른다
        {
            // 입력값 읽기 11
            // deptcode랑 deptName은 employee DB에 없다. -> deptcode로 deptID를 조회해서 저장을 해야한다
            int deptId = EmployeeRepository.GetDeptIdByCode(DeptCodeComboBox.SelectedValue?.ToString());
            string empCode = EmpCodeTextBox.Text.Trim();
            string empName = EmpNameTextBox.Text.Trim();
            Gender gender = Gender.None;
            if (RbtnGenderMale.Checked)
                gender = Gender.남;
            else if (RbtnGenderFemale.Checked)
                gender = Gender.여;
            string loginId = LoginIDTextBox.Text.Trim();
            string pwd = PwdTextBox.Text.Trim();
            string position = PositionTextBox.Text.Trim();
            string employmentType = EmploymentTypeTextBox.Text.Trim();
            string phone = PhoneTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string messengerId = MessengerIDTextBox.Text.Trim();
            string memo = MemoTextBox.Text;
        
            // 필수 입력값 체크
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
            try
            {
                // EmployeeModel 객체 생성 12개
                var employee = new EmployeeModel
                {
                    DeptID = deptId,
                    EmpCode = empCode,
                    EmpName = empName,
                    Gender = gender,
                    LoginID = loginId,
                    Pwd = pwd,
                    Position = position,
                    EmploymentType = employmentType,
                    Phone = phone,
                    Email = email,
                    MessengerID = messengerId,
                    Memo = memo
                };

                // EmployeeRepository를 통해 저장
                var repository = new EmployeeRepository();
                bool result = repository.AddEmployee(employee);

                if (result)
                {
                    MessageBox.Show("사원 정보가 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("저장에 실패했습니다.", "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"저장 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
