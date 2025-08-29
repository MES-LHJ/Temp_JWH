using EmployeeManagement.Models.Repository;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class DeleteEmployeeForm : Form
    {
        private int empId;
        public DeleteEmployeeForm()
        {
            InitializeComponent();
        }

        public DeleteEmployeeForm(string empId, string empCode, string empName) : this()
        {
            this.empId = Convert.ToInt32(empId);
            EmpCodeTextBox.Text = empCode;
            EmpNameTextBox.Text = empName;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string empCode = EmpCodeTextBox.Text;

            var result = MessageBox.Show("정말로 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            try
            {
                var repo = new EmployeeRepository();
                bool deleteSuccess = repo.DeleteEmployee(empId); // 삭제 결과 반환

                if (deleteSuccess)
                {
                    MessageBox.Show("사원이 성공적으로 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("해당 사원을 찾을 수 없습니다.", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
