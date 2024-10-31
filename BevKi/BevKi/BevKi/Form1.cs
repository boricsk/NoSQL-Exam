using System.Windows.Forms.DataVisualization.Charting;

namespace BevKi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Adatok");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

            series.Points.AddXY("2020", 100);
            series.Points.AddXY("2021", 200);
            series.Points.AddXY("2022", 300);

            chart1.Series.Add(series);
        }
    }
}
