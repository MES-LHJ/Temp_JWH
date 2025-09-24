using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Implementation;
using DevExpress.XtraSpreadsheet;
using NewEmpManagement.Models;
using NewEmpManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmpManagement.Forms.Employee
{
    public partial class MultiAddEmpForm : XtraForm
    {
        public MultiAddEmpForm()
        {
            InitializeComponent();
            CreateHeaderRow();
            LoadEvent();
        }

        private void CreateHeaderRow()
        {
            // 활성 워크시트 가져오기
            Worksheet worksheet = SpreadSheetControl.ActiveWorksheet;

            // 1행 헤더 작성
            string[] headers = { "부서코드", "사원코드", "사원명", "로그인ID", "비밀번호",
                         "직위", "고용형태", "성별", "휴대전화", "이메일",
                         "메신저ID", "메모", "이미지" };

            for (int i = 0; i < headers.Length; i++)
            {
                worksheet.Cells[0, i].Value = headers[i];
            }

            // 헤더 스타일
            var headerRange = worksheet.Range["A1:M1"];
            headerRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            headerRange.FillColor = Color.LightGray;

            // 필수 컬럼(A~E) 강조
            var essentialRange = worksheet.Range["A1:E1"];
            essentialRange.Font.Color = Color.Red;

            worksheet.Range["A2:M200"].Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin);

        }
        private void LoadEvent()
        {
            BtnCancel.Click += BtnCancel_Click;
            BtnSave.Click += BtnSave_Click;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var employees = GetEmployeesFromSheet();

                if (employees.Count == 0)
                {
                    XtraMessageBox.Show("등록할 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool result = EmployeeRepository.Instance.AddEmployeesBulk(employees);

                if (result)
                {
                    XtraMessageBox.Show($"{employees.Count}명의 사원이 등록되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("저장 중 오류가 발생했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"예외 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<EmployeeModel> GetEmployeesFromSheet()
        {
            List<EmployeeModel> empList = new List<EmployeeModel>();
            Worksheet sheet = SpreadSheetControl.ActiveWorksheet;

            // 2행부터 데이터 시작
            for (int row = 1; row <= sheet.Rows.LastUsedIndex; row++)
            {
                if (sheet.Cells[row, 1].Value.IsEmpty) continue; // 사원코드가 없으면 skip

                EmployeeModel emp = new EmployeeModel
                {
                    EmpCode = sheet.Cells[row, 1].Value.TextValue,
                    EmpName = sheet.Cells[row, 2].Value.TextValue,
                    LoginID = sheet.Cells[row, 3].Value.TextValue,
                    Pwd = sheet.Cells[row, 4].Value.TextValue,
                    Position = sheet.Cells[row, 5].Value.TextValue,
                    EmploymentType = sheet.Cells[row, 6].Value.TextValue,
                    Gender = sheet.Cells[row, 7].Value.TextValue == "남" ? Gender.남 : Gender.여,
                    Phone = sheet.Cells[row, 8].Value.TextValue,
                    Email = sheet.Cells[row, 9].Value.TextValue,
                    MessengerID = sheet.Cells[row, 10].Value.TextValue,
                    Memo = sheet.Cells[row, 11].Value.TextValue,
                    ImagePath = sheet.Cells[row, 12].Value.TextValue,
                    DeptID = int.TryParse(sheet.Cells[row, 0].Value.TextValue, out int deptId) ? deptId : 0
                };

                empList.Add(emp);
            }

            return empList;
        }
    }
}