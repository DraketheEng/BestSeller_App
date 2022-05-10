namespace UrunTakip_PostgreSQL
{
    partial class FrmStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistics));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblExpensive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblCheap = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblMostProfit = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(62, 55);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Categories";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(411, 443);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(479, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 158);
            this.panel1.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(62, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(25, 29);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Category Count";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21114;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.lblExpensive);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(479, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 158);
            this.panel2.TabIndex = 21115;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(48, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 29);
            this.label19.TabIndex = 2;
            this.label19.Text = "Product";
            // 
            // lblExpensive
            // 
            this.lblExpensive.AutoSize = true;
            this.lblExpensive.Location = new System.Drawing.Point(62, 75);
            this.lblExpensive.Name = "lblExpensive";
            this.lblExpensive.Size = new System.Drawing.Size(25, 29);
            this.lblExpensive.TabIndex = 1;
            this.lblExpensive.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Most Expensive ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightPink;
            this.panel3.Controls.Add(this.lblTotalMoney);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(479, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 158);
            this.panel3.TabIndex = 2;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(62, 75);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(25, 29);
            this.lblTotalMoney.TabIndex = 1;
            this.lblTotalMoney.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Money";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Salmon;
            this.panel4.Controls.Add(this.lblCustomerCity);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(685, 340);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 158);
            this.panel4.TabIndex = 21117;
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Location = new System.Drawing.Point(62, 75);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(25, 29);
            this.lblCustomerCity.TabIndex = 1;
            this.lblCustomerCity.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Cities";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Controls.Add(this.LblCheap);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(685, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 158);
            this.panel5.TabIndex = 21118;
            // 
            // LblCheap
            // 
            this.LblCheap.AutoSize = true;
            this.LblCheap.Location = new System.Drawing.Point(62, 75);
            this.LblCheap.Name = "LblCheap";
            this.LblCheap.Size = new System.Drawing.Size(25, 29);
            this.LblCheap.TabIndex = 1;
            this.LblCheap.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cheapest Product";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Crimson;
            this.panel6.Controls.Add(this.lblProduct);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(685, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 158);
            this.panel6.TabIndex = 21116;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(62, 75);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(25, 29);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "All product count";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Controls.Add(this.lblCustomerCount);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(891, 340);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 158);
            this.panel7.TabIndex = 21117;
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Location = new System.Drawing.Point(62, 75);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(25, 29);
            this.lblCustomerCount.TabIndex = 1;
            this.lblCustomerCount.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Customer Count";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel8.Controls.Add(this.lblMostProfit);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(891, 176);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 158);
            this.panel8.TabIndex = 21118;
            // 
            // lblMostProfit
            // 
            this.lblMostProfit.AutoSize = true;
            this.lblMostProfit.Location = new System.Drawing.Point(62, 75);
            this.lblMostProfit.Name = "lblMostProfit";
            this.lblMostProfit.Size = new System.Drawing.Size(25, 29);
            this.lblMostProfit.TabIndex = 1;
            this.lblMostProfit.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = "Most Profit";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.Controls.Add(this.lblStock);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(891, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 158);
            this.panel9.TabIndex = 21116;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(62, 75);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(25, 29);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 29);
            this.label18.TabIndex = 0;
            this.label18.Text = "Stock Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 29);
            this.label2.TabIndex = 21119;
            this.label2.Text = "Graph: Distinct Categories";
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1102, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExpensive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblCheap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblMostProfit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
    }
}