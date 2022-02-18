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
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\varat\source\repos\bryceditto49\Senior-Capstone\NewOrderDesign\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (txtcon.Text != string.Empty || txtpass.Text != string.Empty || txtuser.Text != string.Empty)
            {
                if (txtpass.Text == txtcon.Text)
                {
                    cmd = new SqlCommand("select * from Table where username='" + txtuser.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Table values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtuser.Text);
                        cmd.Parameters.AddWithValue("password", txtpass.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account Created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Password missmatch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string username;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = txtuser.Text;
        }

        string password;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = txtpass.Text;
        }

        private void btsubmit_Clicked(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btguess_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
