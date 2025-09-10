using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Employee
{
    public partial class ModifyEmployeeForm : Form
    {
        private EmployeeModel employee;
        public string SelectedPicturePath { get; private set; }
        private string CurrentPicturePath { get; set; }

        public ModifyEmployeeForm(EmployeeModel employee)
        {
            InitializeComponent();
            this.employee = employee;
            LoadDepartments();
            LoadEmployeeData();
            LoadEvents();
        }

        private void LoadEvents()
        {
            BtnSave.Click += BtnSave_Click;
            BtnClose.Click += BtnClose_Click;
            BtnSelectPicture.Click += BtnSelectPicture_Click;
        }
        private void LoadEmployeeData()
        {
            DeptCodeComboBox.SelectedValue = employee.DeptID; // deptid?
            DeptNameTextBox.Text = employee.DeptName;
            EmpCodeTextBox.Text = employee.EmpCode;
            EmpNameTextBox.Text = employee.EmpName;
            PositionTextBox.Text = employee.Position;
            EmploymentTypeTextBox.Text = employee.EmploymentType;
            PhoneTextBox.Text = employee.Phone;
            EmailTextBox.Text = employee.Email;
            MessengerIDTextBox.Text = employee.MessengerID;
            MemoTextBox.Text = employee.Memo;
            RbtnGenderMale.Checked = (employee.Gender == Gender.남);
            RbtnGenderFemale.Checked = (employee.Gender == Gender.여);
            CurrentPicturePath = employee.ImagePath;
            // 이미지 로드
            if (!string.IsNullOrEmpty(employee.ImagePath) && File.Exists(employee.ImagePath))
            {
                try
                {
                    using (FileStream fs = new FileStream(employee.ImagePath, FileMode.Open, FileAccess.Read))
                    {
                        var imageBytes = new byte[fs.Length];
                        fs.Read(imageBytes, 0, (int)fs.Length);

                        using (var ms = new MemoryStream(imageBytes))
                        {
                            EmpPictureBox.Image = Image.FromStream(ms);
                            EmpPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"이미지 로드 실패: {ex.Message}");
                    EmpPictureBox.Image = null;
                }
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
                MessageBox.Show($"CurrentPicturePath: {CurrentPicturePath ?? "NULL"}\nSelectedPicturePath: {SelectedPicturePath ?? "NULL"}", "디버그 정보");
                string targetFile = repository.ImageModify(empCode, SelectedPicturePath, CurrentPicturePath);

                employee.DeptID = deptId;
                employee.DeptCode = deptCode;
                employee.DeptName = deptName;
                employee.EmpCode = empCode;
                employee.EmpName = empName;
                employee.Gender = gender;
                employee.Position = position;
                employee.EmploymentType = employmentType;
                employee.Phone = phone;
                employee.Email = email;
                employee.MessengerID = messengerId;
                employee.Memo = memo;
                employee.ImagePath = targetFile;

                bool success = repository.UpdateEmployee(employee);

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
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 기존 이미지 해제 (파일 잠금 방지)
                    if (EmpPictureBox.Image != null)
                    {
                        EmpPictureBox.Image.Dispose();
                        EmpPictureBox.Image = null;
                    }

                    // 새 이미지를 복사본으로 로드
                    using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        var imageBytes = new byte[fs.Length];
                        fs.Read(imageBytes, 0, (int)fs.Length);

                        using (var ms = new MemoryStream(imageBytes))
                        {
                            EmpPictureBox.Image = Image.FromStream(ms);
                            EmpPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }

                    SelectedPicturePath = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"이미지 로드 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ofd.Dispose();
        }
    }
}
