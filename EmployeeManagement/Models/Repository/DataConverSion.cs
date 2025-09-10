using ClosedXML.Excel;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EmployeeManagement.Models.Repository
{
    internal class DataConversion
    {
        public static bool ExportEmployeesToExcel(BindingList<EmployeeModel> employees, string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("직원 목록");

                    // 헤더 설정
                    var headers = new[]
                    {
                        "사원ID", "부서코드", "부서명", "사원코드", "사원명", 
                        "성별", "직책", "고용형태", "전화번호", "이메일", 
                        "로그인ID","비밀번호","메신저ID", "메모"
                    };

                    // 헤더 행 추가
                    for (int i = 0; i < headers.Length; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = headers[i];
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                        worksheet.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                    }

                    // 데이터 행 추가
                    int row = 2;
                    foreach (var emp in employees)
                    {
                        worksheet.Cell(row, 1).Value = emp.EmpID;
                        worksheet.Cell(row, 2).Value = emp.DeptCode ?? string.Empty;
                        worksheet.Cell(row, 3).Value = emp.DeptName ?? string.Empty;
                        worksheet.Cell(row, 4).Value = emp.EmpCode ?? string.Empty;
                        worksheet.Cell(row, 5).Value = emp.EmpName ?? string.Empty;
                        worksheet.Cell(row, 6).Value = emp.Gender.ToString();
                        worksheet.Cell(row, 7).Value = emp.Position ?? string.Empty;
                        worksheet.Cell(row, 8).Value = emp.EmploymentType ?? string.Empty;
                        worksheet.Cell(row, 9).Value = emp.Phone ?? string.Empty;
                        worksheet.Cell(row, 10).Value = emp.Email ?? string.Empty;
                        worksheet.Cell(row, 11).Value = emp.LoginID ?? string.Empty;
                        worksheet.Cell(row, 12).Value = emp.Pwd ?? string.Empty;
                        worksheet.Cell(row, 13).Value = emp.MessengerID ?? string.Empty;
                        worksheet.Cell(row, 14).Value = emp.Memo ?? string.Empty;
                        row++;
                    }

                        worksheet.Columns().AdjustToContents();
                        // 표 스타일 적용
                        var dataRange = worksheet.Range(1, 1, row - 1, headers.Length);
                    dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    // 파일 저장
                    workbook.SaveAs(filePath);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel 파일 생성 중 오류가 발생했습니다: {ex.Message}", 
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static string GetExcelSaveFilePath()
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel 파일 (*.xlsx)|*.xlsx|모든 파일 (*.*)|*.*";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.FileName = $"직원목록_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                saveFileDialog.Title = "Excel 파일로 저장";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return saveFileDialog.FileName;
                }
                return null;
            }
        }
    }
}
