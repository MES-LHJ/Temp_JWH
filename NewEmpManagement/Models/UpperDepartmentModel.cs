using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmpManagement.Models
{
    public class UpperDepartmentModel
    {

        public int UDeptID { get; set; }

        public string UDeptCode { get; set; }

        public string UDeptName { get; set; }

        public string Memo { get; set; }
    }
}
