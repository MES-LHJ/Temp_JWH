namespace NewEmpManagement.Forms.Department
{
    partial class ManageDeptForm
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
            this.DeptTopPanel = new DevExpress.XtraEditors.PanelControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModify = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnChart = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTreeList = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUDept = new DevExpress.XtraEditors.SimpleButton();
            this.DeptTitleLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptMainPanel = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.DeptGridView1 = new DevExpress.XtraGrid.GridControl();
            this.upperDepartmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUDeptID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDeptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeptGridView2 = new DevExpress.XtraGrid.GridControl();
            this.departmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDeptID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDeptID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DeptTopPanel)).BeginInit();
            this.DeptTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptMainPanel)).BeginInit();
            this.DeptMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDepartmentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptTopPanel
            // 
            this.DeptTopPanel.Controls.Add(this.BtnClose);
            this.DeptTopPanel.Controls.Add(this.BtnDelete);
            this.DeptTopPanel.Controls.Add(this.BtnModify);
            this.DeptTopPanel.Controls.Add(this.BtnAdd);
            this.DeptTopPanel.Controls.Add(this.BtnChart);
            this.DeptTopPanel.Controls.Add(this.BtnTreeList);
            this.DeptTopPanel.Controls.Add(this.BtnUDept);
            this.DeptTopPanel.Controls.Add(this.DeptTitleLabel);
            this.DeptTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeptTopPanel.Location = new System.Drawing.Point(0, 0);
            this.DeptTopPanel.Name = "DeptTopPanel";
            this.DeptTopPanel.Size = new System.Drawing.Size(1265, 45);
            this.DeptTopPanel.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Location = new System.Drawing.Point(1193, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(52, 29);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "닫기";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(1109, 8);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(54, 32);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "삭제";
            // 
            // BtnModify
            // 
            this.BtnModify.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnModify.Appearance.Options.UseFont = true;
            this.BtnModify.Location = new System.Drawing.Point(1049, 8);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(54, 32);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "수정";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(989, 8);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(54, 32);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "추가";
            // 
            // BtnChart
            // 
            this.BtnChart.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnChart.Appearance.Options.UseFont = true;
            this.BtnChart.Location = new System.Drawing.Point(929, 8);
            this.BtnChart.Name = "BtnChart";
            this.BtnChart.Size = new System.Drawing.Size(54, 32);
            this.BtnChart.TabIndex = 2;
            this.BtnChart.Text = "차트";
            // 
            // BtnTreeList
            // 
            this.BtnTreeList.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTreeList.Appearance.Options.UseFont = true;
            this.BtnTreeList.Location = new System.Drawing.Point(869, 8);
            this.BtnTreeList.Name = "BtnTreeList";
            this.BtnTreeList.Size = new System.Drawing.Size(54, 32);
            this.BtnTreeList.TabIndex = 2;
            this.BtnTreeList.Text = "트리";
            // 
            // BtnUDept
            // 
            this.BtnUDept.Appearance.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnUDept.Appearance.Options.UseFont = true;
            this.BtnUDept.Location = new System.Drawing.Point(809, 8);
            this.BtnUDept.Name = "BtnUDept";
            this.BtnUDept.Size = new System.Drawing.Size(54, 32);
            this.BtnUDept.TabIndex = 2;
            this.BtnUDept.Text = "상위부서";
            // 
            // DeptTitleLabel
            // 
            this.DeptTitleLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptTitleLabel.Appearance.Options.UseFont = true;
            this.DeptTitleLabel.Location = new System.Drawing.Point(15, 13);
            this.DeptTitleLabel.Name = "DeptTitleLabel";
            this.DeptTitleLabel.Size = new System.Drawing.Size(30, 20);
            this.DeptTitleLabel.TabIndex = 0;
            this.DeptTitleLabel.Text = "부서";
            // 
            // DeptMainPanel
            // 
            this.DeptMainPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.DeptMainPanel.Appearance.Options.UseBackColor = true;
            this.DeptMainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.DeptMainPanel.Controls.Add(this.splitContainerControl1);
            this.DeptMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeptMainPanel.Location = new System.Drawing.Point(0, 45);
            this.DeptMainPanel.Name = "DeptMainPanel";
            this.DeptMainPanel.Size = new System.Drawing.Size(1265, 409);
            this.DeptMainPanel.TabIndex = 2;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 17);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.DeptGridView1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.DeptGridView2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1241, 378);
            this.splitContainerControl1.SplitterPosition = 614;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // DeptGridView1
            // 
            this.DeptGridView1.DataSource = this.upperDepartmentModelBindingSource;
            this.DeptGridView1.Location = new System.Drawing.Point(3, 0);
            this.DeptGridView1.MainView = this.gridView1;
            this.DeptGridView1.Name = "DeptGridView1";
            this.DeptGridView1.Size = new System.Drawing.Size(605, 375);
            this.DeptGridView1.TabIndex = 0;
            this.DeptGridView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // upperDepartmentModelBindingSource
            // 
            this.upperDepartmentModelBindingSource.DataSource = typeof(NewEmpManagement.Models.UpperDepartmentModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUDeptID,
            this.colUDeptCode,
            this.colUDeptName,
            this.colMemo});
            this.gridView1.DetailHeight = 375;
            this.gridView1.GridControl = this.DeptGridView1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colUDeptID
            // 
            this.colUDeptID.FieldName = "UDeptID";
            this.colUDeptID.Name = "colUDeptID";
            this.colUDeptID.Visible = true;
            this.colUDeptID.VisibleIndex = 0;
            // 
            // colUDeptCode
            // 
            this.colUDeptCode.FieldName = "UDeptCode";
            this.colUDeptCode.Name = "colUDeptCode";
            this.colUDeptCode.Visible = true;
            this.colUDeptCode.VisibleIndex = 1;
            this.colUDeptCode.Width = 100;
            // 
            // colUDeptName
            // 
            this.colUDeptName.FieldName = "UDeptName";
            this.colUDeptName.Name = "colUDeptName";
            this.colUDeptName.Visible = true;
            this.colUDeptName.VisibleIndex = 2;
            this.colUDeptName.Width = 200;
            // 
            // colMemo
            // 
            this.colMemo.FieldName = "Memo";
            this.colMemo.Name = "colMemo";
            this.colMemo.Visible = true;
            this.colMemo.VisibleIndex = 3;
            this.colMemo.Width = 205;
            // 
            // DeptGridView2
            // 
            this.DeptGridView2.DataSource = this.departmentModelBindingSource;
            this.DeptGridView2.Location = new System.Drawing.Point(7, 0);
            this.DeptGridView2.MainView = this.gridView2;
            this.DeptGridView2.Name = "DeptGridView2";
            this.DeptGridView2.Size = new System.Drawing.Size(606, 375);
            this.DeptGridView2.TabIndex = 1;
            this.DeptGridView2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // departmentModelBindingSource
            // 
            this.departmentModelBindingSource.DataSource = typeof(NewEmpManagement.Models.DepartmentModel);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDeptID,
            this.colDeptCode,
            this.colDeptName,
            this.colMemo1,
            this.colUDeptID1});
            this.gridView2.DetailHeight = 375;
            this.gridView2.GridControl = this.DeptGridView2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // colDeptID
            // 
            this.colDeptID.FieldName = "DeptID";
            this.colDeptID.Name = "colDeptID";
            this.colDeptID.Visible = true;
            this.colDeptID.VisibleIndex = 0;
            this.colDeptID.Width = 68;
            // 
            // colDeptCode
            // 
            this.colDeptCode.FieldName = "DeptCode";
            this.colDeptCode.Name = "colDeptCode";
            this.colDeptCode.Visible = true;
            this.colDeptCode.VisibleIndex = 1;
            this.colDeptCode.Width = 100;
            // 
            // colDeptName
            // 
            this.colDeptName.FieldName = "DeptName";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.Visible = true;
            this.colDeptName.VisibleIndex = 2;
            this.colDeptName.Width = 165;
            // 
            // colMemo1
            // 
            this.colMemo1.FieldName = "Memo";
            this.colMemo1.Name = "colMemo1";
            this.colMemo1.Visible = true;
            this.colMemo1.VisibleIndex = 3;
            this.colMemo1.Width = 165;
            // 
            // colUDeptID1
            // 
            this.colUDeptID1.FieldName = "UDeptID";
            this.colUDeptID1.Name = "colUDeptID1";
            this.colUDeptID1.Visible = true;
            this.colUDeptID1.VisibleIndex = 4;
            this.colUDeptID1.Width = 83;
            // 
            // ManageDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 454);
            this.Controls.Add(this.DeptMainPanel);
            this.Controls.Add(this.DeptTopPanel);
            this.Name = "ManageDeptForm";
            this.Text = "DeptTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeptTopPanel)).EndInit();
            this.DeptTopPanel.ResumeLayout(false);
            this.DeptTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptMainPanel)).EndInit();
            this.DeptMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeptGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDepartmentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl DeptTopPanel;
        private DevExpress.XtraEditors.LabelControl DeptTitleLabel;
        private DevExpress.XtraEditors.PanelControl DeptMainPanel;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl DeptGridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl DeptGridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnModify;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnChart;
        private DevExpress.XtraEditors.SimpleButton BtnTreeList;
        private DevExpress.XtraEditors.SimpleButton BtnUDept;
        private System.Windows.Forms.BindingSource upperDepartmentModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUDeptID;
        private DevExpress.XtraGrid.Columns.GridColumn colUDeptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn colMemo;
        private System.Windows.Forms.BindingSource departmentModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptID;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn colMemo1;
        private DevExpress.XtraGrid.Columns.GridColumn colUDeptID1;
    }
}