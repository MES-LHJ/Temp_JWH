using DevExpress.XtraEditors;
using NewEmpManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.UpperDepartment
{
    public partial class DeleteUDeptForm : XtraForm
    {
        private readonly Models.UpperDepartmentModel upperDepartment;
        public DeleteUDeptForm(Models.UpperDepartmentModel upperDepartment)
        {
            InitializeComponent();
            this.upperDepartment = upperDepartment;
            LoadUpperDepartmentData();
            LoadEvents();
        }
        private void LoadEvents()
        {
            BtnCancel.Click += BtnClose_Click;
            BtnDelete.Click += BtnDelete_Click;
        }
        private void LoadUpperDepartmentData()
        {
            UDeptCodeTextBox.Text = upperDepartment.UDeptCode;
            UDeptNameTextBox.Text = upperDepartment.UDeptName;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            try
            {
                var repository = UpperDepartmentRepository.Instance;
                bool success = repository.DeleteUpperDepartment(upperDepartment.UDeptID);
                if (success)
                {
                    MessageBox.Show("상위 부서가 성공적으로 삭제되었습니다.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("상위 부서 삭제에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"상위 부서 삭제 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}