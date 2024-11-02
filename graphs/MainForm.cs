using System.Runtime.CompilerServices;
using System.Windows.Forms.DataVisualization.Charting;
namespace graphs
{
    public partial class MainForm : Form
    {
        public System.Windows.Forms.DataVisualization.Charting.Chart chart = new System.Windows.Forms.DataVisualization.Charting.Chart();

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set the chart location and size
            chart.Location = new Point(10, 10);
            chart.Size = new Size((int)(this.Width * 0.7), (int)(this.Height * 0.7));
            // Set the chart title
            chart.ChartAreas.Add(new ChartArea());
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            // Add a series to the chart
            chart.Series.Add(new Series("Bars"));
            chart.Series[0].ChartType = SeriesChartType.Bar;
            chart.Series[0].IsXValueIndexed = true;

            this.Controls.Add(chart);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            // Get the value and type from the input fields
            double value = double.Parse(numericUpDown_Input.Text);
            string type = textBox_Type_Input.Text;

            // Add the value to the chart
            var point = new DataPoint(chart.Series[0].Points.Count + 1, value);
            point.AxisLabel = type;

            // Set the color of the point
            point.Color = Color.FromArgb(
                64 + (chart.Series[0].Points.Count * 20) % 192,
                64 + (chart.Series[0].Points.Count * 40) % 192,
                64 + (chart.Series[0].Points.Count * 60) % 192
            );
            // Add the point to the chart
            chart.Series[0].Points.Add(point);
            numericUpDown_Input.Focus();
            numericUpDown_Input.Value = 0;
            textBox_Type_Input.Text = String.Empty ;
        }

        private void button_Pie_chart_Click(object sender, EventArgs e)
        {
            // Check if the chart has negative values
            for (int i = 0; i < chart.Series[0].Points.Count; i++)
            {
                if (chart.Series[0].Points[i].YValues[0] < 0)
                {
                    MessageBox.Show("Pie Chart doesn't allow negative numbers");
                    return;
                }
            }
            // Set the chart type to Pie
            chart.Series[0].ChartType = SeriesChartType.Pie;
        }

        private void button_Bar_Graph_Click(object sender, EventArgs e)
        {
            // Set the chart type to Bar
            chart.Series[0].ChartType = SeriesChartType.Bar;
        }

        private void button_Line_graph_Click(object sender, EventArgs e)
        {
            // Set the chart type to Line
            chart.Series[0].ChartType = SeriesChartType.Line;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            // Clear the chart
            chart.Series[0].Points.Clear();
        }
    }
    // Not counting this comment this file is 13.636% comments lol.
}
