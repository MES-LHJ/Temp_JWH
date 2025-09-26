using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpManagement.Model.Dto
{
    public class EmployeeUpdateDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ContractType { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MessengerId { get; set; }
        public string Memo { get; set; }
        public long DepartmentId { get; set; }
    }
}
