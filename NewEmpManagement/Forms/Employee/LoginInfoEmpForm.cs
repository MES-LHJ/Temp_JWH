using NewEmpManagement.Models;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Repository;
using NewEmpManagement.Utils;
using System;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.Employee
{
    public partial class LoginInfoEmpForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly EmployeeDetailDto employeeDetailDto;
        public LoginInfoEmpForm(EmployeeDetailDto employeeDetailDto)
        {
            InitializeComponent();
            this.employeeDetailDto = employeeDetailDto;
            LoadEmpData();
            LoadEvent();
        }
        private void LoadEmpData()
        {
            LoginIDTextBox.Text = employeeDetailDto.LoginID;
            PwdTextBox.Text = employeeDetailDto.Pwd;
        }
        private void LoadEvent()
        {
            BtnClose.Click += BtnClose_Click;
            BtnSave.Click += BtnSave_Click;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Helpers.ValidateRequired(BtnClose, "로그인ID를 입력하세요")) return;
            if (!Helpers.ValidateRequired(PwdTextBox, "비밀번호를 입력하세요")) return;

            try
            {
                var updatedEmp = new EmployeeModel
                {
                    EmpID = employeeDetailDto.EmpID,           
                    EmpCode = employeeDetailDto.EmpCode,       
                    EmpName = employeeDetailDto.EmpName,       
                    LoginID = LoginIDTextBox.Text.Trim(),      
                    Pwd = PwdTextBox.Text.Trim(),              
                    Position = employeeDetailDto.Position,
                    EmploymentType = employeeDetailDto.EmploymentType,
                    Gender = employeeDetailDto.Gender,
                    Phone = employeeDetailDto.Phone,
                    Email = employeeDetailDto.Email,
                    MessengerID = employeeDetailDto.MessengerID,
                    Memo = employeeDetailDto.Memo,
                    ImagePath = employeeDetailDto.ImagePath,
                    DeptID = employeeDetailDto.DeptID
                };
                bool result = EmployeeRepository.Instance.UpdateEmployee(updatedEmp);
                if (result)
                {
                    MessageBox.Show("사원 정보가 성공적으로 수정되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("사원 정보 수정에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}