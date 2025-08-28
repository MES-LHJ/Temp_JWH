using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            var employee = new EmployeeModel();

            string query = @"INSERT INTO Employee 
                            (DeptID, EmpCode, EmpName, Gender, LoginID, Pwd, Position, 
                             EmploymentType, Phone, Email, MessengerID, Memo) 
                            VALUES 
                            (@DeptID, @EmpCode, @EmpName, @Gender, @LoginID, @Pwd, @Position, 
                             @EmploymentType, @Phone, @Email, @MessengerID, @Memo)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@EmpCode", SqlDbType.NVarChar, 10).Value = employee.EmpCode;
                cmd.Parameters.Add("@EmpName", SqlDbType.NVarChar, 20).Value = employee.EmpName;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 2).Value = employee.Gender;
                cmd.Parameters.Add("@LoginID", SqlDbType.NVarChar, 25).Value = employee.LoginID;
                cmd.Parameters.Add("@Pwd", SqlDbType.NVarChar, 50).Value = employee.Pwd;
                cmd.Parameters.Add("@Position", SqlDbType.NVarChar, 30).Value = employee.Position;
                cmd.Parameters.Add("@EmploymentType", SqlDbType.NVarChar, 20).Value = employee.EmploymentType;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 15).Value = employee.Phone;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 40).Value = employee.Email;
                cmd.Parameters.Add("@MessengerID", SqlDbType.NVarChar, 30).Value = employee.MessengerID;
                cmd.Parameters.Add("@Memo", SqlDbType.NVarChar, 1000).Value = employee.Memo;

                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("사원 정보가 저장되었습니다.");
                    return true;
                }
                else
                {
                    MessageBox.Show("저장에 실패했습니다.");
                    return false;
                }

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
                cmd.Parameters.AddWithValue("@EmpID", employee.EmpID);
                cmd.Parameters.AddWithValue("@DeptID", employee.DeptID);
                cmd.Parameters.AddWithValue("@EmpCode", employee.EmpCode);
                cmd.Parameters.AddWithValue("@EmpName", employee.EmpName);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender ?? string.Empty);
                cmd.Parameters.AddWithValue("@LoginID", employee.LoginID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Pwd", employee.Pwd ?? string.Empty);
                cmd.Parameters.AddWithValue("@Position", employee.Position ?? string.Empty);
                cmd.Parameters.AddWithValue("@EmploymentType", employee.EmploymentType ?? string.Empty);
                cmd.Parameters.AddWithValue("@Phone", employee.Phone ?? string.Empty);
                cmd.Parameters.AddWithValue("@Email", employee.Email ?? string.Empty);
                cmd.Parameters.AddWithValue("@MessengerID", employee.MessengerID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Memo", employee.Memo ?? string.Empty);

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
                cmd.Parameters.AddWithValue("@EmpID", employee.EmpID);
                cmd.Parameters.AddWithValue("@LoginID", employee.LoginID ?? string.Empty);
                cmd.Parameters.AddWithValue("@Pwd", employee.Pwd ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
