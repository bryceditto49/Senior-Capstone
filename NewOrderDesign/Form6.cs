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
        public static int fullscreentoggle;
        
        string conn = (@"Data Source=173.217.234.232\SQLEXPRESS,20222;Initial Catalog=Credentials;User ID=apeuser2;Password=daylonswallows1234");
        public Form6()
        {
            InitializeComponent();
        }

        public static bool button2_Clicked = false;
        public void button2_Click(object sender, EventArgs e)
        {
            button2_Clicked = true;
            this.Hide();
            fullscreencheck(this);
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

        private static string CreateSaltedPassword(string pwd, string salt)
        {
            string saltAndPwd = String.Concat(pwd, salt);
            return saltAndPwd;
        }
        private void btlogin_Click(object sender, EventArgs e)
        {
                if (chkre.Checked == true)
                {
                    Properties.Settings.Default.Username = txtuser.Text;
                    Properties.Settings.Default.Password = txtpass.Text;
                    Properties.Settings.Default.Save();
                }

                if (chkre.Checked == false)
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }

                if (txtuser.Text == "" && txtpass.Text == "")
                {
                    MessageBox.Show("Please fill in the Blanks");
                }
                else
                {     
                    

                    SqlConnection con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("select * from LoginTable1 where username=@username and password=@password", con);
                    SqlCommand getSalt = new SqlCommand("select salt from LoginTable1 where username=@username", con);
                    getSalt.Parameters.AddWithValue("@username", txtuser.Text);
                    con.Open();
                    string salt = (string)getSalt.ExecuteScalar();
                    string saltandpass = CreateSaltedPassword(txtpass.Text.Trim(), salt);
                    Console.WriteLine(salt);
                    string hashedpass = getHash(saltandpass);
                    Console.WriteLine(hashedpass);
                    //int length = salt.Length;
                    //int digitcount = 14 + length;
                    hashedpass = hashedpass.Remove(50, 14);
                    cmd.Parameters.AddWithValue("@username", txtuser.Text);
                    cmd.Parameters.AddWithValue("@password", hashedpass);
                    //var dbhash = cmd.Parameters.Add("@password");
                    
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();
                    fullscreencheck(this);
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

            public static void fullscreencheck(Form form)
            {
                int n = 1;
                while (n == 1)
                {
                    if (form.WindowState == FormWindowState.Maximized)
                    {
                        fullscreentoggle = 1;
                    }
                    else
                    {
                        fullscreentoggle = 0;
                    }
                    n = n + 1;
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

        private Size oldsize;
        private void Form6_Load(object sender, EventArgs e)
        {

            if (Form6.fullscreentoggle == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            oldsize = base.Size; 
            if (Properties.Settings.Default.Username != string.Empty)
            {
                txtuser.Text = Properties.Settings.Default.Username;
                txtpass.Text = Properties.Settings.Default.Password;  
            }
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldsize = base.Size;
        }
        private void ResizeAll(Control control, Size newSize)
        {
            int width = newSize.Width - oldsize.Width;
            control.Left += (control.Left * width) / oldsize.Width;
            control.Width += (control.Width * width) / oldsize.Width;

            int height = newSize.Height - oldsize.Height;
            control.Top += (control.Top * height) / oldsize.Height;
            control.Height += (control.Height * height) / oldsize.Height;
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btlogin.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                button1.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                button2.BringToFront();
                txtpass.PasswordChar = '*';
            }
        }

        private void lbpass_Click(object sender, EventArgs e)
        {

        }
    }
}
