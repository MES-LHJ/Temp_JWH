using DevExpress.XtraEditors;
using NewEmpManagement.Models;
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

namespace NewEmpManagement.Forms.Employee
{
    public partial class DeleteEmpForm : XtraForm
    {//gridview가 dto랑 연결되어서 dto로 받음
        private readonly EmployeeDetailDto EmployeeDetailDto;
        public DeleteEmpForm(EmployeeDetailDto EmployeeDetailDto)
        {
            InitializeComponent();
            this.EmployeeDetailDto = EmployeeDetailDto;
            LoadDelEmpData();
            LoadEvent();
        }
        private void LoadEvent()
        {
            BtnDelete.Click += BtnDelete_Click;
            BtnCancel.Click += BtnCancel_Click;
        }

        private void LoadDelEmpData() 
        {
            EmpCodeTextBox.Text = EmployeeDetailDto.EmpCode; 
            EmpNameTextBox.Text = EmployeeDetailDto.EmpName;
        }
        private void BtnDelete_Click(object sender, EventArgs e) //삭제버튼 -> Model로
        {
            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            var emp = EmployeeRepository.Instance;

            try
            {   emp.DeleteEmployee(EmployeeDetailDto.EmpID, EmployeeDetailDto.EmpCode);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("삭제 중 오류 발생", ex);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}