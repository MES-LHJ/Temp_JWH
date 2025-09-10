using System;
using System.Text.RegularExpressions;

namespace EmployeeManagement.Models
{
    public class EmployeeModel
    {
        private string _empCode;
        private string _empName;
        private string _loginID;
        private string _pwd;
        private string _phone;
        private string _email;

        public int EmpID { get; set; }

        public int DeptID { get; set; }

        public string EmpCode
        {
            get => _empCode;
            set => _empCode = !string.IsNullOrWhiteSpace(value) ? value.Trim().ToUpper() :
                   throw new ArgumentException("직원 코드는 필수입니다.");
        }

        public string EmpName
        {
            get => _empName;
            set => _empName = !string.IsNullOrWhiteSpace(value) ? value.Trim() :
                   throw new ArgumentException("직원명은 필수입니다.");
        }

        public Gender Gender { get; set; }

        public string LoginID
        {
            get => _loginID;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("로그인 ID는 필수입니다.");

                var trimmed = value.Trim().ToLower();
                if (!Regex.IsMatch(trimmed, @"^[a-z0-9]+$"))
                    throw new ArgumentException("로그인 ID는 영문 소문자와 숫자만 허용됩니다.");

                _loginID = trimmed;
            }
        }

        public string Pwd
        {
            get => _pwd;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("비밀번호는 필수입니다.");
                _pwd = value;
            }
        }
        public string Position { get; set; }

        public string EmploymentType { get; set; }

        public string Phone
        {
            get => _phone;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _phone = null;
                    return;
                }

                // 숫자만 추출
                var numbers = Regex.Replace(value, @"[^\d]", "");

                if (numbers.Length == 11 && numbers.StartsWith("010"))
                {
                    _phone = $"{numbers.Substring(0, 3)}-{numbers.Substring(3, 4)}-{numbers.Substring(7, 4)}";
                }
                else if (numbers.Length >= 9 && numbers.Length <= 11)
                {
                    _phone = numbers;
                }
                else
                {
                    throw new ArgumentException("올바른 전화번호 형식이 아닙니다.");
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _email = null;
                    return;
                }

                var trimmed = value.Trim().ToLower();
                if (!Regex.IsMatch(trimmed, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    throw new ArgumentException("올바른 이메일 형식이 아닙니다.");

                _email = trimmed;
            }
        }

        public string MessengerID { get; set; }

        public string Memo { get; set; }
        
        public string ImagePath { get; set; }

        // 조인용 속성 (읽기 전용)

        public string DeptCode { get; set; }

        public string DeptName { get; set; }

    }
}
