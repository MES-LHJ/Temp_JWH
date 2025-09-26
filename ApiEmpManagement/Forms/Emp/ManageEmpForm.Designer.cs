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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmpForm));
            this.EmpGridView = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnDataConv = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLoginInfo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModify = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMultiAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.employeeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpGridView
            // 
            this.EmpGridView.DataSource = this.employeeDtoBindingSource;
            this.EmpGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.EmpGridView.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.EmpGridView.Location = new System.Drawing.Point(0, 55);
            this.EmpGridView.MainView = this.gridView1;
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.Size = new System.Drawing.Size(1447, 449);
            this.EmpGridView.TabIndex = 5;
            this.EmpGridView.TabStop = false;
            this.EmpGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Location = new System.Drawing.Point(1399, 14);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(38, 31);
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
            this.layoutControl1.Controls.Add(this.BtnDataConv);
            this.layoutControl1.Controls.Add(this.BtnDelete);
            this.layoutControl1.Controls.Add(this.BtnLoginInfo);
            this.layoutControl1.Controls.Add(this.BtnAdd);
            this.layoutControl1.Controls.Add(this.BtnModify);
            this.layoutControl1.Controls.Add(this.BtnRefresh);
            this.layoutControl1.Controls.Add(this.BtnMultiAdd);
            this.layoutControl1.Controls.Add(this.BtnDepartment);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1057, 340, 650, 400);
            this.layoutControl1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.AutoSize;
            this.layoutControl1.OptionsView.AlwaysScrollActiveControlIntoView = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1447, 55);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(12, 12);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(36, 35);
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 7;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(52, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 35);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "부서사원";
            // 
            // BtnDataConv
            // 
            this.BtnDataConv.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDataConv.Appearance.Options.UseFont = true;
            this.BtnDataConv.Location = new System.Drawing.Point(1294, 12);
            this.BtnDataConv.Name = "BtnDataConv";
            this.BtnDataConv.Size = new System.Drawing.Size(60, 35);
            this.BtnDataConv.StyleController = this.layoutControl1;
            this.BtnDataConv.TabIndex = 1;
            this.BtnDataConv.Text = "자료변환";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(1237, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(53, 35);
            this.BtnDelete.StyleController = this.layoutControl1;
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "삭제";
            // 
            // BtnLoginInfo
            // 
            this.BtnLoginInfo.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginInfo.Appearance.Options.UseFont = true;
            this.BtnLoginInfo.Location = new System.Drawing.Point(1175, 12);
            this.BtnLoginInfo.Name = "BtnLoginInfo";
            this.BtnLoginInfo.Size = new System.Drawing.Size(58, 35);
            this.BtnLoginInfo.StyleController = this.layoutControl1;
            this.BtnLoginInfo.TabIndex = 1;
            this.BtnLoginInfo.Text = "로그인\r\n정보";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(979, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(67, 35);
            this.BtnAdd.StyleController = this.layoutControl1;
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "추가";
            // 
            // BtnModify
            // 
            this.BtnModify.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnModify.Appearance.Options.UseFont = true;
            this.BtnModify.Location = new System.Drawing.Point(1116, 12);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(55, 35);
            this.BtnModify.StyleController = this.layoutControl1;
            this.BtnModify.TabIndex = 1;
            this.BtnModify.Text = "수정";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnRefresh.Appearance.Options.UseFont = true;
            this.BtnRefresh.Location = new System.Drawing.Point(906, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(69, 35);
            this.BtnRefresh.StyleController = this.layoutControl1;
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "조회";
            // 
            // BtnMultiAdd
            // 
            this.BtnMultiAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiAdd.Appearance.Options.UseFont = true;
            this.BtnMultiAdd.Location = new System.Drawing.Point(1050, 12);
            this.BtnMultiAdd.Name = "BtnMultiAdd";
            this.BtnMultiAdd.Size = new System.Drawing.Size(62, 35);
            this.BtnMultiAdd.StyleController = this.layoutControl1;
            this.BtnMultiAdd.TabIndex = 1;
            this.BtnMultiAdd.Text = "다중추가";
            // 
            // BtnDepartment
            // 
            this.BtnDepartment.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDepartment.Appearance.Options.UseFont = true;
            this.BtnDepartment.Location = new System.Drawing.Point(832, 12);
            this.BtnDepartment.Name = "BtnDepartment";
            this.BtnDepartment.Size = new System.Drawing.Size(70, 35);
            this.BtnDepartment.StyleController = this.layoutControl1;
            this.BtnDepartment.TabIndex = 1;
            this.BtnDepartment.Text = "부서";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1447, 59);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.BtnDataConv;
            this.layoutControlItem1.Location = new System.Drawing.Point(1282, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(59, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(64, 39);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.BtnClose;
            this.layoutControlItem9.Location = new System.Drawing.Point(1389, 0);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(35, 26);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4);
            this.layoutControlItem9.Size = new System.Drawing.Size(38, 39);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.BtnDelete;
            this.layoutControlItem8.Location = new System.Drawing.Point(1225, 0);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(35, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(57, 39);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.BtnLoginInfo;
            this.layoutControlItem7.Location = new System.Drawing.Point(1163, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(62, 39);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.BtnModify;
            this.layoutControlItem6.Location = new System.Drawing.Point(1104, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(35, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(59, 39);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.BtnMultiAdd;
            this.layoutControlItem5.Location = new System.Drawing.Point(1038, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(59, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(66, 39);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnRefresh;
            this.layoutControlItem3.Location = new System.Drawing.Point(894, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(35, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(73, 39);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1346, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(43, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(43, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(43, 39);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.labelControl1;
            this.layoutControlItem10.Location = new System.Drawing.Point(40, 0);
            this.layoutControlItem10.MinSize = new System.Drawing.Size(64, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(69, 39);
            this.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.svgImageBox1;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(40, 39);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(109, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(711, 39);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BtnDepartment;
            this.layoutControlItem4.Location = new System.Drawing.Point(820, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(35, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(74, 39);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.BtnAdd;
            this.layoutControlItem2.Location = new System.Drawing.Point(967, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(30, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(71, 39);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // employeeDtoBindingSource
            // 
            this.employeeDtoBindingSource.DataSource = typeof(ApiEmpManagement.Model.Dto.EmployeeDto);
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
            // ManageEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 504);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ManageEmpForm";
            this.Text = "ManageEmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl EmpGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDataConv;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnLoginInfo;
        private DevExpress.XtraEditors.SimpleButton BtnModify;
        private DevExpress.XtraEditors.SimpleButton BtnMultiAdd;
        private DevExpress.XtraEditors.SimpleButton BtnDepartment;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource employeeDtoBindingSource;
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
    }
}