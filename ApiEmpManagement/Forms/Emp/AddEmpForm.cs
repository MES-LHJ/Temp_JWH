using ApiEmpManagement.Model.Dto;
using ApiEmpManagement.Service;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ApiEmpManagement.Forms.Emp
{
    public partial class AddEmpForm : XtraForm
    {
        private readonly string _employeeToken;
        public AddEmpForm(string employeeToken)
        {
            InitializeComponent();
            _employeeToken = employeeToken;
            LoadEvent();
        }
        private void LoadEvent()
        {
            BtnSave.Click += btnAdd_Click;
            BtnCancel.Click += btnCancel_Click;
        }

        #region Form Properties (Get/Set)

        public string EmployeeCode
        {
            get => EmpCodeTextBox.Text;
            set => EmpCodeTextBox.Text = value;
        }
        public string EmployeeName
        {
            get => EmpNameTextBox.Text;
            set => EmpNameTextBox.Text = value;
        }
        public string Position
        {
            get => PositionTextBox.Text;
            set => PositionTextBox.Text = value;
        }
        public string ContractType
        {
            get => EmpTypeTextBox.Text;
            set => EmpTypeTextBox.Text = value;
        }
        public string LoginId
        {
            get => LoginIDTextBox.Text;
            set => LoginIDTextBox.Text = value;
        }
        public string LoginPassword
        {
            get => PwdTextBox.Text;
            set => PwdTextBox.Text = value;
        }
        public string LoginTag
        {
            get => LoginTagTextBox.Text;
            set => LoginTagTextBox.Text = value;
        }
        public string PhoneNumber
        {
            get => PhoneTextBox.Text;
            set => PhoneTextBox.Text = value;
        }
        public string Email
        {
            get => EmailTextBox.Text;
            set => EmailTextBox.Text = value;
        }
        public string MessengerId
        {
            get => MsgIDTextBox.Text;
            set => MsgIDTextBox.Text = value;
        }
        public string Memo
        {
            get => MemoTextBox.Text;
            set => MemoTextBox.Text = value;
        }
        public long DepartmentId
        {
            get => long.TryParse(DeptIdBox.Text, out var id) ? id : 0;
            set => DeptIdBox.Text = value.ToString();
        }
        public bool IsAdmin
        {
            get => AdminCheck.Checked;
            set => AdminCheck.Checked = true;
        }
        #endregion

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newEmployee = new EmployeeAddDto
                {
                    Code = this.EmployeeCode,
                    Name = this.EmployeeName,
                    Position = this.Position,
                    ContractType = this.ContractType,
                    LoginId = this.LoginId,
                    LoginPassword = this.LoginPassword,
                    LoginTag = this.LoginTag,
                    PhoneNumber = this.PhoneNumber,
                    Email = this.Email,
                    MessengerId = this.MessengerId,
                    Memo = this.Memo,
                    DepartmentId = this.DepartmentId,
                    IsAdmin = this.IsAdmin
                };

                bool success = await EmployeeService.Instance.AddEmployeeAsync(_employeeToken, newEmployee);

                if (success)
                {
                    XtraMessageBox.Show("사원 추가 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"사원 추가 실패: {ex.Message}");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}