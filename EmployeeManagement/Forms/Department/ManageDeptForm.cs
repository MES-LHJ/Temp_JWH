using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class ManageDeptForm : Form
    {
        private readonly DepartmentRepository DepartmentModel = DepartmentRepository.Instance;

        public ManageDeptForm()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void DepartmentManagementForm_Load(object sender, EventArgs e)
        {
            LoadDepartmentData();
        }

        private void LoadEvents() 
        {
            BtnChart.Click += BtnChart_Click;
            BtnAdd.Click += BtnAdd_Click;
            BtnModify.Click += BtnModify_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;
            this.Load += DepartmentManagementForm_Load;
        }

        private void LoadDepartmentData() // 조회기능 
        {
            try
            {
                var departments = DepartmentModel.GetAllDepartments();
                DeptDgv.DataSource = null; // 바인딩 초기화
                DeptDgv.DataSource = departments;
                DeptDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e) //추가버튼
        {
            using (var dlg = new AddDepartmentForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadDepartmentData();
                }
            }
        }

        private void BtnModify_Click(object sender, EventArgs e) //수정버튼
        {
            var row = DeptDgv.CurrentRow.DataBoundItem as DepartmentModel;
            var dlg = new ModifyDepartmentForm(row);
            
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadDepartmentData();
                }
        }
        private void BtnDelete_Click(object sender, EventArgs e) //삭제버튼
        {
            var row = DeptDgv.CurrentRow.DataBoundItem as DepartmentModel;
            var dlg = new DeleteDepartmentForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadDepartmentData();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) //닫기버튼
        {
            this.Close();
        }

        private void BtnChart_Click(object sender, EventArgs e) //차트버튼
        {
            var dlg = new ChartDepartment();
            dlg.ShowDialog();
        }
    }
}
