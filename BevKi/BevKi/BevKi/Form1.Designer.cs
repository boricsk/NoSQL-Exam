namespace BevKi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            tbValue = new NumericUpDown();
            label2 = new Label();
            tbDesc = new TextBox();
            btnExpense = new Button();
            imageList1 = new ImageList(components);
            btnIncome = new Button();
            label1 = new Label();
            cashFlows = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Desc = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cashFlows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbValue);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbDesc);
            groupBox1.Controls.Add(btnExpense);
            groupBox1.Controls.Add(btnIncome);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item";
            // 
            // tbValue
            // 
            tbValue.DecimalPlaces = 2;
            tbValue.Location = new Point(6, 83);
            tbValue.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            tbValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(238, 23);
            tbValue.TabIndex = 6;
            tbValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Value";
            // 
            // tbDesc
            // 
            tbDesc.Location = new Point(6, 37);
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(238, 23);
            tbDesc.TabIndex = 3;
            // 
            // btnExpense
            // 
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.ImageIndex = 1;
            btnExpense.ImageList = imageList1;
            btnExpense.Location = new Point(158, 112);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(86, 37);
            btnExpense.TabIndex = 2;
            btnExpense.Text = "-";
            btnExpense.TextAlign = ContentAlignment.MiddleLeft;
            btnExpense.UseVisualStyleBackColor = true;
            btnExpense.Click += btnClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "hand-money-income-note-icon(3).png");
            imageList1.Images.SetKeyName(1, "give-hand-palm-icon.png");
            // 
            // btnIncome
            // 
            btnIncome.FlatStyle = FlatStyle.Flat;
            btnIncome.ImageIndex = 0;
            btnIncome.ImageList = imageList1;
            btnIncome.Location = new Point(6, 112);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(86, 37);
            btnIncome.TabIndex = 1;
            btnIncome.Text = "+";
            btnIncome.TextAlign = ContentAlignment.MiddleLeft;
            btnIncome.UseVisualStyleBackColor = true;
            btnIncome.Click += btnClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // cashFlows
            // 
            cashFlows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashFlows.Columns.AddRange(new DataGridViewColumn[] { Type, Date, Desc, Value });
            cashFlows.Location = new Point(274, 12);
            cashFlows.Name = "cashFlows";
            cashFlows.Size = new Size(636, 471);
            cashFlows.TabIndex = 1;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.Width = 56;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.Width = 56;
            // 
            // Desc
            // 
            Desc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Desc.HeaderText = "Description";
            Desc.Name = "Desc";
            Desc.Width = 92;
            // 
            // Value
            // 
            Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Value.DefaultCellStyle = dataGridViewCellStyle1;
            Value.HeaderText = "Value";
            Value.Name = "Value";
            Value.Width = 60;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomLeft;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(6, 22);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(244, 252);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chart1);
            groupBox2.Location = new Point(12, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(256, 280);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 174);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 495);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(cashFlows);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "BevKi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)cashFlows).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox tbDesc;
        private Button btnExpense;
        private Button btnIncome;
        private Label label1;
        private DataGridView cashFlows;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private NumericUpDown tbValue;
        private GroupBox groupBox2;
        private ImageList imageList1;
        private Label label3;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn Value;
    }
}
