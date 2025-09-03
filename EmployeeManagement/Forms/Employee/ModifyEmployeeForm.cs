using EmployeeManagement.Models.Repository;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Employee
{
    public partial class ModifyEmployeeForm : Form
    {
        private DataTable deptTable;
        private int empId;
        public ModifyEmployeeForm()
        {
            InitializeComponent();
            LoadDeptComboBox();
        }

        public ModifyEmployeeForm(
            int employeeId,
            string deptCode, string deptName, string empCode, string empName, string gender,
            string position, string employmentType, string phone, string email, string messengerId, string memo)
            : this()
        {
            this.empId = employeeId;
            // 콤보박스 데이터 바인딩 후 값 설정
            if (!string.IsNullOrEmpty(deptCode))
                DeptCodeComboBox.SelectedValue = deptCode;

                DeptNameTextBox.Text = deptName;
                EmpCodeTextBox.Text = empCode;
                EmpNameTextBox.Text = empName;
                RbtnGenderMale.Checked = (gender == "남"); // Gender 라디오버튼 처리
                RbtnGenderFemale.Checked = (gender == "여");
                PositionTextBox.Text = position;
                EmploymentTypeTextBox.Text = employmentType;
                PhoneTextBox.Text = phone;
                EmailTextBox.Text = email;
                MessengerIDTextBox.Text = messengerId;
                MemoTextBox.Text = memo;
        }

        private void LoadDeptComboBox() // 부서코드 콤보박스 로드
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = "SELECT DeptCode, DeptName FROM Department";
            deptTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                adapter.Fill(deptTable);
            }

            DeptCodeComboBox.DataSource = deptTable;
            DeptCodeComboBox.DisplayMember = "DeptCode";
            DeptCodeComboBox.ValueMember = "DeptCode";
        }

        private void DeptCodeComboBox_SelectedIndexChanged(object sender, EventArgs e) // 부서코드 선택시 부서명 표시
        {
            if (DeptCodeComboBox.SelectedValue != null && deptTable != null)
            {
                DataRow[] rows = deptTable.Select($"DeptCode = '{DeptCodeComboBox.SelectedValue}'");
                if (rows.Length > 0)
                {
                    DeptNameTextBox.Text = rows[0]["DeptName"].ToString();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e) // 수정 버튼
        {
            string deptCode = DeptCodeComboBox.SelectedValue?.ToString() ?? string.Empty;
            int deptId = EmployeeRepository.Instance.GetDeptIdByCode(deptCode);
            string deptName = DeptNameTextBox.Text;
            string empCode = EmpCodeTextBox.Text;
            string empName = EmpNameTextBox.Text;
            Models.Gender gender = Models.Gender.None;
            if (RbtnGenderMale.Checked)
                gender = Models.Gender.남;
            else if (RbtnGenderFemale.Checked)
                gender = Models.Gender.여;
            string position = PositionTextBox.Text;
            string employmentType = EmploymentTypeTextBox.Text;
            string phone = PhoneTextBox.Text;
            string email = EmailTextBox.Text;
            string messengerId = MessengerIDTextBox.Text;
            string memo = MemoTextBox.Text;

            // 필수값 체크
            if (string.IsNullOrEmpty(DeptCodeComboBox.Text) ||
                string.IsNullOrEmpty(EmpCodeTextBox.Text) ||
                string.IsNullOrEmpty(EmpNameTextBox.Text))
            {
                MessageBox.Show("부서코드, 사원코드, 사원명은 필수 입력 항목입니다.");
                return;
            }

            // 부서ID 유효성 체크
            if (deptId == 0)
            {
                MessageBox.Show("유효하지 않은 부서코드입니다.");
                return;
            }

            try
            {
                var info = new Models.EmployeeModel
                {
                    EmpID = this.empId,
                    DeptID = deptId,
                    DeptCode = deptCode,
                    DeptName = deptName,
                    EmpCode = empCode,
                    EmpName = empName,
                    Gender = gender,
                    Position = position,
                    EmploymentType = employmentType,
                    Phone = phone,
                    Email = email,
                    MessengerID = messengerId,
                    Memo = memo
                };

                var repository = EmployeeRepository.Instance;
                bool success = repository.UpdateEmployee(info);

                if (success)
                {
                    MessageBox.Show("사원 정보가 수정되었습니다.", "수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("사원 정보 수정에 실패했습니다.", "수정 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 : {ex.Message}\n\n상세 오류: {ex.InnerException?.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
