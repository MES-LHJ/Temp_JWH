using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class ModifyDepartmentForm : Form
    {
        private Models.DepartmentModel department;

        public ModifyDepartmentForm(Models.DepartmentModel department)
        {
            InitializeComponent();
            this.department = department;//위치 LoadDepartmentData();보다 위로
            LoadDepartmentData();
        }
        private void LoadDepartmentData() {
            DeptCodeTextBox.Text = department.DeptCode;
            DeptNameTextBox.Text = department.DeptName;
            MemoTextBox.Text = department.Memo;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string newDeptCode = DeptCodeTextBox.Text.Trim();
            string newDeptName = DeptNameTextBox.Text.Trim();
            string newMemo = MemoTextBox.Text;

            if (string.IsNullOrEmpty(newDeptCode) || string.IsNullOrEmpty(newDeptName))
            {
                MessageBox.Show("부서코드와 부서명은 필수 입력 항목입니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                department.DeptCode = newDeptCode;
                department.DeptName = newDeptName;
                department.Memo = newMemo;

                var repository = DepartmentRepository.Instance;
                bool success = repository.UpdateDepartment(department);

                if (success)
                {
                    MessageBox.Show("수정 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("수정 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 수정 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
