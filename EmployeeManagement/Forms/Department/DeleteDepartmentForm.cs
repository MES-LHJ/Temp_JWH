using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class DeleteDepartmentForm : Form
    {
        private readonly int DeptID;
        public DeleteDepartmentForm(int deptId, string deptCode, string deptName)
        {
            InitializeComponent();
            this.DeptID = deptId;
            DeptCodeTextBox.Text = deptCode; // 부서코드
            DeptNameTextBox.Text = deptName; // 부서명
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;
          
            try
            {
                var repository = new DepartmentRepository();
                repository.DeleteDepartment(this.DeptID); // 부서 삭제 메서드 호출

                    MessageBox.Show("삭제 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

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
