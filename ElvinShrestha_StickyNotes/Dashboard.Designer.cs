namespace ElvinShrestha_StickyNotes
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gboxThisYear = new System.Windows.Forms.GroupBox();
            this.lblYearIncomplete = new System.Windows.Forms.Label();
            this.lblYearComplete = new System.Windows.Forms.Label();
            this.yearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxThisMonth = new System.Windows.Forms.GroupBox();
            this.lblMonthIncomplete = new System.Windows.Forms.Label();
            this.lblMonthComplete = new System.Windows.Forms.Label();
            this.monthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxThisWeek = new System.Windows.Forms.GroupBox();
            this.lblWeekIncomplete = new System.Windows.Forms.Label();
            this.lblWeekComplete = new System.Windows.Forms.Label();
            this.weekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gboxToday = new System.Windows.Forms.GroupBox();
            this.lblTodayIncomplete = new System.Windows.Forms.Label();
            this.lblTodayComplete = new System.Windows.Forms.Label();
            this.todayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gboxThisYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearChart)).BeginInit();
            this.gboxThisMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).BeginInit();
            this.gboxThisWeek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekChart)).BeginInit();
            this.gboxToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(72)))));
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.lblUserType);
            this.panelHeader.Controls.Add(this.lblUserFullName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(707, 112);
            this.panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(369, 73);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(96, 22);
            this.lblUserType.TabIndex = 1;
            this.lblUserType.Text = "User Type";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserFullName.AutoSize = true;
            this.lblUserFullName.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.lblUserFullName.Location = new System.Drawing.Point(260, 21);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(183, 42);
            this.lblUserFullName.TabIndex = 0;
            this.lblUserFullName.Text = "Full Name";
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(225)))), ((int)(((byte)(72)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 49);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard showing current notes status";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(201)))), ((int)(((byte)(65)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gboxThisYear);
            this.panel4.Controls.Add(this.gboxThisMonth);
            this.panel4.Controls.Add(this.gboxThisWeek);
            this.panel4.Controls.Add(this.gboxToday);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 465);
            this.panel4.TabIndex = 3;
            // 
            // gboxThisYear
            // 
            this.gboxThisYear.Controls.Add(this.lblYearIncomplete);
            this.gboxThisYear.Controls.Add(this.lblYearComplete);
            this.gboxThisYear.Controls.Add(this.yearChart);
            this.gboxThisYear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gboxThisYear.Location = new System.Drawing.Point(357, 231);
            this.gboxThisYear.Name = "gboxThisYear";
            this.gboxThisYear.Size = new System.Drawing.Size(337, 220);
            this.gboxThisYear.TabIndex = 1;
            this.gboxThisYear.TabStop = false;
            this.gboxThisYear.Text = "This Year";
            // 
            // lblYearIncomplete
            // 
            this.lblYearIncomplete.AutoSize = true;
            this.lblYearIncomplete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblYearIncomplete.Location = new System.Drawing.Point(217, 146);
            this.lblYearIncomplete.Name = "lblYearIncomplete";
            this.lblYearIncomplete.Size = new System.Drawing.Size(88, 15);
            this.lblYearIncomplete.TabIndex = 6;
            this.lblYearIncomplete.Text = "YearIncomplete";
            // 
            // lblYearComplete
            // 
            this.lblYearComplete.AutoSize = true;
            this.lblYearComplete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblYearComplete.Location = new System.Drawing.Point(217, 131);
            this.lblYearComplete.Name = "lblYearComplete";
            this.lblYearComplete.Size = new System.Drawing.Size(81, 15);
            this.lblYearComplete.TabIndex = 5;
            this.lblYearComplete.Text = "YearComplete";
            // 
            // yearChart
            // 
            this.yearChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.yearChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.yearChart.Legends.Add(legend1);
            this.yearChart.Location = new System.Drawing.Point(6, 20);
            this.yearChart.Name = "yearChart";
            this.yearChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.yearChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumSeaGreen,
        System.Drawing.Color.RoyalBlue};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "yearSeries";
            this.yearChart.Series.Add(series1);
            this.yearChart.Size = new System.Drawing.Size(325, 195);
            this.yearChart.TabIndex = 2;
            this.yearChart.Text = "chart4";
            // 
            // gboxThisMonth
            // 
            this.gboxThisMonth.Controls.Add(this.lblMonthIncomplete);
            this.gboxThisMonth.Controls.Add(this.lblMonthComplete);
            this.gboxThisMonth.Controls.Add(this.monthChart);
            this.gboxThisMonth.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gboxThisMonth.Location = new System.Drawing.Point(11, 231);
            this.gboxThisMonth.Name = "gboxThisMonth";
            this.gboxThisMonth.Size = new System.Drawing.Size(338, 220);
            this.gboxThisMonth.TabIndex = 1;
            this.gboxThisMonth.TabStop = false;
            this.gboxThisMonth.Text = "This Month";
            // 
            // lblMonthIncomplete
            // 
            this.lblMonthIncomplete.AutoSize = true;
            this.lblMonthIncomplete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblMonthIncomplete.Location = new System.Drawing.Point(217, 146);
            this.lblMonthIncomplete.Name = "lblMonthIncomplete";
            this.lblMonthIncomplete.Size = new System.Drawing.Size(100, 15);
            this.lblMonthIncomplete.TabIndex = 4;
            this.lblMonthIncomplete.Text = "MonthIncomplete";
            // 
            // lblMonthComplete
            // 
            this.lblMonthComplete.AutoSize = true;
            this.lblMonthComplete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblMonthComplete.Location = new System.Drawing.Point(217, 131);
            this.lblMonthComplete.Name = "lblMonthComplete";
            this.lblMonthComplete.Size = new System.Drawing.Size(93, 15);
            this.lblMonthComplete.TabIndex = 3;
            this.lblMonthComplete.Text = "MonthComplete";
            // 
            // monthChart
            // 
            this.monthChart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.monthChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            this.monthChart.Legends.Add(legend2);
            this.monthChart.Location = new System.Drawing.Point(6, 20);
            this.monthChart.Name = "monthChart";
            this.monthChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.monthChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumSeaGreen,
        System.Drawing.Color.RoyalBlue};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "monthSeries";
            this.monthChart.Series.Add(series2);
            this.monthChart.Size = new System.Drawing.Size(326, 195);
            this.monthChart.TabIndex = 1;
            this.monthChart.Text = "chart3";
            // 
            // gboxThisWeek
            // 
            this.gboxThisWeek.Controls.Add(this.lblWeekIncomplete);
            this.gboxThisWeek.Controls.Add(this.lblWeekComplete);
            this.gboxThisWeek.Controls.Add(this.weekChart);
            this.gboxThisWeek.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gboxThisWeek.Location = new System.Drawing.Point(355, 5);
            this.gboxThisWeek.Name = "gboxThisWeek";
            this.gboxThisWeek.Size = new System.Drawing.Size(337, 220);
            this.gboxThisWeek.TabIndex = 1;
            this.gboxThisWeek.TabStop = false;
            this.gboxThisWeek.Text = "This Week";
            // 
            // lblWeekIncomplete
            // 
            this.lblWeekIncomplete.AutoSize = true;
            this.lblWeekIncomplete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblWeekIncomplete.Location = new System.Drawing.Point(217, 146);
            this.lblWeekIncomplete.Name = "lblWeekIncomplete";
            this.lblWeekIncomplete.Size = new System.Drawing.Size(95, 15);
            this.lblWeekIncomplete.TabIndex = 4;
            this.lblWeekIncomplete.Text = "WeekIncomplete";
            // 
            // lblWeekComplete
            // 
            this.lblWeekComplete.AutoSize = true;
            this.lblWeekComplete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblWeekComplete.Location = new System.Drawing.Point(217, 131);
            this.lblWeekComplete.Name = "lblWeekComplete";
            this.lblWeekComplete.Size = new System.Drawing.Size(88, 15);
            this.lblWeekComplete.TabIndex = 3;
            this.lblWeekComplete.Text = "WeekComplete";
            // 
            // weekChart
            // 
            this.weekChart.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.weekChart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Legend1";
            this.weekChart.Legends.Add(legend3);
            this.weekChart.Location = new System.Drawing.Point(6, 20);
            this.weekChart.Name = "weekChart";
            this.weekChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.weekChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumSeaGreen,
        System.Drawing.Color.RoyalBlue};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "weekSeries";
            this.weekChart.Series.Add(series3);
            this.weekChart.Size = new System.Drawing.Size(325, 195);
            this.weekChart.TabIndex = 1;
            this.weekChart.Text = "chart2";
            // 
            // gboxToday
            // 
            this.gboxToday.Controls.Add(this.lblTodayIncomplete);
            this.gboxToday.Controls.Add(this.lblTodayComplete);
            this.gboxToday.Controls.Add(this.todayChart);
            this.gboxToday.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.gboxToday.Location = new System.Drawing.Point(11, 5);
            this.gboxToday.Name = "gboxToday";
            this.gboxToday.Size = new System.Drawing.Size(338, 220);
            this.gboxToday.TabIndex = 0;
            this.gboxToday.TabStop = false;
            this.gboxToday.Text = "Today";
            // 
            // lblTodayIncomplete
            // 
            this.lblTodayIncomplete.AutoSize = true;
            this.lblTodayIncomplete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblTodayIncomplete.Location = new System.Drawing.Point(217, 146);
            this.lblTodayIncomplete.Name = "lblTodayIncomplete";
            this.lblTodayIncomplete.Size = new System.Drawing.Size(98, 15);
            this.lblTodayIncomplete.TabIndex = 2;
            this.lblTodayIncomplete.Text = "TodayIncomplete";
            // 
            // lblTodayComplete
            // 
            this.lblTodayComplete.AutoSize = true;
            this.lblTodayComplete.Font = new System.Drawing.Font("Century Gothic", 7F);
            this.lblTodayComplete.Location = new System.Drawing.Point(217, 131);
            this.lblTodayComplete.Name = "lblTodayComplete";
            this.lblTodayComplete.Size = new System.Drawing.Size(91, 15);
            this.lblTodayComplete.TabIndex = 1;
            this.lblTodayComplete.Text = "TodayComplete";
            // 
            // todayChart
            // 
            this.todayChart.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.todayChart.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Name = "Legend1";
            this.todayChart.Legends.Add(legend4);
            this.todayChart.Location = new System.Drawing.Point(6, 20);
            this.todayChart.Name = "todayChart";
            this.todayChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.todayChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumSeaGreen,
        System.Drawing.Color.RoyalBlue};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "todaySeries";
            this.todayChart.Series.Add(series4);
            this.todayChart.Size = new System.Drawing.Size(326, 195);
            this.todayChart.TabIndex = 0;
            this.todayChart.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(231)))), ((int)(((byte)(108)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 25);
            this.panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 651);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.gboxThisYear.ResumeLayout(false);
            this.gboxThisYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearChart)).EndInit();
            this.gboxThisMonth.ResumeLayout(false);
            this.gboxThisMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).EndInit();
            this.gboxThisWeek.ResumeLayout(false);
            this.gboxThisWeek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekChart)).EndInit();
            this.gboxToday.ResumeLayout(false);
            this.gboxToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todayChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblUserFullName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gboxThisYear;
        private System.Windows.Forms.GroupBox gboxThisMonth;
        private System.Windows.Forms.GroupBox gboxThisWeek;
        private System.Windows.Forms.GroupBox gboxToday;
        private System.Windows.Forms.DataVisualization.Charting.Chart todayChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart weekChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTodayIncomplete;
        private System.Windows.Forms.Label lblTodayComplete;
        private System.Windows.Forms.Label lblWeekIncomplete;
        private System.Windows.Forms.Label lblWeekComplete;
        private System.Windows.Forms.Label lblMonthIncomplete;
        private System.Windows.Forms.Label lblMonthComplete;
        private System.Windows.Forms.Label lblYearIncomplete;
        private System.Windows.Forms.Label lblYearComplete;
    }
}