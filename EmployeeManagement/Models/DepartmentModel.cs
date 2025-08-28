using System.ComponentModel;

namespace EmployeeManagement.Models
{
    public class DepartmentModel
    {
        [DisplayName("부서ID")]
        public int DeptID { get; set; }

        [DisplayName("부서코드")]
        public string DeptCode { get; set; }

        [DisplayName("부서명")]
        public string DeptName { get; set; }

        [DisplayName("메모")]
        public string Memo { get; set; }
    }
}
