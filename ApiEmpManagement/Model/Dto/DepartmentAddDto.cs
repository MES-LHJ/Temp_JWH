using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiEmpManagement.Model.Dto
{
    public class DepartmentAddDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Memo { get; set; }
        public long FactoryId { get; set; } = 1; 
        public long? UpperDepartmentId { get; set; }
    }
    public class DepartmentAddResponse
    {
        public long Data { get; set; }   
        public string Error { get; set; }  
    }
    public class DepartmentUpdateResponse<T>
    {
        public T Data { get; set; }
        public string Error { get; set; }
    }
}
