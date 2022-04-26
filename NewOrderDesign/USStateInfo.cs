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

            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    //Fetch the Statistical data from database.
                    //this below code is to grab population from SQL
                    string queryPopulation = $"SELECT Population_Covered FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = '{statePersons}'";
                    SqlCommand cmdtotalPop = conn.CreateCommand();
                    cmdtotalPop.CommandText = queryPopulation;
                    totalPopulation = (Int32)cmdtotalPop.ExecuteScalar();
                    label3.Text = totalPopulation.ToString();
                    //this below code is to grab percentage of crime per citizen
                    string queryPerCapita = $"SELECT Percentages FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = '{statePersons}'";
                    SqlCommand cmdPerCapita = conn.CreateCommand();
                    cmdPerCapita.CommandText = queryPerCapita;
                    double percent;
                    percent = (double)cmdPerCapita.ExecuteScalar();
                    perCapita = (percent / 100) * 1000;
                    label4.Text = perCapita.ToString();

                    string query = $"SELECT State, Total_Offenses";
                    query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = '{statePersons}' OR State = 'Total'";
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
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private static DataTable GetData(string query)
        {
            string constr = @"Data Source = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
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
            stateProperty = PropertyComboBox.Text;

            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    //Fetch the Statistical data from database.
                    //this below code is to grab population from SQL
                    string queryPopulation = $"SELECT Population_Covered FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateProperty}'";
                    SqlCommand cmdtotalPop = conn.CreateCommand();
                    cmdtotalPop.CommandText = queryPopulation;
                    totalPopulation = (Int32)cmdtotalPop.ExecuteScalar();
                    label7.Text = totalPopulation.ToString();
                    //this below code is to grab percentage of crime per citizen
                    string queryPerCapita = $"SELECT Percentages FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateProperty}'";
                    SqlCommand cmdPerCapita = conn.CreateCommand();
                    cmdPerCapita.CommandText = queryPerCapita;
                    double percent;
                    percent = (double)cmdPerCapita.ExecuteScalar();
                    perCapita = (percent / 100) * 1000;
                    label8.Text = perCapita.ToString();


                    string query = $"SELECT State, Total_Offenses";
                    query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateProperty}' or State = 'Total'";
                    DataTable dt = GetData(query);

                    //Get the names of states.
                    string[] x = (from p in dt.AsEnumerable()
                                  orderby p.Field<string>("State") ascending
                                  select p.Field<string>("State")).ToArray();

                    //Get the Total of Amount of Crime for each state.
                    int[] y = (from p in dt.AsEnumerable()
                               orderby p.Field<string>("State") ascending
                               select p.Field<int>("Total_Offenses")).ToArray();



                    chart2.Series[0].ChartType = SeriesChartType.Pie;
                    chart2.Series[0].Points.DataBindXY(x, y);
                    chart2.Legends[0].Enabled = true;
                    chart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                    dataGridView2.Hide();

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

            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {

                    conn.Open();
                    //Fetch the Statistical data from database.
                    //this below code is to grab population from SQL
                    string queryPopulation = $"SELECT Population_Covered FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateSociety}'";
                    SqlCommand cmdtotalPop = conn.CreateCommand();
                    cmdtotalPop.CommandText = queryPopulation;
                    totalPopulation = (Int32)cmdtotalPop.ExecuteScalar();
                    label11.Text = totalPopulation.ToString();
                    //this below code is to grab percentage of crime per citizen
                    string queryPerCapita = $"SELECT Percentages FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateSociety}'";
                    SqlCommand cmdPerCapita = conn.CreateCommand();
                    cmdPerCapita.CommandText = queryPerCapita;
                    double percent;
                    percent = (double)cmdPerCapita.ExecuteScalar();
                    perCapita = (percent / 100) * 1000;
                    label12.Text = perCapita.ToString();   


                    string query = $"SELECT State, Total_Offenses";
                    query += $" FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateSociety}' or State = 'Total'";
                    DataTable dt = GetData(query);

                    //Get the names of states.
                    string[] x = (from p in dt.AsEnumerable()
                                  orderby p.Field<string>("State") ascending
                                  select p.Field<string>("State")).ToArray();

                    //Get the Total of Amount of Crime for each state.
                    int[] y = (from p in dt.AsEnumerable()
                               orderby p.Field<string>("State") ascending
                               select p.Field<int>("Total_Offenses")).ToArray();



                    chart3.Series[0].ChartType = SeriesChartType.Pie;
                    chart3.Series[0].Points.DataBindXY(x, y);
                    chart3.Legends[0].Enabled = true;
                    chart3.ChartAreas[0].Area3DStyle.Enable3D = true;

                    dataGridView3.Hide();

                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        int totalPopulation = 0;
        double perCapita = 0;

        private void USStateInfo_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

