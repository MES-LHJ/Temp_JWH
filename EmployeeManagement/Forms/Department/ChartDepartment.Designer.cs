namespace EmployeeManagement.Forms.Department
{
    partial class ChartDepartment
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.DeptHeadCountChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DeptHeadCountChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptHeadCountChart
            // 
            chartArea1.AxisX.Title = "부서코드";
            chartArea1.AxisY.Title = "인원 수";
            chartArea1.Name = "ChartArea1";
            this.DeptHeadCountChart.ChartAreas.Add(chartArea1);
            this.DeptHeadCountChart.Location = new System.Drawing.Point(12, 12);
            this.DeptHeadCountChart.Name = "DeptHeadCountChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.DeptHeadCountChart.Series.Add(series1);
            this.DeptHeadCountChart.Size = new System.Drawing.Size(767, 426);
            this.DeptHeadCountChart.TabIndex = 0;
            this.DeptHeadCountChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            title1.Name = "ChartTitle";
            title1.Text = "부서별 인원수";
            this.DeptHeadCountChart.Titles.Add(title1);
            // 
            // ChartDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeptHeadCountChart);
            this.Name = "ChartDepartment";
            this.Text = "ChartDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.DeptHeadCountChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DeptHeadCountChart;
    }
}