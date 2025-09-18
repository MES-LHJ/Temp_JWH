using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEmpManagement.Utils
{
    public static class AppConfig
    {
        private const string ConnectionName = "NewEmployeeManagementDB";

        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
    }
    public static class Helpers
    {
        public static bool ValidateRequired(Control control, string message)
        {
            bool isEmpty = false;

            if (control is TextBoxBase tb)
            {
                isEmpty = string.IsNullOrWhiteSpace(tb.Text);
            }
            else if (control is BaseEdit be) // DevExpress BaseEdit 기반 컨트롤들
            {
                if (be is LookUpEdit)
                {
                    isEmpty = be.EditValue == null;
                }
                else
                {
                    isEmpty = string.IsNullOrWhiteSpace(be.Text);
                }
            }

            if (isEmpty)
            {
                MessageBox.Show(message, "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                control.Focus();
                return false;
            }

            return true;
        }
    }
}
