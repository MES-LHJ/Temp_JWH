using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public partial class ChartDepartment : Form
    {
        // 클래스 내에 connectionString 필드를 추가합니다.
        string connectionString = ConfigurationManager.ConnectionStrings["EmployeeManageDB"].ConnectionString;
        public ChartDepartment()
        {
            InitializeComponent();
            LoadChartData();
        }
        private void LoadChartData() {
           
            string query = @"
                SELECT d.DeptName, COUNT(e.EmpID) AS EmployeeCount
                FROM Department d
                JOIN Employee e ON d.DeptID = e.DeptID
                GROUP BY d.DeptID, d.DeptName
                ORDER BY d.DeptName";

            const string EmployeeCountColumn = "EmployeeCount";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {

                        // SQL 쿼리 결과의 실제 컬럼명 사용
                        string deptName = reader[nameof(DepartmentModel.DeptName)].ToString();
                        int empCount = Convert.ToInt32(reader[EmployeeCountColumn]);

                        // 차트에 데이터 포인트 추가(여기서 AddXY(a,b)로인해 a칸 x축에 한개 만들어지고 b만큼 y축이 된다. 반복. )
                        DeptHeadCountChart.Series[0].Points.AddXY(deptName, empCount);

                        // 선택사항: 각 막대 위에 숫자 표시
                        int pointIndex = DeptHeadCountChart.Series[0].Points.Count - 1;
                        DeptHeadCountChart.Series[0].Points[pointIndex].Label = empCount.ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        
    }
}
