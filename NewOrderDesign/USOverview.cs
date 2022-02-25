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
    public partial class USOverview : Form
    {
        //Global variables
        public static Int32 overviewtotalpersons;
        public static Int32 overviewtotalproperty;
        public static Int32 overviewtotalsociety;
        public static Int32 overviewtotalassault;
        public static Int16 overviewtotalhomicide;
        public static Int16 overviewtotalhumantrafficking;
        public static Int16 overviewtotalkidnapping;
        public static Int32 overviewtotalsex;
        public USOverview()
        {
            InitializeComponent();
            PersonsComboBox.SelectedItem = "Assault";
            PropertyComboBox.SelectedItem = "Arson";
            SocietyComboBox.SelectedItem = "Animal Cruelty";
        }

        private void USOverview_Load(object sender, EventArgs e)
        {
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                    string query2 = $"SELECT Total_Offenses FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                    string query3 = $"SELECT Total_Offenses FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                    SqlCommand cmdtotalpersons = conn.CreateCommand();
                    cmdtotalpersons.CommandText = query1;
                    USOverview.overviewtotalpersons = (Int32)cmdtotalpersons.ExecuteScalar();
                    TotalCrimesAgainstPersonsLabel.Text = USOverview.overviewtotalpersons.ToString();

                    SqlCommand cmdtotalproperty = conn.CreateCommand();
                    cmdtotalproperty.CommandText = query2;
                    USOverview.overviewtotalproperty = (Int32)cmdtotalproperty.ExecuteScalar();
                    TotalCrimesAgainstPropertyLabel.Text = USOverview.overviewtotalproperty.ToString();

                    SqlCommand cmdtotalsociety = conn.CreateCommand();
                    cmdtotalsociety.CommandText = query3;
                    USOverview.overviewtotalsociety = (Int32)cmdtotalsociety.ExecuteScalar();
                    TotalCrimesAgainstSocietyLabel.Text = USOverview.overviewtotalsociety.ToString();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }

        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query1 = $"SELECT Assault_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                    string query2 = $"";
                    string query3 = $"";

                    SqlCommand cmdtotalassault = conn.CreateCommand();
                    cmdtotalassault.CommandText = query1;
                    USOverview.overviewtotalassault = (Int32)cmdtotalassault.ExecuteScalar();
                    TotalCrimesAgainstPersonsTabLabel1.Text = USOverview.overviewtotalassault.ToString();

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

            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (PersonsComboBox.Text.Equals("Assault"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Assault_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalassault = conn.CreateCommand();
                        cmdtotalassault.CommandText = query1;
                        USOverview.overviewtotalassault = (Int32)cmdtotalassault.ExecuteScalar();
                        TotalCrimesAgainstPersonsTabLabel1.Text = USOverview.overviewtotalassault.ToString();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Homicide"))
                    {
                        conn.Open();

                        string query2 = $"SELECT Homicide_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalhomicide = conn.CreateCommand();
                        cmdtotalhomicide.CommandText = query2;
                        Console.WriteLine("Here");
                        USOverview.overviewtotalhomicide = (Int16)cmdtotalhomicide.ExecuteScalar();
                        TotalCrimesAgainstPersonsTabLabel1.Text = USOverview.overviewtotalhomicide.ToString();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Human Trafficking"))
                    {
                        conn.Open();

                        string query3 = $"SELECT Human_Trafficking FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalhumantrafficking = conn.CreateCommand();
                        cmdtotalhumantrafficking.CommandText = query3;
                        Console.WriteLine("Here");
                        USOverview.overviewtotalhumantrafficking = (Int16)cmdtotalhumantrafficking.ExecuteScalar();
                        TotalCrimesAgainstPersonsTabLabel1.Text = USOverview.overviewtotalhumantrafficking.ToString();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Kidnapping / Abduction"))
                    {
                        conn.Open();

                        string query3 = $"SELECT Kidnapping_Abduction FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalkidnapping = conn.CreateCommand();
                        cmdtotalkidnapping.CommandText = query3;
                        USOverview.overviewtotalkidnapping = (Int16)cmdtotalkidnapping.ExecuteScalar();
                        TotalCrimesAgainstPersonsTabLabel1.Text = USOverview.overviewtotalkidnapping.ToString();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Sex Offenses"))
                    {
                        conn.Open();

                        string query3 = $"SELECT Sex_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalsex = conn.CreateCommand();
                        cmdtotalsex.CommandText = query3;
                        USOverview.overviewtotalsex = (Int32)cmdtotalsex.ExecuteScalar();
                        TotalCrimesAgainstPersonsTabLabel1.Text = USOverview.overviewtotalsex.ToString();

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void continueFBIUSView_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBIStateDashboard form4 = new FBIStateDashboard();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSelection form2 = new DataSelection();
            form2.Show();
        }
    }
}
