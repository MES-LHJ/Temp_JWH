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

namespace ApiEmpManagement.Forms.Emp
{
    public partial class DelEmpForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _employeeToken;
        private readonly EmployeeDto _employeeDto;
        public DelEmpForm(string employeeToken, EmployeeDto dto)
        {
            InitializeComponent();
            _employeeToken = employeeToken;
            _employeeDto = dto;
            LoadEmpData();
            LoadEvent();
        }

        private void LoadEmpData()
        {
            EmpCodeTextBox.Text = _employeeDto.Code;
            EmpNameTextBox.Text = _employeeDto.Name;
        }
        private void LoadEvent()
        {
            BtnCancel.Click += BtnClose_Click;
            BtnDelete.Click += BtnDelete_Click;
        }
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = XtraMessageBox.Show(
                    $"{_employeeDto.Name} 사원을 삭제하시겠습니까?",
                    "삭제 확인",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var success = await EmployeeService.Instance.DeleteEmployeeAsync(_employeeToken, _employeeDto.Id);
                    if (success)
                    {
                        XtraMessageBox.Show("사원 삭제 완료", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK; // 부모 폼에서 OK 확인 후 새로고침 가능
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"삭제 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}