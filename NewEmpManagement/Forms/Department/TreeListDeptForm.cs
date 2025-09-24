using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using NewEmpManagement.Models;
using NewEmpManagement.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmpManagement.Forms.Department
{
    public partial class TreeListDeptForm : DevExpress.XtraEditors.XtraForm
    {
        public TreeListDeptForm()
        {
            InitializeComponent();
            LoadTreeListAsync();
        }

        private async Task LoadTreeListAsync()
        {
            var uDeptList = await UpperDepartmentRepository.Instance.GetAllUpperDepartments();
            var deptList = await DepartmentRepository.Instance.GetAllDepartments();
            var empList = await EmployeeRepository.Instance.GetEmployeeDtosAsync(); 

            var treeListNodes = new List<TreeNodeDto>();
            TreeList treeList = this.TreeListView;

            // 2. 상위부서(UDept) 노드(직원이 없어도 표시)
            treeListNodes.AddRange(
                uDeptList.Select(ud => new TreeNodeDto
                {
                    Id = $"U_{ud.UDeptID}",
                    ParentId = null, // 최상위 노드
                    Name = ud.UDeptName,
                    UDeptCode = ud.UDeptCode
                })
            );

            //  부서(Dept) 노드를 (직원이 없어도 표시)
            treeListNodes.AddRange(
                deptList.Select(d => new TreeNodeDto
                {
                    Id = $"D_{d.DeptID}",
                    ParentId = d.UDeptID == 0 ? null : $"U_{d.UDeptID}", // 상위부서 ID를 ParentId로 설정
                    Name = d.DeptName,
                    // 부모의 UDeptCode를 찾아서 설정해줍니다.
                    UDeptCode = uDeptList.FirstOrDefault(ud => ud.UDeptID == d.UDeptID)?.UDeptCode ?? string.Empty,
                    DeptCode = d.DeptCode
                })
            );

            //  사원(Emp) 노드
            treeListNodes.AddRange(
                empList.Select(e => new TreeNodeDto
                {
                    Id = $"E_{e.EmpID}",
                    ParentId = e.DeptID == 0 ? null : $"D_{e.DeptID}",
                    Name = e.EmpName,
                    UDeptCode = e.UDeptCode,
                    DeptCode = e.DeptCode,
                    EmpCode = e.EmpCode
                })
            );
            treeList.KeyFieldName = "Id";
            treeList.ParentFieldName = "ParentId";
            treeList.DataSource = treeListNodes;

            treeList.ExpandAll();
        }
    }
}