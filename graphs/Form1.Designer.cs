namespace graphs
{
    partial class Form1
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
            textBox_Value_Input = new TextBox();
            textBox_Type_Input = new TextBox();
            button_Add = new Button();
            label1 = new Label();
            label2 = new Label();
            button_Pie_chart = new Button();
            button_Bar_Graph = new Button();
            button_Line_graph = new Button();
            SuspendLayout();
            // 
            // textBox_Value_Input
            // 
            textBox_Value_Input.Location = new Point(55, 482);
            textBox_Value_Input.Name = "textBox_Value_Input";
            textBox_Value_Input.Size = new Size(175, 35);
            textBox_Value_Input.TabIndex = 0;
            // 
            // textBox_Type_Input
            // 
            textBox_Type_Input.Location = new Point(272, 482);
            textBox_Type_Input.Name = "textBox_Type_Input";
            textBox_Type_Input.Size = new Size(175, 35);
            textBox_Type_Input.TabIndex = 1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(490, 477);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(131, 40);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add Vaule ";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 443);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 3;
            label1.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 443);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 4;
            label2.Text = "Type or Name";
            // 
            // button_Pie_chart
            // 
            button_Pie_chart.Location = new Point(716, 112);
            button_Pie_chart.Name = "button_Pie_chart";
            button_Pie_chart.Size = new Size(131, 40);
            button_Pie_chart.TabIndex = 5;
            button_Pie_chart.Text = "Pie Chart";
            button_Pie_chart.UseVisualStyleBackColor = true;
            button_Pie_chart.Click += button_Pie_chart_Click;
            // 
            // button_Bar_Graph
            // 
            button_Bar_Graph.Location = new Point(716, 183);
            button_Bar_Graph.Name = "button_Bar_Graph";
            button_Bar_Graph.Size = new Size(131, 40);
            button_Bar_Graph.TabIndex = 6;
            button_Bar_Graph.Text = "Bar Graph";
            button_Bar_Graph.UseVisualStyleBackColor = true;
            button_Bar_Graph.Click += button_Bar_Graph_Click;
            // 
            // button_Line_graph
            // 
            button_Line_graph.BackgroundImageLayout = ImageLayout.Stretch;
            button_Line_graph.Location = new Point(716, 249);
            button_Line_graph.Name = "button_Line_graph";
            button_Line_graph.Size = new Size(131, 40);
            button_Line_graph.TabIndex = 7;
            button_Line_graph.Text = "Line Graph";
            button_Line_graph.UseVisualStyleBackColor = true;
            button_Line_graph.Click += button_Line_graph_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 615);
            Controls.Add(button_Line_graph);
            Controls.Add(button_Bar_Graph);
            Controls.Add(button_Pie_chart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Add);
            Controls.Add(textBox_Type_Input);
            Controls.Add(textBox_Value_Input);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Value_Input;
        private TextBox textBox_Type_Input;
        private Button button_Add;
        private Label label1;
        private Label label2;
        private Button button_Pie_chart;
        private Button button_Bar_Graph;
        private Button button_Line_graph;
    }
}
