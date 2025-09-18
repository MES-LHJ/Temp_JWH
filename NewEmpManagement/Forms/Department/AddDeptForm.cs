using DevExpress.XtraEditors;
using NewEmpManagement.Models;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Repository;
using NewEmpManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.Department
{
    public partial class AddDeptForm : XtraForm
    {
        private List<DepartmentDetailDto> upperDepartments;

        public AddDeptForm()
        {
            InitializeComponent();
            LoadEvent();
            LoadUpperDepartmentData();
        }

        private async void LoadUpperDepartmentData()
        {

            try
            {
                upperDepartments = await DepartmentRepository.Instance.GetDepartmentDetailsAsync();
                var distinctList = upperDepartments
                    .GroupBy(x => new { x.UDeptCode, x.UDeptName })
                    .Select(g => g.First())
                    .ToList();

                UDeptCodeLookUpBox.Properties.DataSource = distinctList;
                UDeptCodeLookUpBox.Properties.DisplayMember = "UDeptCode";
                UDeptCodeLookUpBox.Properties.ValueMember = "UDeptID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"상위부서 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadEvent()
        {
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnCancel_Click;
            UDeptCodeLookUpBox.EditValueChanged += UDeptCodeLookUpBox_EditValueChanged;
        }
        private void UDeptCodeLookUpBox_EditValueChanged(object sender, EventArgs e)
        {
            var selected = UDeptCodeLookUpBox.GetSelectedDataRow() as UpperDepartmentModel;
            if (selected != null)
            {
                UDeptNameTextBox.Text = selected.UDeptName;
            }
            else
            {
                // 선택이 해제된 경우 텍스트 초기화
                UDeptNameTextBox.Text = string.Empty;
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (!Helpers.ValidateRequired(UDeptCodeLookUpBox, "상위부서코드를 선택해주세요")) return;
            if (!Helpers.ValidateRequired(DeptCodeTextBox, "부서코드를 입력해주세요")) return;
            if (!Helpers.ValidateRequired(DeptNameTextBox, "부서명을 입력해주세요")) return;

            var newDepartment = new DepartmentModel
            {
                DeptCode = DeptCodeTextBox.Text.Trim(),
                DeptName = DeptNameTextBox.Text.Trim(),
                Memo = string.IsNullOrWhiteSpace(MemoTextBox.Text) ? null : MemoTextBox.Text,
                UDeptID = (int)UDeptCodeLookUpBox.EditValue
            };

            try
            {
                var repository = DepartmentRepository.Instance;
                bool result = repository.AddDepartment(newDepartment);

                if (result)
                {
                    MessageBox.Show("부서가 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("부서 추가에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 추가 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}