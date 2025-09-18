using DevExpress.XtraEditors;
using NewEmpManagement.Models;
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
    public partial class DeleteEmpForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly EmployeeModel employeeModel;
        public DeleteEmpForm(EmployeeModel employeeModel)
        {
            InitializeComponent();
            this.employeeModel = employeeModel;
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
            EmpCodeTextBox.Text = employeeModel.EmpCode; // 여기서 오류뜸.->
            EmpNameTextBox.Text = employeeModel.EmpName;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //삭제
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}