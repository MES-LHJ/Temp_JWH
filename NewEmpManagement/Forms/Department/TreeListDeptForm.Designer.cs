namespace NewEmpManagement.Forms.Department
{
    partial class TreeListDeptForm
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
            this.TreeListView = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUDeptCode1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeptCode1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEmpCode1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeNodeDtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.treeNodeDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colEmpCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeptCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUDeptCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TreeListPanel = new DevExpress.XtraEditors.PanelControl();
            this.TreeListLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeNodeDtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeNodeDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListPanel)).BeginInit();
            this.TreeListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeListView
            // 
            this.TreeListView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colParentId,
            this.colName,
            this.colUDeptCode1,
            this.colDeptCode1,
            this.colEmpCode1});
            this.TreeListView.CustomizationFormBounds = new System.Drawing.Rectangle(442, 591, 266, 244);
            this.TreeListView.DataSource = this.treeNodeDtoBindingSource1;
            this.TreeListView.KeyFieldName = "Id";
            this.TreeListView.Location = new System.Drawing.Point(12, 34);
            this.TreeListView.Name = "TreeListView";
            this.TreeListView.OptionsBehavior.Editable = false;
            this.TreeListView.OptionsBehavior.PopulateServiceColumns = true;
            this.TreeListView.ParentFieldName = "ParentId";
            this.TreeListView.Size = new System.Drawing.Size(636, 649);
            this.TreeListView.TabIndex = 1;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            // 
            // colName
            // 
            this.colName.Caption = "이름";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 3;
            // 
            // colUDeptCode1
            // 
            this.colUDeptCode1.Caption = "상위부서코드";
            this.colUDeptCode1.FieldName = "UDeptCode";
            this.colUDeptCode1.Name = "colUDeptCode1";
            this.colUDeptCode1.Visible = true;
            this.colUDeptCode1.VisibleIndex = 0;
            // 
            // colDeptCode1
            // 
            this.colDeptCode1.Caption = "부서코드";
            this.colDeptCode1.FieldName = "DeptCode";
            this.colDeptCode1.Name = "colDeptCode1";
            this.colDeptCode1.Visible = true;
            this.colDeptCode1.VisibleIndex = 1;
            // 
            // colEmpCode1
            // 
            this.colEmpCode1.Caption = "사원코드";
            this.colEmpCode1.FieldName = "EmpCode";
            this.colEmpCode1.Name = "colEmpCode1";
            this.colEmpCode1.Visible = true;
            this.colEmpCode1.VisibleIndex = 2;
            // 
            // treeNodeDtoBindingSource1
            // 
            this.treeNodeDtoBindingSource1.DataSource = typeof(NewEmpManagement.Models.TreeNodeDto);
            // 
            // colEmpCode
            // 
            this.colEmpCode.FieldName = "EmpCode";
            this.colEmpCode.Name = "colEmpCode";
            this.colEmpCode.OptionsColumn.AllowSort = true;
            this.colEmpCode.Visible = true;
            this.colEmpCode.VisibleIndex = 0;
            // 
            // colDeptCode
            // 
            this.colDeptCode.FieldName = "DeptCode";
            this.colDeptCode.Name = "colDeptCode";
            this.colDeptCode.OptionsColumn.AllowSort = true;
            this.colDeptCode.Visible = true;
            this.colDeptCode.VisibleIndex = 1;
            // 
            // colUDeptCode
            // 
            this.colUDeptCode.FieldName = "UDeptCode";
            this.colUDeptCode.Name = "colUDeptCode";
            this.colUDeptCode.OptionsColumn.AllowSort = true;
            this.colUDeptCode.Visible = true;
            this.colUDeptCode.VisibleIndex = 2;
            // 
            // TreeListPanel
            // 
            this.TreeListPanel.Controls.Add(this.TreeListLabel);
            this.TreeListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TreeListPanel.Location = new System.Drawing.Point(0, 0);
            this.TreeListPanel.Name = "TreeListPanel";
            this.TreeListPanel.Size = new System.Drawing.Size(660, 34);
            this.TreeListPanel.TabIndex = 2;
            // 
            // TreeListLabel
            // 
            this.TreeListLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeListLabel.Appearance.Options.UseFont = true;
            this.TreeListLabel.Location = new System.Drawing.Point(12, 10);
            this.TreeListLabel.Name = "TreeListLabel";
            this.TreeListLabel.Size = new System.Drawing.Size(26, 17);
            this.TreeListLabel.TabIndex = 0;
            this.TreeListLabel.Text = "트리";
            // 
            // TreeListDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 696);
            this.Controls.Add(this.TreeListPanel);
            this.Controls.Add(this.TreeListView);
            this.Name = "TreeListDeptForm";
            this.Text = "TreeListForm";
            ((System.ComponentModel.ISupportInitialize)(this.TreeListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeNodeDtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeNodeDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListPanel)).EndInit();
            this.TreeListPanel.ResumeLayout(false);
            this.TreeListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList TreeListView;
        private DevExpress.XtraEditors.PanelControl TreeListPanel;
        private DevExpress.XtraEditors.LabelControl TreeListLabel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEmpCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeptCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUDeptCode;
        private System.Windows.Forms.BindingSource treeNodeDtoBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUDeptCode1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeptCode1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEmpCode1;
        private System.Windows.Forms.BindingSource treeNodeDtoBindingSource1;
    }
}