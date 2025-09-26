using ApiEmpManagement.Forms.Dept;
using ApiEmpManagement.Model;
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

namespace ApiEmpManagement.Forms.UDept
{
    public partial class ManageUDeptForm : XtraForm
    {
        public ManageUDeptForm()
        {
            InitializeComponent();
            LoadEvent();
        }
        private void LoadEvent()
        {
            BtnAdd.Click += BtnAdd_Click;
            BtnModify.Click += BtnModify_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;
        }
        private void BtnAdd_Click(object sender, EventArgs e) // 추가
        {
            var dlg = new AddUDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        private void BtnModify_Click(object sender, EventArgs e) // 수정
        {

            var dlg = new ModifyUDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
              
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e) // 삭제
        {

            var dlg = new DelUDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
    
            }
        }
        private void BtnClose_Click(object sender, EventArgs e) // 닫기
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}