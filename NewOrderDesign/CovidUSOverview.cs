using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NewOrderDesign
{
    public partial class CovidUSOverview : Form
    {
        public static Int32 confirmed_cases;
        public static Int32 deaths;
        public static Int32 overviewTotalCases;

        public CovidUSOverview()
        {
            InitializeComponent();
            PersonsComboBox.SelectedItem = "Alabama";
        }

        string stateCovid;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSelection form2 = new DataSelection();
            form2.Show();
        }


        private void OverviewTab_Click(object sender, EventArgs e)
        {
            
        }
        private void PersonsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            stateCovid = PersonsComboBox.Text;

            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = CovidData; User Id = apeuser; Password = daylonswallows123;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT SUM(confirmed_cases) FROM states WHERE state_name = '{stateCovid}'";
                    string query2 = $"SELECT SUM(deaths) FROM states WHERE state_name = '{stateCovid}'";

                    SqlCommand cmdStateCases = conn.CreateCommand();
                    cmdStateCases.CommandText = query1;
                    CovidUSOverview.overviewTotalCases = (Int32)cmdStateCases.ExecuteScalar();
                    TotalStateCovidResultsLabel1.Text = CovidUSOverview.overviewTotalCases.ToString();

                    SqlCommand cmdStateDeaths = conn.CreateCommand();
                    cmdStateDeaths.CommandText = query2;
                    CovidUSOverview.deaths = (Int32)cmdStateDeaths.ExecuteScalar();
                    TotalStateCovidResultsLabel2.Text = CovidUSOverview.deaths.ToString();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RawDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CovidStateData CovidStateData = new CovidStateData();
            CovidStateData.Show();
        }

        private void CovidUSOverview_Load(object sender, EventArgs e)
        {
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = CovidData; User Id = apeuser; Password = daylonswallows123;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT SUM(confirmed_cases) FROM states; ";
                    string query2 = $"SELECT sum(deaths) FROM states";

                    SqlCommand cmdconfirmedcases = conn.CreateCommand();
                    cmdconfirmedcases.CommandText = query1;
                    CovidUSOverview.confirmed_cases = (Int32)cmdconfirmedcases.ExecuteScalar();
                    CovidUSTotalLabel.Text = CovidUSOverview.confirmed_cases.ToString();

                    SqlCommand cmddeaths = conn.CreateCommand();
                    cmddeaths.CommandText = query2;
                    CovidUSOverview.deaths = (Int32)cmddeaths.ExecuteScalar();
                    CovidUSTotalLabel2.Text = CovidUSOverview.deaths.ToString();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }

}
