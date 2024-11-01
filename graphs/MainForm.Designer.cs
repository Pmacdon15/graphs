namespace graphs
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Type_Input = new TextBox();
            button_Add = new Button();
            label1 = new Label();
            label2 = new Label();
            button_Pie_chart = new Button();
            button_Bar_Graph = new Button();
            button_Line_graph = new Button();
            numericUpDown_Input = new NumericUpDown();
            button_Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Input).BeginInit();
            SuspendLayout();
            // 
            // textBox_Type_Input
            // 
            textBox_Type_Input.Location = new Point(172, 372);
            textBox_Type_Input.Margin = new Padding(2);
            textBox_Type_Input.Name = "textBox_Type_Input";
            textBox_Type_Input.Size = new Size(118, 27);
            textBox_Type_Input.TabIndex = 1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(318, 369);
            button_Add.Margin = new Padding(2);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(87, 27);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add Vaule ";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 346);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 3;
            label1.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 346);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 4;
            label2.Text = "Type or Name";
            // 
            // button_Pie_chart
            // 
            button_Pie_chart.BackgroundImage = Properties.Resources.piechart;
            button_Pie_chart.BackgroundImageLayout = ImageLayout.Stretch;
            button_Pie_chart.Location = new Point(554, 13);
            button_Pie_chart.Margin = new Padding(2);
            button_Pie_chart.Name = "button_Pie_chart";
            button_Pie_chart.Size = new Size(120, 120);
            button_Pie_chart.TabIndex = 5;
            button_Pie_chart.UseVisualStyleBackColor = true;
            button_Pie_chart.Click += button_Pie_chart_Click;
            // 
            // button_Bar_Graph
            // 
            button_Bar_Graph.BackgroundImage = Properties.Resources.barchart1;
            button_Bar_Graph.BackgroundImageLayout = ImageLayout.Stretch;
            button_Bar_Graph.Location = new Point(554, 137);
            button_Bar_Graph.Margin = new Padding(2);
            button_Bar_Graph.Name = "button_Bar_Graph";
            button_Bar_Graph.Size = new Size(120, 120);
            button_Bar_Graph.TabIndex = 6;
            button_Bar_Graph.UseVisualStyleBackColor = true;
            button_Bar_Graph.Click += button_Bar_Graph_Click;
            // 
            // button_Line_graph
            // 
            button_Line_graph.BackgroundImage = Properties.Resources.linechart;
            button_Line_graph.BackgroundImageLayout = ImageLayout.Stretch;
            button_Line_graph.Location = new Point(554, 261);
            button_Line_graph.Margin = new Padding(2);
            button_Line_graph.Name = "button_Line_graph";
            button_Line_graph.Size = new Size(120, 120);
            button_Line_graph.TabIndex = 7;
            button_Line_graph.UseVisualStyleBackColor = true;
            button_Line_graph.Click += button_Line_graph_Click;
            // 
            // numericUpDown_Input
            // 
            numericUpDown_Input.DecimalPlaces = 2;
            numericUpDown_Input.Location = new Point(17, 372);
            numericUpDown_Input.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDown_Input.Minimum = new decimal(new int[] { -1486618625, 232830643, 0, int.MinValue });
            numericUpDown_Input.Name = "numericUpDown_Input";
            numericUpDown_Input.Size = new Size(150, 27);
            numericUpDown_Input.TabIndex = 0;
            numericUpDown_Input.TextAlign = HorizontalAlignment.Right;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(422, 369);
            button_Clear.Margin = new Padding(2);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(87, 27);
            button_Clear.TabIndex = 8;
            button_Clear.Text = "Clear Values";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 410);
            Controls.Add(button_Clear);
            Controls.Add(numericUpDown_Input);
            Controls.Add(button_Line_graph);
            Controls.Add(button_Bar_Graph);
            Controls.Add(button_Pie_chart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Add);
            Controls.Add(textBox_Type_Input);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Graphs";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Input).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Type_Input;
        private Button button_Add;
        private Label label1;
        private Label label2;
        private Button button_Pie_chart;
        private Button button_Bar_Graph;
        private Button button_Line_graph;
        private NumericUpDown numericUpDown_Input;
        private Button button_Clear;
    }
}
