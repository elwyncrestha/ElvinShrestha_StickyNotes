using System;
using System.Data;
using System.Windows.Forms;

namespace ElvinShrestha_StickyNotes
{
    public partial class Dashboard : Form
    {
        StickyNotesBLL stickyNotesBLL = new StickyNotesBLL();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnOpenStickyNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // send to BLL
            stickyNotesBLL._username = FormLoaderClass._username;

            // header part
            UserBLL userBLL = new UserBLL();
            DataTable dataTable = userBLL.getUserDetails(FormLoaderClass._username);
            lblUserFullName.Text = dataTable.Rows[0][0].ToString() + " " + dataTable.Rows[0][1].ToString();
            lblUserType.Text = dataTable.Rows[0][2].ToString();

            float complete, incomplete, total;
            // today chart
            complete = (float) stickyNotesBLL.countTodayNotes("Completed",DateTime.Now.ToString());
            incomplete = (float) stickyNotesBLL.countTodayNotes("Incomplete",DateTime.Now.ToString());
            total = (float) stickyNotesBLL.countTodayNotes("All",DateTime.Now.ToString());
            complete = (complete / total) * 100;
            incomplete = (incomplete / total) * 100;
            loadTodayChart(complete,incomplete);

            // week chart
            complete = (float)stickyNotesBLL.countWeekNotes("Completed",DateTime.Now.AddDays(-7).ToString(),DateTime.Now.ToString());
            incomplete = (float)stickyNotesBLL.countWeekNotes("Incomplete",DateTime.Now.AddDays(-7).ToString(), DateTime.Now.ToString());
            total = (float)stickyNotesBLL.countWeekNotes("All", DateTime.Now.AddDays(-7).ToString(), DateTime.Now.ToString());
            complete = (complete / total) * 100;
            incomplete = (incomplete / total) * 100;
            loadWeekChart(complete, incomplete);

            // month chart
            complete = (float)stickyNotesBLL.countMonthNotes("Completed",DateTime.Now.AddMonths(-1).ToString(), DateTime.Now.ToString());
            incomplete = (float)stickyNotesBLL.countMonthNotes("Incomplete",DateTime.Now.AddMonths(-1).ToString(), DateTime.Now.ToString());
            total = (float)stickyNotesBLL.countMonthNotes("All",DateTime.Now.AddMonths(-1).ToString(), DateTime.Now.ToString());
            complete = (complete / total) * 100;
            incomplete = (incomplete / total) * 100;
            loadMonthChart(complete, incomplete);

            // year chart
            complete = (float)stickyNotesBLL.countYearNotes("Completed", DateTime.Now.AddYears(-1).ToString(), DateTime.Now.ToString());
            incomplete = (float)stickyNotesBLL.countYearNotes("Incomplete", DateTime.Now.AddYears(-1).ToString(), DateTime.Now.ToString());
            total = (float)stickyNotesBLL.countYearNotes("All", DateTime.Now.AddYears(-1).ToString(), DateTime.Now.ToString());
            complete = (complete / total) * 100;
            incomplete = (incomplete / total) * 100;
            loadYearChart(complete, incomplete);
        }

        private void loadTodayChart(float complete_Today, float incomplete_Today)
        {
            if (complete_Today > 0 && incomplete_Today > 0)
            {
                todayChart.Series["todaySeries"].Points.AddXY("Completed", complete_Today);
                todayChart.Series["todaySeries"].Points.AddXY("Incomplete", incomplete_Today);
                lblTodayComplete.Text = String.Format("{0:0.00}", complete_Today) + " % completed";
                lblTodayIncomplete.Text = String.Format("{0:0.00}", incomplete_Today) + " % incomplete";
            }
            else if (complete_Today > 0 && incomplete_Today <= 0)
            {
                todayChart.Series["todaySeries"].Points.AddXY("Completed", complete_Today);
                lblTodayComplete.Text = String.Format("{0:0.00}", complete_Today) + " % completed";
                lblTodayIncomplete.Visible = false;
            }
            else if (complete_Today <= 0 && incomplete_Today > 0)
            {
                todayChart.Series["todaySeries"].Points.AddXY("Incomplete", incomplete_Today);
                lblTodayIncomplete.Text = String.Format("{0:0.00}", incomplete_Today) + " % incomplete";
                lblTodayComplete.Visible = false;
            }
            else
            {
                todayChart.Series["todaySeries"].Points.AddXY("No data", 100);
                lblTodayComplete.Visible = lblTodayIncomplete.Visible = false;
            }
        }

        private void loadWeekChart(float complete_Week, float incomplete_Week)
        {
            if (complete_Week > 0 && incomplete_Week > 0)
            {
                weekChart.Series["weekSeries"].Points.AddXY("Completed", complete_Week);
                weekChart.Series["weekSeries"].Points.AddXY("Incomplete", incomplete_Week);
                lblWeekComplete.Text = String.Format("{0:0.00}", complete_Week) + " % completed";
                lblWeekIncomplete.Text = String.Format("{0:0.00}", incomplete_Week) + " % incomplete";
            }
            else if (complete_Week > 0 && incomplete_Week <= 0)
            {
                weekChart.Series["weekSeries"].Points.AddXY("Completed", complete_Week);
                lblWeekComplete.Text = String.Format("{0:0.00}", complete_Week) + " % completed";
                lblWeekIncomplete.Visible = false;
            }
            else if (complete_Week <= 0 && incomplete_Week > 0)
            {
                weekChart.Series["weekSeries"].Points.AddXY("Incomplete", incomplete_Week);
                lblWeekIncomplete.Text = String.Format("{0:0.00}", incomplete_Week) + " % incomplete";
                lblWeekComplete.Visible = false;
            }
            else
            {
                weekChart.Series["weekSeries"].Points.AddXY("No data", 100);
                lblWeekComplete.Visible = lblWeekIncomplete.Visible = false;
            }
        }

        private void loadMonthChart(float complete_Month, float incomplete_Month)
        {
            if (complete_Month > 0 && incomplete_Month > 0)
            {
                monthChart.Series["monthSeries"].Points.AddXY("Completed", complete_Month);
                monthChart.Series["monthSeries"].Points.AddXY("Incomplete", incomplete_Month);
                lblMonthComplete.Text = String.Format("{0:0.00}", complete_Month) + " % completed";
                lblMonthIncomplete.Text = String.Format("{0:0.00}", incomplete_Month) + " % incomplete";
            }
            else if (complete_Month > 0 && incomplete_Month <= 0)
            {
                monthChart.Series["monthSeries"].Points.AddXY("Completed", complete_Month);
                lblMonthComplete.Text = String.Format("{0:0.00}", complete_Month) + " % completed";
                lblMonthIncomplete.Visible = false;
            }
            else if (complete_Month <= 0 && incomplete_Month > 0)
            {
                monthChart.Series["monthSeries"].Points.AddXY("Incomplete", incomplete_Month);
                lblMonthIncomplete.Text = String.Format("{0:0.00}", incomplete_Month) + " % incomplete";
                lblMonthComplete.Visible = false;
            }
            else
            {
                monthChart.Series["monthSeries"].Points.AddXY("No data", 100);
                lblMonthComplete.Visible = lblMonthIncomplete.Visible = false;
            }
        }

        private void loadYearChart(float complete_Year, float incomplete_Year)
        {
            if (complete_Year > 0 && incomplete_Year > 0)
            {
                yearChart.Series["yearSeries"].Points.AddXY("Completed", complete_Year);
                yearChart.Series["yearSeries"].Points.AddXY("Incomplete", incomplete_Year);
                lblYearComplete.Text = String.Format("{0:0.00}",complete_Year) + " % completed";
                lblYearIncomplete.Text = String.Format("{0:0.00}", incomplete_Year) + " % incomplete";
            }
            else if (complete_Year > 0 && incomplete_Year <= 0)
            {
                yearChart.Series["yearSeries"].Points.AddXY("Completed", complete_Year);
                lblYearComplete.Text = String.Format("{0:0.00}", complete_Year) + " % completed";
                lblYearIncomplete.Visible = false;
            }
            else if (complete_Year <= 0 && incomplete_Year > 0)
            {
                yearChart.Series["yearSeries"].Points.AddXY("Incomplete", incomplete_Year);
                lblYearIncomplete.Text = String.Format("{0:0.00}", incomplete_Year) + " % incomplete";
                lblYearComplete.Visible = false;
            }
            else
            {
                yearChart.Series["yearSeries"].Points.AddXY("No data", 100);
                lblYearComplete.Visible = lblYearIncomplete.Visible = false;
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormLoaderClass.loadStickyNotes();
            this.Close();
        }
    }
}
