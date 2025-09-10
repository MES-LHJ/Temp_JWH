using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class DeleteEmployeeForm : Form
    {
        private readonly int empId;
        private readonly string empCode;

        public DeleteEmployeeForm()
        {
            InitializeComponent();
            LoadEvents();
        }

        private void LoadEvents()
        {
            BtnDelete.Click += BtnDelete_Click;
            BtnCancel.Click += BtnClose_Click;
        }
        public DeleteEmployeeForm(int empId, string empCode, string empName) : this()
        {
            this.empId = Convert.ToInt32(empId);
            this.empCode = empCode;
            EmpCodeTextBox.Text = empCode;
            EmpNameTextBox.Text = empName;
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("정말로 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            try
            {
                var repo = EmployeeRepository.Instance;
                var success = repo.DeleteEmployee(empId, empCode); // 삭제 결과 반환
                if (success) {
                    MessageBox.Show("사원이 성공적으로 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("사원 삭제에 실패했습니다.", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
