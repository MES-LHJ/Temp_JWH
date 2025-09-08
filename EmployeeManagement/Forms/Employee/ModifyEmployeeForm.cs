using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;
using System;
using System.IO;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Employee
{
    public partial class ModifyEmployeeForm : Form
    {
        public string SelectedPicturePath { get; private set; }
        private int EmpID { get; set; }
        private string CurrentPicturePath { get; set; }

        public ModifyEmployeeForm()
        {
            InitializeComponent();
            LoadDepartments();
            BtnSelectPicture.Click += BtnSelectPicture_Click;
            BtnSave.Click += BtnSave_Click;
            BtnClose.Click += BtnClose_Click;
        }

        public ModifyEmployeeForm(
            int empID,
            string deptCode, string deptName, string empCode, string empName, string gender,
            string position, string employmentType, string phone, string email, string messengerId, string memo, string imagePath)
            : this()
        {
            EmpID = empID;
            CurrentPicturePath = imagePath;
            if (!string.IsNullOrEmpty(deptCode))

                DeptNameTextBox.Text = deptName;
                EmpCodeTextBox.Text = empCode;
                EmpNameTextBox.Text = empName;
                RbtnGenderMale.Checked = (gender == "남"); // Gender 라디오버튼 처리
                RbtnGenderFemale.Checked = (gender == "여");
                PositionTextBox.Text = position;
                EmploymentTypeTextBox.Text = employmentType;
                PhoneTextBox.Text = phone;
                EmailTextBox.Text = email;
                MessengerIDTextBox.Text = messengerId;
                MemoTextBox.Text = memo;
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath)){
                EmpPictureBox.Image = System.Drawing.Image.FromFile(imagePath);
                EmpPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void LoadDepartments()
        {
            try
            {
                var departments = DepartmentRepository.Instance.GetAllDepartments();

                DeptCodeComboBox.DataSource = departments;
                DeptCodeComboBox.DisplayMember = "DeptCode";  // 화면에 표시될 값
                DeptCodeComboBox.ValueMember = "DeptID";    // 실제 값

                // 초기 선택 없음
                //DeptCodeComboBox.SelectedIndex = -1;

                // 선택 변경 이벤트 핸들러 추가
                DeptCodeComboBox.SelectedIndexChanged += DeptCodeComboBox_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 데이터 로드 중 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 부서 선택 시 부서명 자동 업데이트
        private void DeptCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeptCodeComboBox.SelectedItem != null)
            {
                var selectedDept = (DepartmentModel)DeptCodeComboBox.SelectedItem;
                DeptNameTextBox.Text = selectedDept.DeptName;
            }
            else
            {
                DeptNameTextBox.Text = string.Empty;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e) // 수정 버튼
        {
            string deptCode = DeptCodeComboBox.SelectedValue?.ToString() ?? string.Empty;
            int deptId = EmployeeRepository.Instance.GetDeptIdByCode(deptCode);
            string deptName = DeptNameTextBox.Text;
            string empCode = EmpCodeTextBox.Text;
            string empName = EmpNameTextBox.Text;
            Gender gender = Gender.None;
            if (RbtnGenderMale.Checked)
                gender = Gender.남;
            else if (RbtnGenderFemale.Checked)
                gender = Gender.여;
            string position = PositionTextBox.Text;
            string employmentType = EmploymentTypeTextBox.Text;
            string phone = PhoneTextBox.Text;
            string email = EmailTextBox.Text;
            string messengerId = MessengerIDTextBox.Text;
            string memo = MemoTextBox.Text;
            string imagePath = EmpPictureBox.ImageLocation;
            // 필수값 체크
            if (string.IsNullOrEmpty(DeptCodeComboBox.Text) ||
                string.IsNullOrEmpty(EmpCodeTextBox.Text) ||
                string.IsNullOrEmpty(EmpNameTextBox.Text))
            {
                MessageBox.Show("부서코드, 사원코드, 사원명은 필수 입력 항목입니다.");
                return;
            }
            try
            {
                //이미지 삭제 후 선택이미지 복사되도록 수정필요
                var repository = EmployeeRepository.Instance;
                string targetFile = repository.ImageModify(empCode, SelectedPicturePath, CurrentPicturePath); 

                var info = new EmployeeModel
                    {
                        EmpID = this.EmpID,
                        DeptID = deptId,
                        DeptCode = deptCode,
                        DeptName = deptName,
                        EmpCode = empCode,
                        EmpName = empName,
                        Gender = gender,
                        Position = position,
                        EmploymentType = employmentType,
                        Phone = phone,
                        Email = email,
                        MessengerID = messengerId,
                        Memo = memo,
                        ImagePath = targetFile ?? string.Empty
                    };

                bool success = repository.UpdateEmployee(info);

                if (success)
                {
                    MessageBox.Show("사원 정보가 수정되었습니다.", "수정 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("사원 정보 수정에 실패했습니다.", "수정 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 : {ex.Message}\n\n상세 오류: {ex.InnerException?.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "사진 선택",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"
            };
            ofd.ShowDialog();

            if (!string.IsNullOrEmpty(ofd.FileName))
            {

                EmpPictureBox.ImageLocation = ofd.FileName;
                EmpPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                SelectedPicturePath = ofd.FileName; //OFD 화면에 떠 있는 이미지
            }
            ofd.Dispose();
        }
    }
}
