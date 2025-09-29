using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpManagement.Model.Dto
{
    public class EmployeeAddDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ContractType { get; set; }
        public string LoginId { get; set; }
        public string LoginPassword { get; set; }
        public string LoginTag { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MessengerId { get; set; }
        public string Memo { get; set; }
        public long DepartmentId { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class EmployeeAddResponse
    {
        public string Data { get; set; }   // 성공 시 메시지 또는 ID
        public string Error { get; set; }  // 실패 시 에러
    }
}
