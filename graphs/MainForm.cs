using System.Runtime.CompilerServices;
using System.Windows.Forms.DataVisualization.Charting;
namespace graphs
{
    public partial class MainForm : Form
    {
        //Declaring our chart
        private System.Windows.Forms.DataVisualization.Charting.Chart chart = new System.Windows.Forms.DataVisualization.Charting.Chart();

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Defines where the chart will be placed
            chart.Location = new Point(10, 10); 
            
            //Using relatives measures to be compatible with all screens
            chart.Size = new Size((int)(this.Width * 0.7), (int)(this.Height * 0.7));

            //ChartArea objects are used to plot the chart.
            chart.ChartAreas.Add(new ChartArea());
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            //Defining default Type as Bars
            chart.Series.Add(new Series("Bars"));
            chart.Series[0].ChartType = SeriesChartType.Bar;
            chart.Series[0].IsXValueIndexed = true;


            //Adding the graph to the Main Form
            this.Controls.Add(chart);
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            // Getting typed information
            double value = double.Parse(numericUpDown_Input.Text);
            string type = textBox_Type_Input.Text;

            // Inserting the value and type to graph
            var point = new DataPoint(chart.Series[0].Points.Count + 1, value);
            point.AxisLabel = type;

            // Defining color
            point.Color = Color.FromArgb(
                64 + (chart.Series[0].Points.Count * 20) % 192,
                64 + (chart.Series[0].Points.Count * 40) % 192,
                64 + (chart.Series[0].Points.Count * 60) % 192
            );
            
            //Adding to Graph
            chart.Series[0].Points.Add(point);

            //After insert the values, clean the inputs and rturn focus to first input
            numericUpDown_Input.Value = 0;
            textBox_Type_Input.Text = String.Empty ;
            numericUpDown_Input.Focus();
        }

        private void button_Pie_chart_Click(object sender, EventArgs e)
        {
            // Checking if there are any negative values
            for (int i = 0; i < chart.Series[0].Points.Count; i++)
            {
                if (chart.Series[0].Points[i].YValues[0] < 0)
                {
                    MessageBox.Show("Pie Chart doesn't allow negative numbers");
                    return;
                }
            }
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

        private void button_Clear_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
        }
    }
}
