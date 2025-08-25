using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class DepartmentManagementForm : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeManageDB;Integrated Security=True;";

        public DepartmentManagementForm()
        {
            InitializeComponent();
        }

        private void DepartmentManagementForm_Load(object sender, EventArgs e)
        {
            LoadDepartmentData();
        }

        private void LoadDepartmentData()
        {
            string query = "SELECT DeptCode AS [부서코드], DeptName AS [부서명] , Memo AS [메모] FROM [dbo].[Department]";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DpetDgv.DataSource = dt;
                DpetDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }


        private void BtnAdd_Click(object sender, EventArgs e) //추가버튼
        {
            using (var dlg = new AddDepartmentForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadDepartmentData();
                }
            }
        }

        private void BtnModify_Click(object sender, EventArgs e) //수정버튼
        {
            DataGridViewRow row = null;
            if (DpetDgv.SelectedRows.Count > 0)
                row = DpetDgv.SelectedRows[0];
            else if (DpetDgv.SelectedCells.Count > 0)
                row = DpetDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {
                string deptCode = row.Cells["부서코드"].Value?.ToString() ?? string.Empty;
                string deptName = row.Cells["부서명"].Value?.ToString() ?? string.Empty;
                string memo = row.Cells["메모"].Value?.ToString() ?? string.Empty;

                using (var dlg = new ModifyDepartmentForm(deptCode, deptName, memo))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        LoadDepartmentData();
                    }
                }
            }
            else
            {
                MessageBox.Show("수정할 셀을 선택하세요.");
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e) //삭제버튼
        {
            DataGridViewRow row = null;
            if (DpetDgv.SelectedRows.Count > 0)
                row = DpetDgv.SelectedRows[0];
            else if (DpetDgv.SelectedCells.Count > 0)
                row = DpetDgv.SelectedCells[0].OwningRow;

            if (row != null)
            {
                string deptCode = row.Cells["부서코드"].Value?.ToString() ?? string.Empty;
                string deptName = row.Cells["부서명"].Value?.ToString() ?? string.Empty;

                using (var dlg = new DeleteDepartmentForm(deptCode, deptName))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        LoadDepartmentData();
                    }
                }
            }
            else
            {
                MessageBox.Show("삭제할 셀 또는 행을 선택하세요.");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) //닫기버튼
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
