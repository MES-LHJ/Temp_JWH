using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeModel
    {
        [DisplayName("사원ID")]
        public int EmpID { get; set; }

        [DisplayName("부서ID")]
        public int DeptID { get; set; }

        [DisplayName("사원코드")]
        public string EmpCode { get; set; }

        [DisplayName("사원명")]
        public string EmpName { get; set; }

        [DisplayName("성별")]
        public Gender Gender { get; set; }

        [DisplayName("로그인ID")]
        public string LoginID { get; set; }

        [DisplayName("비밀번호")]
        public string Pwd { get; set; }

        [DisplayName("직위")]
        public string Position { get; set; }

        [DisplayName("고용형태")]
        public string EmploymentType { get; set; }

        [DisplayName("휴대전화")]
        public string Phone { get; set; }

        [DisplayName("이메일")]
        public string Email { get; set; }

        [DisplayName("메신저ID")]
        public string MessengerID { get; set; }

        [DisplayName("메모")]
        public string Memo { get; set; }
        
        [DisplayName("사진경로")]
        public string ImagePath { get; set; }

        // 조인용 속성 (읽기 전용)
        [DisplayName("부서코드")]
        public string DeptCode { get; set; }

        [DisplayName("부서명")]
        public string DeptName { get; set; }

        
    }
}
