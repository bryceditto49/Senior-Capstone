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
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = CovidData; User Id = apeuser; Password = daylonswallows123;";

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
            // TODO: This line of code loads data into the 'covidDataDataSet4.states' table. You can move, or remove it, as needed.
            this.statesTableAdapter4.Fill(this.covidDataDataSet4.states);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSelection form2 = new DataSelection();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = CovidData; User Id = apeuser; Password = daylonswallows123;";

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string query = $"SELECT * FROM (SELECT TOP 7 * FROM states WHERE state_name = '{state}' ORDER BY date DESC) SQ ORDER BY date ASC";


                    //AND date BETWEEN '2022-01-25' AND '2022-02-01'//
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

        private void button4_Click(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = CovidData; User Id = apeuser; Password = daylonswallows123;";

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string query = $"SELECT * FROM (SELECT TOP 14 * FROM states WHERE state_name = '{state}' ORDER BY date DESC) SQ ORDER BY date ASC";


                    //AND date BETWEEN '2022-01-25' AND '2022-02-01'//
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

        private void button5_Click(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Server = 74.192.196.118\SQLEXPRESS,2022; Database = CovidData; User Id = apeuser; Password = daylonswallows123;";

            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string query = $"SELECT * FROM (SELECT TOP 21 * FROM states WHERE state_name = '{state}' ORDER BY date DESC) SQ ORDER BY date ASC";


                    //AND date BETWEEN '2022-01-25' AND '2022-02-01'//
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
    }
}
