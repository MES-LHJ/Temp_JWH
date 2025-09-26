using ApiEmpManagement.Forms.Dept;
using ApiEmpManagement.Model.Dto;
using ApiEmpManagement.Service;
using ApiEmpManagement.Service.Api;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiEmpManagement.Forms.Emp
{
    public partial class ManageEmpForm : DevExpress.XtraEditors.XtraForm
    {

        private readonly HttpClient _httpClient;
        string empOk { get; set; }
        public ManageEmpForm()
        {
            InitializeComponent();
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
            BtnDataConv.Click += BtnDataConv_ClickAsync;
        }
        private void BtnDepartment_Click(object sender, EventArgs e) // 부서
        {
            string empToken = empOk;
            var dlg = new ManageDeptForm(empToken);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               
            }
        }
        private async void BtnRefresh_Click(object sender, EventArgs e) // 조회
        {
            var originalText = BtnRefresh.Text;
            BtnRefresh.Text = "조회중..";
            BtnRefresh.Enabled = false;

            try
            {
                string empToken = empOk; // 로그인 시 받은 사원토큰
                int factoryId = 1;

                var employees = await EmployeeService.Instance.GetEmployeesAsync(empToken, factoryId);

                EmpGridView.DataSource = employees; // GridControl에 바인딩
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"데이터 조회 중 오류: {ex.Message}");
            }
            finally
            {
                BtnRefresh.Text = originalText;
                BtnRefresh.Enabled = true;
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e) // 추가
        {
            string empToken = empOk;

            var dlg = new AddEmpForm(empToken);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
            }
        }
        private void BtnMultiAdd_Click(object sender, EventArgs e) // 다중추가
        {

        }
        private void BtnModify_Click(object sender, EventArgs e) // 수정
        {
            string empToken = empOk;
            var row = gridView1.GetFocusedRow() as EmployeeDto;
            var dlg = new ModifyEmpForm(empToken, row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               
            }
        }
        private async void BtnLoginInfo_Click(object sender, EventArgs e) // 로그인정보
        {
            var api = ApiService.Instance;

            // 1. 업체 토큰 발급
            bool companyOk = await api.AuthenticateCompanyAsync("debug");
            if (!companyOk)
            {
                MessageBox.Show("업체 토큰 발급 실패");
                return;
            }
            MessageBox.Show("업체 토큰: " + api.CompanyToken);

            // 2. 사원 토큰 발급
            bool empOk = await api.AuthenticateEmployeeAsync("admin", "1111");
            if (!empOk)
            {
                MessageBox.Show("사원 토큰 발급 실패");
                return;
            }
            MessageBox.Show("사원 토큰: " + api.EmployeeToken);
            this.empOk = api.EmployeeToken;

        }
        private void BtnDelete_Cick(object sender, EventArgs e) // 삭제
        {
            string empToken = empOk;
            var row = gridView1.GetFocusedRow() as EmployeeDto;
            var dlg = new DelEmpForm(empToken, row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void BtnDataConv_ClickAsync(object sender, EventArgs e) // 데이터변환
        {
            
        }
        private void BtnClose_Click(object sender, EventArgs e) // 닫기
        {
            Application.Exit();
        }
    }
   
}