using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeeManagement.Models.Repository
{
    internal class EmployeeRepository
    {
        // 🔹 Lazy<T>를 이용한 싱글톤 인스턴스
        private static readonly Lazy<EmployeeRepository> _instance =
            new Lazy<EmployeeRepository>(() => new EmployeeRepository());

        // 🔹 외부에서 접근할 수 있는 프로퍼티
        public static EmployeeRepository Instance => _instance.Value;

        // 🔹 private 생성자 (외부에서 new 금지)
        private readonly string connectionString;
        private EmployeeRepository() 
        {   connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString; }


        // 모든 사원 데이터 조회 (부서 정보 포함)
        public BindingList<EmployeeModel> GetAllEmployees()
        {
            var employees = new BindingList<EmployeeModel>();
            string query = @"
        SELECT e.EmpID, e.DeptID, e.EmpCode, e.EmpName, e.Gender,
               e.LoginID, e.Pwd, e.Position, e.EmploymentType,
               e.Phone, e.Email, e.MessengerID, e.Memo,
               d.DeptCode, d.DeptName
        FROM Employee e 
        JOIN Department d ON e.DeptID = d.DeptID
        ORDER BY e.EmpCode";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var emp = new EmployeeModel //15개
                            {
                                EmpID = reader.GetInt32(reader.GetOrdinal(nameof(EmployeeModel.EmpID))),
                                DeptID = reader.GetInt32(reader.GetOrdinal(nameof(EmployeeModel.DeptID))),
                                EmpCode = reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.EmpCode))),
                                EmpName = reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.EmpName))),
                                Gender = ParseGender(reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.Gender))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.Gender)))), // string.empty -> None
                                LoginID = reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.LoginID))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.LoginID))),
                                Pwd = reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.Pwd))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.Pwd))),
                                Position = reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.Position))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.Position))),
                                EmploymentType = reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.EmploymentType))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.EmploymentType))),
                                Phone = reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.Phone))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.Phone))),
                                Email = reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.Email))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.Email))),
                                MessengerID = reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.MessengerID))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.MessengerID))),
                                Memo = reader.IsDBNull(reader.GetOrdinal(nameof(EmployeeModel.Memo))) ? string.Empty : reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.Memo))),
                                DeptCode = reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.DeptCode))),
                                DeptName = reader.GetString(reader.GetOrdinal(nameof(EmployeeModel.DeptName)))
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
        // Gender enum 문자열 변환 ?
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

        // 사원 추가
        public bool AddEmployee(EmployeeModel employeeData) // 매개변수로 EmployeeModel 객체 받기 12개
        {
            // Phone 유효성 검사
            if (!IsValidPhone(employeeData.Phone))
            {
                throw new ArgumentException("휴대전화 번호 형식이 올바르지 않습니다. (예: 010-1234-5678)");
            }

            // Email 유효성 검사
            if (!IsValidEmail(employeeData.Email))
            {
                throw new ArgumentException("이메일 주소 형식이 올바르지 않습니다. (예: user@example.com)");
            }
            string query = @"INSERT INTO Employee 
                            (DeptID, EmpCode, EmpName, Gender, LoginID, Pwd, Position, 
                             EmploymentType, Phone, Email, MessengerID, Memo) 
                            VALUES 
                            (@DeptID, @EmpCode, @EmpName, @Gender, @LoginID, @Pwd, @Position, 
                             @EmploymentType, @Phone, @Email, @MessengerID, @Memo)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn)) //12개 deptcode deptname 제외
                {
                    cmd.Parameters.Add("@DeptID", SqlDbType.Int).Value = employeeData.DeptID;
                    cmd.Parameters.Add("@EmpCode", SqlDbType.NVarChar, 10).Value = employeeData.EmpCode ?? string.Empty;
                    cmd.Parameters.Add("@EmpName", SqlDbType.NVarChar, 20).Value = employeeData.EmpName ?? string.Empty;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 2).Value = 
                        employeeData.Gender == Gender.None ? string.Empty : employeeData.Gender.ToString();
                    cmd.Parameters.Add("@LoginID", SqlDbType.NVarChar, 25).Value = employeeData.LoginID ?? string.Empty;
                    cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar, 50).Value = employeeData.Pwd ?? string.Empty;
                    cmd.Parameters.Add("@Position", SqlDbType.NVarChar, 30).Value = employeeData.Position ?? string.Empty;
                    cmd.Parameters.Add("@EmploymentType", SqlDbType.NVarChar, 20).Value = employeeData.EmploymentType ?? string.Empty;
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value = employeeData.Phone ?? string.Empty;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 40).Value = employeeData.Email ?? string.Empty;
                    cmd.Parameters.Add("@MessengerID", SqlDbType.NVarChar, 30).Value = employeeData.MessengerID ?? string.Empty;
                    cmd.Parameters.Add("@Memo", SqlDbType.NVarChar, 1000).Value = employeeData.Memo ?? string.Empty;

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"사원 추가 중 오류: {ex.Message}");
                return false;
            }
        }

        // Phone 유효성 검사 메서드
        private bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return true; // 선택사항이므로 빈 값 허용

            // 11자리 숫자만 있는 경우 하이픈 추가
            if (Regex.IsMatch(phone, @"^\d{11}$"))
            {
                phone = phone.Insert(3, "-").Insert(8, "-");
            }

            // 휴대전화 패턴: 010, 011, 016, 017, 018, 019로 시작하는 번호
            string phonePattern = @"^01[0-9]-\d{3,4}-\d{4}$";
            return Regex.IsMatch(phone, phonePattern);
        }
        // Email 유효성 검사 메서드
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true; // 선택사항이므로 빈 값 허용

            // 이메일 패턴 검사
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        // DeptCode로 DeptID를 검색하는 메서드
        public int GetDeptIdByCode(string deptCode)
        {
            if (string.IsNullOrEmpty(deptCode))
                return 0;

            string query = "SELECT DeptID FROM Department WHERE DeptCode = @DeptCode";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
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
        public bool UpdateEmployee(EmployeeModel employee)
        {
            string query = @"
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

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.DeptID), employee.DeptID);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmpCode), employee.EmpCode ?? string.Empty);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmpName), employee.EmpName ?? string.Empty);
                    // Gender enum을 문자열로 변환
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Gender), employee.Gender == Models.Gender.None ? string.Empty : employee.Gender.ToString());
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Position), employee.Position ?? string.Empty);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmploymentType), employee.EmploymentType ?? string.Empty);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Phone), employee.Phone ?? string.Empty);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Email), employee.Email ?? string.Empty);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.MessengerID), employee.MessengerID ?? string.Empty);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Memo), employee.Memo ?? string.Empty);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmpID), employee.EmpID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"사원 수정 중 오류 발생: {ex.Message}", ex);
            }
        }

        // 사원 삭제
        public bool DeleteEmployee(int empId)
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
        // 로그인 정보 업데이트
        public bool UpdateLoginInfo(int EmpID, string LoginID, string Pwd)
        {
            string query = "UPDATE Employee SET LoginID = @LoginID, Pwd = @Pwd WHERE EmpID = @EmpID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue(nameof(EmployeeModel.EmpID), EmpID);     
                cmd.Parameters.AddWithValue(nameof(EmployeeModel.LoginID), LoginID ?? string.Empty);
                cmd.Parameters.AddWithValue(nameof(EmployeeModel.Pwd), Pwd ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
