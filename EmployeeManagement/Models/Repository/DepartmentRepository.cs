using EmployeeManagement.Forms.Department;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement.Models.Repository
{
    public class DepartmentRepository
    {
        //싱글톤 인스턴스
        private static readonly Lazy<DepartmentRepository> _instance =
            new Lazy<DepartmentRepository>(() => new DepartmentRepository());

        // 외부에서 접근할 수 있는 싱글톤 프로퍼티
        public static DepartmentRepository Instance => _instance.Value;

        private readonly string connectionString;

        // 생성자를 private으로 막아서 외부에서 new 못하게 함
        private DepartmentRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
        }

        // 모든 부서 데이터 조회
        public BindingList<DepartmentModel> GetAllDepartments()
        {
            var departments = new BindingList<DepartmentModel>();
            string query = "SELECT DeptID, DeptCode, DeptName, Memo FROM Department";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int DeptID = reader.GetOrdinal(nameof(DeptID));
                    int DeptCode = reader.GetOrdinal(nameof(DeptCode));
                    int DeptName = reader.GetOrdinal(nameof(DeptName));
                    int Memo = reader.GetOrdinal(nameof(Memo));
                    while (reader.Read())
                    {
                        var dept = new DepartmentModel
                        {
                            DeptID = reader.GetInt32(DeptID),
                            DeptCode = reader.GetString(DeptCode),
                            DeptName = reader.GetString(DeptName),
                            Memo = reader.IsDBNull(Memo) ? string.Empty : reader.GetString(Memo)
                        };
                        departments.Add(dept);
                    }
                }
            }
            return departments; //boundinglist 반환
        }

        // 부서 추가
        public bool AddDepartment(DepartmentModel department)
        {
            string query = "INSERT INTO Department (DeptCode, DeptName, Memo) VALUES (@DeptCode, @DeptName, @Memo)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.DeptCode), department.DeptCode);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.DeptName), department.DeptName);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Memo), department.Memo ?? string.Empty);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("부서 추가 중 오류 발생", ex);
            }

        }

        // 부서 수정
        public bool UpdateDepartment(DepartmentModel department)
        {
            string query = "UPDATE Department SET DeptCode = @DeptCode, DeptName = @DeptName, Memo = @Memo WHERE DeptID = @DeptID";

            try {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.DeptID), department.DeptID);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.DeptCode), department.DeptCode);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.DeptName), department.DeptName);
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.Memo), department.Memo ?? string.Empty);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("부서 수정 중 오류 발생", ex);
            }
        }

        // 부서 삭제
        public bool DeleteDepartment(int deptID)
        {
            string query = "DELETE FROM Department WHERE DeptID = @DeptID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(EmployeeModel.DeptID), deptID);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // 외래키 제약 조건 위반 오류 (SQL Server Error 547)
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("소속 사원 삭제후 부서 삭제가 가능합니다.", "삭제 불가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show($"부서 삭제 중 SQL오류 발생: {sqlEx.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


        public BindingList<DepartmentModel> GetDepartmentHeadCount()
        {
            var chartData = new BindingList<DepartmentModel>();
            string query = @"SELECT d.DeptID, d.DeptCode, d.DeptName, COUNT(e.EmpID) as HeadCount 
                           FROM Department d 
                           LEFT JOIN Employee e ON d.DeptID = e.DeptID 
                           GROUP BY d.DeptID, d.DeptCode, d.DeptName 
                           ORDER BY d.DeptName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var chartItem = new DepartmentModel
                        {
                            DeptID = reader.GetInt32(reader.GetOrdinal("DeptID")),
                            DeptCode = reader.GetString(reader.GetOrdinal("DeptCode")),
                            DeptName = reader.GetString(reader.GetOrdinal("DeptName")),
                            HeadCount = reader.GetInt32(reader.GetOrdinal("HeadCount"))
                        };
                        chartData.Add(chartItem);
                    }
                }
            }
            return chartData;
        }
    }
}
