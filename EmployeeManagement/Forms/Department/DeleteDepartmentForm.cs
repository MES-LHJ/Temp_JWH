using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class DeleteDepartmentForm : Form
    {
        private Models.DepartmentModel department;

        public DeleteDepartmentForm(Models.DepartmentModel department)
        {
            InitializeComponent();
            this.department = department;
            LoadDepartmentData();
            LoadEvents();
        }
        private void LoadEvents()
        {
            BtnDelete.Click += BtnDelete_Click;
            BtnCancel.Click += BtnCancel_Click;
        }
        private void LoadDepartmentData() { 
            DeptCodeTextBox.Text = department.DeptCode;
            DeptNameTextBox.Text = department.DeptName;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var repo = DepartmentRepository.Instance;

            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var deleted = repo.DeleteDepartment(department.DeptID);

                if (deleted)
                {
                    MessageBox.Show("삭제성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("삭제실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 삭제 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
