using NewEmpManagement.Models;
using NewEmpManagement.Models.Dto;
using NewEmpManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmpManagement.Repository
{
    public class DepartmentRepository
    {
        private static readonly Lazy<DepartmentRepository> _instance =
            new Lazy<DepartmentRepository>(() => new DepartmentRepository());
        public static DepartmentRepository Instance => _instance.Value;
        private readonly string connectionString;
        
        private DepartmentRepository()
        {
            connectionString = AppConfig.ConnectionString;
        }
        public async Task<List<DepartmentModel>> GetAllDepartments() // 조회(비동기)
        {
            var departments = new List<DepartmentModel>();
            string query = "SELECT DeptID, DeptCode, DeptName, Memo, UDeptID FROM Department";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                await conn.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var dept = new DepartmentModel
                        {
                            DeptID = await reader.GetFieldValueAsync<int>(reader.GetOrdinal(nameof(DepartmentModel.DeptID))),   // DeptID
                            DeptCode = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(DepartmentModel.DeptCode))), // DeptCode
                            DeptName = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(DepartmentModel.DeptName))), // DeptName
                            Memo = await reader.IsDBNullAsync(reader.GetOrdinal(nameof(UpperDepartmentModel.Memo)))? string.Empty : await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(UpperDepartmentModel.Memo))),
                            UDeptID = await reader.IsDBNullAsync(reader.GetOrdinal(nameof(DepartmentModel.UDeptID))) ? 0 : await reader.GetFieldValueAsync<int>(reader.GetOrdinal(nameof(DepartmentModel.UDeptID)))
                        };
                        departments.Add(dept);
                    }
                }
            }
            return departments;
        }
        public bool AddDepartment(DepartmentModel dept) // 추가
        {
            try
            {
                string query = "INSERT INTO Department (DeptCode, DeptName, Memo, UDeptID) VALUES (@DeptCode, @DeptName, @Memo, @UDeptID)";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.DeptCode), dept.DeptCode);
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.DeptName), dept.DeptName);
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.Memo), string.IsNullOrEmpty(dept.Memo) ? (object)DBNull.Value : dept.Memo);
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.UDeptID), dept.UDeptID);
                    conn.Open();
                    
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("부서 추가 중 오류가 발생했습니다.", ex);
            }
        }
        public bool UpdateDepartment(DepartmentModel dept) // 수정
        {
            try
            {
                string query = "UPDATE Department SET DeptCode = @DeptCode, DeptName = @DeptName, Memo = @Memo, UDeptID = @UDeptID WHERE DeptID = @DeptID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.DeptCode), dept.DeptCode);
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.DeptName), dept.DeptName);
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.Memo), string.IsNullOrEmpty(dept.Memo) ? (object)DBNull.Value : dept.Memo);
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.UDeptID), dept.UDeptID);
                    cmd.Parameters.AddWithValue(nameof(DepartmentModel.DeptID), dept.DeptID);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("부서 수정 중 오류가 발생했습니다.", ex);
            }
        }
        public bool DeleteDepartment(int deptId) // 삭제
        {
            try
            {
                string query = "DELETE FROM Department WHERE DeptID = @DeptID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DeptID", deptId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("부서 삭제 중 오류가 발생했습니다.", ex);
            }
        }
        public async Task<List<DepartmentDetailDto>> GetDepartmentDetailsAsync()
        {
            var departments = await GetAllDepartments(); // Model 리스트 (비동기)
            var upperDepartments = await UpperDepartmentRepository.Instance.GetAllUpperDepartments();

            var dtoList = (from dept in departments
                           join upper in upperDepartments on dept.UDeptID equals upper.UDeptID
                           select new DepartmentDetailDto
                           {
                               DeptID = dept.DeptID,
                               DeptCode = dept.DeptCode,
                               DeptName = dept.DeptName,
                               Memo = dept.Memo,
                               UDeptID = upper.UDeptID,
                               UDeptCode = upper.UDeptCode,
                               UDeptName = upper.UDeptName,
                               //EmployeeCount = upper.UDeptID.
                           }).ToList();

            return dtoList;
        }
        

    }
}
