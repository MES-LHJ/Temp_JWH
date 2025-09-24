using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmpManagement.Models
{
    public class TreeNodeDto
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string UDeptCode { get; set; } 
        public string DeptCode { get; set; }
        public string EmpCode { get; set; }
    }
}
