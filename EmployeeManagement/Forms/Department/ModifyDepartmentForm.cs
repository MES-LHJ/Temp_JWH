using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class ModifyDepartmentForm : Form
    {
        private readonly int DeptID;

        public ModifyDepartmentForm(int deptId, string deptCode, string deptName, string memo)
        {
            InitializeComponent();
            this.DeptID = deptId;
            DeptCodeTextBox.Text = deptCode;   // 부서코드
            DeptNameTextBox.Text = deptName;   // 부서명
            MemoTextBox.Text = memo;       // 메모를 '부서관리'에서 받아오는 생성자
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
                var department = new EmployeeManagement.Models.DepartmentModel
                { 
                    DeptID = this.DeptID,
                    DeptCode = newDeptCode,
                    DeptName = newDeptName, 
                    Memo = newMemo,
                };
                var repository = new DepartmentRepository();
                repository.UpdateDepartment(department);
                MessageBox.Show("수정 성공");
                this.DialogResult = DialogResult.OK;
                this.Close();
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
