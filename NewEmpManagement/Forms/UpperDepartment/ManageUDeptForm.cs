using DevExpress.XtraEditors;
using NewEmpManagement.Models;
using NewEmpManagement.Repository;
using System;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.UpperDepartment
{
    public partial class ManageUDeptForm : XtraForm
    {
        private readonly UpperDepartmentRepository UDeptModel = UpperDepartmentRepository.Instance;
        public ManageUDeptForm()
        {
            InitializeComponent();
            LoadEvent();
            LoadUDeptData();
        }
        private void LoadEvent()
        {
            BtnAdd.Click += BtnAdd_Click;
            BtnModify.Click += BtnModify_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;
        }

        private async void LoadUDeptData() // 조회기능 
        {
            try
            {
                var udepts = await UDeptModel.GetAllUpperDepartments();
                //UDeptGridView.DataSource = null; // 바인딩 초기화
                UDeptGridView.DataSource = udepts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"상위부서 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e) // 추가
        {
            var dlg = new AddUDeptForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUDeptData();
            }
        }
        private void BtnModify_Click(object sender, EventArgs e) // 수정
        {
            var row = gridView.GetFocusedRow() as UpperDepartmentModel;
            var dlg = new ModifyUDeptForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUDeptData(); 
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e) // 삭제
        {
            var row = gridView.GetFocusedRow() as UpperDepartmentModel;
            var dlg = new DeleteUDeptForm(row);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadUDeptData();
            }
        }
        private void BtnClose_Click(object sender, EventArgs e) // 닫기
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}