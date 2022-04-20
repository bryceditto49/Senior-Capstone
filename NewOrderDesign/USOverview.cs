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
using LiveCharts;

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
        public static Int16 overviewtotalarson;
        public static Int16 overviewtotalbribery;
        public static Int32 overviewtotalburglary;
        public static Int32 overviewtotalcounterfeiting;
        public static Int32 overviewtotaldestruction;
        public static Int16 overviewtotalembezzlement;
        public static Int16 overviewtotalextortion;
        public static Int32 overviewtotalfraud;
        public static Int32 overviewtotallarceny;
        public static Int32 overviewtotalmotor;
        public static Int32 overviewtotalrobbery;
        public static Int32 overviewtotalstolen;
        public static Int16 overviewtotalanimal;
        public static Int32 overviewtotaldrug;
        public static Int16 overviewtotalgambling;
        public static Int16 overviewtotalpornography;
        public static Int16 overviewtotalprostitution;
        public static Int32 overviewtotalweapon;


        public USOverview()
        {
            InitializeComponent();
            PersonsComboBox.SelectedItem = "Assault";
            PropertyComboBox.SelectedItem = "Arson";
            SocietyComboBox.SelectedItem = "Animal Cruelty";
        }

        Func<ChartPoint, string> label = chartpoint => String.Format("{0} ({1:P)", chartpoint.Y, chartpoint.Participation);
        private void USOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Society_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIDataSet5.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Property_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIDataSet5.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet5.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIDataSet5.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020);

            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
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
            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
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

            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (PersonsComboBox.Text.Equals("Assault"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Assault_Offenses, Total_Offenses";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                      orderby p.Field<int>("Assault_Offenses") ascending
                                      select p.Field<int>("Assault_Offenses")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView3.Hide();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Homicide"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Homicide_Offenses, Total_Offenses";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<Int16>("Homicide_Offenses") ascending
                                   select p.Field<Int16>("Homicide_Offenses")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView3.Hide();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Human Trafficking"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Human_Trafficking, Total_Offenses";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<Int16>("Human_Trafficking") ascending
                                   select p.Field<Int16>("Human_Trafficking")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView3.Hide();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Kidnapping/Abduction"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Kidnapping_Abduction, Total_Offenses";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<Int16>("Kidnapping_Abduction") ascending
                                   select p.Field<Int16>("Kidnapping_Abduction")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView3.Hide();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Sex Offenses"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Sex_Offenses, Total_Offenses";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Sex_Offenses") ascending
                                   select p.Field<int>("Sex_Offenses")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView3.Hide();


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
            USStateInfo form4 = new USStateInfo();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSelection form2 = new DataSelection();
            form2.Show();
        }

        private void PropertyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (PropertyComboBox.Text.Equals("Arson"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Arson, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<Int16>("Arson") ascending
                                   select p.Field<Int16>("Arson")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Bribery"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Bribery, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<Int16>("Bribery") ascending
                                   select p.Field<Int16>("Bribery")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Burglary / Breaking & Entering"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Burglary_Breaking_Entering, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Burglary_Breaking_Entering") ascending
                                   select p.Field<int>("Burglary_Breaking_Entering")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Counterfeiting / Forgery"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Counterfeiting_Forgery, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Counterfeiting_Forgery") ascending
                                   select p.Field<int>("Counterfeiting_Forgery")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Destruction / Damage / Vandalism"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Destruction_Damage_Vandalism, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Destruction_Damage_Vandalism") ascending
                                   select p.Field<int>("Destruction_Damage_Vandalism")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Embezzlement"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Embezzlement, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<Int16>("Embezzlement") ascending
                                   select p.Field<Int16>("Embezzlement")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Extortion / Blackmail"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Extortion_Blackmail, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<Int16>("Extortion_Blackmail") ascending
                                   select p.Field<Int16>("Extortion_Blackmail")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Fraud"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Fraud_Offenses, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Fraud_Offenses") ascending
                                   select p.Field<int>("Fraud_Offenses")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Larceny / Theft"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Larceny_Theft_Offenses, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Larceny_Theft_Offenses") ascending
                                   select p.Field<int>("Larceny_Theft_Offenses")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Motor Vehicle Theft"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Motor_Vehicle_Theft, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Motor_Vehicle_Theft") ascending
                                   select p.Field<int>("Motor_Vehicle_Theft")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Robbery"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Robbery, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Robbery") ascending
                                   select p.Field<int>("Robbery")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Stolen Property"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Stolen_Property_Offenses, Total_Offenses";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] x = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Stolen_Property_Offenses") ascending
                                   select p.Field<int>("Stolen_Property_Offenses")).ToArray();

                        int[] y = (from p in dt.AsEnumerable()
                                   orderby p.Field<int>("Total_Offenses") ascending
                                   select p.Field<int>("Total_Offenses")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                        overviewdataGridView2.Hide();

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

        private void SocietyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = @"Server = 173.217.234.232\SQLEXPRESS,20222; Database = FBI; User Id = apeuser2; Password = daylonswallows1234;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (SocietyComboBox.Text.Equals("Animal Cruelty"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Animal_Cruelty FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalanimal = conn.CreateCommand();
                        cmdtotalanimal.CommandText = query1;
                        USOverview.overviewtotalanimal = (Int16)cmdtotalanimal.ExecuteScalar();
                        TotalCrimesAgainstSocietyTabLabel1.Text = USOverview.overviewtotalanimal.ToString();

                        conn.Close();
                    }
                    else if (SocietyComboBox.Text.Equals("Drug / Narcotics"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Drug_Narcotic_Offenses FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotaldrug = conn.CreateCommand();
                        cmdtotaldrug.CommandText = query1;
                        USOverview.overviewtotaldrug = (Int32)cmdtotaldrug.ExecuteScalar();
                        TotalCrimesAgainstSocietyTabLabel1.Text = USOverview.overviewtotaldrug.ToString();

                        conn.Close();
                    }
                    if (SocietyComboBox.Text.Equals("Gambling"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Gambling_Offenses FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalgambling = conn.CreateCommand();
                        cmdtotalgambling.CommandText = query1;
                        USOverview.overviewtotalgambling = (Int16)cmdtotalgambling.ExecuteScalar();
                        TotalCrimesAgainstSocietyTabLabel1.Text = USOverview.overviewtotalgambling.ToString();

                        conn.Close();
                    }
                    if (SocietyComboBox.Text.Equals("Pornography / Obscene Material"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Pornography_Obscene_Material FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalpornography = conn.CreateCommand();
                        cmdtotalpornography.CommandText = query1;
                        USOverview.overviewtotalpornography = (Int16)cmdtotalpornography.ExecuteScalar();
                        TotalCrimesAgainstSocietyTabLabel1.Text = USOverview.overviewtotalpornography.ToString();

                        conn.Close();
                    }
                    if (SocietyComboBox.Text.Equals("Prostitution"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Prostitution_Offenses FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalprostitution = conn.CreateCommand();
                        cmdtotalprostitution.CommandText = query1;
                        USOverview.overviewtotalprostitution = (Int16)cmdtotalprostitution.ExecuteScalar();
                        TotalCrimesAgainstSocietyTabLabel1.Text = USOverview.overviewtotalprostitution.ToString();

                        conn.Close();
                    }
                    if (SocietyComboBox.Text.Equals("Weapon Law Violations"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Weapon_Law_Violations FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalweapon = conn.CreateCommand();
                        cmdtotalweapon.CommandText = query1;
                        USOverview.overviewtotalweapon = (Int32)cmdtotalweapon.ExecuteScalar();
                        TotalCrimesAgainstSocietyTabLabel1.Text = USOverview.overviewtotalweapon.ToString();

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



        private void OverviewTab_Click(object sender, EventArgs e)
        {

        }
    }
}

