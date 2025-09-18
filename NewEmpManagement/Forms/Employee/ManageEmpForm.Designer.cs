namespace NewEmpManagement.Forms
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
            this.EmpGridView = new DevExpress.XtraGrid.GridControl();
            this.employeeDetailDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploymentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessengerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImagePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDeptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.EmpTopPanel = new DevExpress.XtraEditors.PanelControl();
            this.EmpTitleLabel = new DevExpress.XtraEditors.LabelControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDataConv = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnLoginInfo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModify = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMultiAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTopPanel)).BeginInit();
            this.EmpTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpGridView
            // 
            this.EmpGridView.DataSource = this.employeeDetailDtoBindingSource;
            this.EmpGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.EmpGridView.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.EmpGridView.Location = new System.Drawing.Point(0, 43);
            this.EmpGridView.MainView = this.gridView1;
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.Size = new System.Drawing.Size(1426, 451);
            this.EmpGridView.TabIndex = 0;
            this.EmpGridView.TabStop = false;
            this.EmpGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // employeeDetailDtoBindingSource
            // 
            this.employeeDetailDtoBindingSource.DataSource = typeof(NewEmpManagement.Models.Dto.EmployeeDetailDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpID,
            this.colEmpCode,
            this.colEmpName,
            this.colLoginID,
            this.colPwd,
            this.colPosition,
            this.colEmploymentType,
            this.colGender,
            this.colPhone,
            this.colEmail,
            this.colMessengerID,
            this.colMemo,
            this.colImagePath,
            this.colDeptID,
            this.colDeptCode,
            this.colDeptName,
            this.colUDeptCode,
            this.colUDeptName});
            this.gridView1.DetailHeight = 375;
            this.gridView1.GridControl = this.EmpGridView;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmpID
            // 
            this.colEmpID.FieldName = "EmpID";
            this.colEmpID.Name = "colEmpID";
            this.colEmpID.OptionsColumn.AllowEdit = false;
            this.colEmpID.OptionsColumn.AllowFocus = false;
            this.colEmpID.OptionsColumn.AllowMove = false;
            this.colEmpID.OptionsColumn.ReadOnly = true;
            this.colEmpID.OptionsColumn.TabStop = false;
            this.colEmpID.Visible = true;
            this.colEmpID.VisibleIndex = 0;
            // 
            // colEmpCode
            // 
            this.colEmpCode.FieldName = "EmpCode";
            this.colEmpCode.Name = "colEmpCode";
            this.colEmpCode.OptionsColumn.AllowEdit = false;
            this.colEmpCode.OptionsColumn.AllowFocus = false;
            this.colEmpCode.OptionsColumn.AllowMove = false;
            this.colEmpCode.OptionsColumn.ReadOnly = true;
            this.colEmpCode.OptionsColumn.TabStop = false;
            this.colEmpCode.Visible = true;
            this.colEmpCode.VisibleIndex = 1;
            // 
            // colEmpName
            // 
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.OptionsColumn.AllowEdit = false;
            this.colEmpName.OptionsColumn.AllowFocus = false;
            this.colEmpName.OptionsColumn.AllowMove = false;
            this.colEmpName.OptionsColumn.ReadOnly = true;
            this.colEmpName.OptionsColumn.TabStop = false;
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 2;
            // 
            // colLoginID
            // 
            this.colLoginID.FieldName = "LoginID";
            this.colLoginID.Name = "colLoginID";
            this.colLoginID.OptionsColumn.AllowEdit = false;
            this.colLoginID.OptionsColumn.AllowFocus = false;
            this.colLoginID.OptionsColumn.AllowMove = false;
            this.colLoginID.OptionsColumn.ReadOnly = true;
            this.colLoginID.OptionsColumn.TabStop = false;
            this.colLoginID.Visible = true;
            this.colLoginID.VisibleIndex = 3;
            // 
            // colPwd
            // 
            this.colPwd.FieldName = "Pwd";
            this.colPwd.Name = "colPwd";
            this.colPwd.OptionsColumn.AllowEdit = false;
            this.colPwd.OptionsColumn.AllowFocus = false;
            this.colPwd.OptionsColumn.AllowMove = false;
            this.colPwd.OptionsColumn.ReadOnly = true;
            this.colPwd.OptionsColumn.TabStop = false;
            this.colPwd.Visible = true;
            this.colPwd.VisibleIndex = 4;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.OptionsColumn.AllowEdit = false;
            this.colPosition.OptionsColumn.AllowFocus = false;
            this.colPosition.OptionsColumn.AllowMove = false;
            this.colPosition.OptionsColumn.ReadOnly = true;
            this.colPosition.OptionsColumn.TabStop = false;
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 5;
            // 
            // colEmploymentType
            // 
            this.colEmploymentType.FieldName = "EmploymentType";
            this.colEmploymentType.Name = "colEmploymentType";
            this.colEmploymentType.OptionsColumn.AllowEdit = false;
            this.colEmploymentType.OptionsColumn.AllowFocus = false;
            this.colEmploymentType.OptionsColumn.AllowMove = false;
            this.colEmploymentType.OptionsColumn.ReadOnly = true;
            this.colEmploymentType.OptionsColumn.TabStop = false;
            this.colEmploymentType.Visible = true;
            this.colEmploymentType.VisibleIndex = 6;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowEdit = false;
            this.colGender.OptionsColumn.AllowFocus = false;
            this.colGender.OptionsColumn.AllowMove = false;
            this.colGender.OptionsColumn.ReadOnly = true;
            this.colGender.OptionsColumn.TabStop = false;
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 7;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.OptionsColumn.AllowMove = false;
            this.colPhone.OptionsColumn.ReadOnly = true;
            this.colPhone.OptionsColumn.TabStop = false;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 8;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.AllowFocus = false;
            this.colEmail.OptionsColumn.AllowMove = false;
            this.colEmail.OptionsColumn.TabStop = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            // 
            // colMessengerID
            // 
            this.colMessengerID.FieldName = "MessengerID";
            this.colMessengerID.Name = "colMessengerID";
            this.colMessengerID.OptionsColumn.AllowEdit = false;
            this.colMessengerID.OptionsColumn.AllowFocus = false;
            this.colMessengerID.OptionsColumn.AllowMove = false;
            this.colMessengerID.OptionsColumn.ReadOnly = true;
            this.colMessengerID.OptionsColumn.TabStop = false;
            this.colMessengerID.Visible = true;
            this.colMessengerID.VisibleIndex = 10;
            // 
            // colMemo
            // 
            this.colMemo.FieldName = "Memo";
            this.colMemo.Name = "colMemo";
            this.colMemo.OptionsColumn.AllowEdit = false;
            this.colMemo.OptionsColumn.AllowFocus = false;
            this.colMemo.OptionsColumn.AllowMove = false;
            this.colMemo.OptionsColumn.ReadOnly = true;
            this.colMemo.OptionsColumn.TabStop = false;
            this.colMemo.Visible = true;
            this.colMemo.VisibleIndex = 11;
            // 
            // colImagePath
            // 
            this.colImagePath.FieldName = "ImagePath";
            this.colImagePath.Name = "colImagePath";
            this.colImagePath.OptionsColumn.AllowEdit = false;
            this.colImagePath.OptionsColumn.AllowFocus = false;
            this.colImagePath.OptionsColumn.AllowMove = false;
            this.colImagePath.OptionsColumn.ReadOnly = true;
            this.colImagePath.OptionsColumn.TabStop = false;
            this.colImagePath.Visible = true;
            this.colImagePath.VisibleIndex = 12;
            // 
            // colDeptID
            // 
            this.colDeptID.FieldName = "DeptID";
            this.colDeptID.Name = "colDeptID";
            this.colDeptID.OptionsColumn.AllowEdit = false;
            this.colDeptID.OptionsColumn.AllowFocus = false;
            this.colDeptID.OptionsColumn.AllowMove = false;
            this.colDeptID.OptionsColumn.ReadOnly = true;
            this.colDeptID.OptionsColumn.TabStop = false;
            this.colDeptID.Visible = true;
            this.colDeptID.VisibleIndex = 13;
            // 
            // colDeptCode
            // 
            this.colDeptCode.FieldName = "DeptCode";
            this.colDeptCode.Name = "colDeptCode";
            this.colDeptCode.OptionsColumn.AllowEdit = false;
            this.colDeptCode.OptionsColumn.AllowFocus = false;
            this.colDeptCode.OptionsColumn.AllowMove = false;
            this.colDeptCode.OptionsColumn.ReadOnly = true;
            this.colDeptCode.OptionsColumn.TabStop = false;
            this.colDeptCode.Visible = true;
            this.colDeptCode.VisibleIndex = 14;
            // 
            // colDeptName
            // 
            this.colDeptName.FieldName = "DeptName";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.OptionsColumn.AllowEdit = false;
            this.colDeptName.OptionsColumn.AllowFocus = false;
            this.colDeptName.OptionsColumn.AllowMove = false;
            this.colDeptName.OptionsColumn.ReadOnly = true;
            this.colDeptName.OptionsColumn.TabStop = false;
            this.colDeptName.Visible = true;
            this.colDeptName.VisibleIndex = 15;
            // 
            // colUDeptCode
            // 
            this.colUDeptCode.FieldName = "UDeptCode";
            this.colUDeptCode.Name = "colUDeptCode";
            this.colUDeptCode.OptionsColumn.AllowEdit = false;
            this.colUDeptCode.OptionsColumn.AllowFocus = false;
            this.colUDeptCode.OptionsColumn.AllowMove = false;
            this.colUDeptCode.OptionsColumn.ReadOnly = true;
            this.colUDeptCode.OptionsColumn.TabStop = false;
            this.colUDeptCode.Visible = true;
            this.colUDeptCode.VisibleIndex = 16;
            // 
            // colUDeptName
            // 
            this.colUDeptName.FieldName = "UDeptName";
            this.colUDeptName.Name = "colUDeptName";
            this.colUDeptName.OptionsColumn.AllowEdit = false;
            this.colUDeptName.OptionsColumn.AllowFocus = false;
            this.colUDeptName.OptionsColumn.AllowMove = false;
            this.colUDeptName.OptionsColumn.ReadOnly = true;
            this.colUDeptName.OptionsColumn.TabStop = false;
            this.colUDeptName.Visible = true;
            this.colUDeptName.VisibleIndex = 17;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(977, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(54, 32);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "추가";
            // 
            // EmpTopPanel
            // 
            this.EmpTopPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.EmpTopPanel.Appearance.Options.UseBackColor = true;
            this.EmpTopPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.EmpTopPanel.Controls.Add(this.EmpTitleLabel);
            this.EmpTopPanel.Controls.Add(this.BtnClose);
            this.EmpTopPanel.Controls.Add(this.BtnDataConv);
            this.EmpTopPanel.Controls.Add(this.BtnDelete);
            this.EmpTopPanel.Controls.Add(this.BtnLoginInfo);
            this.EmpTopPanel.Controls.Add(this.BtnModify);
            this.EmpTopPanel.Controls.Add(this.BtnMultiAdd);
            this.EmpTopPanel.Controls.Add(this.BtnDepartment);
            this.EmpTopPanel.Controls.Add(this.BtnRefresh);
            this.EmpTopPanel.Controls.Add(this.BtnAdd);
            this.EmpTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpTopPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpTopPanel.Name = "EmpTopPanel";
            this.EmpTopPanel.Size = new System.Drawing.Size(1426, 43);
            this.EmpTopPanel.TabIndex = 2;
            // 
            // EmpTitleLabel
            // 
            this.EmpTitleLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTitleLabel.Appearance.Options.UseFont = true;
            this.EmpTitleLabel.Location = new System.Drawing.Point(18, 11);
            this.EmpTitleLabel.Name = "EmpTitleLabel";
            this.EmpTitleLabel.Size = new System.Drawing.Size(60, 20);
            this.EmpTitleLabel.TabIndex = 0;
            this.EmpTitleLabel.Text = "부서사원";
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Location = new System.Drawing.Point(1355, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(46, 27);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "닫기";
            // 
            // BtnDataConv
            // 
            this.BtnDataConv.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnDataConv.Appearance.Options.UseFont = true;
            this.BtnDataConv.Location = new System.Drawing.Point(1277, 5);
            this.BtnDataConv.Name = "BtnDataConv";
            this.BtnDataConv.Size = new System.Drawing.Size(54, 32);
            this.BtnDataConv.TabIndex = 1;
            this.BtnDataConv.Text = "자료변환";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(1217, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(54, 32);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "삭제";
            // 
            // BtnLoginInfo
            // 
            this.BtnLoginInfo.Appearance.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLoginInfo.Appearance.Options.UseFont = true;
            this.BtnLoginInfo.Location = new System.Drawing.Point(1157, 5);
            this.BtnLoginInfo.Name = "BtnLoginInfo";
            this.BtnLoginInfo.Size = new System.Drawing.Size(54, 32);
            this.BtnLoginInfo.TabIndex = 1;
            this.BtnLoginInfo.Text = "로그인\r\n정보";
            // 
            // BtnModify
            // 
            this.BtnModify.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnModify.Appearance.Options.UseFont = true;
            this.BtnModify.Location = new System.Drawing.Point(1097, 5);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(54, 32);
            this.BtnModify.TabIndex = 1;
            this.BtnModify.Text = "수정";
            // 
            // BtnMultiAdd
            // 
            this.BtnMultiAdd.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnMultiAdd.Appearance.Options.UseFont = true;
            this.BtnMultiAdd.Location = new System.Drawing.Point(1037, 5);
            this.BtnMultiAdd.Name = "BtnMultiAdd";
            this.BtnMultiAdd.Size = new System.Drawing.Size(54, 32);
            this.BtnMultiAdd.TabIndex = 1;
            this.BtnMultiAdd.Text = "다중추가";
            // 
            // BtnDepartment
            // 
            this.BtnDepartment.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDepartment.Appearance.Options.UseFont = true;
            this.BtnDepartment.Location = new System.Drawing.Point(857, 5);
            this.BtnDepartment.Name = "BtnDepartment";
            this.BtnDepartment.Size = new System.Drawing.Size(54, 32);
            this.BtnDepartment.TabIndex = 1;
            this.BtnDepartment.Text = "부서";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnRefresh.Appearance.Options.UseFont = true;
            this.BtnRefresh.Location = new System.Drawing.Point(917, 5);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(54, 32);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "조회";
            // 
            // ManageEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 494);
            this.Controls.Add(this.EmpGridView);
            this.Controls.Add(this.EmpTopPanel);
            this.Name = "ManageEmpForm";
            this.Text = "EmpTableForms";
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTopPanel)).EndInit();
            this.EmpTopPanel.ResumeLayout(false);
            this.EmpTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl EmpGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.PanelControl EmpTopPanel;
        private DevExpress.XtraEditors.LabelControl EmpTitleLabel;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDataConv;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnLoginInfo;
        private DevExpress.XtraEditors.SimpleButton BtnModify;
        private DevExpress.XtraEditors.SimpleButton BtnMultiAdd;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.SimpleButton BtnDepartment;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource employeeDetailDtoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpCode;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginID;
        private DevExpress.XtraGrid.Columns.GridColumn colPwd;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colMessengerID;
        private DevExpress.XtraGrid.Columns.GridColumn colMemo;
        private DevExpress.XtraGrid.Columns.GridColumn colImagePath;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptID;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn colUDeptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUDeptName;
    }
}