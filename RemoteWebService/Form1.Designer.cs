namespace RemoteWebService
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CurrencycomboBox = new System.Windows.Forms.ComboBox();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UntildateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartRateData
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRateData.Legends.Add(legend2);
            this.chartRateData.Location = new System.Drawing.Point(412, 66);
            this.chartRateData.Name = "chartRateData";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRateData.Series.Add(series2);
            this.chartRateData.Size = new System.Drawing.Size(1031, 300);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // CurrencycomboBox
            // 
            this.CurrencycomboBox.FormattingEnabled = true;
            this.CurrencycomboBox.Items.AddRange(new object[] {
            "EUR"});
            this.CurrencycomboBox.Location = new System.Drawing.Point(463, 13);
            this.CurrencycomboBox.Name = "CurrencycomboBox";
            this.CurrencycomboBox.Size = new System.Drawing.Size(159, 21);
            this.CurrencycomboBox.TabIndex = 2;
            this.CurrencycomboBox.Text = "EUR";
            this.CurrencycomboBox.SelectedIndexChanged += new System.EventHandler(this.CurrencycomboBox_SelectedIndexChanged);
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Location = new System.Drawing.Point(13, 13);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FromdateTimePicker.TabIndex = 3;
            this.FromdateTimePicker.ValueChanged += new System.EventHandler(this.FromdateTimePicker_ValueChanged);
            // 
            // UntildateTimePicker
            // 
            this.UntildateTimePicker.Location = new System.Drawing.Point(243, 13);
            this.UntildateTimePicker.Name = "UntildateTimePicker";
            this.UntildateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.UntildateTimePicker.TabIndex = 4;
            this.UntildateTimePicker.ValueChanged += new System.EventHandler(this.UntildateTimePicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 402);
            this.Controls.Add(this.UntildateTimePicker);
            this.Controls.Add(this.FromdateTimePicker);
            this.Controls.Add(this.CurrencycomboBox);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.ComboBox CurrencycomboBox;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.DateTimePicker UntildateTimePicker;
    }
}

