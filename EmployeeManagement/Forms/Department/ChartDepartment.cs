using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EmployeeManagement.Models;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EmployeeManagement.Forms.Department
{
    public partial class ChartDepartment : Form
    {

        public ChartDepartment()
        {
            InitializeComponent();
            LoadChartData();
        }
        private void LoadChartData() 
        {
            try
            {
                var series = DeptHeadCountChart.Series[0];
                series.XValueMember = "DeptName";    // X축: 부서명
                series.YValueMembers = "HeadCount";  // Y축: 인원수

                // DataSource 설정
                var departmentRepository = Models.Repository.DepartmentRepository.Instance;
                var chartData = departmentRepository.GetDepartmentHeadCount();

                DeptHeadCountChart.DataSource = chartData;
                DeptHeadCountChart.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"차트 데이터 로드 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
