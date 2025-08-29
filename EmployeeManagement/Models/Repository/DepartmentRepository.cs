using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeManagement.Models.Repository
{
    public class DepartmentRepository
    {
        private readonly string connectionString;

        public DepartmentRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
        }

        // 모든 부서 데이터 조회
        public List<DepartmentModel> GetAllDepartments()
        {
            var departments = new List<DepartmentModel>();
            string query = "SELECT DeptID, DeptCode, DeptName, Memo FROM Department";

            using (SqlConnection conn = new SqlConnection(connectionString))
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
        public bool AddDepartment(DepartmentModel department)
        {
            string query = "INSERT INTO Department (DeptCode, DeptName, Memo) VALUES (@DeptCode, @DeptName, @Memo)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DeptCode", department.DeptCode);
                cmd.Parameters.AddWithValue("@DeptName", department.DeptName);
                cmd.Parameters.AddWithValue("@Memo", department.Memo ?? string.Empty);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 부서 수정
        public void UpdateDepartment(DepartmentModel department)
        {
            string query = "UPDATE Department SET DeptCode = @DeptCode, DeptName = @DeptName, Memo = @Memo WHERE DeptID = @DeptID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DeptID", department.DeptID);
                cmd.Parameters.AddWithValue("@DeptCode", department.DeptCode);
                cmd.Parameters.AddWithValue("@DeptName", department.DeptName);
                cmd.Parameters.AddWithValue("@Memo", department.Memo ?? string.Empty);

                conn.Open();
            }
        }

        // 부서 삭제
        public bool DeleteDepartment(int deptID)
        {
            string query = "DELETE FROM Department WHERE DeptID = @DeptID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DeptID", deptID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
