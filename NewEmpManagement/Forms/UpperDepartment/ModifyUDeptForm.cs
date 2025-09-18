using DevExpress.XtraEditors;
using NewEmpManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.UpperDepartment
{
    public partial class ModifyUDeptForm : XtraForm
    {
        private readonly Models.UpperDepartmentModel upperDepartment;
        public ModifyUDeptForm(Models.UpperDepartmentModel upperDepartment)
        {
            InitializeComponent();
            this.upperDepartment = upperDepartment;
            LoadUpperDepartmentData();
            LoadEvent();
        }
        private void LoadUpperDepartmentData() 
        {
            UDeptCodeTextBox.Text = upperDepartment.UDeptCode;
            UDeptNameTextBox.Text = upperDepartment.UDeptName;
            MemoTextBox.Text = upperDepartment.Memo;
        }
        private void LoadEvent()
        {
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnClose_Click;
        }
        private void BtnSave_Click(object sender, EventArgs e) // 저장
        {
            string newUDeptCode = UDeptCodeTextBox.Text.Trim();
            string newUDeptName = UDeptNameTextBox.Text.Trim();
            string newMemo = MemoTextBox.Text;
            if (string.IsNullOrEmpty(newUDeptCode) || string.IsNullOrEmpty(newUDeptName))
            {
                MessageBox.Show("상위부서코드와 상위부서명은 필수 입력 항목입니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                upperDepartment.UDeptCode = newUDeptCode;
                upperDepartment.UDeptName = newUDeptName;
                upperDepartment.Memo = newMemo;
                var repository = UpperDepartmentRepository.Instance;
                bool success = repository.UpdateUpperDepartment(upperDepartment);
                if (success)
                {
                    MessageBox.Show("수정 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("수정 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"상위부서 수정 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e) // 닫기
        {
            this.Close();
        }
    }
}