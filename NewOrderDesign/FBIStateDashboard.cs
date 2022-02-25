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
    public partial class FBIStateDashboard : Form
    {
        public FBIStateDashboard()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Persons";
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = FBI; User Id = apeuser; Password = daylonswallows123;";

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query;

                    //retrieve the SQL Server instance version
                    if (String.IsNullOrEmpty(state))
                    {
                        query = $"SELECT * FROM Crimes_Against_" + table + $"_Offenses_Offense_Category_by_State_2020";
                    }
                    else
                    {
                        query = $"SELECT * FROM Crimes_Against_" + table + $"_Offenses_Offense_Category_by_State_2020 WHERE State = '{state}'";
                    }
                    

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results

                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    if (table.Equals("Persons"))
                    {
                        dataGridView1.Show();
                        dataGridView2.Hide();
                        dataGridView3.Hide();
                    }
                    else if (table.Equals("Property"))
                    {
                        dataGridView1.Hide();
                        dataGridView2.Show();
                        dataGridView3.Hide();
                    }
                    else if (table.Equals("Society"))
                    {
                        dataGridView1.Hide();
                        dataGridView2.Hide();
                        dataGridView3.Show();
                    }

                    dataGridView1.ReadOnly = true;
                    dataGridView2.ReadOnly = true;
                    dataGridView3.ReadOnly = true;

                    //set the DataGridView control's data source/data table

                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView2.DataSource = ds.Tables[0];
                    dataGridView3.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        string state;
        string table;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            state = textBox1.Text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fBIDataSet2.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Society_Offenses_Offense_Category_by_State_2020TableAdapter.Fill(this.fBIDataSet2.Crimes_Against_Society_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIPropertyDataSet.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Property_Offenses_Offense_Category_by_State_2020TableAdapter.Fill(this.fBIPropertyDataSet.Crimes_Against_Property_Offenses_Offense_Category_by_State_2020);
            // TODO: This line of code loads data into the 'fBIDataSet1.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020' table. You can move, or remove it, as needed.
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter1.Fill(this.fBIDataSet1.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            USOverview form4 = new USOverview();
            form4.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            table = comboBox1.Text;
            submitbutton.PerformClick();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
