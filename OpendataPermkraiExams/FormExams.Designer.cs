namespace OpendataPermkraiExams
{
    partial class FormExams
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chrtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trbYear = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chrtMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYear)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtMain
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.Title = "Доля лиц (%)";
            chartArea2.Name = "ChartArea1";
            this.chrtMain.ChartAreas.Add(chartArea2);
            this.chrtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chrtMain.Legends.Add(legend2);
            this.chrtMain.Location = new System.Drawing.Point(0, 0);
            this.chrtMain.Name = "chrtMain";
            this.chrtMain.Size = new System.Drawing.Size(284, 217);
            this.chrtMain.TabIndex = 0;
            this.chrtMain.Text = "chrtMain";
            // 
            // trbYear
            // 
            this.trbYear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trbYear.Location = new System.Drawing.Point(0, 217);
            this.trbYear.Name = "trbYear";
            this.trbYear.Size = new System.Drawing.Size(284, 45);
            this.trbYear.TabIndex = 1;
            // 
            // FormExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chrtMain);
            this.Controls.Add(this.trbYear);
            this.Name = "FormExams";
            this.Text = "Пример о результатах ЕГЭ @ opendata.permkrai.ru";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chrtMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtMain;
        private System.Windows.Forms.TrackBar trbYear;
    }
}