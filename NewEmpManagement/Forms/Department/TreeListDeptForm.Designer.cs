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
            this.TreeListView = new DevExpress.XtraTreeList.TreeList();
            this.TreeListPanel = new DevExpress.XtraEditors.PanelControl();
            this.TreeListLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListPanel)).BeginInit();
            this.TreeListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeListView
            // 
            this.TreeListView.Location = new System.Drawing.Point(12, 32);
            this.TreeListView.Name = "TreeListView";
            this.TreeListView.Size = new System.Drawing.Size(636, 606);
            this.TreeListView.TabIndex = 1;
            // 
            // TreeListPanel
            // 
            this.TreeListPanel.Controls.Add(this.TreeListLabel);
            this.TreeListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TreeListPanel.Location = new System.Drawing.Point(0, 0);
            this.TreeListPanel.Name = "TreeListPanel";
            this.TreeListPanel.Size = new System.Drawing.Size(660, 32);
            this.TreeListPanel.TabIndex = 2;
            // 
            // TreeListLabel
            // 
            this.TreeListLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeListLabel.Appearance.Options.UseFont = true;
            this.TreeListLabel.Location = new System.Drawing.Point(12, 9);
            this.TreeListLabel.Name = "TreeListLabel";
            this.TreeListLabel.Size = new System.Drawing.Size(26, 17);
            this.TreeListLabel.TabIndex = 0;
            this.TreeListLabel.Text = "트리";
            // 
            // TreeListDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 650);
            this.Controls.Add(this.TreeListPanel);
            this.Controls.Add(this.TreeListView);
            this.Name = "TreeListDeptForm";
            this.Text = "TreeListForm";
            ((System.ComponentModel.ISupportInitialize)(this.TreeListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeListPanel)).EndInit();
            this.TreeListPanel.ResumeLayout(false);
            this.TreeListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList TreeListView;
        private DevExpress.XtraEditors.PanelControl TreeListPanel;
        private DevExpress.XtraEditors.LabelControl TreeListLabel;
    }
}