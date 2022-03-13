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
using System.Security.Cryptography;



namespace NewOrderDesign
{
    public partial class Form6 : Form
    {
        
        string conn = (@"Data Source=74.192.196.118\SQLEXPRESS,2022;Initial Catalog=Credentials;User ID=apeuser;Password=daylonswallows123");
        public Form6()
        {
            InitializeComponent();
        }

        public static bool button2_Clicked = false;
        public void button2_Click(object sender, EventArgs e)
        {
            button2_Clicked = true;
            this.Hide();
            DataSelection form2 = new DataSelection();
            form2.Show();
        }
        private static string getHash(string text)
        {
            // SHA512 is disposable by inheritance.  
            using (var sha256 = SHA256.Create())
            {
                // Send a sample text to hash.  
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                // Get the hashed string.  
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private void btlogin_Click(object sender, EventArgs e)
        {
            
                if (txtuser.Text == "" && txtpass.Text == "")
                {
                    MessageBox.Show("Please fill in the Blanks");
                }
                else
                {
                    string hashedpass = getHash(txtpass.Text.Trim());
                    SqlConnection con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("select * from LoginTable2 where username=@username and password=@password", con);
                    cmd.Parameters.AddWithValue("@username", txtuser.Text);
                    cmd.Parameters.AddWithValue("@password", hashedpass);
                    //var dbhash = cmd.Parameters.Add("@password");
                    Console.WriteLine(hashedpass);

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

        public static string username;
        public void txtuser_TextChanged(object sender, EventArgs e)
        {
            username = txtuser.Text;
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar);

        }



        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
