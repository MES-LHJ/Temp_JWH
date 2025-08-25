using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeManagement.Forms.Department;

namespace EmployeeManagement.Forms.Employee
{
    public partial class ManageDeptEmpForm : Form
    {

        public ManageDeptEmpForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new AddEmployeeForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadEmployeeData();
                }
            }
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
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
            DataGridViewRow row = null;

            if (EmpDgv.SelectedCells.Count > 0)
                row = EmpDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {
                // 각 셀 값 추출 (LoginID, Pwd 제외)
                string deptCode = row.Cells["부서코드"].Value?.ToString();
                string deptName = row.Cells["부서명"].Value?.ToString();
                string empCode = row.Cells["사원코드"].Value?.ToString();
                string empName = row.Cells["사원명"].Value?.ToString();
                string gender = row.Cells["성별"].Value?.ToString();
                string position = row.Cells["직위"].Value?.ToString();
                string employmentType = row.Cells["고용형태"].Value?.ToString();
                string phone = row.Cells["휴대전화"].Value?.ToString();
                string email = row.Cells["이메일"].Value?.ToString();
                string messengerId = row.Cells["메신저ID"].Value?.ToString();
                string memo = row.Cells["메모"].Value?.ToString();

                using (var dlg = new ModifyEmployeeForm(
                    deptCode, deptName, empCode, empName, gender, position, employmentType, phone, email, messengerId, memo))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        LoadEmployeeData();
                    }
                }
            }
            else
            {
                MessageBox.Show("수정할 셀을 선택하세요.");
            }
        }

        private void DepartmentEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;
            if (EmpDgv.SelectedCells.Count > 0)
                row = EmpDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {
                string empCode = row.Cells["사원코드"].Value?.ToString();
                string empName = row.Cells["사원명"].Value?.ToString();

                using (var dlg = new DeleteEmployeeForm(empCode, empName))
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

        private void Btn_LoginInfo_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = null;
            if (EmpDgv.SelectedCells.Count > 0)
                row = EmpDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {
                string loginId = row.Cells["로그인ID"].Value?.ToString();
                string pwd = row.Cells["비밀번호"].Value?.ToString();
                string empCode = row.Cells["사원코드"].Value?.ToString();

                using (var dlg = new LoginInformationForm(loginId, pwd, empCode))
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

            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = @"SELECT 
                                e.EmpID AS [사원ID],
                                d.DeptCode AS [부서코드],
                                d.DeptName AS [부서명],
                                e.EmpCode AS [사원코드],
                                e.EmpName AS [사원명],
                                e.Gender AS [성별],
                                e.LoginID AS [로그인ID],
                                e.Pwd AS [비밀번호],
                                e.Position AS [직위],
                                e.EmploymentType AS [고용형태],
                                e.Phone AS [휴대전화],
                                e.Email AS [이메일],
                                e.MessengerID AS [메신저ID],
                                e.Memo AS [메모]
                            FROM employee e JOIN Department d ON e.DeptID = d.DeptID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                EmpDgv.DataSource = dt;
                EmpDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void BtnDataConv_Click(object sender, EventArgs e)
        {
            //자료변환
        }
    }
}
