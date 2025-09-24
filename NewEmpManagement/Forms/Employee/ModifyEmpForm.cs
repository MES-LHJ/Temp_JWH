using DevExpress.XtraEditors;
using NewEmpManagement.Models;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Repository;
using NewEmpManagement.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.Employee
{
    public partial class ModifyEmpForm : XtraForm
    {
        public string SelectedPicturePath { get; private set; }
        public string CurrentPicturePath { get; set; }
        private readonly EmployeeDetailDto empDto;
        private List<UpperDepartmentModel> upperDeptList;
        private List<DepartmentDetailDto> deptList;

        public ModifyEmpForm(EmployeeDetailDto empDto)
        {
            InitializeComponent();
            this.empDto = empDto;
            LoadEmpData();
            LoadLookupDataAsync();
            LoadEvent();

        }
        private async Task LoadLookupDataAsync()
        {
            upperDeptList = await UpperDepartmentRepository.Instance.GetAllUpperDepartments();
            deptList = await DepartmentRepository.Instance.GetDepartmentDetailsAsync();

            // 상위부서 조회
            UDeptCodeLookupBox.Properties.DataSource = upperDeptList;
            UDeptCodeLookupBox.Properties.DisplayMember = "UDeptCode";
            UDeptCodeLookupBox.Properties.ValueMember = "UDeptID";

            DeptCodeLookupBox.Properties.DataSource = deptList;
            DeptCodeLookupBox.Properties.DisplayMember = "DeptCode";
            DeptCodeLookupBox.Properties.ValueMember = "DeptID";

        }
        private void UDeptLookupBox_EditValueChanged(object sender, EventArgs e)
        {
            // 선택된 상위부서 DTO
            var selectedUDept = UDeptCodeLookupBox.GetSelectedDataRow() as UpperDepartmentModel;

            if (selectedUDept != null)
            {
                UDeptNameTextBox.Text = selectedUDept.UDeptName;

                // 선택된 상위부서에 속한 하위부서만 필터링
                var filteredDepts = deptList
                    .Where(d => d.UDeptID == selectedUDept.UDeptID)
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
                var parentUDept = upperDeptList.FirstOrDefault(u => u.UDeptID == selectedDept.UDeptID);
                if (parentUDept != null)
                {
                    UDeptCodeLookupBox.EditValue = parentUDept.UDeptID;
                    UDeptNameTextBox.Text = parentUDept.UDeptName;

                    // 선택된 상위부서 기준으로 하위부서 필터링
                    var filteredDepts = deptList
                        .Where(d => d.UDeptID == parentUDept.UDeptID)
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
        private void LoadEmpData()
        {
            UDeptCodeLookupBox.EditValue = empDto.UDeptID;
            UDeptNameTextBox.Text = empDto.UDeptName;
            DeptCodeLookupBox.EditValue = empDto.DeptID;
            DeptNameTextBox.Text = empDto.DeptName;
            EmpCodeTextBox.Text = empDto.EmpCode;
            EmpNameTextBox.Text = empDto.EmpName;
            LoginIDTextBox.Text = empDto.LoginID;
            PwdTextBox.Text = empDto.Pwd;
            PositionTextBox.Text = empDto.Position;
            EmpTypeTextBox.Text = empDto.EmploymentType;
            PhoneTextBox.Text = empDto.Phone;
            EmailTextBox.Text = empDto.Email;
            GenderRBtn.EditValue = empDto.Gender.ToString();
            MsgIDTextBox.Text = empDto.MessengerID;
            MemoTextBox.Text = empDto.Memo;
            CurrentPicturePath = empDto.ImagePath; // dto에서 현재 이미지 경로
            // 이미지 로드
            if (!string.IsNullOrEmpty(empDto.ImagePath) && File.Exists(empDto.ImagePath))
            {
                byte[] imageBytes = File.ReadAllBytes(empDto.ImagePath);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    PictureEditEmp.Image = Image.FromStream(ms);
                }
            }

        }
        private void LoadEvent()
        {
            BtnSave.Click += BtnSave_Click;
            BtnCancel.Click += BtnCancel_Click;
            ImgSelect.Click += ImgBtn_Click;
            UDeptCodeLookupBox.EditValueChanged += UDeptLookupBox_EditValueChanged;
            DeptCodeLookupBox.EditValueChanged += DeptCodeLookupBox_EditValueChanged;
        }
        private void ImgBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "이미지 선택";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // PictureEdit에 이미지 미리보기
                    PictureEditEmp.Image =Image.FromFile(ofd.FileName);
                    string selectedFilePath = ofd.FileName;
                    SelectedPicturePath = ofd.FileName;
                }
            }
            
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Helpers.ValidateRequired(UDeptCodeLookupBox, "상위부서코드를 선택해주세요")) return;
            if (!Helpers.ValidateRequired(DeptCodeLookupBox, "부서코드를 선택해주세요")) return;
            if (!Helpers.ValidateRequired(EmpCodeTextBox, "사원코드를 입력해주세요")) return;
            if (!Helpers.ValidateRequired(EmpNameTextBox, "사원명을 입력해주세요")) return;
            if (!Helpers.ValidateRequired(LoginIDTextBox, "로그인ID를 입력해주세요")) return;
            if (!Helpers.ValidateRequired(PwdTextBox, "비밀번호를 입력해주세요")) return;

            try
            {
                var emp = EmployeeRepository.Instance;
                string targetFile = emp.UpdateEmployeeImage(EmpCodeTextBox.Text, SelectedPicturePath, CurrentPicturePath);
                var updatedEmp = new EmployeeModel
                {
                    EmpID = empDto.EmpID,
                    EmpCode = EmpCodeTextBox.Text,
                    EmpName = EmpNameTextBox.Text,
                    LoginID = LoginIDTextBox.Text,
                    Pwd = PwdTextBox.Text,
                    Position = PositionTextBox.Text,
                    EmploymentType = EmpTypeTextBox.Text,
                    Gender = emp.ParseGender(GenderRBtn.EditValue?.ToString()),
                    Phone = PhoneTextBox.Text,
                    Email = EmailTextBox.Text,
                    MessengerID = MsgIDTextBox.Text,
                    Memo = MemoTextBox.Text,
                    ImagePath = targetFile,
                    DeptID = empDto.DeptID,
                };
                MessageBox.Show($"CurrentPicturePath: {CurrentPicturePath ?? "NULL"}\nSelectedPicturePath: {SelectedPicturePath ?? "NULL"}", "디버그 정보");

                bool result = emp.UpdateEmployee(updatedEmp);
                if (result)
                {
                    MessageBox.Show("사원 정보가 성공적으로 수정되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("사원 정보 수정에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}