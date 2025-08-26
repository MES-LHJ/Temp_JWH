using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeModel
    {
        [DisplayName("사원ID")]
        public int EmpID { get; set; }

        [DisplayName("부서ID")]
        public int DeptID { get; set; }

        [DisplayName("사원코드")]
        public string EmpCode { get; set; }

        [DisplayName("사원명")]
        public string EmpName { get; set; }

        [DisplayName("성별")]
        public string Gender { get; set; }

        [DisplayName("로그인ID")]
        public string LoginID { get; set; }

        [DisplayName("비밀번호")]
        public string Pwd { get; set; }

        [DisplayName("직위")]
        public string Position { get; set; }

        [DisplayName("고용형태")]
        public string EmploymentType { get; set; }

        [DisplayName("휴대전화")]
        public string Phone { get; set; }

        [DisplayName("이메일")]
        public string Email { get; set; }

        [DisplayName("메신저ID")]
        public string MessengerID { get; set; }

        [DisplayName("메모")]
        public string Memo { get; set; }

        // 조인용 속성 (읽기 전용)
        [DisplayName("부서코드")]
        public string DeptCode { get; set; }

        [DisplayName("부서명")]
        public string DeptName { get; set; }

        private static string ConnectionString => ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;

        // 모든 사원 데이터 조회 (부서 정보 포함)
        public static List<EmployeeModel> GetAllEmployees()
        {
            var employees = new List<EmployeeModel>();
            string query = @"SELECT 
                                e.EmpID, e.DeptID, e.EmpCode, e.EmpName, e.Gender,
                                e.LoginID, e.Pwd, e.Position, e.EmploymentType,
                                e.Phone, e.Email, e.MessengerID, e.Memo,
                                d.DeptCode, d.DeptName
                            FROM Employee e 
                            JOIN Department d ON e.DeptID = d.DeptID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int idxEmpID = reader.GetOrdinal("EmpID");
                    int idxDeptID = reader.GetOrdinal("DeptID");
                    int idxEmpCode = reader.GetOrdinal("EmpCode");
                    int idxEmpName = reader.GetOrdinal("EmpName");
                    int idxGender = reader.GetOrdinal("Gender");
                    int idxLoginID = reader.GetOrdinal("LoginID");
                    int idxPwd = reader.GetOrdinal("Pwd");
                    int idxPosition = reader.GetOrdinal("Position");
                    int idxEmploymentType = reader.GetOrdinal("EmploymentType");
                    int idxPhone = reader.GetOrdinal("Phone");
                    int idxEmail = reader.GetOrdinal("Email");
                    int idxMessengerID = reader.GetOrdinal("MessengerID");
                    int idxMemo = reader.GetOrdinal("Memo");
                    int idxDeptCode = reader.GetOrdinal("DeptCode");
                    int idxDeptName = reader.GetOrdinal("DeptName");

                    while (reader.Read())
                    {
                        var emp = new EmployeeModel
                        {
                            EmpID = reader.GetInt32(idxEmpID),
                            DeptID = reader.GetInt32(idxDeptID),
                            EmpCode = reader.GetString(idxEmpCode),
                            EmpName = reader.GetString(idxEmpName),
                            Gender = reader.IsDBNull(idxGender) ? string.Empty : reader.GetString(idxGender),
                            LoginID = reader.IsDBNull(idxLoginID) ? string.Empty : reader.GetString(idxLoginID),
                            Pwd = reader.IsDBNull(idxPwd) ? string.Empty : reader.GetString(idxPwd),
                            Position = reader.IsDBNull(idxPosition) ? string.Empty : reader.GetString(idxPosition),
                            EmploymentType = reader.IsDBNull(idxEmploymentType) ? string.Empty : reader.GetString(idxEmploymentType),
                            Phone = reader.IsDBNull(idxPhone) ? string.Empty : reader.GetString(idxPhone),
                            Email = reader.IsDBNull(idxEmail) ? string.Empty : reader.GetString(idxEmail),
                            MessengerID = reader.IsDBNull(idxMessengerID) ? string.Empty : reader.GetString(idxMessengerID),
                            Memo = reader.IsDBNull(idxMemo) ? string.Empty : reader.GetString(idxMemo),
                            DeptCode = reader.GetString(idxDeptCode),
                            DeptName = reader.GetString(idxDeptName)
                        };
                        employees.Add(emp);
                    }
                }
            }
            return employees;
        }

        // 사원 추가
        public bool AddEmployee()
        {
            string query = @"INSERT INTO Employee 
                            (DeptID, EmpCode, EmpName, Gender, LoginID, Pwd, Position, 
                             EmploymentType, Phone, Email, MessengerID, Memo) 
                            VALUES 
                            (@DeptID, @EmpCode, @EmpName, @Gender, @LoginID, @Pwd, @Position, 
                             @EmploymentType, @Phone, @Email, @MessengerID, @Memo)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DeptID", this.DeptID);
                cmd.Parameters.AddWithValue("@EmpCode", this.EmpCode);
                cmd.Parameters.AddWithValue("@EmpName", this.EmpName);
                cmd.Parameters.AddWithValue("@Gender", this.Gender ?? string.Empty);
                cmd.Parameters.AddWithValue("@LoginID", this.LoginID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Pwd", this.Pwd ?? string.Empty);
                cmd.Parameters.AddWithValue("@Position", this.Position ?? string.Empty);
                cmd.Parameters.AddWithValue("@EmploymentType", this.EmploymentType ?? string.Empty);
                cmd.Parameters.AddWithValue("@Phone", this.Phone ?? string.Empty);
                cmd.Parameters.AddWithValue("@Email", this.Email ?? string.Empty);
                cmd.Parameters.AddWithValue("@MessengerID", this.MessengerID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Memo", this.Memo ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 사원 수정
        public bool UpdateEmployee()
        {
            string query = @"UPDATE Employee SET 
                            DeptID = @DeptID, EmpCode = @EmpCode, EmpName = @EmpName, 
                            Gender = @Gender, LoginID = @LoginID, Pwd = @Pwd, Position = @Position,
                            EmploymentType = @EmploymentType, Phone = @Phone, Email = @Email, 
                            MessengerID = @MessengerID, Memo = @Memo
                            WHERE EmpID = @EmpID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmpID", this.EmpID);
                cmd.Parameters.AddWithValue("@DeptID", this.DeptID);
                cmd.Parameters.AddWithValue("@EmpCode", this.EmpCode);
                cmd.Parameters.AddWithValue("@EmpName", this.EmpName);
                cmd.Parameters.AddWithValue("@Gender", this.Gender ?? string.Empty);
                cmd.Parameters.AddWithValue("@LoginID", this.LoginID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Pwd", this.Pwd ?? string.Empty);
                cmd.Parameters.AddWithValue("@Position", this.Position ?? string.Empty);
                cmd.Parameters.AddWithValue("@EmploymentType", this.EmploymentType ?? string.Empty);
                cmd.Parameters.AddWithValue("@Phone", this.Phone ?? string.Empty);
                cmd.Parameters.AddWithValue("@Email", this.Email ?? string.Empty);
                cmd.Parameters.AddWithValue("@MessengerID", this.MessengerID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Memo", this.Memo ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 사원 삭제
        public static bool DeleteEmployee(int empId)
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
        public bool UpdateLoginInfo()
        {
            string query = "UPDATE Employee SET LoginID = @LoginID, Pwd = @Pwd WHERE EmpID = @EmpID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmpID", this.EmpID);
                cmd.Parameters.AddWithValue("@LoginID", this.LoginID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Pwd", this.Pwd ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
