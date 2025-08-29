namespace EmployeeManagement.Forms.Employee
{
    partial class ManageDeptEmpForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainBackGround = new System.Windows.Forms.DataGridView();
            this.BtnDepartment = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnEmpAdd = new System.Windows.Forms.Button();
            this.BtnEmpModify = new System.Windows.Forms.Button();
            this.BtnLoginInfo = new System.Windows.Forms.Button();
            this.BtnEmpDel = new System.Windows.Forms.Button();
            this.BtnDataConv = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.MainTileLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EmpDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainBackGround)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // MainBackGround
            // 
            this.MainBackGround.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainBackGround.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainBackGround.Location = new System.Drawing.Point(57, 106);
            this.MainBackGround.Name = "MainBackGround";
            this.MainBackGround.RowTemplate.Height = 23;
            this.MainBackGround.Size = new System.Drawing.Size(1122, 268);
            this.MainBackGround.TabIndex = 1;
            // 
            // BtnDepartment
            // 
            this.BtnDepartment.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDepartment.Location = new System.Drawing.Point(588, 11);
            this.BtnDepartment.Name = "BtnDepartment";
            this.BtnDepartment.Size = new System.Drawing.Size(58, 28);
            this.BtnDepartment.TabIndex = 2;
            this.BtnDepartment.Text = "부서";
            this.BtnDepartment.UseVisualStyleBackColor = true;
            this.BtnDepartment.Click += new System.EventHandler(this.BtnDepartment_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnRefresh.Location = new System.Drawing.Point(652, 11);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(58, 28);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "조회";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnEmpAdd
            // 
            this.BtnEmpAdd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnEmpAdd.Location = new System.Drawing.Point(716, 11);
            this.BtnEmpAdd.Name = "BtnEmpAdd";
            this.BtnEmpAdd.Size = new System.Drawing.Size(58, 28);
            this.BtnEmpAdd.TabIndex = 4;
            this.BtnEmpAdd.Text = "추가";
            this.BtnEmpAdd.UseVisualStyleBackColor = true;
            this.BtnEmpAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEmpModify
            // 
            this.BtnEmpModify.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnEmpModify.Location = new System.Drawing.Point(780, 11);
            this.BtnEmpModify.Name = "BtnEmpModify";
            this.BtnEmpModify.Size = new System.Drawing.Size(58, 28);
            this.BtnEmpModify.TabIndex = 5;
            this.BtnEmpModify.Text = "수정";
            this.BtnEmpModify.UseVisualStyleBackColor = true;
            this.BtnEmpModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnLoginInfo
            // 
            this.BtnLoginInfo.Font = new System.Drawing.Font("맑은 고딕", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnLoginInfo.Location = new System.Drawing.Point(844, 11);
            this.BtnLoginInfo.Name = "BtnLoginInfo";
            this.BtnLoginInfo.Size = new System.Drawing.Size(69, 28);
            this.BtnLoginInfo.TabIndex = 6;
            this.BtnLoginInfo.Text = "로그인정보";
            this.BtnLoginInfo.UseVisualStyleBackColor = true;
            this.BtnLoginInfo.Click += new System.EventHandler(this.Btn_LoginInfo_Click);
            // 
            // BtnEmpDel
            // 
            this.BtnEmpDel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnEmpDel.Location = new System.Drawing.Point(919, 11);
            this.BtnEmpDel.Name = "BtnEmpDel";
            this.BtnEmpDel.Size = new System.Drawing.Size(58, 28);
            this.BtnEmpDel.TabIndex = 7;
            this.BtnEmpDel.Text = "삭제";
            this.BtnEmpDel.UseVisualStyleBackColor = true;
            this.BtnEmpDel.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDataConv
            // 
            this.BtnDataConv.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDataConv.Location = new System.Drawing.Point(983, 11);
            this.BtnDataConv.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDataConv.Name = "BtnDataConv";
            this.BtnDataConv.Size = new System.Drawing.Size(62, 28);
            this.BtnDataConv.TabIndex = 8;
            this.BtnDataConv.Text = "자료변환";
            this.BtnDataConv.UseVisualStyleBackColor = true;
            this.BtnDataConv.Click += new System.EventHandler(this.BtnDataConv_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnClose.Location = new System.Drawing.Point(1070, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 28);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "닫기";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MainTileLabel
            // 
            this.MainTileLabel.AutoSize = true;
            this.MainTileLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainTileLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainTileLabel.Location = new System.Drawing.Point(45, 15);
            this.MainTileLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MainTileLabel.Name = "MainTileLabel";
            this.MainTileLabel.Size = new System.Drawing.Size(71, 16);
            this.MainTileLabel.TabIndex = 10;
            this.MainTileLabel.Text = "부서사원";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MyImage);
            this.panel1.Controls.Add(this.MainTileLabel);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.BtnDataConv);
            this.panel1.Controls.Add(this.BtnDepartment);
            this.panel1.Controls.Add(this.BtnEmpDel);
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.BtnLoginInfo);
            this.panel1.Controls.Add(this.BtnEmpAdd);
            this.panel1.Controls.Add(this.BtnEmpModify);
            this.panel1.Location = new System.Drawing.Point(57, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 46);
            this.panel1.TabIndex = 11;
            // 
            // MyImage
            // 
            this.MyImage.Image = global::EmployeeManagement.Properties.Resources.free_icon_user_6607993__1_1;
            this.MyImage.Location = new System.Drawing.Point(8, 7);
            this.MyImage.Name = "MyImage";
            this.MyImage.Size = new System.Drawing.Size(31, 36);
            this.MyImage.TabIndex = 12;
            this.MyImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmpDgv
            // 
            this.EmpDgv.BackgroundColor = System.Drawing.Color.White;
            this.EmpDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDgv.Location = new System.Drawing.Point(58, 134);
            this.EmpDgv.Name = "EmpDgv";
            this.EmpDgv.ReadOnly = true;
            this.EmpDgv.RowTemplate.Height = 23;
            this.EmpDgv.Size = new System.Drawing.Size(1110, 218);
            this.EmpDgv.TabIndex = 12;
            this.EmpDgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.EmpDgv_CellFormatting);
            // 
            // ManageDeptEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 427);
            this.Controls.Add(this.EmpDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainBackGround);
            this.Name = "ManageDeptEmpForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DepartmentEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainBackGround)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDgv)).EndInit();
            this.ResumeLayout(false);

        }
       
        #endregion

        private System.Windows.Forms.DataGridView MainBackGround;
        private System.Windows.Forms.Button BtnDepartment;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnEmpAdd;
        private System.Windows.Forms.Button BtnEmpModify;
        private System.Windows.Forms.Button BtnLoginInfo;
        private System.Windows.Forms.Button BtnEmpDel;
        private System.Windows.Forms.Button BtnDataConv;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label MainTileLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MyImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView EmpDgv;
    }
}

