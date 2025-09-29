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
    public partial class DelDeptForm : XtraForm
    {
        private readonly DepartmentDto _deptDto;
        private readonly string _token;
        public DelDeptForm(string token, DepartmentDto deptDto)
        {
            InitializeComponent();
            _token = token;
            _deptDto = deptDto;
            LoadData();
            LoadEvent();
        }
        #region Form Properties
        public string DeptCode
        {
            get => DeptCodeTextBox.Text;
            set => DeptCodeTextBox.Text = value;
        }

        public string DeptName
        {
            get => DeptNameTextBox.Text;
            set => DeptNameTextBox.Text = value;
        }
        #endregion

        private void LoadData()
        {
            if (_deptDto == null) return;
            DeptCode = _deptDto.Code;
            DeptName = _deptDto.Name;
        }

        private void LoadEvent()
        {
            BtnDelete.Click += BtnDelete_Click;
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = XtraMessageBox.Show(
                    $"{_deptDto.Name} 부서를 삭제하시겠습니까?",
                    "삭제 확인",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes) return;

                await DepartmentService.Instance.DeleteDepartmentAsync(_deptDto.Id, _token);

                XtraMessageBox.Show("부서 삭제 완료", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // 부모폼에서 OK 확인 후 새로고침 가능
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"삭제 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
