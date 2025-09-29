using ApiEmpManagement.Forms.UDept;
using ApiEmpManagement.Model.Dto;
using ApiEmpManagement.Service;
using ApiEmpManagement.Service.Api;
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
    public partial class ManageDeptForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly string token;
        public ManageDeptForm(string token)
        {
            InitializeComponent();
            LoadEvent();
            this.token = token;
            LoadDesign();
        }
        private void LoadEvent()
        {
            Load += LoadDeptData;
            BtnAdd.Click += BtnAdd_Click;
            BtnModify.Click += BtnModify_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;
        }
        private void LoadDesign()
        {
            BtnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnModify.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnModify.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            BtnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
        }
        private async void LoadDeptData(object sender, EventArgs e)
        {
            try
            {
                List<DepartmentDto> departments = await DepartmentService.Instance.GetDepartmentsAsync(token);
                gridControl2.DataSource = departments;
                gridControl1.DataSource = departments;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 조회 실패: {ex.Message}");
            }
        }
        private void BtnAdd_Click(Object sender, EventArgs e) // 추가
        {
            var dlg = new AddDeptForm(token);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadDeptData(sender, e);
            }
        }
        private void BtnModify_Click(Object sender, EventArgs e) // 수정
        {
            var row = gridView1.GetFocusedRow() as DepartmentDto;
            var dlg = new ModifyDeptForm(token, row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadDeptData(sender, e);
            }
        }
        private void BtnDelete_Click(Object sender, EventArgs e) // 삭제
        {
     
            var row = gridView1.GetFocusedRow() as DepartmentDto;
            var dlg = new DelDeptForm(token, row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadDeptData(sender, e);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e) // 닫기
        {
            this.Close();
        }
    }
}