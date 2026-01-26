namespace DevExpressDemo
{
    partial class Form2
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
            chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)chartControl1).BeginInit();
            SuspendLayout();
            // 
            // chartControl1
            // 
            chartControl1.Dock = DockStyle.Fill;
            chartControl1.Legend.LegendID = -1;
            chartControl1.Location = new Point(0, 0);
            chartControl1.Name = "chartControl1";
            chartControl1.Size = new Size(1611, 869);
            chartControl1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1611, 869);
            Controls.Add(chartControl1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)chartControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}