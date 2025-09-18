using DevExpress.XtraEditors;
using NewEmpManagement.Models;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Repository;
using NewEmpManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmpManagement.Forms
{
    public partial class AddEmpForm : XtraForm
    {
        private List<DepartmentDetailDto> deptDto;
        public AddEmpForm()
        {
            InitializeComponent();
            LoadEvent();
            LoadLookUpData();
        }
        private void LoadEvent()
        {
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnCancel_Click;
            UDeptLookupBox.EditValueChanged += UDeptLookupBox_EditValueChanged;
            DeptCodeLookupBox.EditValueChanged += DeptCodeLookupBox_EditValueChanged;
            BtnImgSelect.Click += BtnImgSelect_Click;
        }

        private async void LoadLookUpData()
        {
            try
            {
                deptDto = await Repository.DepartmentRepository.Instance.GetDepartmentDetailsAsync();

                //상위부서코드 중복제거
                var distinctList = deptDto
                    .GroupBy(x => new { x.UDeptCode, x.UDeptName })
                    .Select(g => g.First())
                    .ToList();

                //상위부서코드Lookup박스
                UDeptLookupBox.Properties.DataSource = distinctList;
                UDeptLookupBox.Properties.DisplayMember = "UDeptCode";
                UDeptLookupBox.Properties.ValueMember = "UDeptID";

                //부서코드Lookup박스
                DeptCodeLookupBox.Properties.DataSource = deptDto;
                DeptCodeLookupBox.Properties.DisplayMember = "DeptCode";
                DeptCodeLookupBox.Properties.ValueMember = "DeptID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터를 불러오는데 실패했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UDeptLookupBox_EditValueChanged(object sender, EventArgs e)
        {
            // 선택된 상위부서 DTO
            var selected = UDeptLookupBox.GetSelectedDataRow() as DepartmentDetailDto;

            if (selected != null)
            {
                UDeptNameTextBox.Text = selected.UDeptName;

                // 선택된 상위부서에 속한 하위부서만 필터링
                var filteredDepts = deptDto
                    .Where(d => d.UDeptID == selected.UDeptID)
                    .ToList();

                DeptCodeLookupBox.Properties.DataSource = filteredDepts;
                DeptCodeLookupBox.EditValue = null; // 이전 선택 초기화
                DeptNameTextBox.Text = string.Empty;
            }
            else
            {
                UDeptNameTextBox.Text = string.Empty;
                DeptCodeLookupBox.Properties.DataSource = null;
                DeptNameTextBox.Text = string.Empty;
            }
        }

        private void DeptCodeLookupBox_EditValueChanged(object sender, EventArgs e)
        {
            var selectedDept = DeptCodeLookupBox.GetSelectedDataRow() as DepartmentDetailDto;
            if (selectedDept != null)
            {
                // DeptName 표시
                DeptNameTextBox.Text = selectedDept.DeptName;

                // 상위부서 자동 선택
                var parentDept = deptDto.FirstOrDefault(d => d.UDeptID == selectedDept.UDeptID);
                if (parentDept != null)
                {
                    UDeptLookupBox.EditValue = parentDept.UDeptID;
                    UDeptNameTextBox.Text = parentDept.UDeptName;

                    // 선택된 상위부서 기준으로 하위부서 필터링
                    var filteredDepts = deptDto
                        .Where(d => d.UDeptID == parentDept.UDeptID)
                        .ToList();
                    DeptCodeLookupBox.Properties.DataSource = filteredDepts;

                    // 현재 선택 부서를 다시 선택
                    DeptCodeLookupBox.EditValue = selectedDept.DeptID;
                }
            }
            else
            {
                DeptNameTextBox.Text = string.Empty;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e) // 저장
        {
            if (!Helpers.ValidateRequired(UDeptLookupBox, "상위부서코드를 선택해주세요")) return;
            if (!Helpers.ValidateRequired(DeptCodeLookupBox, "부서코드를 선택해주세요")) return;
            if (!Helpers.ValidateRequired(EmpCodeTextBox, "사원코드를 입력해주세요")) return;
            if (!Helpers.ValidateRequired(EmpNameTextBox, "사원명을 입력해주세요")) return;
            if (!Helpers.ValidateRequired(LoginTextBox, "로그인ID를 입력해주세요")) return;
            if (!Helpers.ValidateRequired(PwdTextBox, "비밀번호를 입력해주세요")) return;



            try
            {
                var repository = EmployeeRepository.Instance;

                string empCode = EmpCodeTextBox.Text.Trim();
                string selectedPicturePath = PictureEditEmp.Tag?.ToString(); 
                string savedImagePath = string.Empty;

                if (!string.IsNullOrEmpty(selectedPicturePath))
                {
                    savedImagePath = repository.AddImage(empCode, selectedPicturePath);
                }

                // RadioGroup EditValue -> enum 변환
                var genderEnum = GenderRBtn.EditValue != null
                    ? EmployeeRepository.Instance.ParseGender(GenderRBtn.EditValue.ToString())
                    : Gender.None;

                var newEmployee = new EmployeeModel
                {
                    EmpCode = EmpCodeTextBox.Text.Trim(),
                    EmpName = EmpNameTextBox.Text.Trim(),
                    LoginID = LoginTextBox.Text.Trim(),
                    Pwd = PwdTextBox.Text.Trim(),
                    Position = PositionTextBox.Text.Trim(),
                    EmploymentType = EmpTypeTextBox.Text.Trim(),
                    Gender = genderEnum,
                    Phone = PhoneTextBox.Text.Trim(),
                    Email = EmailTextBox.Text.Trim(),
                    MessengerID = MsgIDTextBox.Text.Trim(),
                    Memo = MemoTextBox.Text,
                    ImagePath = savedImagePath,
                    DeptID = DeptCodeLookupBox.EditValue is int deptId ? deptId : 0
                };

                bool result = repository.AddEmployee(newEmployee);
                if (result)
                {
                    MessageBox.Show("사원 등록이 완료되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("사원 등록에 실패했습니다.", "실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"사원 등록에 실패했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnImgSelect_Click(object sender, EventArgs e) // 사진선택
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // 선택한 파일이 있으면 이미지 로드
                    PictureEditEmp.Image = Image.FromFile(ofd.FileName);
                    PictureEditEmp.Tag = ofd.FileName;
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}