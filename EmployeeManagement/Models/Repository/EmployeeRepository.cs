using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Models.Repository
{
    internal class EmployeeRepository
    {
        private static string ConnectionString => ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
        Models.EmployeeModel employee = new EmployeeModel();
        // 모든 사원 데이터 조회 (부서 정보 포함)
        public static List<EmployeeModel> GetAllEmployees()
        {
            var employees = new List<EmployeeModel>();
            string query = @"
        SELECT e.EmpID, e.DeptID, e.EmpCode, e.EmpName, e.Gender,
               e.LoginID, e.Pwd, e.Position, e.EmploymentType,
               e.Phone, e.Email, e.MessengerID, e.Memo,
               d.DeptCode, d.DeptName
        FROM Employee e 
        JOIN Department d ON e.DeptID = d.DeptID";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Helper 함수 사용
                        while (reader.Read())
                        {
                            var emp = new EmployeeModel //15개
                            {
                                EmpID = reader.GetInt32(reader.GetOrdinal("EmpID")),
                                DeptID = reader.GetInt32(reader.GetOrdinal("DeptID")),
                                EmpCode = reader.GetString(reader.GetOrdinal("EmpCode")),
                                EmpName = reader.GetString(reader.GetOrdinal("EmpName")),
                                Gender = ParseGender(reader.IsDBNull(reader.GetOrdinal("Gender")) ? string.Empty : reader.GetString(reader.GetOrdinal("Gender"))),
                                LoginID = reader.IsDBNull(reader.GetOrdinal("LoginID")) ? string.Empty : reader.GetString(reader.GetOrdinal("LoginID")),
                                Pwd = reader.IsDBNull(reader.GetOrdinal("Pwd")) ? string.Empty : reader.GetString(reader.GetOrdinal("Pwd")),
                                Position = reader.IsDBNull(reader.GetOrdinal("Position")) ? string.Empty : reader.GetString(reader.GetOrdinal("Position")),
                                EmploymentType = reader.IsDBNull(reader.GetOrdinal("EmploymentType")) ? string.Empty : reader.GetString(reader.GetOrdinal("EmploymentType")),
                                Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? string.Empty : reader.GetString(reader.GetOrdinal("Phone")),
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? string.Empty : reader.GetString(reader.GetOrdinal("Email")),
                                MessengerID = reader.IsDBNull(reader.GetOrdinal("MessengerID")) ? string.Empty : reader.GetString(reader.GetOrdinal("MessengerID")),
                                Memo = reader.IsDBNull(reader.GetOrdinal("Memo")) ? string.Empty : reader.GetString(reader.GetOrdinal("Memo")),
                                DeptCode = reader.GetString(reader.GetOrdinal("DeptCode")),
                                DeptName = reader.GetString(reader.GetOrdinal("DeptName"))
                            };
                            employees.Add(emp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 조회 중 오류: {ex.Message}");
            }

            return employees;
        }
        // Gender enum과 문자열 간 변환 헬퍼 메서드
        private static Gender ParseGender(string genderString)
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

        private static string GenderToString(Gender gender) 
        {
            switch (gender)
            {
                case Gender.남:
                    return "남";
                case Gender.여:
                    return "여";
                default:
                    return string.Empty;
            }
        }

        // 사원 추가
        public bool AddEmployee(EmployeeModel employeeData) // 매개변수로 EmployeeModel 객체 받기 12개
        {
            string query = @"INSERT INTO Employee 
                            (DeptID, EmpCode, EmpName, Gender, LoginID, Pwd, Position, 
                             EmploymentType, Phone, Email, MessengerID, Memo) 
                            VALUES 
                            (@DeptID, @EmpCode, @EmpName, @Gender, @LoginID, @Pwd, @Position, 
                             @EmploymentType, @Phone, @Email, @MessengerID, @Memo)";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn)) //12개 deptcode deptname 제외
                {
                    cmd.Parameters.Add("@DeptID", SqlDbType.Int).Value = employeeData.DeptID;
                    cmd.Parameters.Add("@EmpCode", SqlDbType.NVarChar, 10).Value = employeeData.EmpCode ?? string.Empty;
                    cmd.Parameters.Add("@EmpName", SqlDbType.NVarChar, 20).Value = employeeData.EmpName ?? string.Empty;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 2).Value = GenderToString(employeeData.Gender);
                    cmd.Parameters.Add("@LoginID", SqlDbType.NVarChar, 25).Value = employeeData.LoginID ?? string.Empty;
                    cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar, 50).Value = employeeData.Pwd ?? string.Empty;
                    cmd.Parameters.Add("@Position", SqlDbType.NVarChar, 30).Value = employeeData.Position ?? string.Empty;
                    cmd.Parameters.Add("@EmploymentType", SqlDbType.NVarChar, 20).Value = employeeData.EmploymentType ?? string.Empty;
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value = employeeData.Phone ?? string.Empty;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 40).Value = employeeData.Email ?? string.Empty;
                    cmd.Parameters.Add("@MessengerID", SqlDbType.NVarChar, 30).Value = employeeData.MessengerID ?? string.Empty;
                    cmd.Parameters.Add("@Memo", SqlDbType.NVarChar, 1000).Value = employeeData.Memo ?? string.Empty;

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"사원 추가 중 오류: {ex.Message}");
                return false;
            }
        }
        // DeptCode로 DeptID를 검색하는 메서드
        public static int GetDeptIdByCode(string deptCode)
        {
            if (string.IsNullOrEmpty(deptCode))
                return 0;

            string query = "SELECT DeptID FROM Department WHERE DeptCode = @DeptCode";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DeptCode", deptCode);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 조회 중 오류: {ex.Message}");
                return 0;
            }
        }

        // 사원 수정
        public void UpdateEmployee(EmployeeModel employee)
        {
            string queryEmployee = @"
        UPDATE Employee 
        SET DeptID = @DeptID,
            EmpCode = @EmpCode,
            EmpName = @EmpName,
            Gender = @Gender,
            Position = @Position,
            EmploymentType = @EmploymentType,
            Phone = @Phone,
            Email = @Email,
            MessengerID = @MessengerID,
            Memo = @Memo
        WHERE EmpID = @EmpID;";

            string queryDept = @"
        UPDATE Department
        SET DeptName = @DeptName
        WHERE DeptID = @DeptID;";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                using (SqlCommand cmdEmp = new SqlCommand(queryEmployee, conn, tran))
                using (SqlCommand cmdDept = new SqlCommand(queryDept, conn, tran))
                {
                    // Employee 파라미터
                    cmdEmp.Parameters.AddWithValue("@DeptID", employee.DeptID);
                    cmdEmp.Parameters.AddWithValue("@EmpCode", employee.EmpCode);
                    cmdEmp.Parameters.AddWithValue("@EmpName", employee.EmpName);
                    cmdEmp.Parameters.AddWithValue("@Gender", GenderToString(employee.Gender));
                    cmdEmp.Parameters.AddWithValue("@Position", employee.Position ?? string.Empty);
                    cmdEmp.Parameters.AddWithValue("@EmploymentType", employee.EmploymentType ?? string.Empty);
                    cmdEmp.Parameters.AddWithValue("@Phone", employee.Phone ?? string.Empty);
                    cmdEmp.Parameters.AddWithValue("@Email", employee.Email ?? string.Empty);
                    cmdEmp.Parameters.AddWithValue("@MessengerID", employee.MessengerID ?? string.Empty);
                    cmdEmp.Parameters.AddWithValue("@Memo", employee.Memo ?? string.Empty);
                    cmdEmp.Parameters.AddWithValue("@EmpID", employee.EmpID);

                    // Department 파라미터
                    cmdDept.Parameters.AddWithValue("@DeptID", employee.DeptID); 
                    cmdDept.Parameters.AddWithValue("@DeptCode", employee.DeptCode);
                    cmdDept.Parameters.AddWithValue("@DeptName", employee.DeptName ?? string.Empty);

                    try
                    {
                        cmdEmp.ExecuteNonQuery();
                        cmdDept.ExecuteNonQuery();
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // 사원 삭제
        public bool DeleteEmployee(int empId)
        {
            string query = "DELETE FROM Employee WHERE EmpID = @EmpID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmpID", empId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // 로그인 정보 업데이트
        public bool UpdateLoginInfo(int EmpID, string LoginID, string Pwd)
        {
            string query = "UPDATE Employee SET LoginID = @LoginID, Pwd = @Pwd WHERE EmpID = @EmpID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmpID", EmpID);     
                cmd.Parameters.AddWithValue("@LoginID", LoginID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Pwd", Pwd ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
