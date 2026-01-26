using DevExpress.Drawing.Printing.Internal;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressDemo
{
    public partial class Form2 : Form
    {
        const int ViewportPointCount = 100;
        ObservableCollection<DataPoint> dataPoints = new ObservableCollection<DataPoint>();
        public Form2()
        {
            WindowsFormsSettings.ForceDirectXPaint();
            InitializeComponent();
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            chartControl1.Titles.Add(new ChartTitle() { Text = "Real-Time Data Simulation" });
            chartControl1.RuntimeHitTesting = false;

            Series series = new Series();
            series.ChangeView(ViewType.SwiftPlot);
            series.DataSource = dataPoints;
            series.DataSourceSorted = true;
            series.ArgumentDataMember = "Argument";
            series.ValueDataMembers.AddRange("Value");
            chartControl1.Series.Add(series);

            SwiftPlotSeriesView seriesView = (SwiftPlotSeriesView)series.View;
            ConstantLine currentValLine = new ConstantLine("Current Value");
            currentValLine.Visible = true;
            currentValLine.ShowInLegend = false;
            currentValLine.Title.Alignment = ConstantLineTitleAlignment.Far;
            currentValLine.Title.ShowBelowLine = true;

            //XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            //diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            //diagram.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            //diagram.AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;
            //diagram.AxisX.WholeRange.SideMarginsValue = 0;
            //diagram.DependentAxesYRange = DefaultBoolean.True;
            //diagram.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            SwiftPlotDiagram diagram = (SwiftPlotDiagram)chartControl1.Diagram;
            diagram.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            diagram.AxisY.VisualRange.Auto = true;
            diagram.AxisY.ConstantLines.Add(currentValLine);
            diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            diagram.AxisX.WholeRange.Auto = true;
            diagram.AxisX.VisualRange.Auto = true;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }
        int counter = 0;

        void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            var newPoint = new DataPoint(DateTime.Now, generateValue(counter++));
            dataPoints.Add(newPoint);

            if(dataPoints.Count > ViewportPointCount)
                dataPoints.RemoveAt(0);

            SwiftPlotDiagram diagram = (SwiftPlotDiagram)chartControl1.Diagram;
            if(diagram != null)
            {
                diagram.AxisX.VisualRange.SetMinMaxValues(
                    now.AddSeconds(-10),
                    now);

            }

            //SwiftPlotDiagram diagram = (SwiftPlotDiagram)chartControl1.Diagram;
            //if(diagram != null && series.Points.Count > 1)
            //{
            //    diagram.AxisX.VisualRange.SetMinMaxValues(
            //        series.Points[0].DateTimeArgument,
            //        series.Points[series.Points.Count - 1].DateTimeArgument);
            //}
        }

        double generateValue(double x)
        {
            return Math.Sin(x) * 3 + x / 2 + 5;
        }
    }
}
