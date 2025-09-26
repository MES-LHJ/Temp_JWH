using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpManagement.Model.Dto
{
    public class DepartmentDto
    {
        public long? Id { get; set; }
        public long? FactoryId { get; set; }
        public string FactoryCode { get; set; }
        public string FactoryName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public long? UpperDepartmentId { get; set; }
        public string UpperDepartmentCode { get; set; }
        public string UpperDepartmentName { get; set; }
    }

    public class DepartmentApiResponse
    {
        public List<DepartmentDto> Data { get; set; }
        public string Error { get; set; }
    }
}
