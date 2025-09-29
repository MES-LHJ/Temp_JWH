using ApiEmpManagement.Model.Dto;
using ApiEmpManagement.Service;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ApiEmpManagement.Forms.Emp
{
    public partial class ModifyEmpForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _employeeToken;
        private readonly EmployeeDto _employeeDto;
        private readonly long _employeeId;
        public ModifyEmpForm(string employeeToken, EmployeeDto dto)
        {
            InitializeComponent();
            _employeeToken = employeeToken;
            _employeeDto = dto;
            _employeeId = dto.Id;
            LoadEvent();
            LoadEmpData();
        }
        #region Properties (TextEdit -> 속성)

        public string EmployeeCode //Code
        {
            get => EmpCodeTextBox.Text;
            set => EmpCodeTextBox.Text = value;
        }

        public string EmployeeName // Name
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
            get => long.TryParse(DeptCodeTextBox.Text, out var id) ? id : 0;
            set => DeptCodeTextBox.Text = value.ToString();
        }

        #endregion
        private void LoadEvent()
        {
            BtnCancel.Click += BtnClose_Click;
            BtnSave.Click += BtnModify_Click;
        }
        private void LoadEmpData()
        {
            EmpCodeTextBox.Text = _employeeDto.Code;
            EmpNameTextBox.Text = _employeeDto.Name;
            PositionTextBox.Text = _employeeDto.Position;
            EmpTypeTextBox.Text = _employeeDto.ContractType;
            PhoneTextBox.Text = _employeeDto.PhoneNumber;
            EmailTextBox.Text = _employeeDto.Email;
            MsgIDTextBox.Text = _employeeDto.MessengerId;
            MemoTextBox.Text = _employeeDto.Memo;
            DeptCodeTextBox.Text = _employeeDto.DepartmentId.ToString();
        }
        private async void BtnModify_Click(object sender, EventArgs e)
        {

            try
            {
                var updateDto = new EmployeeUpdateDto
                {
                    Code = this.EmployeeCode,
                    Name = this.EmployeeName,
                    Position = this.Position,
                    ContractType = this.ContractType,
                    PhoneNumber = this.PhoneNumber,
                    Email = this.Email,
                    MessengerId = this.MessengerId,
                    Memo = this.Memo,
                    DepartmentId = this.DepartmentId
                };

                bool success = await EmployeeService.Instance.UpdateEmployeeAsync(_employeeToken, _employeeId, updateDto);

                if (success)
                {
                    XtraMessageBox.Show("사원 수정 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"사원 수정 실패: {ex.Message}");
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}