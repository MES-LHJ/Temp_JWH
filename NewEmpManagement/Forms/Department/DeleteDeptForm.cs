using DevExpress.XtraEditors;
using NewEmpManagement.Models.Dto;
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

namespace NewEmpManagement.Forms.Department
{
    public partial class DeleteDeptForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly DepartmentDetailDto departmentDetailDto;
        public DeleteDeptForm(Models.Dto.DepartmentDetailDto departmentDetailDto)
        {
            InitializeComponent();
            this.departmentDetailDto = departmentDetailDto;
            LoadEvent();
            DeleteData();
        }

        private void DeleteData()
        {
            DeptCodeTextBox.Text = departmentDetailDto.DeptCode;
            DeptNameTextBox.Text = departmentDetailDto.DeptName;
;
        }
        private void LoadEvent()
        {
            BtnDelete.Click += BtnDelete_Click;
            BtnCancel.Click += BtnCancel_Click;

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var repository = DepartmentRepository.Instance;
                bool result = repository.DeleteDepartment(departmentDetailDto.DeptID);
                
                if (result)
                {
                    XtraMessageBox.Show("부서가 성공적으로 삭제되었습니다.", "삭제 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("부서 삭제에 실패했습니다.", "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"부서 삭제 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}