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

        public ModifyEmployeeForm()
        {
            InitializeComponent();
            LoadDeptComboBox();
        }

        public ModifyEmployeeForm(
            string deptCode, string deptName, string empCode, string empName, string gender,
            string position, string employmentType, string phone, string email, string messengerId, string memo)
            : this()
        {
            // 콤보박스 데이터 바인딩 후 값 설정
            if (!string.IsNullOrEmpty(deptCode))
                DeptCodeComboBox.SelectedValue = deptCode;

            DeptNameTextBox.Text = deptName;
            EmpCodeTextBox.Text = empCode;
            EmpNameTextBox.Text = empName;
            // Gender 라디오버튼 처리
            if (gender == "남")
                RbtnGenderMale.Checked = true;
            else if (gender == "여")
                RbtnGenderFemale.Checked = true;
            else
            {
                RbtnGenderMale.Checked = false;
                RbtnGenderFemale.Checked = false;
            }
            PositionTextBox.Text = position;
            EmploymentTypeTextBox.Text = employmentType;
            PhoneTextBox.Text = phone;
            EmailTextBox.Text = email;
            MessengerIDTextBox.Text = messengerId;
            MemoTextBox.Text = memo;
        }

        private void LoadDeptComboBox()
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

        private void DeptCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 필수값 체크
            if (string.IsNullOrWhiteSpace(DeptCodeComboBox.Text) ||
                string.IsNullOrWhiteSpace(EmpCodeTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmpNameTextBox.Text))
            {
                MessageBox.Show("부서코드, 사원코드, 사원명은 필수 입력 항목입니다.");
                return;
            }

            string deptCode = DeptCodeComboBox.Text;
            string empCode = EmpCodeTextBox.Text;
            string empName = EmpNameTextBox.Text;
            string gender = RbtnGenderMale.Checked ? "남" : (RbtnGenderFemale.Checked ? "여" : "");
            string position = PositionTextBox.Text;
            string employmentType = EmploymentTypeTextBox.Text;
            string phone = PhoneTextBox.Text;
            string email = EmailTextBox.Text;
            string messengerId = MessengerIDTextBox.Text;
            string memo = MemoTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = @"UPDATE Employee SET
                                DeptCode = @DeptCode,
                                EmpName = @EmpName,
                                Gender = @Gender,
                                Position = @Position,
                                EmploymentType = @EmploymentType,
                                Phone = @Phone,
                                Email = @Email,
                                MessengerID = @MessengerID,
                                Memo = @Memo
                            WHERE EmpCode = @EmpCode";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DeptCode", deptCode);
                    cmd.Parameters.AddWithValue("@EmpCode", empCode);
                    cmd.Parameters.AddWithValue("@EmpName", empName);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@EmploymentType", employmentType);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MessengerID", messengerId);
                    cmd.Parameters.AddWithValue("@Memo", memo);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("수정이 완료되었습니다.");
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
