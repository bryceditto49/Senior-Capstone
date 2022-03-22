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

        string statePersons;
        string stateProperty;
        string stateSociety;
        private void PersonsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            statePersons = PersonsComboBox.Text;

            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = '{statePersons}'";

                    SqlCommand cmdtotalpersons = conn.CreateCommand();
                    cmdtotalpersons.CommandText = query1;
                    USStateInfo.overviewtotalpersons = (Int32)cmdtotalpersons.ExecuteScalar();
                    TotalCrimesAgainstPersonsStateTotal.Text = USStateInfo.overviewtotalpersons.ToString();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void continueFBIStateView_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBIStateDashboard form4 = new FBIStateDashboard();
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

            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
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

            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
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
    }
}

