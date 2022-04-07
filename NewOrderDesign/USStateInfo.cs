﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms.DataVisualization.Charting;

namespace NewOrderDesign
{
    public partial class USStateInfo : Form
    {
        public static Int32 overviewtotalpersons;
        public static Int32 overviewtotalproperty;
        public static Int32 overviewtotalsociety;

        public USStateInfo()
        {
            InitializeComponent();
            PersonsComboBox.SelectedItem = "Alabama";
            PropertyComboBox.SelectedItem = "Alabama";
            SocietyComboBox.SelectedItem = "Alabama";
        }

        Func<ChartPoint, string> label = chartpoint => String.Format("{0} ({1:P)", chartpoint.Y, chartpoint.Participation);


        string statePersons;
        string stateProperty;
        string stateSociety;
        private void PersonsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            statePersons = PersonsComboBox.Text;

            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows1234;";
            try
            {
                /*
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = '{statePersons}'";

                    SqlCommand cmdtotalpersons = conn.CreateCommand();
                    cmdtotalpersons.CommandText = query1;
                    USStateInfo.overviewtotalpersons = (Int32)cmdtotalpersons.ExecuteScalar();
                    TotalCrimesAgainstPersonsStateTotal.Text = USStateInfo.overviewtotalpersons.ToString();
                }
                */

                //Fetch the Statistical data from database.
                string query = $"SELECT State, Total_Offenses";
                query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020";
                DataTable dt = GetData(query);

                //Get the names of states.
                string[] x = (from p in dt.AsEnumerable()
                              orderby p.Field<string>("State") ascending
                              select p.Field<string>("State")).ToArray();

                //Get the Total of Amount of Crime for each state.
                int[] y = (from p in dt.AsEnumerable()
                           orderby p.Field<string>("State") ascending
                           select p.Field<int>("Total_Offenses")).ToArray();

       

                chart1.Series[0].ChartType = SeriesChartType.Pie;
                chart1.Series[0].Points.DataBindXY(x, y);
                chart1.Legends[0].Enabled = true;
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                dataGridView1.Hide();
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private static DataTable GetData(string query)
        {
            string constr = @"Data Source=74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows1234;";
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
        private void continueFBIStateView_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBIViewMore form4 = new FBIViewMore();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            USOverview form2 = new USOverview();
            form2.Show();
        }

        private void PropertyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stateProperty = PersonsComboBox.Text;

            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows1234;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT Total_Offenses FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateProperty}'";

                    SqlCommand cmdtotalproperty = conn.CreateCommand();
                    cmdtotalproperty.CommandText = query1;
                    USStateInfo.overviewtotalproperty = (Int32)cmdtotalproperty.ExecuteScalar();
                    TotalCrimesAgainstPropertyStateTotal.Text = USStateInfo.overviewtotalproperty.ToString();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void SocietyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stateSociety = SocietyComboBox.Text;

            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows1234;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT Total_Offenses FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateProperty}'";

                    SqlCommand cmdtotalsociety = conn.CreateCommand();
                    cmdtotalsociety.CommandText = query1;
                    USStateInfo.overviewtotalsociety = (Int32)cmdtotalsociety.ExecuteScalar();
                    TotalCrimesAgainstSocietyStateTotal.Text = USStateInfo.overviewtotalsociety.ToString();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void USStateInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fBIPropertyDataSet.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Property_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIPropertyDataSet.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet2.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Society_Offenses_Offense_Category_by_State_2020TableAdapter.Fill(this.fBIDataSet2.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet1.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter.Fill(this.fBIDataSet1.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020);

        }
    }
}

