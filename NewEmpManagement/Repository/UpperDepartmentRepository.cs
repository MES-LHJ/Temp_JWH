using NewEmpManagement.Models;
using NewEmpManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewEmpManagement.Repository
{
    public class UpperDepartmentRepository
    {
        private static readonly Lazy<UpperDepartmentRepository> _instance =
            new Lazy<UpperDepartmentRepository>(() => new UpperDepartmentRepository());

        public static UpperDepartmentRepository Instance => _instance.Value;
        private readonly string connectionString;

        private UpperDepartmentRepository()
        {
            connectionString = AppConfig.ConnectionString;
        }

        public async Task<List<UpperDepartmentModel>> GetAllUpperDepartments() // 조회(비동기)
        {
            var upperDepartments = new List<UpperDepartmentModel>();
            string query = "SELECT UDeptID, UDeptCode, UDeptName, Memo FROM UpperDepartment";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                await conn.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var udept = new UpperDepartmentModel
                        {
                            UDeptID = await reader.GetFieldValueAsync<int>(reader.GetOrdinal(nameof(UpperDepartmentModel.UDeptID))),
                            UDeptCode = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(UpperDepartmentModel.UDeptCode))),
                            UDeptName = await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(UpperDepartmentModel.UDeptName))),
                            Memo = await reader.IsDBNullAsync(reader.GetOrdinal(nameof(UpperDepartmentModel.Memo))) ? string.Empty : await reader.GetFieldValueAsync<string>(reader.GetOrdinal(nameof(UpperDepartmentModel.Memo)))
                        };
                        upperDepartments.Add(udept);
                    }
                }
            }
            return upperDepartments;
        }
        public bool AddUpperDepartment(UpperDepartmentModel udept) // 추가
        {
            try
            {
                string query = "INSERT INTO UpperDepartment (UDeptCode, UDeptName, Memo) VALUES (@UDeptCode, @UDeptName, @Memo)";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.UDeptCode), udept.UDeptCode);
                    cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.UDeptName), udept.UDeptName);
                    cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.Memo), udept.Memo ?? string.Empty);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("상위부서 추가 중 오류가 발생했습니다.", ex);
            }
        }
        public bool UpdateUpperDepartment(UpperDepartmentModel udept) // 수정
        {
            try
            {
                string query = "UPDATE UpperDepartment SET UDeptCode = @UDeptCode, UDeptName = @UDeptName, Memo = @Memo WHERE UDeptID = @UDeptID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.UDeptID), udept.UDeptID);
                    cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.UDeptCode), udept.UDeptCode);
                    cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.UDeptName), udept.UDeptName);
                    cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.Memo), udept.Memo ?? string.Empty);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("상위부서 수정 중 오류가 발생했습니다.", ex);
            }
        }
        public bool DeleteUpperDepartment(int udeptId) // 삭제
        {
            try
            {
                string query = "DELETE FROM UpperDepartment WHERE UDeptID = @UDeptID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.UDeptID), udeptId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 547) // 외래 키 제약 조건 위반
            {
                throw new InvalidOperationException("이 상위부서는 다른 데이터와 연관되어 있어 삭제할 수 없습니다.", sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception("상위부서 삭제 중 오류가 발생했습니다.", ex);
            }

        }

        public async Task<UpperDepartmentModel> GetUpperDepartmentById(int udeptId) // ID로 상위부서 조회(비동기) /보류
        {
            string query = "SELECT UDeptID, UDeptCode, UDeptName, Memo FROM UpperDepartment WHERE UDeptID = @UDeptID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue(nameof(UpperDepartmentModel.UDeptID), udeptId);
                await conn.OpenAsync();
                using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        int UDeptID = reader.GetOrdinal(nameof(UpperDepartmentModel.UDeptID));
                        int UDeptCode = reader.GetOrdinal(nameof(UpperDepartmentModel.UDeptCode));
                        int UDeptName = reader.GetOrdinal(nameof(UpperDepartmentModel.UDeptName));
                        int Memo = reader.GetOrdinal(nameof(UpperDepartmentModel.Memo));
                        
                        return new UpperDepartmentModel
                        {
                            UDeptID = reader.GetInt32(UDeptID),
                            UDeptCode = reader.GetString(UDeptCode),
                            UDeptName = reader.GetString(UDeptName),
                            Memo = reader.IsDBNull(Memo) ? string.Empty : reader.GetString(Memo)
                        };
                    }
                }
            }
            return null;
        }
    }
}