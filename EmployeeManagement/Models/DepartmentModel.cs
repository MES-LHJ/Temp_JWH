using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EmployeeManagement.Forms.Classes
{
    public class DepartmentModel
    {
        [DisplayName("부서ID")]
        public int DeptID { get; set; }

        [DisplayName("부서코드")]
        public string DeptCode { get; set; }

        [DisplayName("부서명")]
        public string DeptName { get; set; }

        [DisplayName("메모")]
        public string Memo { get; set; }

        private static string ConnectionString => ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;

        // 모든 부서 데이터 조회
        public static List<DepartmentModel> GetAllDepartments()
        {
            var departments = new List<DepartmentModel>();
            string query = "SELECT DeptID, DeptCode, DeptName, Memo FROM Department";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int idxDeptID = reader.GetOrdinal("DeptID");
                    int idxDeptCode = reader.GetOrdinal("DeptCode");
                    int idxDeptName = reader.GetOrdinal("DeptName");
                    int idxMemo = reader.GetOrdinal("Memo");
                    while (reader.Read())
                    {
                        var dept = new DepartmentModel
                        {
                            DeptID = reader.GetInt32(idxDeptID),
                            DeptCode = reader.GetString(idxDeptCode),
                            DeptName = reader.GetString(idxDeptName),
                            Memo = reader.IsDBNull(idxMemo) ? string.Empty : reader.GetString(idxMemo)
                        };
                        departments.Add(dept);
                    }
                }
            }
            return departments;
        }

        // 부서 추가
        public bool AddDepartment()
        {
            string query = "INSERT INTO Department (DeptCode, DeptName, Memo) VALUES (@DeptCode, @DeptName, @Memo)";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DeptCode", this.DeptCode);
                cmd.Parameters.AddWithValue("@DeptName", this.DeptName);
                cmd.Parameters.AddWithValue("@Memo", this.Memo ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 부서 수정
        public bool UpdateDepartment()
        {
            string query = "UPDATE Department SET DeptCode = @DeptCode, DeptName = @DeptName, Memo = @Memo WHERE DeptID = @DeptID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DeptID", this.DeptID);
                cmd.Parameters.AddWithValue("@DeptCode", this.DeptCode);
                cmd.Parameters.AddWithValue("@DeptName", this.DeptName);
                cmd.Parameters.AddWithValue("@Memo", this.Memo ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 부서 삭제
        public static bool DeleteDepartment(int deptId)
        {
            string query = "DELETE FROM Department WHERE DeptID = @DeptID";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DeptID", deptId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
