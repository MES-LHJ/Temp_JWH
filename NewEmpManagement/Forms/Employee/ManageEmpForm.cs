using DevExpress.XtraEditors;
using NewEmpManagement.Forms.Department;
using NewEmpManagement.Forms.Employee;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Repository;
using System;
using System.Windows.Forms;

namespace NewEmpManagement.Forms
{
    public partial class ManageEmpForm : XtraForm
    {
        private readonly EmployeeRepository empList = EmployeeRepository.Instance;
        public ManageEmpForm()
        {
            InitializeComponent();
            LoadEmpData();
            LoadEvent();
        }

        private void LoadEvent() 
        {
            BtnClose.Click += BtnClose_Click;
            BtnDepartment.Click += BtnDepartment_Click;
            BtnRefresh.Click += BtnRefresh_Click;
            BtnAdd.Click += BtnAdd_Click;
            BtnMultiAdd.Click += BtnMultiAdd_Click;
            BtnModify.Click += BtnModify_Click;
            BtnLoginInfo.Click += BtnLoginInfo_Click;
            BtnDelete.Click += BtnDelete_Cick;
            BtnDataConv.Click += BtnDataConv_Click;
        }

        private async void LoadEmpData() // 사원 조회기능 
        {
            var emp = await empList.GetEmployeeDtosAsync();
            EmpGridView.DataSource = emp;
        }
        private void BtnDepartment_Click(object sender, EventArgs e) // 부서
        {
            var dlg = new ManageDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmpData();
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e) // 조회
        {
            var originalText = BtnRefresh.Text;
            BtnRefresh.Text = "조회중..";
            BtnRefresh.Enabled = false;

            try
            {
                LoadEmpData();
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
        private void BtnAdd_Click(object sender, EventArgs e) // 추가
        {
            var dlg = new AddEmpForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmpData();
            }
        }
        private void BtnMultiAdd_Click(object sender, EventArgs e) // 다중추가
        {
            var dlg = new MultiAddEmpForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmpData();
            }
        }
        private void BtnModify_Click(object sender, EventArgs e) // 수정
        {
            var row = gridView1.GetFocusedRow() as EmployeeDetailDto;
            var dlg = new ModifyEmpForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmpData();
            }
        }
        private void BtnLoginInfo_Click(object sender, EventArgs e) // 로그인정보
        {
            var row = gridView1.GetFocusedRow() as EmployeeDetailDto;
            var dlg = new LoginInfoEmpForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmpData();
            }
        }
        private void BtnDelete_Cick(object sender, EventArgs e) // 삭제
        {
            var row = gridView1.GetFocusedRow() as EmployeeDetailDto;
            var dlg = new DeleteEmpForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadEmpData();
            }
        }
        private void BtnDataConv_Click(object sender, EventArgs e) // 데이터변환
        {

        }
        private void BtnClose_Click(object sender, EventArgs e) // 닫기
        {
            Application.Exit();
        }
    }
}