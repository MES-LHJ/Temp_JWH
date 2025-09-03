namespace EmployeeManagement.Models
{
    public class EmployeeModel
    {

        public int EmpID { get; set; }

        public int DeptID { get; set; }

        public string EmpCode { get; set; }

        public string EmpName { get; set; }

        public Gender Gender { get; set; }

        public string LoginID { get; set; }

        public string Pwd { get; set; }

        public string Position { get; set; }

        public string EmploymentType { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string MessengerID { get; set; }

        public string Memo { get; set; }
        
        public string ImagePath { get; set; }

        // 조인용 속성 (읽기 전용)

        public string DeptCode { get; set; }


        public string DeptName { get; set; }

    }
}
