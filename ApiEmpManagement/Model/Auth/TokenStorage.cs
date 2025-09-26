using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpManagement.Model.Dto
{
    public static class TokenStorage
    {
        public static string CompanyToken { get; set; }   // 업체 토큰
        public static string EmployeeToken { get; set; }  // 사원 토큰
    }
}
