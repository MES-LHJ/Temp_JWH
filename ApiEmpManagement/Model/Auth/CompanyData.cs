using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpManagement.Model.Dto
{
    public class AuthRequest
    {
        public string Brn { get; set; }
    }

    public class CompanyAuthResponse
    {
        public CompanyData Data { get; set; }
        public string Error { get; set; }
    }

    public class CompanyData
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string DataLogCertificationKey { get; set; }
        public string ImagePath { get; set; }
        public string Token { get; set; }
    }
    public class EmployeeAuthResponse
    {
        public string Data { get; set; }   // 사원토큰
        public string Error { get; set; }
    }
}
