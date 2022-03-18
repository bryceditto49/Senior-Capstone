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
            FBIViewMore form4 = new FBIViewMore();
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
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
            try
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (PropertyComboBox.Text.Equals("Arson"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Arson FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalarson = conn.CreateCommand();
                        cmdtotalarson.CommandText = query1;
                        USOverview.overviewtotalarson = (Int16)cmdtotalarson.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalarson.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Bribery"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Bribery FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalbribery = conn.CreateCommand();
                        cmdtotalbribery.CommandText = query1;
                        USOverview.overviewtotalbribery = (Int16)cmdtotalbribery.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalbribery.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Burglary / Breaking & Entering"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Burglary_Breaking_Entering FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalburglary = conn.CreateCommand();
                        cmdtotalburglary.CommandText = query1;
                        USOverview.overviewtotalburglary = (Int32)cmdtotalburglary.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalburglary.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Counterfeiting / Forgery"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Counterfeiting_Forgery FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalcounterfeiting = conn.CreateCommand();
                        cmdtotalcounterfeiting.CommandText = query1;
                        USOverview.overviewtotalcounterfeiting = (Int32)cmdtotalcounterfeiting.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalcounterfeiting.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Destruction / Damage / Vandalism"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Destruction_Damage_Vandalism FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotaldestruction = conn.CreateCommand();
                        cmdtotaldestruction.CommandText = query1;
                        USOverview.overviewtotaldestruction = (Int32)cmdtotaldestruction.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotaldestruction.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Embezzlement"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Embezzlement FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalembezzlement = conn.CreateCommand();
                        cmdtotalembezzlement.CommandText = query1;
                        USOverview.overviewtotalembezzlement = (Int16)cmdtotalembezzlement.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalembezzlement.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Extortion / Blackmail"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Extortion_Blackmail FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalextortion = conn.CreateCommand();
                        cmdtotalextortion.CommandText = query1;
                        USOverview.overviewtotalextortion = (Int16)cmdtotalextortion.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalextortion.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Fraud"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Fraud_Offenses FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalfraud = conn.CreateCommand();
                        cmdtotalfraud.CommandText = query1;
                        USOverview.overviewtotalfraud = (Int32)cmdtotalfraud.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalfraud.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Larceny / Theft"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Larceny_Theft_Offenses FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotallarceny = conn.CreateCommand();
                        cmdtotallarceny.CommandText = query1;
                        USOverview.overviewtotallarceny = (Int32)cmdtotallarceny.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotallarceny.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Motor Vehicle Theft"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Motor_Vehicle_Theft FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalmotor = conn.CreateCommand();
                        cmdtotalmotor.CommandText = query1;
                        USOverview.overviewtotalmotor = (Int32)cmdtotalmotor.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalmotor.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Robbery"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Robbery FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalrobbery = conn.CreateCommand();
                        cmdtotalrobbery.CommandText = query1;
                        USOverview.overviewtotalrobbery = (Int32)cmdtotalrobbery.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalrobbery.ToString();

                        conn.Close();
                    }
                    else if (PropertyComboBox.Text.Equals("Stolen Property"))
                    {
                        conn.Open();

                        string query1 = $"SELECT Stolen_Property_Offenses FROM Crimes_Against_Property_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";

                        SqlCommand cmdtotalstolen = conn.CreateCommand();
                        cmdtotalstolen.CommandText = query1;
                        USOverview.overviewtotalstolen = (Int32)cmdtotalstolen.ExecuteScalar();
                        TotalCrimesAgainstPropertyTabLabel1.Text = USOverview.overviewtotalstolen.ToString();

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
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
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
    }
}

