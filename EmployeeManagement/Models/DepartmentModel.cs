using System;

namespace EmployeeManagement.Models
{
    public class DepartmentModel
    {
        private string _deptCode;
        private string _deptName;
        private int _headCount;

        public int DeptID { get; set; }

        public string DeptCode 
        { 
            get => _deptCode;
            set => _deptCode = !string.IsNullOrWhiteSpace(value) ? value.Trim().ToUpper() : 
                   throw new ArgumentException("부서 코드는 필수입니다.");
        }

        public string DeptName 
        { 
            get => _deptName;
            set => _deptName = !string.IsNullOrWhiteSpace(value) ? value.Trim() : 
                   throw new ArgumentException("부서명은 필수입니다.");
        }

        public string Memo { get; set; }

        public int HeadCount 
        { 
            get => _headCount;
            set => _headCount = value >= 0 ? value : 
                   throw new ArgumentException("인원수는 0 이상이어야 합니다.");
        }
    }
}
