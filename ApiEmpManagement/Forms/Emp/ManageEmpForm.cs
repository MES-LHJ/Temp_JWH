using ApiEmpManagement.Forms.Dept;
using ApiEmpManagement.Model.Dto;
using ApiEmpManagement.Service;
using ApiEmpManagement.Service.Api;
using DevExpress.XtraEditors;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiEmpManagement.Forms.Emp
{
    public partial class ManageEmpForm : XtraForm
    {

        private readonly HttpClient _httpClient;
        string empOk { get; set; }
        public ManageEmpForm()
        {
            InitializeComponent();
            LoadEvent();
            LoadDesign();
        }

        private void LoadEvent()
        {
            BtnClose.Click += BtnClose_Click;
            BtnDepartment.Click += BtnDepartment_Click;
            BtnRefresh.Click += BtnRefresh_Click;
            BtnAdd.Click += BtnAdd_Click;
            BtnModify.Click += BtnModify_Click;
            BtnLoginInfo.Click += BtnLoginInfo_Click;
            BtnDelete.Click += BtnDelete_Cick;
        }
        private void LoadDesign()
        {
            BtnDepartment.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnRefresh.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnModify.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnLoginInfo.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnDepartment.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnRefresh.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnModify.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnLoginInfo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;

            layoutItemDept.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutItemRefresh.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutItemAdd.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutItemModify.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutItemDel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void BtnDepartment_Click(object sender, EventArgs e) // 부서
        {
            string empToken = empOk;
            var dlg = new ManageDeptForm(empToken);
            dlg.ShowDialog();
        }
        private async Task LoadEmployeesAsync() //비동기 조회
        {
            try
            {
                string empToken = empOk;
                int factoryId = 1;

                var employees = await EmployeeService.Instance.GetEmployeesAsync(empToken, factoryId);
                EmpGridView.DataSource = employees; // GridControl에 바인딩
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"데이터 조회 중 오류: {ex.Message}");
            }
        }
        private async void BtnRefresh_Click(object sender, EventArgs e) // 조회버튼
        {
            var originalText = BtnRefresh.Text;
            BtnRefresh.Text = "조회중..";
            BtnRefresh.Enabled = false;

            await LoadEmployeesAsync();

            BtnRefresh.Text = originalText;
            BtnRefresh.Enabled = true;
        }
        private async void BtnAdd_Click(object sender, EventArgs e) // 추가
        {
            string empToken = empOk;
            var dlg = new AddEmpForm(empToken);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                await LoadEmployeesAsync(); 
            }
        }
        private async void BtnModify_Click(object sender, EventArgs e) // 수정
        {
            string empToken = empOk;
            var row = gridView1.GetFocusedRow() as EmployeeDto;
            var dlg = new ModifyEmpForm(empToken, row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                await LoadEmployeesAsync(); 
            }
        }
        private async void BtnLoginInfo_Click(object sender, EventArgs e) // 로그인
        {
            var api = ApiService.Instance;

            // 업체 토큰
            bool companyOk = await api.AuthenticateCompanyAsync("debug");
            if (!companyOk)
            {
                MessageBox.Show("업체 토큰 발급 실패");
                return;
            }

            // 사원 토큰
            bool empOk = await api.AuthenticateEmployeeAsync("admin", "1111");
            if (!empOk)
            {
                MessageBox.Show("사원 토큰 발급 실패");
                return;
            }

            this.empOk = api.EmployeeToken;
            await LoadEmployeesAsync();

            // 버튼 보이기
            layoutItemDept.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutItemRefresh.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutItemAdd.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutItemModify.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            layoutItemDel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }
        private async void BtnDelete_Cick(object sender, EventArgs e) // 삭제
        {
            string empToken = empOk;
            var row = gridView1.GetFocusedRow() as EmployeeDto;
            var dlg = new DelEmpForm(empToken, row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                await LoadEmployeesAsync(); 
            }
        }
        private void BtnClose_Click(object sender, EventArgs e) // 닫기
        {
            Application.Exit();
        }
    }
   
}