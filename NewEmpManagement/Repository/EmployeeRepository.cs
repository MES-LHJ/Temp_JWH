using NewEmpManagement.Models;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmpManagement.Repository
{
    public class EmployeeRepository
    {
        private static readonly Lazy<EmployeeRepository> _instance =
            new Lazy<EmployeeRepository>(() => new EmployeeRepository());
        public static EmployeeRepository Instance => _instance.Value;
        private readonly string connectionString;

        private EmployeeRepository()
        {
            connectionString = AppConfig.ConnectionString;
        }

        private const string BASE_DIRECTORY = @"C:\NAS\";

        public async Task<List<EmployeeModel>> GetAllEmployees() // 조회(비동기)
        {
            var employees = new List<EmployeeModel>();
            string query = "SELECT EmpID, EmpCode, EmpName, LoginID, Pwd, Position, EmploymentType, Gender, Phone, Email, MessengerID, Memo, ImagePath, DeptID FROM Employee";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                await conn.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var emp = new EmployeeModel
                        {
                            EmpID = await reader.GetFieldValueAsync<int>(reader.GetOrdinal(nameof(EmployeeModel.EmpID))),
                            EmpCode = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.EmpCode))),
                            EmpName = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.EmpName))),
                            LoginID = await reader.IsDBNullAsync(reader.GetOrdinal(nameof(EmployeeModel.LoginID))) ? string.Empty : await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.LoginID))),
                            Pwd = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.Pwd))),
                            Position = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.Position))),
                            EmploymentType = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.EmploymentType))),
                            Gender = ParseGender(await reader.IsDBNullAsync(reader.GetOrdinal(nameof(EmployeeModel.Gender))) ? string.Empty : await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.Gender)))),
                            Phone = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.Phone))),
                            Email = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.Email))),
                            MessengerID = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.MessengerID))),
                            Memo = await reader.IsDBNullAsync(reader.GetOrdinal(nameof(EmployeeModel.Memo))) ? string.Empty : await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.Memo))),
                            ImagePath = await reader.IsDBNullAsync(reader.GetOrdinal(nameof(EmployeeModel.ImagePath))) ? string.Empty : await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(EmployeeModel.ImagePath))),
                            DeptID = await reader.GetFieldValueAsync<int>(reader.GetOrdinal(nameof(EmployeeModel.DeptID)))
                        };
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }
        public Gender ParseGender(string genderString) // string -> enum 변환
        {
            if (string.IsNullOrEmpty(genderString))
                return Gender.None;

            switch (genderString)
            {
                case "남":
                    return Gender.남;
                case "여":
                    return Gender.여;
                default:
                    return Gender.None;
            }
        }
        public async Task<List<EmployeeDetailDto>> GetEmployeeDtosAsync() // Dto 조회(비동기)
        {
            var employee = await GetAllEmployees();
            var departments = await DepartmentRepository.Instance.GetAllDepartments();
            var upperDepartments = await UpperDepartmentRepository.Instance.GetAllUpperDepartments();

            var dtoList = (from emp in employee
                           join dept in departments
                               on emp.DeptID equals dept.DeptID
                           join uDept in upperDepartments
                               on dept.UDeptID equals uDept.UDeptID into uDeptJoin
                           from uDept in uDeptJoin.DefaultIfEmpty() // 상위부서가 없는 경우도 처리
                           select new EmployeeDetailDto
                           {
                            EmpID = emp.EmpID,
                            EmpCode = emp.EmpCode,
                            EmpName = emp.EmpName,
                            LoginID = emp.LoginID,
                            Pwd = emp.Pwd,
                            Position = emp.Position,
                            EmploymentType = emp.EmploymentType,
                            Gender = emp.Gender,
                            Phone = emp.Phone,
                            Email = emp.Email,
                            MessengerID = emp.MessengerID,
                            Memo = emp.Memo,
                            ImagePath = emp.ImagePath,
                            DeptID = emp.DeptID,
                            DeptCode = dept.DeptCode,
                            DeptName = dept.DeptName,
                            UDeptCode = uDept?.UDeptCode ?? string.Empty,
                            UDeptName = uDept?.UDeptName ?? string.Empty
                           }).ToList();

            return dtoList;
        }
        public bool AddEmployee(EmployeeModel emp) // 추가
        {
            string query = @"INSERT INTO Employee 
                        (EmpCode, EmpName, LoginID, Pwd, Position, EmploymentType, Gender, Phone, Email, MessengerID, Memo, ImagePath, DeptID) 
                        VALUES 
                        (@EmpCode, @EmpName, @LoginID, @Pwd, @Position, @EmploymentType, @Gender, @Phone, @Email, @MessengerID, @Memo, @ImagePath, @DeptID)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    //DB에는 string.Empty가 들어가고 UI에서는 None이 나온다.
                    string dbGender = emp.Gender == Gender.남 ? "남" :
                                      emp.Gender == Gender.여 ? "여" : string.Empty;

                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmpCode), emp.EmpCode);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmpName), emp.EmpName);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.LoginID), string.IsNullOrEmpty(emp.LoginID) ? (object)DBNull.Value : emp.LoginID);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Pwd), emp.Pwd);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Position), emp.Position);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmploymentType), emp.EmploymentType);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Gender), dbGender); 
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Phone), emp.Phone);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Email), emp.Email);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.MessengerID), emp.MessengerID);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Memo), string.IsNullOrEmpty(emp.Memo) ? (object)DBNull.Value : emp.Memo);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.ImagePath), string.IsNullOrEmpty(emp.ImagePath) ? (object)DBNull.Value : emp.ImagePath);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.DeptID), emp.DeptID);
                    conn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SQL 실행 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
        }
        public string AddImage(string empCode, string selectedPicturePath) // 이미지 경로 추가
        {
            string empFolder = Path.Combine(BASE_DIRECTORY, empCode);

            if (string.IsNullOrEmpty(selectedPicturePath))
                return string.Empty;
            try
            {
                if (!Directory.Exists(empFolder))
                {
                    Directory.CreateDirectory(empFolder);
                }
                string targetFilePath = Path.Combine(empFolder, Path.GetFileName(selectedPicturePath));
                File.Copy(selectedPicturePath, targetFilePath, true);

                return targetFilePath;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool DeleteEmployee(int empId) // 삭제
        {
            try
            {
                string query = "DELETE FROM Employee WHERE EmpID = @EmpID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmpID), empId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("사원 삭제 중 오류가 발생했습니다.", ex);
            }
        }
    }
}
