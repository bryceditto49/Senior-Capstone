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
            if (Form6.fullscreentoggle == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
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
                    string query2 = $"SELECT State, Assault_Offenses, Homicide_Offenses, Human_Trafficking, Kidnapping_Abduction, Sex_Offenses, Percentages";
                    query2 += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = '{statePersons}'";
                    DataTable dt = GetData(query2);
                    DataTable dt2 = GetData(query);

                    //Get the names of the crime.
                    string[] x = new string[] { "Assault" };
                    string[] x1 = new string[] { "Homicide" };
                    string[] x2 = new string[] { "Human Trafficking" };
                    string[] x3 = new string[] { "Kidnapping/Abduction" };
                    string[] x4 = new string[] { "Sex Offenses" };

                    string[] bargraphstaticname = new string[] { "National Average" };
                    string[] bargraphdynamicname = new string[] { statePersons };

                    double[] bargraphstaticnum = new double[] { 1.26 };

                    //Get the Total of Amount of Crime for each state.
                    int[] y = (from p in dt.AsEnumerable()
                               select p.Field<int>("Assault_Offenses")).ToArray();

                    Int16[] y1 = (from p in dt.AsEnumerable()
                               select p.Field<Int16>("Homicide_Offenses")).ToArray();

                    Int16[] y2 = (from p in dt.AsEnumerable()
                               select p.Field<Int16>("Human_Trafficking")).ToArray();

                    Int16[] y3 = (from p in dt.AsEnumerable()
                                  select p.Field<Int16>("Kidnapping_Abduction")).ToArray();

                    int[] y4 = (from p in dt.AsEnumerable()
                               select p.Field<int>("Sex_Offenses")).ToArray();

                    string[] totalchart = (from p in dt2.AsEnumerable()
                                           select p.Field<string>("State")).ToArray();

                    int[] totalchartnumbers = (from p in dt2.AsEnumerable()
                                               select p.Field<int>("Total_Offenses")).ToArray();

                    double[] bargraphdynamicnum = (from p in dt.AsEnumerable()
                                                   select p.Field<double>("Percentages")).ToArray();


                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                    chart1.Series[0].Points.DataBindXY(x, y);
                    chart1.Series[0].Points.AddXY(x1[0], y1[0]);
                    chart1.Series[0].Points.AddXY(x2[0], y2[0]);
                    chart1.Series[0].Points.AddXY(x3[0], y3[0]);
                    chart1.Series[0].Points.AddXY(x4[0], y4[0]);
                    chart1.Legends[0].Enabled = true;
                    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                    chart1.Series[0]["PieLabelStyle"] = "Disabled";

                    chart4.Series[0].ChartType = SeriesChartType.Pie;
                    chart4.Series[0].Points.DataBindXY(totalchart, totalchartnumbers);
                    chart4.Legends[0].Enabled = true;
                    chart4.ChartAreas[0].Area3DStyle.Enable3D = true;

                    chart7.Series[0].ChartType = SeriesChartType.Column;
                    chart7.Series[0].Points.DataBindXY(bargraphstaticname, bargraphstaticnum);
                    chart7.Series[0].Points.AddXY(bargraphdynamicname[0], bargraphdynamicnum[0]);
                    chart7.Legends[0].Enabled = false;
                    chart7.ChartAreas[0].Area3DStyle.Enable3D = false;

                    dataGridView7.Hide();
                    dataGridView4.Hide();
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
            Form6.fullscreencheck(this);
            FBIViewMore form4 = new FBIViewMore();
            
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6.fullscreencheck(this);
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

                    string query2 = $"SELECT Arson, Bribery, Burglary_Breaking_Entering, Counterfeiting_Forgery, Destruction_Damage_Vandalism, Embezzlement, Extortion_Blackmail, Fraud_Offenses, Larceny_Theft_Offenses, Motor_Vehicle_Theft, Robbery, Stolen_Property_Offenses, Percentages";
                    query2 += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateProperty}'";

                    DataTable dt = GetData(query2);
                    DataTable dt2 = GetData(query);

                    //Get the names of states.
                    string[] x = new string[] { "Arson" };
                    string[] x1 = new string[] { "Bribery" };
                    string[] x2 = new string[] { "Burglary/Breaking and Entering" };
                    string[] x3 = new string[] { "Counterfeiting/Forgery" };
                    string[] x4 = new string[] { "Destruction/Damage/Vandalism" };
                    string[] x5 = new string[] { "Embezzlement" };
                    string[] x6 = new string[] { "Extortion/Blackmail" };
                    string[] x7 = new string[] { "Fraud" };
                    string[] x8 = new string[] { "Larceny/Theft" };
                    string[] x9 = new string[] { "Motor Vehicle Theft" };
                    string[] x10 = new string[] { "Robbery" };
                    string[] x11 = new string[] { "Stolen Property" };

                    string[] bargraphstaticname = new string[] { "National Average" };
                    string[] bargraphdynamicname = new string[] { stateProperty };

                    double[] bargraphstaticnum = new double[] { 3.03 };

                    //Get the Total of Amount of Crime for each state.
                    Int16[] y = (from p in dt.AsEnumerable()
                               select p.Field<Int16>("Arson")).ToArray();

                    Int16[] y1 = (from p in dt.AsEnumerable()
                                  select p.Field<Int16>("Bribery")).ToArray();

                    int[] y2 = (from p in dt.AsEnumerable()
                                  select p.Field<int>("Burglary_Breaking_Entering")).ToArray();

                    int[] y3 = (from p in dt.AsEnumerable()
                                  select p.Field<int>("Counterfeiting_Forgery")).ToArray();

                    int[] y4 = (from p in dt.AsEnumerable()
                                select p.Field<int>("Destruction_Damage_Vandalism")).ToArray();

                    Int16[] y5 = (from p in dt.AsEnumerable()
                                  select p.Field<Int16>("Embezzlement")).ToArray();

                    Int16[] y6 = (from p in dt.AsEnumerable()
                                  select p.Field<Int16>("Extortion_Blackmail")).ToArray();

                    int[] y7 = (from p in dt.AsEnumerable()
                                select p.Field<int>("Fraud_Offenses")).ToArray();

                    int[] y8 = (from p in dt.AsEnumerable()
                                select p.Field<int>("Larceny_Theft_Offenses")).ToArray();

                    int[] y9 = (from p in dt.AsEnumerable()
                                select p.Field<int>("Motor_Vehicle_Theft")).ToArray();

                    int[] y10 = (from p in dt.AsEnumerable()
                                select p.Field<int>("Robbery")).ToArray();

                    int[] y11 = (from p in dt.AsEnumerable()
                                select p.Field<int>("Stolen_Property_Offenses")).ToArray();

                    string[] totalchart = (from p in dt2.AsEnumerable()
                                           select p.Field<string>("State")).ToArray();

                    int[] totalchartnumbers = (from p in dt2.AsEnumerable()
                                               select p.Field<int>("Total_Offenses")).ToArray();

                    double[] bargraphdynamicnum = (from p in dt.AsEnumerable()
                                                   select p.Field<double>("Percentages")).ToArray();

                    chart2.Series[0].ChartType = SeriesChartType.Pie;
                    chart2.Series[0].Points.DataBindXY(x, y);
                    chart2.Series[0].Points.AddXY(x1[0], y1[0]);
                    chart2.Series[0].Points.AddXY(x2[0], y2[0]);
                    chart2.Series[0].Points.AddXY(x3[0], y3[0]);
                    chart2.Series[0].Points.AddXY(x4[0], y4[0]);
                    chart2.Series[0].Points.AddXY(x5[0], y5[0]);
                    chart2.Series[0].Points.AddXY(x6[0], y6[0]);
                    chart2.Series[0].Points.AddXY(x7[0], y7[0]);
                    chart2.Series[0].Points.AddXY(x8[0], y8[0]);
                    chart2.Series[0].Points.AddXY(x9[0], y9[0]);
                    chart2.Series[0].Points.AddXY(x10[0], y10[0]);
                    chart2.Series[0].Points.AddXY(x11[0], y11[0]);
                    chart2.Legends[0].Enabled = true;
                    chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
                    chart2.Series[0]["PieLabelStyle"] = "Disabled";

                    chart5.Series[0].ChartType = SeriesChartType.Pie;
                    chart5.Series[0].Points.DataBindXY(totalchart, totalchartnumbers);
                    chart5.Legends[0].Enabled = true;
                    chart5.ChartAreas[0].Area3DStyle.Enable3D = true;

                    chart8.Series[0].ChartType = SeriesChartType.Column;
                    chart8.Series[0].Points.DataBindXY(bargraphstaticname, bargraphstaticnum);
                    chart8.Series[0].Points.AddXY(bargraphdynamicname[0], bargraphdynamicnum[0]);
                    chart8.Legends[0].Enabled = false;
                    chart8.ChartAreas[0].Area3DStyle.Enable3D = false;

                    dataGridView8.Hide();
                    dataGridView5.Hide();
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

                    string query2 = $"SELECT Animal_Cruelty, Drug_Narcotic_Offenses, Gambling_Offenses, Pornography_Obscene_Material, Prostitution_Offenses, Weapon_Law_Violations, Percentages";
                    query2 += $" FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = '{stateSociety}'";

                    DataTable dt = GetData(query2);
                    DataTable dt2 = GetData(query);

                    //Get the names of states.
                    string[] x = new string[] { "Animal Cruelty" };
                    string[] x1 = new string[] { "Drugs/Narcotics" };
                    string[] x2 = new string[] { "Gambling" };
                    string[] x3 = new string[] { "Pornography/Obscene Material" };
                    string[] x4 = new string[] { "Prostitution" };
                    string[] x5 = new string[] { "Weapon Law Violations" };

                    string[] bargraphstaticname = new string[] { "National Average" };
                    string[] bargraphdynamicname = new string[] { stateSociety };

                    double[] bargraphstaticnum = new double[] { 0.72 };

                    //Get the Total of Amount of Crime for each state.
                    Int16[] y = (from p in dt.AsEnumerable()
                                 select p.Field<Int16>("Animal_Cruelty")).ToArray();

                    int[] y1 = (from p in dt.AsEnumerable()
                                select p.Field<int>("Drug_Narcotic_Offenses")).ToArray();

                    Int16[] y2 = (from p in dt.AsEnumerable()
                                  select p.Field<Int16>("Gambling_Offenses")).ToArray();

                    Int16[] y3 = (from p in dt.AsEnumerable()
                                  select p.Field<Int16>("Pornography_Obscene_Material")).ToArray();

                    Int16[] y4 = (from p in dt.AsEnumerable()
                                  select p.Field<Int16>("Prostitution_Offenses")).ToArray();

                    int[] y5 = (from p in dt.AsEnumerable()
                                select p.Field<int>("Weapon_Law_Violations")).ToArray();

                    string[] totalchart = (from p in dt2.AsEnumerable()
                                           select p.Field<string>("State")).ToArray();

                    int[] totalchartnumbers = (from p in dt2.AsEnumerable()
                                               select p.Field<int>("Total_Offenses")).ToArray();

                    double[] bargraphdynamicnum = (from p in dt.AsEnumerable()
                                                   select p.Field<double>("Percentages")).ToArray();


                    chart3.Series[0].ChartType = SeriesChartType.Pie;
                    chart3.Series[0].Points.DataBindXY(x, y);
                    chart3.Series[0].Points.AddXY(x1[0], y1[0]);
                    chart3.Series[0].Points.AddXY(x2[0], y2[0]);
                    chart3.Series[0].Points.AddXY(x3[0], y3[0]);
                    chart3.Series[0].Points.AddXY(x4[0], y4[0]);
                    chart3.Series[0].Points.AddXY(x5[0], y5[0]);
                    chart3.Legends[0].Enabled = true;
                    chart3.ChartAreas[0].Area3DStyle.Enable3D = true;
                    chart3.Series[0]["PieLabelStyle"] = "Disabled";

                    chart6.Series[0].ChartType = SeriesChartType.Pie;
                    chart6.Series[0].Points.DataBindXY(totalchart, totalchartnumbers);
                    chart6.Legends[0].Enabled = true;
                    chart6.ChartAreas[0].Area3DStyle.Enable3D = true;

                    chart9.Series[0].ChartType = SeriesChartType.Column;
                    chart9.Series[0].Points.DataBindXY(bargraphstaticname, bargraphstaticnum);
                    chart9.Series[0].Points.AddXY(bargraphdynamicname[0], bargraphdynamicnum[0]);
                    chart9.Legends[0].Enabled = false;
                    chart9.ChartAreas[0].Area3DStyle.Enable3D = false;

                    dataGridView9.Hide();
                    dataGridView6.Hide();
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
            // TODO: This line of code loads data into the 'barGraphDataSet.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Property_Offenses_Offense_Category_by_State_2020TableAdapter3.Fill(this.barGraphDataSet.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'barGraphDataSet.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Society_Offenses_Offense_Category_by_State_2020TableAdapter2.Fill(this.barGraphDataSet.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'barGraphDataSet.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Property_Offenses_Offense_Category_by_State_2020TableAdapter3.Fill(this.barGraphDataSet.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'barGraphDataSet.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter2.Fill(this.barGraphDataSet.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Society_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIDataSet5.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Property_Offenses_Offense_Category_by_State_2020TableAdapter2.Fill(this.fBIDataSet5.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIDataSet5.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020);

        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void chart1_Click(object sender, EventArgs e)

        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void CrimesAgainstSocietyTab_Click(object sender, EventArgs e)
        {

        }
    }
}

