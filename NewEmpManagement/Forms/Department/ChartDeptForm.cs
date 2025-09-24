using DevExpress.XtraCharts;
using NewEmpManagement.Repository;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmpManagement.Forms.Department
{
    public partial class ChartDeptForm : DevExpress.XtraEditors.XtraForm
    {
        public ChartDeptForm()
        {
            InitializeComponent();
            LoadChartDataAsync();
        }

        private async Task LoadChartDataAsync()
        {
            var empList = await DepartmentRepository.Instance.GetDepartmentDetailsAsync();

            var chartData = empList
                .GroupBy(emp => new { emp.UDeptName, emp.DeptName })
                .Select(group => new
                {
                    UDeptName = group.Key.UDeptName,
                    DeptName = group.Key.DeptName,
                    EmployeeCount = group.Count()
                })
                .OrderBy(data => data.UDeptName) // 부서명으로 정렬
                .ToList();

            DeptChartControl.DataSource = chartData;

            DeptChartControl.SeriesDataMember = "DeptName";

            DeptChartControl.SeriesTemplate.ArgumentDataMember = "UDeptName";
            DeptChartControl.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "EmployeeCount" });
            DeptChartControl.SeriesTemplate.View = new StackedBarSeriesView();
            // 범례(Legend)
            DeptChartControl.Legends.Clear();
            DeptChartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}