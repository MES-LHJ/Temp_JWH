namespace ApiEmpManagement.Forms.Emp
{
    partial class DelEmpForm
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.EmpDelMainPanel = new DevExpress.XtraEditors.PanelControl();
            this.EmpDelLabel = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.EmpNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.EmpCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.DeptDelMainLabel = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDelMainPanel)).BeginInit();
            this.EmpDelMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.layoutControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(514, 247);
            this.panelControl2.TabIndex = 4;
            // 
            // EmpDelMainPanel
            // 
            this.EmpDelMainPanel.Controls.Add(this.EmpDelLabel);
            this.EmpDelMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmpDelMainPanel.Location = new System.Drawing.Point(0, 0);
            this.EmpDelMainPanel.Name = "EmpDelMainPanel";
            this.EmpDelMainPanel.Size = new System.Drawing.Size(514, 39);
            this.EmpDelMainPanel.TabIndex = 3;
            // 
            // EmpDelLabel
            // 
            this.EmpDelLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 11.25F);
            this.EmpDelLabel.Appearance.Options.UseFont = true;
            this.EmpDelLabel.Location = new System.Drawing.Point(12, 9);
            this.EmpDelLabel.Name = "EmpDelLabel";
            this.EmpDelLabel.Size = new System.Drawing.Size(65, 20);
            this.EmpDelLabel.TabIndex = 0;
            this.EmpDelLabel.Text = "사원 삭제";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.EmpNameTextBox);
            this.layoutControl1.Controls.Add(this.BtnCancel);
            this.layoutControl1.Controls.Add(this.EmpCodeTextBox);
            this.layoutControl1.Controls.Add(this.BtnDelete);
            this.layoutControl1.Controls.Add(this.DeptDelMainLabel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(751, 124, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(514, 247);
            this.layoutControl1.TabIndex = 19;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.Location = new System.Drawing.Point(95, 46);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.EmpNameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmpNameTextBox.Properties.Appearance.Options.UseBackColor = true;
            this.EmpNameTextBox.Properties.Appearance.Options.UseFont = true;
            this.EmpNameTextBox.Properties.Appearance.Options.UseTextOptions = true;
            this.EmpNameTextBox.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.EmpNameTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.EmpNameTextBox.Properties.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.EmpNameTextBox.Properties.ReadOnly = true;
            this.EmpNameTextBox.Size = new System.Drawing.Size(407, 32);
            this.EmpNameTextBox.StyleController = this.layoutControl1;
            this.EmpNameTextBox.TabIndex = 14;
            this.EmpNameTextBox.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Appearance.Options.UseForeColor = true;
            this.BtnCancel.Location = new System.Drawing.Point(349, 204);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 28);
            this.BtnCancel.StyleController = this.layoutControl1;
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "취소";
            // 
            // EmpCodeTextBox
            // 
            this.EmpCodeTextBox.Location = new System.Drawing.Point(95, 12);
            this.EmpCodeTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.EmpCodeTextBox.Name = "EmpCodeTextBox";
            this.EmpCodeTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.EmpCodeTextBox.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpCodeTextBox.Properties.Appearance.Options.UseBackColor = true;
            this.EmpCodeTextBox.Properties.Appearance.Options.UseFont = true;
            this.EmpCodeTextBox.Properties.Appearance.Options.UseTextOptions = true;
            this.EmpCodeTextBox.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.EmpCodeTextBox.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.EmpCodeTextBox.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.EmpCodeTextBox.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.EmpCodeTextBox.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.EmpCodeTextBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.EmpCodeTextBox.Properties.ReadOnly = true;
            this.EmpCodeTextBox.Size = new System.Drawing.Size(407, 26);
            this.EmpCodeTextBox.StyleController = this.layoutControl1;
            this.EmpCodeTextBox.TabIndex = 15;
            this.EmpCodeTextBox.TabStop = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(59)))), ((int)(((byte)(22)))));
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDelete.Appearance.Options.UseBackColor = true;
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(176, 204);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(153, 28);
            this.BtnDelete.StyleController = this.layoutControl1;
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "삭제";
            // 
            // DeptDelMainLabel
            // 
            this.DeptDelMainLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptDelMainLabel.Appearance.Options.UseFont = true;
            this.DeptDelMainLabel.Location = new System.Drawing.Point(14, 122);
            this.DeptDelMainLabel.Name = "DeptDelMainLabel";
            this.DeptDelMainLabel.Size = new System.Drawing.Size(486, 35);
            this.DeptDelMainLabel.StyleController = this.layoutControl1;
            this.DeptDelMainLabel.TabIndex = 13;
            this.DeptDelMainLabel.Text = "삭제하시겠습니까?";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(514, 247);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 151);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(494, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.DeptDelMainLabel;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(114, 21);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(494, 43);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.BtnDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(161, 189);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(46, 32);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 10, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(168, 38);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.BtnCancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(329, 189);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(46, 32);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 5, 5, 5);
            this.layoutControlItem5.Size = new System.Drawing.Size(165, 38);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem6.Control = this.EmpCodeTextBox;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(54, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsPrint.AppearanceItem.Options.UseTextOptions = true;
            this.layoutControlItem6.OptionsPrint.AppearanceItem.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem6.OptionsPrint.AppearanceItemControl.Options.UseTextOptions = true;
            this.layoutControlItem6.OptionsPrint.AppearanceItemControl.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem6.Size = new System.Drawing.Size(494, 34);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "사원코드 :";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(71, 21);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem7.Control = this.EmpNameTextBox;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(54, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsPrint.AppearanceItemControl.Options.UseTextOptions = true;
            this.layoutControlItem7.OptionsPrint.AppearanceItemControl.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem7.Size = new System.Drawing.Size(494, 37);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "사원명 :";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(71, 21);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 71);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(494, 37);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 189);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(161, 38);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // DelEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 286);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.EmpDelMainPanel);
            this.Name = "DelEmpForm";
            this.Text = "DelEmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpDelMainPanel)).EndInit();
            this.EmpDelMainPanel.ResumeLayout(false);
            this.EmpDelMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl EmpDelMainPanel;
        private DevExpress.XtraEditors.LabelControl EmpDelLabel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit EmpNameTextBox;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.TextEdit EmpCodeTextBox;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.LabelControl DeptDelMainLabel;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}