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
    public partial class CovidStateData : Form
    {
        public CovidStateData()
        {
            InitializeComponent();
        }
        public static string state;
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            state = textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Server = DESKTOP-RU1AMPT\SQLEXPRESS; Database = CovidData; User Id = apeuser; Password = daylonswallows123";

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string query = $"SELECT * FROM states WHERE state_name = '{state}'";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'covidDataDataSet1.states' table. You can move, or remove it, as needed.
            this.statesTableAdapter2.Fill(this.covidDataDataSet1.states);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
