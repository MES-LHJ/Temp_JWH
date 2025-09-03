using EmployeeManagement.Forms.Department;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Employee
{
    public partial class ManageDeptEmpForm : Form
    {
        public ManageDeptEmpForm()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e) //조회
        {
            var originalText = BtnRefresh.Text;
            BtnRefresh.Text = "조회중..";
            BtnRefresh.Enabled = false;

            try
            {
                LoadEmployeeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 조회 중 오류: {ex.Message}");
            }
            finally
            {
                BtnRefresh.Text = originalText;
                BtnRefresh.Enabled = true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e) //추가버튼
        {
            using (var dlg = new AddEmployeeForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployeeData();
                }
            }
        }

        private void BtnDepartment_Click(object sender, EventArgs e) //부서관리버튼
        {
            using (var dlg = new ManageDeptForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployeeData();
                }
            }
        }

        private void BtnModify_Click(object sender, EventArgs e) //수정버튼
        {
            if (EmpDgv.SelectedCells.Count == 0)
            {
                MessageBox.Show("수정할 셀을 선택하세요.");
                return;
            }
            var row = EmpDgv.SelectedCells[0].OwningRow;

            // 각 셀 값 추출 (LoginID, Pwd 제외) 11개
            int employeeId = Convert.ToInt32(row.Cells[nameof(empIDDataGridViewTextBoxColumn)].Value);
            string deptCode = row.Cells[nameof(deptCodeDataGridViewTextBoxColumn)].Value?.ToString();
            string deptName = row.Cells[nameof(deptNameDataGridViewTextBoxColumn)].Value?.ToString();
            string empCode = row.Cells[nameof(empCodeDataGridViewTextBoxColumn)].Value?.ToString();
            string empName = row.Cells[nameof(empNameDataGridViewTextBoxColumn)].Value?.ToString();
            string gender = row.Cells[nameof(genderDataGridViewTextBoxColumn)].Value?.ToString();
            string position = row.Cells[nameof(positionDataGridViewTextBoxColumn)].Value?.ToString();
            string employmentType = row.Cells[nameof(employmentTypeDataGridViewTextBoxColumn)].Value?.ToString();
            string phone = row.Cells[nameof(phoneDataGridViewTextBoxColumn)].Value?.ToString();
            string email = row.Cells[nameof(emailDataGridViewTextBoxColumn)].Value?.ToString();
            string messengerId = row.Cells[nameof(messengerIDDataGridViewTextBoxColumn)].Value?.ToString();
            string memo = row.Cells[nameof(memoDataGridViewTextBoxColumn)].Value?.ToString();

            using (var dlg = new ModifyEmployeeForm(
                employeeId, deptCode, deptName, empCode, empName, gender, position, employmentType, phone, email, messengerId, memo))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployeeData();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) //삭제버튼
        {
            DataGridViewRow row = null;
            if (EmpDgv.SelectedCells.Count > 0)
                row = EmpDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {

                int empId = Convert.ToInt32(row.Cells[nameof(empIDDataGridViewTextBoxColumn)].Value);
                string empCode = row.Cells[nameof(empCodeDataGridViewTextBoxColumn)].Value?.ToString();
                string empName = row.Cells[nameof(empNameDataGridViewTextBoxColumn)].Value?.ToString();

                using (var dlg = new DeleteEmployeeForm(empId, empCode, empName))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        LoadEmployeeData();
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제할 사원을 선택하세요.");
            }
        }

        private void Btn_LoginInfo_Click(object sender, EventArgs e) //로그인정보버튼
        {
            DataGridViewRow row = null;
            if (EmpDgv.SelectedCells.Count > 0)
                row = EmpDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {
                string loginId = row.Cells[nameof(loginIDDataGridViewTextBoxColumn)].Value?.ToString();
                string pwd = row.Cells[nameof(pwdDataGridViewTextBoxColumn)].Value?.ToString();
                string empID = row.Cells[nameof(empIDDataGridViewTextBoxColumn)].Value?.ToString();

                using (var dlg = new LoginInformationForm(loginId, pwd, empID))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        LoadEmployeeData();
                    }
                }
            }
            else
            {
                MessageBox.Show("로그인 정보를 볼 사원을 선택하세요.");
            }
        }

        private void LoadEmployeeData()
        {
            try
            {
                var employees = EmployeeRepository.Instance.GetAllEmployees();

                // DataGridView에 바인딩 -> DataBound 사용하기
                EmpDgv.DataSource = employees;
                EmpDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDataConv_Click(object sender, EventArgs e)
        {
            //자료변환
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //비밀번호 마스킹
        private void EmpDgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (EmpDgv.Columns[e.ColumnIndex].Name == nameof(pwdDataGridViewTextBoxColumn) && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }
    }
}