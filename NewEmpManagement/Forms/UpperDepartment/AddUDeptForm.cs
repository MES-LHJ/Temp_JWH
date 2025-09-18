using DevExpress.XtraEditors;
using System;
using NewEmpManagement.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewEmpManagement.Repository;

namespace NewEmpManagement.Forms.UpperDepartment
{
    public partial class AddUDeptForm : XtraForm
    {
        public AddUDeptForm()
        {
            InitializeComponent();
            LoadEvent();
        }
        private void LoadEvent()
        {
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnCancel_Click;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string UDeptCode = UDpetCodeTextBox.Text;
            string UDeptName = UDeptNameTextBox.Text;
            string Memo = MemoTextBox.Text;
            if (string.IsNullOrEmpty(UDeptCode) || string.IsNullOrEmpty(UDeptName))
            {
                MessageBox.Show("상위부서코드와 상위부서명을 입력하세요.");
                return;
            }
            try
            {
                var udept = new UpperDepartmentModel
                {
                    UDeptCode = UDeptCode,
                    UDeptName = UDeptName,
                    Memo = Memo
                };
                var repository = UpperDepartmentRepository.Instance;
                bool success = repository.AddUpperDepartment(udept);
                if (success)
                {
                    MessageBox.Show("상위부서가 성공적으로 추가되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("상위부서 추가에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"상위부서 추가 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}