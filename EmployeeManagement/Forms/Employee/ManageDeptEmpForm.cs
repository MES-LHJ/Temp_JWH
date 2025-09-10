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
            LoadEvents();
        }

        private void LoadEvents()
        {
            BtnRefresh.Click += BtnRefresh_Click;
            BtnEmpAdd.Click += BtnAdd_Click;
            BtnDepartment.Click += BtnDepartment_Click;
            BtnEmpModify.Click += BtnModify_Click;
            BtnEmpDel.Click += BtnDelete_Click;
            BtnLoginInfo.Click += Btn_LoginInfo_Click;
            BtnDataConv.Click += BtnDataConv_Click;
            BtnClose.Click += BtnClose_Click;
            EmpDgv.CellFormatting += EmpDgv_CellFormatting;
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
            var row = EmpDgv.CurrentRow.DataBoundItem as EmployeeModel;
            var dlg = new ModifyEmployeeForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmployeeData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) //삭제버튼
        {
            var row = EmpDgv.CurrentRow.DataBoundItem as EmployeeModel;
            var dlg = new DeleteEmployeeForm(row.EmpID, row.EmpCode, row.EmpName);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmployeeData();
            }
        }

        private void Btn_LoginInfo_Click(object sender, EventArgs e) //로그인정보버튼
        {
            var row = EmpDgv.CurrentRow.DataBoundItem as EmployeeModel;
            var dlg = new LoginInformationForm(row.LoginID, row.Pwd, row.EmpID);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmployeeData();
            }
        }

        private void LoadEmployeeData()
        {
            try
            {
                var employees = EmployeeRepository.Instance.GetAllEmployees();
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
            // 자료변환 - Excel로 내보내기
            try
            {
                // 저장할 파일 경로 선택
                string filePath = DataConversion.GetExcelSaveFilePath();
                if (string.IsNullOrEmpty(filePath))
                {
                    return; // 사용자가 취소한 경우
                }

                // 모든 직원 데이터 조회
                var employees = EmployeeRepository.Instance.GetAllEmployees();

                if (employees == null || employees.Count == 0)
                {
                    MessageBox.Show("내보낼 직원 데이터가 없습니다.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Excel 파일로 변환
                bool success = DataConversion.ExportEmployeesToExcel(employees, filePath);

                if (success)
                {
                    var result = MessageBox.Show(
                        $"Excel 파일이 성공적으로 생성되었습니다.\n\n파일 위치: {filePath}\n\n파일을 열어보시겠습니까?",
                        "변환 완료",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 변환 중 오류가 발생했습니다: {ex.Message}",
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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