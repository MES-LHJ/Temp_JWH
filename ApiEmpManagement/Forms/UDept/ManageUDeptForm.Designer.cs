namespace ApiEmpManagement.Forms.UDept
{
    partial class ManageUDeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUDeptForm));
            this.UDeptTopPanel = new DevExpress.XtraEditors.PanelControl();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModify = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUDeptDataConv = new DevExpress.XtraEditors.SimpleButton();
            this.UDeptTitleLabel = new DevExpress.XtraEditors.LabelControl();
            this.UDeptMainPanel = new DevExpress.XtraEditors.PanelControl();
            this.UDeptGridView = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UDeptID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UDeptCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UDeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Memo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptTopPanel)).BeginInit();
            this.UDeptTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptMainPanel)).BeginInit();
            this.UDeptMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UDeptTopPanel
            // 
            this.UDeptTopPanel.Controls.Add(this.svgImageBox1);
            this.UDeptTopPanel.Controls.Add(this.BtnClose);
            this.UDeptTopPanel.Controls.Add(this.BtnDelete);
            this.UDeptTopPanel.Controls.Add(this.BtnModify);
            this.UDeptTopPanel.Controls.Add(this.BtnAdd);
            this.UDeptTopPanel.Controls.Add(this.BtnUDeptDataConv);
            this.UDeptTopPanel.Controls.Add(this.UDeptTitleLabel);
            this.UDeptTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UDeptTopPanel.Location = new System.Drawing.Point(0, 0);
            this.UDeptTopPanel.Name = "UDeptTopPanel";
            this.UDeptTopPanel.Size = new System.Drawing.Size(680, 42);
            this.UDeptTopPanel.TabIndex = 4;
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(5, 7);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(33, 30);
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 3;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.Location = new System.Drawing.Point(640, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(52, 27);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "닫기";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(556, 6);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(54, 30);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "삭제";
            // 
            // BtnModify
            // 
            this.BtnModify.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnModify.Appearance.Options.UseFont = true;
            this.BtnModify.Location = new System.Drawing.Point(496, 6);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(54, 30);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "수정";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(436, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(54, 30);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "추가";
            // 
            // BtnUDeptDataConv
            // 
            this.BtnUDeptDataConv.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnUDeptDataConv.Appearance.Options.UseFont = true;
            this.BtnUDeptDataConv.Location = new System.Drawing.Point(376, 6);
            this.BtnUDeptDataConv.Name = "BtnUDeptDataConv";
            this.BtnUDeptDataConv.Size = new System.Drawing.Size(54, 30);
            this.BtnUDeptDataConv.TabIndex = 2;
            this.BtnUDeptDataConv.Text = "(자료변환)";
            // 
            // UDeptTitleLabel
            // 
            this.UDeptTitleLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UDeptTitleLabel.Appearance.Options.UseFont = true;
            this.UDeptTitleLabel.Location = new System.Drawing.Point(44, 13);
            this.UDeptTitleLabel.Name = "UDeptTitleLabel";
            this.UDeptTitleLabel.Size = new System.Drawing.Size(65, 20);
            this.UDeptTitleLabel.TabIndex = 0;
            this.UDeptTitleLabel.Text = "상위 부서";
            // 
            // UDeptMainPanel
            // 
            this.UDeptMainPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.UDeptMainPanel.Appearance.Options.UseBackColor = true;
            this.UDeptMainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.UDeptMainPanel.Controls.Add(this.UDeptGridView);
            this.UDeptMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UDeptMainPanel.Location = new System.Drawing.Point(0, 42);
            this.UDeptMainPanel.Name = "UDeptMainPanel";
            this.UDeptMainPanel.Size = new System.Drawing.Size(680, 330);
            this.UDeptMainPanel.TabIndex = 5;
            // 
            // UDeptGridView
            // 
            this.UDeptGridView.Location = new System.Drawing.Point(22, 31);
            this.UDeptGridView.MainView = this.gridView;
            this.UDeptGridView.Name = "UDeptGridView";
            this.UDeptGridView.Size = new System.Drawing.Size(634, 272);
            this.UDeptGridView.TabIndex = 0;
            this.UDeptGridView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UDeptID,
            this.UDeptCode,
            this.UDeptName,
            this.Memo});
            this.gridView.GridControl = this.UDeptGridView;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // UDeptID
            // 
            this.UDeptID.Caption = "상위부서ID";
            this.UDeptID.FieldName = "UDeptID";
            this.UDeptID.Name = "UDeptID";
            this.UDeptID.Visible = true;
            this.UDeptID.VisibleIndex = 0;
            // 
            // UDeptCode
            // 
            this.UDeptCode.Caption = "상위부서코드";
            this.UDeptCode.FieldName = "UDeptCode";
            this.UDeptCode.Name = "UDeptCode";
            this.UDeptCode.Visible = true;
            this.UDeptCode.VisibleIndex = 1;
            this.UDeptCode.Width = 100;
            // 
            // UDeptName
            // 
            this.UDeptName.Caption = "상위부서명";
            this.UDeptName.FieldName = "UDeptName";
            this.UDeptName.Name = "UDeptName";
            this.UDeptName.Visible = true;
            this.UDeptName.VisibleIndex = 2;
            this.UDeptName.Width = 210;
            // 
            // Memo
            // 
            this.Memo.Caption = "메모";
            this.Memo.FieldName = "Memo";
            this.Memo.Name = "Memo";
            this.Memo.Visible = true;
            this.Memo.VisibleIndex = 3;
            this.Memo.Width = 224;
            // 
            // ManageUDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 372);
            this.Controls.Add(this.UDeptMainPanel);
            this.Controls.Add(this.UDeptTopPanel);
            this.Name = "ManageUDeptForm";
            this.Text = "ManageUDeptForm";
            ((System.ComponentModel.ISupportInitialize)(this.UDeptTopPanel)).EndInit();
            this.UDeptTopPanel.ResumeLayout(false);
            this.UDeptTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptMainPanel)).EndInit();
            this.UDeptMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UDeptGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl UDeptTopPanel;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnModify;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnUDeptDataConv;
        private DevExpress.XtraEditors.LabelControl UDeptTitleLabel;
        private DevExpress.XtraEditors.PanelControl UDeptMainPanel;
        private DevExpress.XtraGrid.GridControl UDeptGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn UDeptID;
        private DevExpress.XtraGrid.Columns.GridColumn UDeptCode;
        private DevExpress.XtraGrid.Columns.GridColumn UDeptName;
        private DevExpress.XtraGrid.Columns.GridColumn Memo;
    }
}