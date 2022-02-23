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
    public partial class FBIUSView : Form
    {
        public int toggle = 1;
        public FBIUSView()
        {
            InitializeComponent();
        }

        private void continueFBIUSView_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBIStateDashboard form4 = new FBIStateDashboard();
            form4.Show();
            toggle = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSelection form2 = new DataSelection();
            form2.Show();
            toggle = 0;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }


        //From here down is all the code for the combo box on each tabs and the tabs themselves
        string DropDownCrimesAgainstPersons;
        private void CrimesAgainstPersonsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownCrimesAgainstPersons = CrimesAgainstPersonsComboBox.Text;

            if (DropDownCrimesAgainstPersons.Equals("Assault"))
            {
                TotalOffensesAgainstPersonsLabel.Text = FBIUSView.totalassaultoffenses.ToString();
            }
            else if (DropDownCrimesAgainstPersons.Equals("Homicide"))
            {



            }
            else if (DropDownCrimesAgainstPersons.Equals("Human Trafficking"))
            {



            }
            else if (DropDownCrimesAgainstPersons.Equals("Kidnapping/Abduction"))
            {



            }
            else if (DropDownCrimesAgainstPersons.Equals("Sex Offenses"))
            {



            }
            else
            {



            }
        }

        //global variables
        public static Int32 totalassaultoffenses;

        //the queries are made here for the Persons tab
        private void CrimesAgainstPersonTab_Click(object sender, EventArgs e)
        {
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    string query1;
                    string query2;
                    string query3;
                    string query4;
                    while (toggle == 1)
                    {
                        conn.Open();

                        if (DropDownCrimesAgainstPersons.Equals("Assault"))
                        {
                            //total assault offenses, total offenses, greatest number from a single state, population from that state
                            query1 = $"SELECT Assault_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query2 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query3 = $"SELECT TOP 1 Assault_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 " +
                                     $"WHERE Assault_Offenses< (SELECT Max(Assault_Offenses) FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020) " +
                                     $"GROUP BY State, Assault_Offenses " +
                                     $"ORDER BY Assault_Offenses desc";
                            query4 = $"";

                            SqlCommand cmdtotalassault = conn.CreateCommand();
                            cmdtotalassault.CommandText = query1;
                            FBIUSView.totalassaultoffenses = (Int32)cmdtotalassault.ExecuteScalar();

                        }
                        else if (DropDownCrimesAgainstPersons.Equals("Homicide"))
                        {
                            //total homicide offenses, total offenses, greatest number from a single state, population from that state
                            query1 = $"SELECT Homicide_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query2 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query3 = $"SELECT TOP 1 Homicide_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 " +
                                     $"WHERE Homicide_Offenses< (SELECT Max(Homicide_Offenses) FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020) " +
                                     $"GROUP BY State, Homicide_Offenses " +
                                     $"ORDER BY Homicide_Offenses desc";
                            query4 = $"";


                        }
                        else if (DropDownCrimesAgainstPersons.Equals("Human Trafficking"))
                        {
                            //total human trafficking offenses, greatest number from a single state, population from that state
                            query1 = $"SELECT Human_Trafficking FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query2 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query3 = $"SELECT TOP 1 Human_Trafficking FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 " +
                                     $"WHERE Human_Trafficking< (SELECT Max(Human_Trafficking) FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020) " +
                                     $"GROUP BY State, Human_Trafficking " +
                                     $"ORDER BY Human_Trafficking desc";
                            query4 = $"";
                        }
                        else if (DropDownCrimesAgainstPersons.Equals("Kidnapping/Abduction"))
                        {
                            //total kidnapping/abduction offenses, total offenses, greatest number from a single state, population from that state
                            query1 = $"SELECT Kidnapping_Abduction FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query2 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query3 = $"SELECT TOP 1 Kidnapping_Abduction FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 " +
                                     $"WHERE Kidnapping_Abduction< (SELECT Max(Kidnapping_Abduction) FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020) " +
                                     $"GROUP BY State, Kidnapping_Abduction " +
                                     $"ORDER BY Kidnapping_Abduction desc";
                            query4 = $"";
                        }
                        else if (DropDownCrimesAgainstPersons.Equals("Sex Offenses"))
                        {
                            //total sex offenses, total offenses, greatest number from a single state, population from that state
                            query1 = $"SELECT Sex_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query2 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query3 = $"SELECT TOP 1 Sex_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 " +
                                     $"WHERE Sex_Offenses< (SELECT Max(Sex_Offenses) FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020) " +
                                     $"GROUP BY State, Sex_Offenses " +
                                     $"ORDER BY Sex_Offenses desc";
                            query4 = $"";
                        }
                        else
                        {
                            //total offenses, greatest number from a single state, population from that state
                            query1 = $"SELECT Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 WHERE State = 'Total'";
                            query3 = $"SELECT TOP 1 Total_Offenses FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020 " +
                                     $"WHERE Total_Offenses < (SELECT Max(Total_Offenses) FROM Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020) " +
                                     $"GROUP BY State, Total_Offenses " +
                                     $"ORDER BY Total_Offenses desc";
                            query4 = $"";
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        string DropDownCrimesAgainstProperty;
        private void CrimesAgainstPropertyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownCrimesAgainstProperty = CrimesAgainstPropertyComboBox.Text;
        }

        private void CrimesAgainstPropertyTab_Click(object sender, EventArgs e)
        {

        }

        string DropDownCrimesAgainstSociety;
        private void CrimesAgainstSocietyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownCrimesAgainstSociety = CrimesAgainstSocietyComboBox.Text;
        }
        private void CrimesAgainstSocietyTab_Click(object sender, EventArgs e)
        {

        }

        //From here down is all the code for the text boxes on each tab

        //Persons tab//////////////////////////////////////////////////////////////////
        private void PersonsDefaultTotalNumber_TextChanged(object sender, EventArgs e)
        {


        }

        private void PercofTotalCrimesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatesWithMostOffensesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalNumberofOffensesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalOffensesAgainstPersonsLabel_Click(object sender, EventArgs e)
        {
            
        }

        //Property Tab/////////////////////////////////////////////////////////////////////

    }
}
