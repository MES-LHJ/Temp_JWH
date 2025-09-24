using DevExpress.XtraEditors;
using NewEmpManagement.Forms.UpperDepartment;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Repository;
using System;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.Department
{
    public partial class ManageDeptForm : XtraForm
    {
        private readonly UpperDepartmentRepository uDeptList = UpperDepartmentRepository.Instance;
        private readonly DepartmentRepository deptList = DepartmentRepository.Instance;
        private readonly EmployeeRepository empList = EmployeeRepository.Instance;
        public ManageDeptForm()
        {
            InitializeComponent();
            LoadEvent();
            LoadUpperDeptData();
            LoadDeptData();
        }
        private void LoadEvent()
        {
            BtnUDept.Click += BtnUDept_Click;
            BtnTreeList.Click += BtnTreeList_Click;
            BtnChart.Click += BtnChart_Click;
            BtnAdd.Click += BtnAdd_Click;
            BtnModify.Click += BtnModify_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;
        }
        private async void LoadUpperDeptData() // 상위부서 조회기능 
        {
            try
            {
                var udepts = await uDeptList.GetAllUpperDepartments();
                DeptGridView1.DataSource = udepts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"상위부서 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadDeptData() // 부서 조회기능 
        {
            try
            {
                var depts = await deptList.GetDepartmentDetailsAsync(); //dto조회 메소드
                DeptGridView2.DataSource = depts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnUDept_Click(object sender, EventArgs e) // 상위부서
        {
            var dlg = new ManageUDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUpperDeptData();
                LoadDeptData();
            }
        }
        private void BtnTreeList_Click(object sender, EventArgs e) // 트리리스트
        {
            var dlg = new TreeListDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUpperDeptData();
                LoadDeptData();
            }
        }
        private void BtnChart_Click(object sender, EventArgs e) // 차트
        {
            var dlg = new ChartDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUpperDeptData();
                LoadDeptData();
            }
        }
        private void BtnAdd_Click(Object sender, EventArgs e) // 추가
        {
            var dlg = new AddDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUpperDeptData();
                LoadDeptData();
            }
        }
        private void BtnModify_Click(Object sender, EventArgs e) // 수정
        {
            var row = gridView2.GetFocusedRow() as DepartmentDetailDto;
            var dlg = new ModifyDeptForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUpperDeptData();
                LoadDeptData();
            }
        }
        private void BtnDelete_Click(Object sender, EventArgs e) // 삭제
        {
            var row = gridView2.GetFocusedRow() as DepartmentDetailDto;
            var dlg = new DeleteDeptForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUpperDeptData();
                LoadDeptData();
            }
        }
        private void BtnClose_Click(object sender, EventArgs e) // 닫기
        {
            this.Close();
        }
    }
}