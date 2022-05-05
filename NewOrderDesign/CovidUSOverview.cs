using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace NewOrderDesign
{
    public partial class CovidUSOverview : Form
    {
        public static Int32 confirmed_cases;
        public static Int32 deaths;
        public static Int32 overviewTotalCases;
        public static Int32 overviewTotalDeath;
        public static Int32 overviewDates;

        public CovidUSOverview()
        {
            InitializeComponent();
            PersonsComboBox.SelectedItem = "Alabama";
        }

        string stateCovid;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6.fullscreencheck(this);
            DataSelection form2 = new DataSelection();
            form2.Show();
        }


        private void OverviewTab_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RawDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6.fullscreencheck(this);
            CovidStateData CovidStateData = new CovidStateData();
            CovidStateData.Show();
        }

        private void CovidUSOverview_Load(object sender, EventArgs e)
        {
            if (Form6.fullscreentoggle == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            // TODO: This line of code loads data into the 'covidDataDataSet7.states' table. You can move, or remove it, as needed.
            this.statesTableAdapter1.Fill(this.covidDataDataSet7.states);
            stateCovid = PersonsComboBox.Text;
            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = CovidData; User Id = apeuser2; Password = daylonswallows1234;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT SUM(confirmed_cases) AS confirmed_cases, SUM(deaths) AS deaths, date FROM states GROUP BY date ORDER BY date ASC";

                    SqlCommand cmdStateCases = conn.CreateCommand();
                    cmdStateCases.CommandText = query1;
                    CovidUSOverview.overviewTotalCases = (Int32)cmdStateCases.ExecuteScalar();

                    DataTable dt1 = GetData(query1);

                    DateTime[] x = (from p in dt1.AsEnumerable()
                               select p.Field<DateTime>("date")).ToArray();

                    int[] y = (from p in dt1.AsEnumerable()
                               select p.Field<int>("confirmed_cases")).ToArray();

                    int[] y1 = (from p in dt1.AsEnumerable()
                               select p.Field<int>("deaths")).ToArray();

                    Covid19_State_Chart.Series[0].ChartType = SeriesChartType.Line;
                    Covid19_State_Chart.Series[0].Points.DataBindXY(x, y);
                    Covid19_State_Chart.Legends[0].Enabled = true;
                    Covid19_State_Chart.ChartAreas[0].Area3DStyle.Enable3D = false;
                    Covid19_State_Chart.ChartAreas[0].AxisX.Title = "Time";
                    Covid19_State_Chart.Series[0].Font = new Font("Georgia", 14, FontStyle.Bold);
                    Covid19_State_Chart.ChartAreas[0].AxisY.Title = "Confirmed Cases";
                    Covid19_State_Chart.Series[0].Font = new Font("Georgia", 14, FontStyle.Bold);

                    Covid19_State_Death_Chart.Series[0].ChartType = SeriesChartType.Line;
                    Covid19_State_Death_Chart.Series[0].Points.DataBindXY(x, y1);
                    Covid19_State_Death_Chart.Legends[0].Enabled = true;
                    Covid19_State_Death_Chart.ChartAreas[0].Area3DStyle.Enable3D = false;
                    Covid19_State_Death_Chart.ChartAreas[0].AxisX.Title = "Time";
                    Covid19_State_Death_Chart.Series[0].Font = new Font("Georgia", 14, FontStyle.Bold);
                    Covid19_State_Death_Chart.ChartAreas[0].AxisY.Title = "Deaths";
                    Covid19_State_Death_Chart.Series[0].Font = new Font("Georgia", 14, FontStyle.Bold);


                    //Covid19_State_Chart.Series[1].ChartType = SeriesChartType.Line;
                    //Covid19_State_Chart.Series[1].Points.DataBindXY(x, y1);
                    //Covid19_State_Chart.Legends[1].Enabled = true;
                    //Covid19_State_Chart.ChartAreas[1].Area3DStyle.Enable3D = false;
                    //Covid19_State_Chart.ChartAreas[1].AxisX.Interval = 1;
                    Covid19Table.Hide();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        private void PersonsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            stateCovid = PersonsComboBox.Text;

            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = CovidData; User Id = apeuser2; Password = daylonswallows1234;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT SUM(confirmed_cases) AS confirmed_cases, SUM(deaths) AS deaths, date FROM states WHERE state_name = '{stateCovid}' GROUP BY date ORDER BY date ASC";

                    DataTable dt1 = GetData(query1);

                    DateTime[] x = (from p in dt1.AsEnumerable()
                                    select p.Field<DateTime>("date")).ToArray();

                    int[] y = (from p in dt1.AsEnumerable()
                               select p.Field<int>("confirmed_cases")).ToArray();

                    int[] y1 = (from p in dt1.AsEnumerable()
                                select p.Field<int>("deaths")).ToArray();

                    Covid19_State_Selection_Chart.Series[0].ChartType = SeriesChartType.Line;
                    Covid19_State_Selection_Chart.Series[0].Points.DataBindXY(x, y);
                    Covid19_State_Selection_Chart.Legends[0].Enabled = true;
                    Covid19_State_Selection_Chart.ChartAreas[0].Area3DStyle.Enable3D = false;
                    Covid19_State_Selection_Chart.ChartAreas[0].AxisX.Title = "Time";
                    Covid19_State_Selection_Chart.ChartAreas[0].AxisY.Title = " Confirmed Cases";

                    Covid19_State_Selection_Death_Chart.Series[0].ChartType = SeriesChartType.Line;
                    Covid19_State_Selection_Death_Chart.Series[0].Points.DataBindXY(x, y1);
                    Covid19_State_Selection_Death_Chart.Legends[0].Enabled = true;
                    Covid19_State_Selection_Death_Chart.ChartAreas[0].Area3DStyle.Enable3D = false;
                    Covid19_State_Selection_Death_Chart.ChartAreas[0].AxisX.Title = "Time";
                    Covid19_State_Selection_Death_Chart.Series[0].Font = new Font("Georgia", 14, FontStyle.Bold);
                    Covid19_State_Selection_Death_Chart.ChartAreas[0].AxisY.Title = "Deaths";
                    Covid19_State_Selection_Death_Chart.Series[0].Font = new Font("Georgia", 14, FontStyle.Bold);

                    //Covid19_State_Selection_Chart.Series[1].ChartType = SeriesChartType.Line;
                    //Covid19_State_Selection_Chart.Series[1].Points.DataBindXY(x, y1);
                    //Covid19_State_Selection_Chart.Legends[1].Enabled = false;
                    //Covid19_State_Selection_Chart.ChartAreas[1].Area3DStyle.Enable3D = false;
                    //Covid19_State_Selection_Chart.ChartAreas[1].AxisX.Interval = 1;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private static DataTable GetData(string query)
        {
            string constr = @"Data Source = 173.217.234.232\SQLEXPRESS,20222; Database = CovidData; User Id = apeuser2; Password = daylonswallows1234;";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        private void GetData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
