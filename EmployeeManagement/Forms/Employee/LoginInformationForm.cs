using System;
using System.Configuration;
using System.Windows.Forms;
using EmployeeManagement.Models.Repository;

namespace EmployeeManagement.Forms.Employee
{
    public partial class LoginInformationForm : Form
    {
        private string EmpID;

        public LoginInformationForm()
        {
            InitializeComponent();
            BtnSave.Click += BtnSave_Click;
            BtnClose.Click += BtnClose_Click;
        }

        public LoginInformationForm(string loginId, string pwd, string empID) : this()
        {
            LoginIDTextBox.Text = loginId;
            PwdTextBox.Text = pwd;
            this.EmpID = empID;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string newLoginID = LoginIDTextBox.Text.Trim();
            string newPassword = PwdTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(EmpID))
            {
                MessageBox.Show("사원 정보가 없습니다.");
                return;
            }

            try
            {
                var repo = EmployeeRepository.Instance;
                bool success = repo.UpdateLoginInfo(Convert.ToInt32(this.EmpID), newLoginID, newPassword);

                if (success)
                {
                    MessageBox.Show("로그인 정보가 성공적으로 업데이트되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("로그인 정보 업데이트에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
        }
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
