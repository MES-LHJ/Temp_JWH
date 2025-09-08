using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class ManageDeptForm : Form
    {

        public ManageDeptForm()
        {
            InitializeComponent();
            this.Load += DepartmentManagementForm_Load;
            BtnChart.Click += BtnChart_Click;
            BtnAdd.Click += BtnAdd_Click;
            BtnModify.Click += BtnModify_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;
        }

        private void DepartmentManagementForm_Load(object sender, EventArgs e)
        {
            LoadDepartmentData();
        }
        private readonly DepartmentRepository DepartmentModel = DepartmentRepository.Instance;

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
            DataGridViewRow row = null;
            if (DeptDgv.SelectedCells.Count > 0)
                row = DeptDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {
                int deptId = Convert.ToInt32(row.Cells[nameof(deptIDDataGridViewTextBoxColumn)].Value);
                string deptCode = row.Cells[nameof(deptCodeDataGridViewTextBoxColumn)].Value?.ToString() ?? string.Empty;
                string deptName = row.Cells[nameof(deptNameDataGridViewTextBoxColumn)].Value?.ToString() ?? string.Empty;
                string memo = row.Cells[nameof(memoDataGridViewTextBoxColumn)].Value?.ToString() ?? string.Empty;

                using (var dlg = new ModifyDepartmentForm(deptId, deptCode, deptName, memo))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        LoadDepartmentData();
                    }
                }
            }
            else
            {
                MessageBox.Show("수정할 셀을 선택하세요.");
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e) //삭제버튼
        {
            DataGridViewRow row = null;
            if (DeptDgv.SelectedCells.Count > 0)
                row = DeptDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {
                int deptId = Convert.ToInt32(row.Cells[nameof(deptIDDataGridViewTextBoxColumn)].Value);
                string deptCode = row.Cells[nameof(deptCodeDataGridViewTextBoxColumn)].Value?.ToString() ?? string.Empty;
                string deptName = row.Cells[nameof(deptNameDataGridViewTextBoxColumn)].Value?.ToString() ?? string.Empty;

                using (var dlg = new DeleteDepartmentForm(deptId, deptCode, deptName))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        LoadDepartmentData();
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제할 셀을 선택하세요.");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) //닫기버튼
        {
            this.Close();
        }

        private void BtnChart_Click(object sender, EventArgs e)
        {
            var dlg = new ChartDepartment();
            dlg.ShowDialog();
        }
    }
}
