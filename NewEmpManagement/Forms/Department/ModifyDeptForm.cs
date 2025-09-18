using DevExpress.XtraEditors;
using NewEmpManagement.Models;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Repository;
using NewEmpManagement.Utils;
using System;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.Department
{
    public partial class ModifyDeptForm : XtraForm
    {
        private readonly DepartmentDetailDto departmentDetailDto;
        public ModifyDeptForm(DepartmentDetailDto departmentDetailDto)
        {
            InitializeComponent();
            LoadEvent();
            this.departmentDetailDto = departmentDetailDto;
            LoadDtoData();
            LoadUpperDepartmentDropdown();
        }
        private async void LoadUpperDepartmentDropdown()
        {
            try
            {
                // 상위부서 데이터 조회
                var upperDepartments = await UpperDepartmentRepository.Instance.GetAllUpperDepartments();

                // LookUpEdit 설정
                UDeptCodeLookUpBox.Properties.DataSource = upperDepartments;
                UDeptCodeLookUpBox.Properties.DisplayMember = "UDeptCode"; // 표시할 필드
                UDeptCodeLookUpBox.Properties.ValueMember = "UDeptID";   // 값으로 사용할 필드

            }
            catch (Exception ex)
            {
                MessageBox.Show($"상위부서 데이터 로드 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDtoData()
        {
            UDeptCodeLookUpBox.EditValue = departmentDetailDto.UDeptID;
            UDeptNameTextBox.Text = departmentDetailDto.UDeptName;
            DeptCodeTextBox.Text = departmentDetailDto.DeptCode;
            DeptNameTextBox.Text = departmentDetailDto.DeptName;
            MemoTextBox.Text = departmentDetailDto.Memo;
        }

        private void LoadEvent()
        {
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnCancel_Click;
            UDeptCodeLookUpBox.EditValueChanged += UDeptCodeLookUpBox_EditValueChanged;
        }
        private void UDeptCodeLookUpBox_EditValueChanged(object sender, EventArgs e)
        {
            var lookup = sender as LookUpEdit;
            if (lookup != null)
            {
                // 현재 선택된 Row 가져오기
                var selected = lookup.GetSelectedDataRow() as UpperDepartmentModel;
                if (selected != null)
                {
                    UDeptNameTextBox.Text = selected.UDeptName;
                }
                else
                {
                    UDeptNameTextBox.Text = string.Empty;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Helpers.ValidateRequired(UDeptCodeLookUpBox, "상위부서코드를 선택해주세요")) return;
            if (!Helpers.ValidateRequired(DeptCodeTextBox, "부서코드를 입력해주세요")) return;
            if (!Helpers.ValidateRequired(DeptNameTextBox, "부서명을 입력해주세요")) return;

            try
            {
                var updatedDept = new DepartmentModel
                {
                    DeptID = departmentDetailDto.DeptID,
                    DeptCode = DeptCodeTextBox.Text,
                    DeptName = DeptNameTextBox.Text,
                    Memo = MemoTextBox.Text,
                    UDeptID = Convert.ToInt32(UDeptCodeLookUpBox.EditValue)
                };

                bool result = DepartmentRepository.Instance.UpdateDepartment(updatedDept);
                if (result)
                {
                    MessageBox.Show("부서 정보가 수정되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("수정할 수 없습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"수정 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}