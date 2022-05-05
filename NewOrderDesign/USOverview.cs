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

                    string query1 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                    string query2 = $"SELECT Total_Offenses FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                    string query3 = $"SELECT Total_Offenses FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";

                    SqlCommand cmdtotalpersons = conn.CreateCommand();
                    cmdtotalpersons.CommandText = query1;
                    USOverview.overviewtotalpersons = (Int32)cmdtotalpersons.ExecuteScalar();

                    SqlCommand cmdtotalproperty = conn.CreateCommand();
                    cmdtotalproperty.CommandText = query2;
                    USOverview.overviewtotalproperty = (Int32)cmdtotalproperty.ExecuteScalar();

                    SqlCommand cmdtotalsociety = conn.CreateCommand();
                    cmdtotalsociety.CommandText = query3;
                    USOverview.overviewtotalsociety = (Int32)cmdtotalsociety.ExecuteScalar();

                    //third graph crime by state
                    string queryStatewise = $"SELECT [Participating_state_Federal], [Total_offenses]";
                    queryStatewise += $"FROM [FBI].[dbo].[Table_11_Offenses_Offense_Type_by_Participating_State_and_Federal_2020] WHERE NOT Participating_state_Federal = 'Total'";
                    DataTable dt3 = GetData(queryStatewise);

                    string[] x3 = (from p in dt3.AsEnumerable()
                                  select p.Field<string>("Participating_state_Federal")).ToArray();

                    Int16[] y3 = (from p in dt3.AsEnumerable()
                                  select p.Field<Int16>("Total_offenses")).ToArray();

                    chart3.Series[0].ChartType = SeriesChartType.Pie;
                    chart3.Series[0].Points.DataBindXY(x3, y3);
                    chart3.Legends[0].Enabled = false;
                    chart3.ChartAreas[0].Area3DStyle.Enable3D = false;
                    chart3.Series[0]["PieLabelStyle"] = "Disabled";

                    //crime by type-simplified
                    //Fetch the Statistical data from database.
                    string[] x2 = new string[] { "Property", "Society", "Persons" };
                    Int32[] y2 = new Int32[] { 5371269, 1273179, 2235280 };
                    chart2.Series[0].ChartType = SeriesChartType.Column;
                    chart2.Series[0].Points.DataBindXY(x2, y2);
                    chart2.Legends[0].Enabled = false;
                    chart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                    //Crime by type
                    //Fetch the Statistical data from database.
                    string query = $"SELECT [Total_offenses],[Murder_and_nonnegligent_manslaughter],[Rape1],[Aggravated_assault],[Simple_assault],[Intimidation],[Other2],[Robbery],[Burglary],[Larceny_theft],[Motor_vehicle_theft],[Arson],[Destruction_damage_vandalism]";
                    query += $" FROM [FBI].[dbo].[Table_11_Offenses_Offense_Type_by_Participating_State_and_Federal_2020] WHERE Participating_state_Federal = 'Total'";
                    DataTable dt1 = GetData(query);
                    Int32 murder = Convert.ToInt32(dt1.Rows[0]["Murder_and_nonnegligent_manslaughter"].ToString());
                    
                    Int32 rape = Convert.ToInt32(dt1.Rows[0]["Rape1"].ToString());
                    Int32 aggravatedassault = Convert.ToInt32(dt1.Rows[0]["Aggravated_assault"].ToString());
                    Int32 simpleassault = Convert.ToInt32(dt1.Rows[0]["Simple_assault"].ToString());
                    Int32 intimidation = Convert.ToInt32(dt1.Rows[0]["Intimidation"].ToString());
                    Int32 other = Convert.ToInt32(dt1.Rows[0]["Other2"].ToString());
                    Int32 robbery = Convert.ToInt32(dt1.Rows[0]["Robbery"].ToString());
                    Int32 burglary = Convert.ToInt32(dt1.Rows[0]["Burglary"].ToString());
                    Int32 gta = Convert.ToInt32(dt1.Rows[0]["Motor_vehicle_theft"].ToString());
                    Int32 arson = Convert.ToInt32(dt1.Rows[0]["Arson"].ToString());
                    Int32 larceny = Convert.ToInt32(dt1.Rows[0]["Larceny_theft"].ToString());
                    Int32 vandalism = Convert.ToInt32(dt1.Rows[0]["Destruction_damage_vandalism"].ToString());
                    string[] x1 = new string[] {"Homicide", "Sex Offenses", "Assault", "Kidnapping", "Robbery", "Burglary/B and E", "Motor Theft", "Arson", "Larceny/Theft", "Vandalism"};
                    Int32[] y1 = new Int32[] {murder, rape, aggravatedassault, simpleassault, robbery, burglary, gta, arson, larceny, vandalism};


                    chart1.Series[0].ChartType = SeriesChartType.Bar;
                    //overviewchart1.Series[0].Points.DataBindXY(murder,rape,aggravated_assault,simple_assault,intimidation,robbery,burglary,larceny,gta,arson,vandalism,other);
                    chart1.Series[0].Points.DataBindXY(x1, y1);
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    chart1.Legends[0].Enabled = false;
                    chart1.ChartAreas[0].Area3DStyle.Enable3D = false;

                    chart3.Hide();

                    overviewdataGridView3.Hide();
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
                    //crime by state
                    conn.Open();
                    /*
                    //Fetch the Statistical data from database.
                    string queryStatewise = $"SELECT [Participating_state_Federal], [Total_offenses], [Intimidation]";
                    queryStatewise += $"FROM [FBI].[dbo].[Table_11_Offenses_Offense_Type_by_Participating_State_and_Federal_2020] WHERE NOT Participating_state_Federal = 'Total'";
                    DataTable dt3 = GetData(queryStatewise);

                    Int16[] x3 = (from p in dt3.AsEnumerable()
                                 orderby p.Field<Int16>("Intimidation") ascending
                                 select p.Field<Int16>("Intimidation")).ToArray();

                    Int16[] y3 = (from p in dt3.AsEnumerable()
                                 orderby p.Field<Int16>("Total_offenses") ascending
                                 select p.Field<Int16>("Total_offenses")).ToArray();
                    chart3.Series[0].ChartType = SeriesChartType.Pie;
                    chart3.Series[0].Points.DataBindXY(x3, y3);
                    chart3.Legends[0].Enabled = false;
                    chart3.ChartAreas[0].Area3DStyle.Enable3D = true;

                    //crime by type-simplified
                    //Fetch the Statistical data from database.
                    string[] x2 = new string[] {"","",""};
                    Int32[] y2 = new Int32[] {5371269, 1273179, 2235280};
                    chart2.Series[0].ChartType = SeriesChartType.Pie;
                    chart2.Series[0].Points.DataBindXY(x2, y2);
                    chart2.Legends[0].Enabled = false;
                    chart2.ChartAreas[0].Area3DStyle.Enable3D = true;

                    //Crime by type
                    //Fetch the Statistical data from database.
                    string query = $"SELECT [Total_offenses],[Murder_and_nonnegligent_manslaughter],[Rape1],[Aggravated_assault],[Simple_assault],[Intimidation],[Other2],[Robbery],[Burglary],[Larceny_theft],[Motor_vehicle_theft],[Arson],[Destruction_damage_vandalism]";
                    query += $" FROM [FBI].[dbo].[Table_11_Offenses_Offense_Type_by_Participating_State_and_Federal_2020] WHERE Participating_state_Federal = 'Total'";
                    DataTable dt1 = GetData(query);
                    
                    Int16[] x1 = (from p in dt1.AsEnumerable()
                               orderby p.Field<Int16>("Total_offenses") ascending
                               select p.Field<Int16>("Total_offenses")).ToArray();

                    Int16[] y1 = (from p in dt1.AsEnumerable()
                               orderby p.Field<Int16>("Aggravated_assault") ascending
                               select p.Field<Int16>("Aggravated_assault")).ToArray();
             

                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                    //overviewchart1.Series[0].Points.DataBindXY(murder,rape,aggravated_assault,simple_assault,intimidation,robbery,burglary,larceny,gta,arson,vandalism,other);
                    chart1.Series[0].Points.DataBindXY(x1, y1);
                    chart1.Legends[0].Enabled = true;
                    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

                    overviewdataGridView3.Hide();
                    */
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
                        string query = $"SELECT Assault_Offenses, State";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                      select p.Field<int>("Assault_Offenses")).ToArray();                  

                        string[] x = (from p in dt.AsEnumerable()
                                   select p.Field<string>("State")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x,y);
                        overviewchart1.Palette = ChartColorPalette.None;
                        overviewchart1.PaletteCustomColors = new Color[] { Color.Aqua, Color.Black, Color.Blue, Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate, Color.Coral, Color.IndianRed, Color.Indigo, Color.Khaki, Color.LightBlue, Color.LightCoral, Color.LightGray, Color.LightGreen, Color.LightPink , Color.LightSalmon, Color.LightSeaGreen , Color.OliveDrab, Color.Tomato, Color.Yellow, Color.Turquoise, Color.DarkSalmon, Color.Crimson, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed, Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum , Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.SandyBrown, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle};
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = false;
                        overviewchart1.Series[0]["PieLabelStyle"] = "Disabled";
                        chart4.Series[0].ChartType = SeriesChartType.Bar;
                        chart4.Series[0].Points.DataBindXY(x, y);
                        chart4.Legends[0].Enabled = true;
                        chart4.ChartAreas[0].Area3DStyle.Enable3D = false;
                        chart4.Series[0]["PieLabelStyle"] = "Disabled";

                        overviewdataGridView3.Hide();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Homicide"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Homicide_Offenses, State";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                   select p.Field<Int16>("Homicide_Offenses")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView3.Hide();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Human Trafficking"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Human_Trafficking, State";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                   select p.Field<Int16>("Human_Trafficking")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView3.Hide();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Kidnapping/Abduction"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Kidnapping_Abduction, State";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                   select p.Field<Int16>("Kidnapping_Abduction")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView3.Hide();

                        conn.Close();
                    }
                    else if (PersonsComboBox.Text.Equals("Sex Offenses"))
                    {
                        conn.Open();
                        //Fetch the Statistical data from database.
                        string query = $"SELECT Sex_Offenses, State";
                        query += $" FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Sex_Offenses")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart1.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart1.Series[0].Points.DataBindXY(x, y);
                        overviewchart1.Legends[0].Enabled = true;
                        overviewchart1.ChartAreas[0].Area3DStyle.Enable3D = false;

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
                        string query = $"SELECT Arson, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                   select p.Field<Int16>("Arson")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Palette = ChartColorPalette.None;
                        overviewchart2.PaletteCustomColors = new Color[] { Color.Aqua, Color.Black, Color.Blue, Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate, Color.Coral, Color.IndianRed, Color.Indigo, Color.Khaki, Color.LightBlue, Color.LightCoral, Color.LightGray, Color.LightGreen, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.OliveDrab, Color.Tomato, Color.Yellow, Color.Turquoise, Color.DarkSalmon, Color.Crimson, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed, Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum, Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.SandyBrown, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle };
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;
                        overviewchart2.Series[0]["PieLabelStyle"] = "Disabled";

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Bribery"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Bribery, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                   select p.Field<Int16>("Bribery")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Burglary / Breaking & Entering"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Burglary_Breaking_Entering, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Burglary_Breaking_Entering")).ToArray();
                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Counterfeiting / Forgery"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Counterfeiting_Forgery, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Counterfeiting_Forgery")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Destruction / Damage / Vandalism"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Destruction_Damage_Vandalism, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Destruction_Damage_Vandalism")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Embezzlement"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Embezzlement, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                   select p.Field<Int16>("Embezzlement")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Extortion / Blackmail"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Extortion_Blackmail, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                   select p.Field<Int16>("Extortion_Blackmail")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Fraud"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Fraud_Offenses, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Fraud_Offenses")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Larceny / Theft"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Larceny_Theft_Offenses, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Larceny_Theft_Offenses")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Motor Vehicle Theft"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Motor_Vehicle_Theft, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Motor_Vehicle_Theft")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Robbery"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Robbery, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Robbery")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

                        overviewdataGridView2.Hide();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Stolen Property"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Stolen_Property_Offenses, State";
                        query += $" FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total' ORDER BY (CASE WHEN State = 'Alabama' THEN 1 ELSE 2 END)";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                   select p.Field<int>("Stolen_Property_Offenses")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart2.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart2.Series[0].Points.DataBindXY(x, y);
                        overviewchart2.Legends[0].Enabled = true;
                        overviewchart2.ChartAreas[0].Area3DStyle.Enable3D = false;

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

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Animal_Cruelty, State";
                        query += $" FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                   select p.Field<Int16>("Animal_Cruelty")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart3.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart3.Series[0].Points.DataBindXY(x, y);
                        overviewchart3.Palette = ChartColorPalette.None;
                        overviewchart3.PaletteCustomColors = new Color[] { Color.Aqua, Color.Black, Color.Blue, Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate, Color.Coral, Color.IndianRed, Color.Indigo, Color.Khaki, Color.LightBlue, Color.LightCoral, Color.LightGray, Color.LightGreen, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.OliveDrab, Color.Tomato, Color.Yellow, Color.Turquoise, Color.DarkSalmon, Color.Crimson, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed, Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum, Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.SandyBrown, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle };
                        overviewchart3.Legends[0].Enabled = true;
                        overviewchart3.ChartAreas[0].Area3DStyle.Enable3D = false;
                        overviewchart3.Series[0]["PieLabelStyle"] = "Disabled";

                        dataGridView1.Hide();

                        conn.Close();
                    }
                    else if (SocietyComboBox.Text.Equals("Drug / Narcotics"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Drug_Narcotic_Offenses, State";
                        query += $" FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                     select p.Field<int>("Drug_Narcotic_Offenses")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart3.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart3.Series[0].Points.DataBindXY(x, y);
                        overviewchart3.Legends[0].Enabled = true;
                        overviewchart3.ChartAreas[0].Area3DStyle.Enable3D = false;

                        dataGridView1.Hide();

                        conn.Close();
                    }
                    if (SocietyComboBox.Text.Equals("Gambling"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Gambling_Offenses, State";
                        query += $" FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                     select p.Field<Int16>("Gambling_Offenses")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart3.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart3.Series[0].Points.DataBindXY(x, y);
                        overviewchart3.Legends[0].Enabled = true;
                        overviewchart3.ChartAreas[0].Area3DStyle.Enable3D = false;

                        dataGridView1.Hide();

                        conn.Close();
                    }
                    if (SocietyComboBox.Text.Equals("Pornography / Obscene Material"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Pornography_Obscene_Material, State";
                        query += $" FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                     select p.Field<Int16>("Pornography_Obscene_Material")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart3.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart3.Series[0].Points.DataBindXY(x, y);
                        overviewchart3.Legends[0].Enabled = true;
                        overviewchart3.ChartAreas[0].Area3DStyle.Enable3D = false;

                        dataGridView1.Hide();

                        conn.Close();
                    }
                    if (SocietyComboBox.Text.Equals("Prostitution"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Prostitution_Offenses, State";
                        query += $" FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        Int16[] y = (from p in dt.AsEnumerable()
                                     select p.Field<Int16>("Prostitution_Offenses")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart3.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart3.Series[0].Points.DataBindXY(x, y);
                        overviewchart3.Legends[0].Enabled = true;
                        overviewchart3.ChartAreas[0].Area3DStyle.Enable3D = false;

                        dataGridView1.Hide();

                        conn.Close();
                    }
                    if (SocietyComboBox.Text.Equals("Weapon Law Violations"))
                    {
                        conn.Open();

                        //Fetch the Statistical data from database.
                        string query = $"SELECT Weapon_Law_Violations, State";
                        query += $" FROM Crimes_Against_Society_Offenses_Offense_Category_by_State_2020 WHERE NOT State = 'Total'";
                        DataTable dt = GetData(query);

                        int[] y = (from p in dt.AsEnumerable()
                                     select p.Field<int>("Weapon_Law_Violations")).ToArray();

                        string[] x = (from p in dt.AsEnumerable()
                                      select p.Field<string>("State")).ToArray();



                        overviewchart3.Series[0].ChartType = SeriesChartType.Pie;
                        overviewchart3.Series[0].Points.DataBindXY(x, y);
                        overviewchart3.Legends[0].Enabled = true;
                        overviewchart3.ChartAreas[0].Area3DStyle.Enable3D = false;

                        dataGridView1.Hide();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

