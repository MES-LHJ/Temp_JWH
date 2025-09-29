namespace ApiEmpManagement.Forms.Emp
{
    partial class ManageEmpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmpForm));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.employeeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLoginInfo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModify = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutItemClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemDel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemModify = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemRefresh = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutItemDept = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutItemAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactoryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactoryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeaprtmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginTag = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessengerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasMultifactory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpGridView = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemDept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDtoBindingSource
            // 
            this.employeeDtoBindingSource.DataSource = typeof(ApiEmpManagement.Model.Dto.EmployeeDto);
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Location = new System.Drawing.Point(1370, 14);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(88, 27);
            this.BtnClose.StyleController = this.layoutControl1;
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "닫기";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AutoScroll = false;
            this.layoutControl1.Controls.Add(this.svgImageBox1);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.BtnClose);
            this.layoutControl1.Controls.Add(this.BtnDelete);
            this.layoutControl1.Controls.Add(this.BtnLoginInfo);
            this.layoutControl1.Controls.Add(this.BtnAdd);
            this.layoutControl1.Controls.Add(this.BtnModify);
            this.layoutControl1.Controls.Add(this.BtnRefresh);
            this.layoutControl1.Controls.Add(this.BtnDepartment);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1057, 340, 650, 400);
            this.layoutControl1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.AutoSize;
            this.layoutControl1.OptionsView.AlwaysScrollActiveControlIntoView = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1468, 55);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(12, 12);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(37, 31);
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 7;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(53, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 31);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "부서사원";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(1255, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(70, 31);
            this.BtnDelete.StyleController = this.layoutControl1;
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "삭제";
            // 
            // BtnLoginInfo
            // 
            this.BtnLoginInfo.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnLoginInfo.Appearance.Options.UseFont = true;
            this.BtnLoginInfo.Location = new System.Drawing.Point(1180, 12);
            this.BtnLoginInfo.Name = "BtnLoginInfo";
            this.BtnLoginInfo.Size = new System.Drawing.Size(71, 31);
            this.BtnLoginInfo.StyleController = this.layoutControl1;
            this.BtnLoginInfo.TabIndex = 1;
            this.BtnLoginInfo.Text = "로그인\r\n";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(1006, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(82, 31);
            this.BtnAdd.StyleController = this.layoutControl1;
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "추가";
            // 
            // BtnModify
            // 
            this.BtnModify.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnModify.Appearance.Options.UseFont = true;
            this.BtnModify.Location = new System.Drawing.Point(1092, 12);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(84, 31);
            this.BtnModify.StyleController = this.layoutControl1;
            this.BtnModify.TabIndex = 1;
            this.BtnModify.Text = "수정";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefresh.Appearance.Options.UseFont = true;
            this.BtnRefresh.Location = new System.Drawing.Point(925, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(77, 31);
            this.BtnRefresh.StyleController = this.layoutControl1;
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "조회";
            // 
            // BtnDepartment
            // 
            this.BtnDepartment.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDepartment.Appearance.Options.UseFont = true;
            this.BtnDepartment.Location = new System.Drawing.Point(844, 12);
            this.BtnDepartment.Name = "BtnDepartment";
            this.BtnDepartment.Size = new System.Drawing.Size(77, 31);
            this.BtnDepartment.StyleController = this.layoutControl1;
            this.BtnDepartment.TabIndex = 1;
            this.BtnDepartment.Text = "부서";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutItemClose,
            this.layoutItemDel,
            this.layoutItemLogin,
            this.layoutItemModify,
            this.layoutItemRefresh,
            this.emptySpaceItem1,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.emptySpaceItem2,
            this.layoutItemDept,
            this.layoutItemAdd});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1468, 55);
            this.Root.TextVisible = false;
            // 
            // layoutItemClose
            // 
            this.layoutItemClose.Control = this.BtnClose;
            this.layoutItemClose.CustomizationFormText = "layoutItemClose";
            this.layoutItemClose.Location = new System.Drawing.Point(1360, 0);
            this.layoutItemClose.MinSize = new System.Drawing.Size(35, 26);
            this.layoutItemClose.Name = "layoutItemClose";
            this.layoutItemClose.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4);
            this.layoutItemClose.Size = new System.Drawing.Size(88, 35);
            this.layoutItemClose.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemClose.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemClose.TextVisible = false;
            // 
            // layoutItemDel
            // 
            this.layoutItemDel.Control = this.BtnDelete;
            this.layoutItemDel.CustomizationFormText = "layoutItemDel";
            this.layoutItemDel.Location = new System.Drawing.Point(1243, 0);
            this.layoutItemDel.MinSize = new System.Drawing.Size(35, 26);
            this.layoutItemDel.Name = "layoutItemDel";
            this.layoutItemDel.Size = new System.Drawing.Size(74, 35);
            this.layoutItemDel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemDel.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemDel.TextVisible = false;
            // 
            // layoutItemLogin
            // 
            this.layoutItemLogin.Control = this.BtnLoginInfo;
            this.layoutItemLogin.CustomizationFormText = "layoutItemLogin";
            this.layoutItemLogin.Location = new System.Drawing.Point(1168, 0);
            this.layoutItemLogin.MinSize = new System.Drawing.Size(47, 26);
            this.layoutItemLogin.Name = "layoutItemLogin";
            this.layoutItemLogin.Size = new System.Drawing.Size(75, 35);
            this.layoutItemLogin.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemLogin.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemLogin.TextVisible = false;
            // 
            // layoutItemModify
            // 
            this.layoutItemModify.Control = this.BtnModify;
            this.layoutItemModify.CustomizationFormText = "layoutItemModify";
            this.layoutItemModify.Location = new System.Drawing.Point(1080, 0);
            this.layoutItemModify.MinSize = new System.Drawing.Size(35, 26);
            this.layoutItemModify.Name = "layoutItemModify";
            this.layoutItemModify.Size = new System.Drawing.Size(88, 35);
            this.layoutItemModify.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemModify.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemModify.TextVisible = false;
            // 
            // layoutItemRefresh
            // 
            this.layoutItemRefresh.Control = this.BtnRefresh;
            this.layoutItemRefresh.CustomizationFormText = "layoutItemRefresh";
            this.layoutItemRefresh.Location = new System.Drawing.Point(913, 0);
            this.layoutItemRefresh.MinSize = new System.Drawing.Size(35, 26);
            this.layoutItemRefresh.Name = "layoutItemRefresh";
            this.layoutItemRefresh.Size = new System.Drawing.Size(81, 35);
            this.layoutItemRefresh.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemRefresh.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemRefresh.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1317, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(43, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(43, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(43, 35);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.labelControl1;
            this.layoutControlItem10.Location = new System.Drawing.Point(41, 0);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(64, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(70, 35);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.svgImageBox1;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(41, 35);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(111, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(721, 35);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutItemDept
            // 
            this.layoutItemDept.Control = this.BtnDepartment;
            this.layoutItemDept.CustomizationFormText = "layoutItemDept";
            this.layoutItemDept.Location = new System.Drawing.Point(832, 0);
            this.layoutItemDept.MinSize = new System.Drawing.Size(35, 26);
            this.layoutItemDept.Name = "layoutItemDept";
            this.layoutItemDept.Size = new System.Drawing.Size(81, 35);
            this.layoutItemDept.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemDept.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemDept.TextVisible = false;
            // 
            // layoutItemAdd
            // 
            this.layoutItemAdd.Control = this.BtnAdd;
            this.layoutItemAdd.CustomizationFormText = "layoutItemAdd";
            this.layoutItemAdd.Location = new System.Drawing.Point(994, 0);
            this.layoutItemAdd.MinSize = new System.Drawing.Size(30, 26);
            this.layoutItemAdd.Name = "layoutItemAdd";
            this.layoutItemAdd.Size = new System.Drawing.Size(86, 35);
            this.layoutItemAdd.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutItemAdd.TextSize = new System.Drawing.Size(0, 0);
            this.layoutItemAdd.TextVisible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFactoryId,
            this.colFactoryCode,
            this.colFactoryName,
            this.colDeaprtmentId,
            this.colDepartmentCode,
            this.colDepartmentName,
            this.colDepartmentMemo,
            this.colCode,
            this.colName,
            this.colPosition,
            this.colContractType,
            this.colMemo,
            this.colUseLogin,
            this.colLoginId,
            this.colLoginPassword,
            this.colLoginTag,
            this.colPhoneNumber,
            this.colEmail,
            this.colMessengerId,
            this.colIsAdmin,
            this.colHasMultifactory});
            this.gridView1.GridControl = this.EmpGridView;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colFactoryId
            // 
            this.colFactoryId.FieldName = "FactoryId";
            this.colFactoryId.Name = "colFactoryId";
            this.colFactoryId.Visible = true;
            this.colFactoryId.VisibleIndex = 1;
            // 
            // colFactoryCode
            // 
            this.colFactoryCode.FieldName = "FactoryCode";
            this.colFactoryCode.Name = "colFactoryCode";
            this.colFactoryCode.Visible = true;
            this.colFactoryCode.VisibleIndex = 2;
            // 
            // colFactoryName
            // 
            this.colFactoryName.FieldName = "FactoryName";
            this.colFactoryName.Name = "colFactoryName";
            this.colFactoryName.Visible = true;
            this.colFactoryName.VisibleIndex = 3;
            // 
            // colDeaprtmentId
            // 
            this.colDeaprtmentId.FieldName = "DeaprtmentId";
            this.colDeaprtmentId.Name = "colDeaprtmentId";
            this.colDeaprtmentId.Visible = true;
            this.colDeaprtmentId.VisibleIndex = 4;
            // 
            // colDepartmentCode
            // 
            this.colDepartmentCode.FieldName = "DepartmentCode";
            this.colDepartmentCode.Name = "colDepartmentCode";
            this.colDepartmentCode.Visible = true;
            this.colDepartmentCode.VisibleIndex = 5;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 6;
            // 
            // colDepartmentMemo
            // 
            this.colDepartmentMemo.FieldName = "DepartmentMemo";
            this.colDepartmentMemo.Name = "colDepartmentMemo";
            this.colDepartmentMemo.Visible = true;
            this.colDepartmentMemo.VisibleIndex = 7;
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 8;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 9;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 10;
            // 
            // colContractType
            // 
            this.colContractType.FieldName = "ContractType";
            this.colContractType.Name = "colContractType";
            this.colContractType.Visible = true;
            this.colContractType.VisibleIndex = 11;
            // 
            // colMemo
            // 
            this.colMemo.FieldName = "Memo";
            this.colMemo.Name = "colMemo";
            this.colMemo.Visible = true;
            this.colMemo.VisibleIndex = 12;
            // 
            // colUseLogin
            // 
            this.colUseLogin.FieldName = "UseLogin";
            this.colUseLogin.Name = "colUseLogin";
            this.colUseLogin.Visible = true;
            this.colUseLogin.VisibleIndex = 13;
            // 
            // colLoginId
            // 
            this.colLoginId.FieldName = "LoginId";
            this.colLoginId.Name = "colLoginId";
            this.colLoginId.Visible = true;
            this.colLoginId.VisibleIndex = 14;
            // 
            // colLoginPassword
            // 
            this.colLoginPassword.FieldName = "LoginPassword";
            this.colLoginPassword.Name = "colLoginPassword";
            this.colLoginPassword.Visible = true;
            this.colLoginPassword.VisibleIndex = 15;
            // 
            // colLoginTag
            // 
            this.colLoginTag.FieldName = "LoginTag";
            this.colLoginTag.Name = "colLoginTag";
            this.colLoginTag.Visible = true;
            this.colLoginTag.VisibleIndex = 16;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 17;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 18;
            // 
            // colMessengerId
            // 
            this.colMessengerId.FieldName = "MessengerId";
            this.colMessengerId.Name = "colMessengerId";
            this.colMessengerId.Visible = true;
            this.colMessengerId.VisibleIndex = 19;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 20;
            // 
            // colHasMultifactory
            // 
            this.colHasMultifactory.FieldName = "HasMultifactory";
            this.colHasMultifactory.Name = "colHasMultifactory";
            this.colHasMultifactory.Visible = true;
            this.colHasMultifactory.VisibleIndex = 21;
            // 
            // EmpGridView
            // 
            this.EmpGridView.DataSource = this.employeeDtoBindingSource;
            this.EmpGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.EmpGridView.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.EmpGridView.Location = new System.Drawing.Point(0, 55);
            this.EmpGridView.MainView = this.gridView1;
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.Size = new System.Drawing.Size(1468, 467);
            this.EmpGridView.TabIndex = 5;
            this.EmpGridView.TabStop = false;
            this.EmpGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ManageEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 522);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ManageEmpForm";
            this.Text = "ManageEmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.employeeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemDept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutItemAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnLoginInfo;
        private DevExpress.XtraEditors.SimpleButton BtnModify;
        private DevExpress.XtraEditors.SimpleButton BtnDepartment;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemDel;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemDept;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemRefresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemAdd;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutItemModify;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource employeeDtoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryId;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFactoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colDeaprtmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentMemo;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colContractType;
        private DevExpress.XtraGrid.Columns.GridColumn colMemo;
        private DevExpress.XtraGrid.Columns.GridColumn colUseLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginId;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginTag;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMessengerId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colHasMultifactory;
        private DevExpress.XtraGrid.GridControl EmpGridView;
    }
}