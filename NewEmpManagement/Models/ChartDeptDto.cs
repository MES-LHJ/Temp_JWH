using DevExpress.XtraCharts;
using NewEmpManagement.Repository; // EmployeeRepository를 사용하기 위해 추가
using System;
using System.Data;
using System.Linq; // LINQ를 사용하기 위해 추가
using System.Threading.Tasks; // 비동기 작업을 위해 추가


namespace NewEmpManagement.Models
{
    internal class ChartDeptDto
    {
        public string UpperDeptName { get; set; }
        public string SubDeptName { get; set; }
        public int EmployeeCount { get; set; }
    }
}
