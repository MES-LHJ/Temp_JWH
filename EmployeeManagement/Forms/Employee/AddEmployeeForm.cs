using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;

namespace EmployeeManagement.Forms.Employee
{
    public partial class AddEmployeeForm : Form
    {
        // 부서 정보 저장용 - DataTable에서 List로 변경
        private List<DepartmentModel> deptList;
        public string SelectedPicturePath { get; private set; } // 선택된 사진 경로

        public AddEmployeeForm()
        {
            InitializeComponent();
            LoadDeptCodes();
            DeptCodeComboBox.SelectedIndexChanged += DeptCodeComboBox_SelectedIndexChanged;
            BtnSave.Click += ButtonSave_Click;
            BtnCancel.Click += BtnCancel_Click;
            BtnSelectPicture.Click += BtnSelectPicture_Click;

        }

        private void LoadDeptCodes() // 부서코드, 부서명 콤보박스에 데이터 로드
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
            string query = "SELECT DeptID, DeptCode, DeptName FROM Department";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        deptList = new List<DepartmentModel>();
                        
                        while (reader.Read())
                        {
                            deptList.Add(new DepartmentModel
                            {
                                DeptID = (int)reader[nameof(DepartmentModel.DeptID)],
                                DeptCode = (string)reader[nameof(DepartmentModel.DeptCode)],
                                DeptName = (string)reader[nameof(DepartmentModel.DeptName)]
                            });
                        }
                    }
                }
                DeptCodeComboBox.DisplayMember = "DeptCode";
                DeptCodeComboBox.ValueMember = "DeptID";
                DeptCodeComboBox.DataSource = deptList;
                //DeptCodeComboBox.SelectedIndex = -1; // 초기 선택 해제
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 정보 로드 중 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeptCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeptCodeComboBox.SelectedValue != null && deptList != null)
            {
                // LINQ를 사용하여 List에서 검색
                var selectedDeptId = Convert.ToInt32(DeptCodeComboBox.SelectedValue);
                var selectedDept = deptList.FirstOrDefault(d => d.DeptID == selectedDeptId);
                
                if (selectedDept != null)
                {
                    DeptNameTextBox.Text = selectedDept.DeptName;
                }
                else
                {
                    DeptNameTextBox.Text = string.Empty;
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e) // 저장 버튼 누른다
        {
            // 입력값 읽기 - ValueMember가 DeptID이므로 직접 사용
            int deptId = Convert.ToInt32(DeptCodeComboBox.SelectedValue ?? 0);
            string empCode = EmpCodeTextBox.Text.Trim();
            string empName = EmpNameTextBox.Text.Trim();
            Gender gender = Gender.None;
            if (RbtnGenderMale.Checked)
                gender = Gender.남;
            else if (RbtnGenderFemale.Checked)
                gender = Gender.여;
            string loginId = LoginIDTextBox.Text.Trim();
            string pwd = PwdTextBox.Text.Trim();
            string position = PositionTextBox.Text.Trim();
            string employmentType = EmploymentTypeTextBox.Text.Trim();
            string phone = PhoneTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string messengerId = MessengerIDTextBox.Text.Trim();
            string memo = MemoTextBox.Text;

            // 필수 입력값 체크
            if (string.IsNullOrEmpty(empCode))
            {
                MessageBox.Show("사원코드를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmpCodeTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(empName))
            {
                MessageBox.Show("사원명을 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmpNameTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(loginId))
            {
                MessageBox.Show("로그인ID를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginIDTextBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("비밀번호를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PwdTextBox.Focus();
                return;
            }
            try
            {
                var repository = EmployeeRepository.Instance; //EmployeeRepository 객체 가져오기
                string targetFile = repository.ImageAdd(empCode, SelectedPicturePath); // 이미지 처리

                // EmployeeModel 객체 생성
                var employee = new EmployeeModel
                {
                    DeptID = deptId,
                    EmpCode = empCode,
                    EmpName = empName,
                    Gender = gender,
                    LoginID = loginId,
                    Pwd = pwd,
                    Position = position,
                    EmploymentType = employmentType,
                    Phone = phone,
                    Email = email,
                    MessengerID = messengerId,
                    Memo = memo,
                    ImagePath = targetFile // 이미지 경로
                };

                // EmployeeRepository를 통해 저장
                bool success = repository.AddEmployee(employee);

                if (success)
                {
                    MessageBox.Show("사원 정보가 저장되었습니다.", "저장 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("사원 정보 저장에 실패했습니다.", "저장 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show($"입력 데이터 오류: {argEx.Message}", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"저장 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
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

                SelectedPicturePath = ofd.FileName;
            }
            ofd.Dispose();       
        }
    }
}
