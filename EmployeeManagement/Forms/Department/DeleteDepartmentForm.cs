using EmployeeManagement.Models.Repository;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class DeleteDepartmentForm : Form
    {
        private readonly int DeptID;

        public DeleteDepartmentForm(int deptId, string deptCode, string deptName)
        {
            InitializeComponent();
            BtnDelete.Click += BtnDelete_Click;
            BtnCancel.Click += BtnCancel_Click;
            this.DeptID = deptId;
            DeptCodeTextBox.Text = deptCode; // 부서코드
            DeptNameTextBox.Text = deptName; // 부서명

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var repo = DepartmentRepository.Instance;

            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var deleted = repo.DeleteDepartment(this.DeptID);

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
