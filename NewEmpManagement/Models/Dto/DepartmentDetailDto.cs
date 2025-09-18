using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmpManagement.Models.Dto
{
    public class DepartmentDetailDto
    {
        public int DeptID { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Memo { get; set; }

        // 상위부서
        public int UDeptID { get; set; }
        public string UDeptCode { get; set; }
        public string UDeptName { get; set; }

        //차트용
        public int EmployeeCount { get; set; }
    }

}
