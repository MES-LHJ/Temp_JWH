namespace NewEmpManagement.Forms.Department
{
    partial class ChartDeptForm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.ChartTopPanel = new DevExpress.XtraEditors.PanelControl();
            this.ChartLabel = new DevExpress.XtraEditors.LabelControl();
            this.DeptChartControl = new DevExpress.XtraCharts.ChartControl();
            this.departmentDetailDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopPanel)).BeginInit();
            this.ChartTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeptChartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDetailDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartTopPanel
            // 
            this.ChartTopPanel.Controls.Add(this.ChartLabel);
            this.ChartTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChartTopPanel.Location = new System.Drawing.Point(0, 0);
            this.ChartTopPanel.Name = "ChartTopPanel";
            this.ChartTopPanel.Size = new System.Drawing.Size(777, 34);
            this.ChartTopPanel.TabIndex = 1;
            // 
            // ChartLabel
            // 
            this.ChartLabel.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartLabel.Appearance.Options.UseFont = true;
            this.ChartLabel.Location = new System.Drawing.Point(12, 10);
            this.ChartLabel.Name = "ChartLabel";
            this.ChartLabel.Size = new System.Drawing.Size(26, 17);
            this.ChartLabel.TabIndex = 0;
            this.ChartLabel.Text = "차트";
            // 
            // DeptChartControl
            // 
            this.DeptChartControl.DataSource = this.departmentDetailDtoBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.DeptChartControl.Diagram = xyDiagram1;
            this.DeptChartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeptChartControl.Location = new System.Drawing.Point(0, 34);
            this.DeptChartControl.Name = "DeptChartControl";
            series1.Name = "Series 1";
            series1.View = stackedBarSeriesView1;
            this.DeptChartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.DeptChartControl.Size = new System.Drawing.Size(777, 457);
            this.DeptChartControl.TabIndex = 2;
            // 
            // departmentDetailDtoBindingSource
            // 
            this.departmentDetailDtoBindingSource.DataSource = typeof(NewEmpManagement.Models.Dto.DepartmentDetailDto);
            // 
            // ChartDeptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 491);
            this.Controls.Add(this.DeptChartControl);
            this.Controls.Add(this.ChartTopPanel);
            this.Name = "ChartDeptForm";
            this.Text = "ChartDeptForm";
            ((System.ComponentModel.ISupportInitialize)(this.ChartTopPanel)).EndInit();
            this.ChartTopPanel.ResumeLayout(false);
            this.ChartTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptChartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDetailDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl ChartTopPanel;
        private DevExpress.XtraEditors.LabelControl ChartLabel;
        private DevExpress.XtraCharts.ChartControl DeptChartControl;
        private System.Windows.Forms.BindingSource departmentDetailDtoBindingSource;
    }
}