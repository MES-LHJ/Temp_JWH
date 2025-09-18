using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEmpManagement.Models.Dto
{
    public class EmployeeDetailDto
    {
        // Employee
        public int EmpID { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string LoginID { get; set; }
        public string Pwd { get; set; }
        public string Position { get; set; }
        public string EmploymentType { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MessengerID { get; set; }
        public string Memo { get; set; }
        public string ImagePath { get; set; }

        // Department
        public int DeptID { get; set; }
        public string DeptCode { get; set; }
        public string DeptName { get; set; }

        // UpperDepartment
        public int UDeptID { get; set; }
        public string UDeptCode { get; set; }
        public string UDeptName { get; set; }
    }
}
