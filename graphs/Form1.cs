using System.Windows.Forms.DataVisualization.Charting;
namespace graphs
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.DataVisualization.Charting.Chart chart = new System.Windows.Forms.DataVisualization.Charting.Chart();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart.Location = new Point(10, 10);
            chart.Size = new Size(600, 400);

            chart.ChartAreas.Add(new ChartArea());
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart.Series.Add(new Series("Bars"));
            chart.Series[0].ChartType = SeriesChartType.Bar;
            chart.Series[0].IsXValueIndexed = true;

            this.Controls.Add(chart);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox_Value_Input.Text);
            string type = textBox_Type_Input.Text;

            var point = new DataPoint(chart.Series[0].Points.Count + 1, value);
            point.AxisLabel = type;
            //point.Label = type; // Set the label to display the name on the bar
            //point.LabelForeColor = Color.White; // Set the text color to white

            point.Color = Color.FromArgb(
                64 + (chart.Series[0].Points.Count * 20) % 192,
                64 + (chart.Series[0].Points.Count * 40) % 192,
                64 + (chart.Series[0].Points.Count * 60) % 192
            );

            chart.Series[0].Points.Add(point);
        }

        private void button_Pie_chart_Click(object sender, EventArgs e)
        {
            chart.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void button_Bar_Graph_Click(object sender, EventArgs e)
        {
            chart.Series[0].ChartType = SeriesChartType.Bar;
        }

        private void button_Line_graph_Click(object sender, EventArgs e)
        {
            chart.Series[0].ChartType = SeriesChartType.Line;
        }
    }
}
