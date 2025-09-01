using EmployeeManagement.Models;
using EmployeeManagement.Models.Repository;
using System;
using System.Windows.Forms;

namespace EmployeeManagement.Forms.Department
{
    public class AddDepartmentForm : Form
    {
        private Panel AddDepartmentPanel;
        private Label AddDepartmentLabel;
        private Label DeptCodeLabel;
        private Label DeptNameLabel;
        private Label MemoLabel;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox MemoTextBox;
        private TextBox DeptCodeTextBox;
        private TextBox DeptNameTextBox;
        private DataGridView dataGridView1;

        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.AddDepartmentPanel = new System.Windows.Forms.Panel();
            this.AddDepartmentLabel = new System.Windows.Forms.Label();
            this.DeptCodeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeptNameLabel = new System.Windows.Forms.Label();
            this.MemoLabel = new System.Windows.Forms.Label();
            this.MemoTextBox = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DeptCodeTextBox = new System.Windows.Forms.TextBox();
            this.DeptNameTextBox = new System.Windows.Forms.TextBox();
            this.AddDepartmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDepartmentPanel
            // 
            this.AddDepartmentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.AddDepartmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddDepartmentPanel.Controls.Add(this.AddDepartmentLabel);
            this.AddDepartmentPanel.Location = new System.Drawing.Point(58, 30);
            this.AddDepartmentPanel.Name = "AddDepartmentPanel";
            this.AddDepartmentPanel.Size = new System.Drawing.Size(419, 40);
            this.AddDepartmentPanel.TabIndex = 14;
            // 
            // AddDepartmentLabel
            // 
            this.AddDepartmentLabel.AutoSize = true;
            this.AddDepartmentLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddDepartmentLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddDepartmentLabel.Location = new System.Drawing.Point(3, 9);
            this.AddDepartmentLabel.Margin = new System.Windows.Forms.Padding(3);
            this.AddDepartmentLabel.Name = "AddDepartmentLabel";
            this.AddDepartmentLabel.Size = new System.Drawing.Size(80, 21);
            this.AddDepartmentLabel.TabIndex = 10;
            this.AddDepartmentLabel.Text = "부서 추가";
            // 
            // DeptCodeLabel
            // 
            this.DeptCodeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeptCodeLabel.AutoSize = true;
            this.DeptCodeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeptCodeLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptCodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.DeptCodeLabel.Location = new System.Drawing.Point(74, 106);
            this.DeptCodeLabel.Name = "DeptCodeLabel";
            this.DeptCodeLabel.Size = new System.Drawing.Size(55, 15);
            this.DeptCodeLabel.TabIndex = 16;
            this.DeptCodeLabel.Text = "부서코드";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(419, 211);
            this.dataGridView1.TabIndex = 13;
            // 
            // DeptNameLabel
            // 
            this.DeptNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.DeptNameLabel.AutoSize = true;
            this.DeptNameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeptNameLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeptNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.DeptNameLabel.Location = new System.Drawing.Point(266, 106);
            this.DeptNameLabel.Name = "DeptNameLabel";
            this.DeptNameLabel.Size = new System.Drawing.Size(43, 15);
            this.DeptNameLabel.TabIndex = 17;
            this.DeptNameLabel.Text = "부서명";
            // 
            // MemoLabel
            // 
            this.MemoLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.MemoLabel.AutoSize = true;
            this.MemoLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MemoLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemoLabel.ForeColor = System.Drawing.Color.Black;
            this.MemoLabel.Location = new System.Drawing.Point(74, 163);
            this.MemoLabel.Name = "MemoLabel";
            this.MemoLabel.Size = new System.Drawing.Size(31, 15);
            this.MemoLabel.TabIndex = 18;
            this.MemoLabel.Text = "메모";
            // 
            // MemoTextBox
            // 
            this.MemoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoTextBox.Location = new System.Drawing.Point(76, 178);
            this.MemoTextBox.MaxLength = 1000;
            this.MemoTextBox.Name = "MemoTextBox";
            this.MemoTextBox.Size = new System.Drawing.Size(356, 21);
            this.MemoTextBox.TabIndex = 21;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(145, 223);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(137, 32);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(80)))), ((int)(((byte)(59)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(295, 223);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(137, 32);
            this.BtnCancel.TabIndex = 25;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DeptCodeTextBox
            // 
            this.DeptCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptCodeTextBox.Location = new System.Drawing.Point(76, 121);
            this.DeptCodeTextBox.MaxLength = 10;
            this.DeptCodeTextBox.Name = "DeptCodeTextBox";
            this.DeptCodeTextBox.Size = new System.Drawing.Size(164, 21);
            this.DeptCodeTextBox.TabIndex = 26;
            // 
            // DeptNameTextBox
            // 
            this.DeptNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptNameTextBox.Location = new System.Drawing.Point(268, 121);
            this.DeptNameTextBox.MaxLength = 20;
            this.DeptNameTextBox.Name = "DeptNameTextBox";
            this.DeptNameTextBox.Size = new System.Drawing.Size(164, 21);
            this.DeptNameTextBox.TabIndex = 27;
            // 
            // AddDepartmentForm
            // 
            this.ClientSize = new System.Drawing.Size(550, 321);
            this.Controls.Add(this.DeptNameTextBox);
            this.Controls.Add(this.DeptCodeTextBox);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.MemoTextBox);
            this.Controls.Add(this.MemoLabel);
            this.Controls.Add(this.DeptNameLabel);
            this.Controls.Add(this.DeptCodeLabel);
            this.Controls.Add(this.AddDepartmentPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddDepartmentForm";
            this.AddDepartmentPanel.ResumeLayout(false);
            this.AddDepartmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string DeptCode = DeptCodeTextBox.Text.Trim();
            string DeptName = DeptNameTextBox.Text.Trim();
            string Memo = MemoTextBox.Text;

            if (string.IsNullOrEmpty(DeptCode) || string.IsNullOrEmpty(DeptName))
            {
                MessageBox.Show("부서코드와 부서명을 입력하세요.");
                return;
            }

            try
            {
                // DepartmentModel 인스턴스 생성
                var department = new DepartmentModel
                {
                    DeptCode = DeptCode,
                    DeptName = DeptName,
                    Memo = Memo
                };

                // DepartmentRepository 인스턴스 생성
                var repository = new DepartmentRepository();

                repository.AddDepartment(department); // 부서 추가 메서드 호출    
                MessageBox.Show("부서가 성공적으로 추가되었습니다.");
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"부서 추가 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}