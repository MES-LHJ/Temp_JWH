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

namespace ApiEmpManagement.Forms.Dept
{
    public partial class AddDeptForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string _token;
        public AddDeptForm(string token)
        {
            InitializeComponent();
            _token = token;
            LoadEvent();
        }
        #region set properties
        public string DeptName => DeptNameTextBox.Text;
        public string DeptCode => DeptCodeTextBox.Text;
        public string DeptMemo => MemoTextBox.Text;
        public long? UpperDeptId
            => string.IsNullOrWhiteSpace(UDeptIdTextBox.Text)
               ? (long?)null
               : Convert.ToInt64(UDeptIdTextBox.Text);

        #endregion
        private void LoadEvent()
        {
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnCancel_Click;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new DepartmentAddDto
                {
                    Name = DeptName,
                    Code = DeptCode,
                    Memo = DeptMemo,
                    FactoryId = 1,
                    UpperDepartmentId = UpperDeptId
                };

                long newDeptId = await DepartmentService.Instance.AddDepartmentAsync(_token, dto);

                MessageBox.Show($"부서 추가 성공! 새 ID: {newDeptId}", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"추가 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}