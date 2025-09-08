using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class AddDepartmentForm : Form
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnCancel_Click;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string DeptCode = DeptCodeTextBox.Text.Trim();
            string DeptName = DeptNameTextBox.Text.Trim();
            string Memo = MemoTextBox.Text;

            if (string.IsNullOrEmpty(DeptCode) || string.IsNullOrEmpty(DeptName))
            {
                MessageBox.Show("부서코드와 부서명을 입력하세요.");
                return;
            }

            try
            {
                // DepartmentModel 인스턴스 생성
                var department = new DepartmentModel
                {
                    DeptCode = DeptCode,
                    DeptName = DeptName,
                    Memo = Memo
                };

                // DepartmentRepository 인스턴스 생성
                var repository = DepartmentRepository.Instance;

                bool success = repository.AddDepartment(department);
                if (success)
                {
                    MessageBox.Show("부서가 성공적으로 추가되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("부서 추가에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 추가 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
