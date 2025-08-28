using System;
using System.Windows.Forms;
using EmployeeManagement.Forms;
using EmployeeManagement.Forms.Employee;

namespace EmployeeManagement
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // 로그인 폼을 먼저 표시
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // 로그인 성공 시 메인 폼 실행
                    Application.Run(new ManageDeptEmpForm());
                }
            }
        }
    }
}
