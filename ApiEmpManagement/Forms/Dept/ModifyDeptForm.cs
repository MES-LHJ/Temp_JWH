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

namespace ApiEmpManagement.Forms.Dept
{
    public partial class ModifyDeptForm : DevExpress.XtraEditors.XtraForm
    {   private readonly DepartmentDto deptdto;
        private readonly string token;
        public ModifyDeptForm(string token, DepartmentDto deptDto)
        {
            InitializeComponent();
            this.deptdto = deptDto;
            this.token = token;
            LoadData();
            LoadEvent();
        }
        private void LoadData()
        {
            DeptNameTextBox.Text = deptdto.Name;
            DeptCodeTextBox.Text = deptdto.Code;
            MemoTextBox.Text = deptdto.Memo;
            UDeptIdTextBox.Text = deptdto.UpperDepartmentId?.ToString() ?? "";
        }
        #region
        public string DeptName
        {
            get => DeptNameTextBox.Text;
            set => DeptNameTextBox.Text = value;
        }

        public string DeptCode
        {
            get => DeptCodeTextBox.Text;
            set => DeptCodeTextBox.Text = value;
        }

        public string DeptMemo
        {
            get => MemoTextBox.Text;
            set => MemoTextBox.Text = value;
        }

        public long? UpperDeptId
        {
            get { if (long.TryParse(UDeptIdTextBox.Text.Trim(), out long id)) return id; return null; }
            set => UDeptIdTextBox.Text = value?.ToString() ?? "";
        }
        #endregion
        private void LoadEvent()
        {
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnCancel_Click;
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // TextBox 값 가져와서 DTO 생성
                var dto = new DepartmentAddDto
                {
                    Name = DeptName,
                    Code = DeptCode,
                    Memo = DeptMemo,
                    FactoryId = 1, // 고정
                    UpperDepartmentId = UpperDeptId
                };

                // API 호출
                await DepartmentService.Instance.UpdateDepartmentAsync(deptdto.Id, token, dto);

                MessageBox.Show("부서 수정 완료", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 수정 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}