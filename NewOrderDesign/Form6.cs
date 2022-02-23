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
    public partial class Form6 : Form
    {
        string conn = (@"Data Source=74.192.196.118\SQLEXPRESS,2022;Initial Catalog=Credentials;User ID=apeuser;Password=***********");
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSelection form2 = new DataSelection();
            form2.Show();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Please fill in the Blanks");
            }
            else
            {
                SqlConnection con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("select * from LoginTable where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtuser.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);

                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successfully");
                    this.Hide();
                    DataSelection form2 = new DataSelection();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Check your username and password");
                }
            }
        }

        private void btregis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
