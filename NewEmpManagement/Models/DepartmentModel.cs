using NewEmpManagement.Models.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmpManagement.Models
{
    public class DepartmentModel
    {

        public int DeptID { get; set; }

        public string DeptCode { get; set; }

        public string DeptName { get; set; }

        public string Memo { get; set; }

        public int UDeptID { get; set; }


    }
}
