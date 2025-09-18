namespace NewEmpManagement.Forms
{
    partial class AddEmpForm
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
            this.AddEmpPanel = new DevExpress.XtraEditors.PanelControl();
            this.AddEmpTopLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmpAddPanel = new DevExpress.XtraEditors.GroupControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnImgSelect = new DevExpress.XtraEditors.SimpleButton();
            this.UDeptNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.DeptNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.EmpCodeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.EmpNameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.LoginTextBox = new DevExpress.XtraEditors.TextEdit();
            this.PwdTextBox = new DevExpress.XtraEditors.TextEdit();
            this.PositionTextBox = new DevExpress.XtraEditors.TextEdit();
            this.EmpTypeTextBox = new DevExpress.XtraEditors.TextEdit();
            this.PhoneTextBox = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextBox = new DevExpress.XtraEditors.TextEdit();
            this.MsgIDTextBox = new DevExpress.XtraEditors.TextEdit();
            this.MemoTextBox = new DevExpress.XtraEditors.TextEdit();
            this.GenderRBtn = new DevExpress.XtraEditors.RadioGroup();
            this.UDeptCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.UDeptNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmpCodeLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmpNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.LoginIDLabel = new DevExpress.XtraEditors.LabelControl();
            this.PwdLabel = new DevExpress.XtraEditors.LabelControl();
            this.PositionLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmpTypeLabel = new DevExpress.XtraEditors.LabelControl();
            this.PhoneLabel = new DevExpress.XtraEditors.LabelControl();
            this.GenderLabel = new DevExpress.XtraEditors.LabelControl();
            this.EmailLabel = new DevExpress.XtraEditors.LabelControl();
            this.MsgIDLabel = new DevExpress.XtraEditors.LabelControl();
            this.MemoLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptCodeLookupBox = new DevExpress.XtraEditors.LookUpEdit();
            this.UDeptLookupBox = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentDetailDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PictureEditEmp = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmpPanel)).BeginInit();
            this.AddEmpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpAddPanel)).BeginInit();
            this.EmpAddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpCodeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PwdTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTypeTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MsgIDTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderRBtn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeLookupBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptLookupBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDetailDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditEmp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmpPanel
            // 
            this.AddEmpPanel.Controls.Add(this.AddEmpTopLabel);
            this.AddEmpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddEmpPanel.Location = new System.Drawing.Point(0, 0);
            this.AddEmpPanel.Name = "AddEmpPanel";
            this.AddEmpPanel.Size = new System.Drawing.Size(733, 43);
            this.AddEmpPanel.TabIndex = 0;
            // 
            // AddEmpTopLabel
            // 
            this.AddEmpTopLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpTopLabel.Appearance.Options.UseFont = true;
            this.AddEmpTopLabel.Location = new System.Drawing.Point(12, 13);
            this.AddEmpTopLabel.Name = "AddEmpTopLabel";
            this.AddEmpTopLabel.Size = new System.Drawing.Size(73, 23);
            this.AddEmpTopLabel.TabIndex = 0;
            this.AddEmpTopLabel.Text = "사원 추가";
            // 
            // EmpAddPanel
            // 
            this.EmpAddPanel.Appearance.BackColor = System.Drawing.Color.White;
            this.EmpAddPanel.Appearance.Options.UseBackColor = true;
            this.EmpAddPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.EmpAddPanel.Controls.Add(this.PictureEditEmp);
            this.EmpAddPanel.Controls.Add(this.BtnSave);
            this.EmpAddPanel.Controls.Add(this.BtnCancel);
            this.EmpAddPanel.Controls.Add(this.BtnImgSelect);
            this.EmpAddPanel.Controls.Add(this.UDeptNameTextBox);
            this.EmpAddPanel.Controls.Add(this.DeptNameTextBox);
            this.EmpAddPanel.Controls.Add(this.EmpCodeTextBox);
            this.EmpAddPanel.Controls.Add(this.EmpNameTextBox);
            this.EmpAddPanel.Controls.Add(this.LoginTextBox);
            this.EmpAddPanel.Controls.Add(this.PwdTextBox);
            this.EmpAddPanel.Controls.Add(this.PositionTextBox);
            this.EmpAddPanel.Controls.Add(this.EmpTypeTextBox);
            this.EmpAddPanel.Controls.Add(this.PhoneTextBox);
            this.EmpAddPanel.Controls.Add(this.EmailTextBox);
            this.EmpAddPanel.Controls.Add(this.MsgIDTextBox);
            this.EmpAddPanel.Controls.Add(this.MemoTextBox);
            this.EmpAddPanel.Controls.Add(this.GenderRBtn);
            this.EmpAddPanel.Controls.Add(this.UDeptCodeLabel);
            this.EmpAddPanel.Controls.Add(this.UDeptNameLabel);
            this.EmpAddPanel.Controls.Add(this.DeptCodeLabel);
            this.EmpAddPanel.Controls.Add(this.DeptNameLabel);
            this.EmpAddPanel.Controls.Add(this.EmpCodeLabel);
            this.EmpAddPanel.Controls.Add(this.EmpNameLabel);
            this.EmpAddPanel.Controls.Add(this.LoginIDLabel);
            this.EmpAddPanel.Controls.Add(this.PwdLabel);
            this.EmpAddPanel.Controls.Add(this.PositionLabel);
            this.EmpAddPanel.Controls.Add(this.EmpTypeLabel);
            this.EmpAddPanel.Controls.Add(this.PhoneLabel);
            this.EmpAddPanel.Controls.Add(this.GenderLabel);
            this.EmpAddPanel.Controls.Add(this.EmailLabel);
            this.EmpAddPanel.Controls.Add(this.MsgIDLabel);
            this.EmpAddPanel.Controls.Add(this.MemoLabel);
            this.EmpAddPanel.Controls.Add(this.DeptCodeLookupBox);
            this.EmpAddPanel.Controls.Add(this.UDeptLookupBox);
            this.EmpAddPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmpAddPanel.Location = new System.Drawing.Point(0, 43);
            this.EmpAddPanel.Name = "EmpAddPanel";
            this.EmpAddPanel.Size = new System.Drawing.Size(733, 614);
            this.EmpAddPanel.TabIndex = 1;
            this.EmpAddPanel.Text = "groupControl1";
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Appearance.Options.UseBackColor = true;
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.Appearance.Options.UseForeColor = true;
            this.BtnSave.Location = new System.Drawing.Point(467, 551);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(107, 29);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "저장";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(596, 551);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(107, 29);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "취소";
            // 
            // BtnImgSelect
            // 
            this.BtnImgSelect.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImgSelect.Appearance.Options.UseFont = true;
            this.BtnImgSelect.Location = new System.Drawing.Point(483, 292);
            this.BtnImgSelect.Name = "BtnImgSelect";
            this.BtnImgSelect.Size = new System.Drawing.Size(220, 18);
            this.BtnImgSelect.TabIndex = 7;
            this.BtnImgSelect.Text = "이미지 수정";
            // 
            // UDeptNameTextBox
            // 
            this.UDeptNameTextBox.Location = new System.Drawing.Point(268, 90);
            this.UDeptNameTextBox.Name = "UDeptNameTextBox";
            this.UDeptNameTextBox.Properties.ReadOnly = true;
            this.UDeptNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.UDeptNameTextBox.TabIndex = 1;
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.Location = new System.Drawing.Point(268, 156);
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.Properties.ReadOnly = true;
            this.DeptNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.DeptNameTextBox.TabIndex = 1;
            // 
            // EmpCodeTextBox
            // 
            this.EmpCodeTextBox.Location = new System.Drawing.Point(52, 225);
            this.EmpCodeTextBox.Name = "EmpCodeTextBox";
            this.EmpCodeTextBox.Size = new System.Drawing.Size(178, 22);
            this.EmpCodeTextBox.TabIndex = 1;
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.Location = new System.Drawing.Point(268, 225);
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.EmpNameTextBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(52, 291);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(178, 22);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PwdTextBox
            // 
            this.PwdTextBox.Location = new System.Drawing.Point(268, 291);
            this.PwdTextBox.Name = "PwdTextBox";
            this.PwdTextBox.Size = new System.Drawing.Size(178, 22);
            this.PwdTextBox.TabIndex = 1;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Location = new System.Drawing.Point(52, 360);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(178, 22);
            this.PositionTextBox.TabIndex = 1;
            // 
            // EmpTypeTextBox
            // 
            this.EmpTypeTextBox.Location = new System.Drawing.Point(268, 360);
            this.EmpTypeTextBox.Name = "EmpTypeTextBox";
            this.EmpTypeTextBox.Size = new System.Drawing.Size(178, 22);
            this.EmpTypeTextBox.TabIndex = 1;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(52, 426);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(178, 22);
            this.PhoneTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(268, 426);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(178, 22);
            this.EmailTextBox.TabIndex = 1;
            // 
            // MsgIDTextBox
            // 
            this.MsgIDTextBox.Location = new System.Drawing.Point(488, 426);
            this.MsgIDTextBox.Name = "MsgIDTextBox";
            this.MsgIDTextBox.Size = new System.Drawing.Size(178, 22);
            this.MsgIDTextBox.TabIndex = 1;
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.Location = new System.Drawing.Point(52, 498);
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(651, 22);
            this.MemoTextBox.TabIndex = 1;
            // 
            // GenderRBtn
            // 
            this.GenderRBtn.Location = new System.Drawing.Point(497, 355);
            this.GenderRBtn.Name = "GenderRBtn";
            this.GenderRBtn.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GenderRBtn.Properties.Appearance.Options.UseFont = true;
            this.GenderRBtn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GenderRBtn.Properties.Columns = 2;
            this.GenderRBtn.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("남", "남", true, null, "RBtnGendermale"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("여", "여", true, null, "RBtnGenderFemale")});
            this.GenderRBtn.Size = new System.Drawing.Size(119, 32);
            this.GenderRBtn.TabIndex = 6;
            this.GenderRBtn.Tag = "";
            // 
            // UDeptCodeLabel
            // 
            this.UDeptCodeLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UDeptCodeLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.UDeptCodeLabel.Appearance.Options.UseFont = true;
            this.UDeptCodeLabel.Appearance.Options.UseForeColor = true;
            this.UDeptCodeLabel.Location = new System.Drawing.Point(52, 65);
            this.UDeptCodeLabel.Name = "UDeptCodeLabel";
            this.UDeptCodeLabel.Size = new System.Drawing.Size(96, 21);
            this.UDeptCodeLabel.TabIndex = 0;
            this.UDeptCodeLabel.Text = "상위부서코드";
            // 
            // UDeptNameLabel
            // 
            this.UDeptNameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UDeptNameLabel.Appearance.Options.UseFont = true;
            this.UDeptNameLabel.Location = new System.Drawing.Point(268, 65);
            this.UDeptNameLabel.Name = "UDeptNameLabel";
            this.UDeptNameLabel.Size = new System.Drawing.Size(80, 21);
            this.UDeptNameLabel.TabIndex = 0;
            this.UDeptNameLabel.Text = "상위부서명";
            // 
            // DeptCodeLabel
            // 
            this.DeptCodeLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeptCodeLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.DeptCodeLabel.Appearance.Options.UseFont = true;
            this.DeptCodeLabel.Appearance.Options.UseForeColor = true;
            this.DeptCodeLabel.Location = new System.Drawing.Point(52, 132);
            this.DeptCodeLabel.Name = "DeptCodeLabel";
            this.DeptCodeLabel.Size = new System.Drawing.Size(64, 21);
            this.DeptCodeLabel.TabIndex = 0;
            this.DeptCodeLabel.Text = "부서코드";
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeptNameLabel.Appearance.Options.UseFont = true;
            this.DeptNameLabel.Location = new System.Drawing.Point(268, 132);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(48, 21);
            this.DeptNameLabel.TabIndex = 0;
            this.DeptNameLabel.Text = "부서명";
            // 
            // EmpCodeLabel
            // 
            this.EmpCodeLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmpCodeLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.EmpCodeLabel.Appearance.Options.UseFont = true;
            this.EmpCodeLabel.Appearance.Options.UseForeColor = true;
            this.EmpCodeLabel.Location = new System.Drawing.Point(52, 200);
            this.EmpCodeLabel.Name = "EmpCodeLabel";
            this.EmpCodeLabel.Size = new System.Drawing.Size(64, 21);
            this.EmpCodeLabel.TabIndex = 0;
            this.EmpCodeLabel.Text = "사원코드";
            // 
            // EmpNameLabel
            // 
            this.EmpNameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.EmpNameLabel.Appearance.Options.UseFont = true;
            this.EmpNameLabel.Appearance.Options.UseForeColor = true;
            this.EmpNameLabel.Location = new System.Drawing.Point(268, 200);
            this.EmpNameLabel.Name = "EmpNameLabel";
            this.EmpNameLabel.Size = new System.Drawing.Size(48, 21);
            this.EmpNameLabel.TabIndex = 0;
            this.EmpNameLabel.Text = "사원명";
            // 
            // LoginIDLabel
            // 
            this.LoginIDLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginIDLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.LoginIDLabel.Appearance.Options.UseFont = true;
            this.LoginIDLabel.Appearance.Options.UseForeColor = true;
            this.LoginIDLabel.Location = new System.Drawing.Point(52, 267);
            this.LoginIDLabel.Name = "LoginIDLabel";
            this.LoginIDLabel.Size = new System.Drawing.Size(63, 21);
            this.LoginIDLabel.TabIndex = 0;
            this.LoginIDLabel.Text = "로그인ID";
            // 
            // PwdLabel
            // 
            this.PwdLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PwdLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.PwdLabel.Appearance.Options.UseFont = true;
            this.PwdLabel.Appearance.Options.UseForeColor = true;
            this.PwdLabel.Location = new System.Drawing.Point(268, 267);
            this.PwdLabel.Name = "PwdLabel";
            this.PwdLabel.Size = new System.Drawing.Size(64, 21);
            this.PwdLabel.TabIndex = 0;
            this.PwdLabel.Text = "비밀번호";
            // 
            // PositionLabel
            // 
            this.PositionLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PositionLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.PositionLabel.Appearance.Options.UseFont = true;
            this.PositionLabel.Appearance.Options.UseForeColor = true;
            this.PositionLabel.Location = new System.Drawing.Point(52, 335);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(32, 21);
            this.PositionLabel.TabIndex = 0;
            this.PositionLabel.Text = "직위";
            // 
            // EmpTypeLabel
            // 
            this.EmpTypeLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmpTypeLabel.Appearance.Options.UseFont = true;
            this.EmpTypeLabel.Location = new System.Drawing.Point(268, 335);
            this.EmpTypeLabel.Name = "EmpTypeLabel";
            this.EmpTypeLabel.Size = new System.Drawing.Size(64, 21);
            this.EmpTypeLabel.TabIndex = 0;
            this.EmpTypeLabel.Text = "고용형태";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PhoneLabel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.PhoneLabel.Appearance.Options.UseFont = true;
            this.PhoneLabel.Appearance.Options.UseForeColor = true;
            this.PhoneLabel.Location = new System.Drawing.Point(52, 402);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(64, 21);
            this.PhoneLabel.TabIndex = 0;
            this.PhoneLabel.Text = "휴대전화";
            // 
            // GenderLabel
            // 
            this.GenderLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GenderLabel.Appearance.Options.UseFont = true;
            this.GenderLabel.Location = new System.Drawing.Point(497, 335);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(32, 21);
            this.GenderLabel.TabIndex = 0;
            this.GenderLabel.Text = "성별";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmailLabel.Appearance.Options.UseFont = true;
            this.EmailLabel.Location = new System.Drawing.Point(268, 402);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 21);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "이메일";
            // 
            // MsgIDLabel
            // 
            this.MsgIDLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MsgIDLabel.Appearance.Options.UseFont = true;
            this.MsgIDLabel.Location = new System.Drawing.Point(488, 402);
            this.MsgIDLabel.Name = "MsgIDLabel";
            this.MsgIDLabel.Size = new System.Drawing.Size(63, 21);
            this.MsgIDLabel.TabIndex = 0;
            this.MsgIDLabel.Text = "메신저ID";
            // 
            // MemoLabel
            // 
            this.MemoLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MemoLabel.Appearance.Options.UseFont = true;
            this.MemoLabel.Location = new System.Drawing.Point(52, 474);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(32, 21);
            this.MemoLabel.TabIndex = 0;
            this.MemoLabel.Text = "메모";
            // 
            // DeptCodeLookupBox
            // 
            this.DeptCodeLookupBox.Location = new System.Drawing.Point(52, 156);
            this.DeptCodeLookupBox.Name = "DeptCodeLookupBox";
            this.DeptCodeLookupBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DeptCodeLookupBox.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DeptCode", "Dept Code", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DeptName", "Dept Name", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.DeptCodeLookupBox.Properties.DataSource = this.departmentDetailDtoBindingSource;
            this.DeptCodeLookupBox.Properties.DisplayMember = "DeptName";
            this.DeptCodeLookupBox.Properties.NullText = "";
            this.DeptCodeLookupBox.Properties.PopupSizeable = false;
            this.DeptCodeLookupBox.Properties.ValueMember = "DeptID";
            this.DeptCodeLookupBox.Size = new System.Drawing.Size(178, 22);
            this.DeptCodeLookupBox.TabIndex = 1;
            // 
            // UDeptLookupBox
            // 
            this.UDeptLookupBox.Location = new System.Drawing.Point(52, 90);
            this.UDeptLookupBox.Name = "UDeptLookupBox";
            this.UDeptLookupBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UDeptLookupBox.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UDeptCode", "UDept Code", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UDeptName", "UDept Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.UDeptLookupBox.Properties.DataSource = this.departmentDetailDtoBindingSource;
            this.UDeptLookupBox.Properties.DisplayMember = "UDeptCode";
            this.UDeptLookupBox.Properties.NullText = "";
            this.UDeptLookupBox.Properties.PopupSizeable = false;
            this.UDeptLookupBox.Properties.ValueMember = "UDeptID";
            this.UDeptLookupBox.Size = new System.Drawing.Size(178, 22);
            this.UDeptLookupBox.TabIndex = 1;
            // 
            // departmentDetailDtoBindingSource
            // 
            this.departmentDetailDtoBindingSource.DataSource = typeof(NewEmpManagement.Models.Dto.DepartmentDetailDto);
            // 
            // PictureEditEmp
            // 
            this.PictureEditEmp.Location = new System.Drawing.Point(483, 75);
            this.PictureEditEmp.Name = "PictureEditEmp";
            this.PictureEditEmp.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureEditEmp.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PictureEditEmp.Size = new System.Drawing.Size(220, 196);
            this.PictureEditEmp.TabIndex = 9;
            // 
            // AddEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 657);
            this.Controls.Add(this.EmpAddPanel);
            this.Controls.Add(this.AddEmpPanel);
            this.Name = "AddEmpForm";
            this.Text = "AddEmpForm";
            ((System.ComponentModel.ISupportInitialize)(this.AddEmpPanel)).EndInit();
            this.AddEmpPanel.ResumeLayout(false);
            this.AddEmpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpAddPanel)).EndInit();
            this.EmpAddPanel.ResumeLayout(false);
            this.EmpAddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpCodeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpNameTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PwdTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTypeTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MsgIDTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderRBtn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptCodeLookupBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDeptLookupBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDetailDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditEmp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl AddEmpPanel;
        private DevExpress.XtraEditors.GroupControl EmpAddPanel;
        private DevExpress.XtraEditors.LabelControl AddEmpTopLabel;
        private DevExpress.XtraEditors.LabelControl UDeptCodeLabel;
        private DevExpress.XtraEditors.TextEdit UDeptNameTextBox;
        private DevExpress.XtraEditors.LabelControl UDeptNameLabel;
        private DevExpress.XtraEditors.TextEdit MemoTextBox;
        private DevExpress.XtraEditors.TextEdit MsgIDTextBox;
        private DevExpress.XtraEditors.TextEdit EmailTextBox;
        private DevExpress.XtraEditors.TextEdit PhoneTextBox;
        private DevExpress.XtraEditors.TextEdit PwdTextBox;
        private DevExpress.XtraEditors.TextEdit LoginTextBox;
        private DevExpress.XtraEditors.TextEdit EmpTypeTextBox;
        private DevExpress.XtraEditors.LabelControl MemoLabel;
        private DevExpress.XtraEditors.TextEdit DeptNameTextBox;
        private DevExpress.XtraEditors.LabelControl MsgIDLabel;
        private DevExpress.XtraEditors.TextEdit EmpNameTextBox;
        private DevExpress.XtraEditors.LabelControl EmailLabel;
        private DevExpress.XtraEditors.TextEdit PositionTextBox;
        private DevExpress.XtraEditors.TextEdit EmpCodeTextBox;
        private DevExpress.XtraEditors.LabelControl PhoneLabel;
        private DevExpress.XtraEditors.LabelControl DeptNameLabel;
        private DevExpress.XtraEditors.LabelControl PwdLabel;
        private DevExpress.XtraEditors.LabelControl LoginIDLabel;
        private DevExpress.XtraEditors.LabelControl EmpTypeLabel;
        private DevExpress.XtraEditors.LabelControl PositionLabel;
        private DevExpress.XtraEditors.LabelControl EmpNameLabel;
        private DevExpress.XtraEditors.LabelControl DeptCodeLabel;
        private DevExpress.XtraEditors.LabelControl EmpCodeLabel;
        private DevExpress.XtraEditors.RadioGroup GenderRBtn;
        private DevExpress.XtraEditors.LabelControl GenderLabel;
        private DevExpress.XtraEditors.SimpleButton BtnImgSelect;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.LookUpEdit DeptCodeLookupBox;
        private DevExpress.XtraEditors.LookUpEdit UDeptLookupBox;
        private System.Windows.Forms.BindingSource departmentDetailDtoBindingSource;
        private DevExpress.XtraEditors.PictureEdit PictureEditEmp;
    }
}