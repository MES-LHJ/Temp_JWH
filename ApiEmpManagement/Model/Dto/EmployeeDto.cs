using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpManagement.Model.Dto
{
    public class EmployeePermissionDto
    {
        public long EmployeeId { get; set; }
        public string Menu { get; set; }
        public bool CanCreate { get; set; }
        public bool CanRead { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }
    }

    public class EmployeeDto
    {
        public long Id { get; set; }
        public long FactoryId { get; set; }
        public string FactoryCode { get; set; }
        public string FactoryName { get; set; }
        public long? DeaprtmentId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentMemo { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ContractType { get; set; }
        public string Memo { get; set; }
        public bool UseLogin { get; set; }
        public string LoginId { get; set; }
        public string LoginPassword { get; set; }
        public string LoginTag { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MessengerId { get; set; }
        public bool IsAdmin { get; set; }
        public bool HasMultifactory { get; set; }

        public List<EmployeePermissionDto> Permission { get; set; }
    }

    public class EmployeeApiResponse
    {
        public List<EmployeeDto> Data { get; set; }
        public string Error { get; set; }
    }
}
