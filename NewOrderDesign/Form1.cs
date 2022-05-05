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
    public partial class Form1 : Form
    {

        string connectionString = (@"Data Source=173.217.234.232\SQLEXPRESS,20222;Initial Catalog=Credentials;User ID=apeuser2;Password=daylonswallows1234");
        public Form1()
        {
            InitializeComponent();
        }

        private Size oldsize;
        private void Form1_Load(object sender, EventArgs e)
        {
            oldsize = base.Size;
            if (Form6.fullscreentoggle == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (txtcon.Text != string.Empty && txtpass.Text != string.Empty && txtuser.Text != string.Empty )
            {
                if (txtpass.Text == txtcon.Text)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {   
                        Random random = new Random();
                        int salt = random.Next();
                        string saltString= salt.ToString();
                        string updatedpass = CreateSaltedPassword(txtpass.Text.Trim(), saltString);
                        Console.WriteLine(updatedpass);
                        string hashpass = getHash(updatedpass);
                        sqlCon.Open();
                        bool exists = false;
                        using (SqlCommand sqlCmd = new SqlCommand("select count(*) from LoginTable1 where username = @username", sqlCon))
                        {
                            sqlCmd.Parameters.AddWithValue("@username", txtuser.Text.Trim());
                            exists = (int)sqlCmd.ExecuteScalar() > 0;
                        }
                        if (exists)
                        {
                            MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            using (SqlCommand sqlCmd = new SqlCommand("UserAdds", sqlCon))
                            {
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                sqlCmd.Parameters.AddWithValue("@username", txtuser.Text.Trim());
                                sqlCmd.Parameters.AddWithValue("@password", hashpass);
                                sqlCmd.Parameters.AddWithValue("@salt", saltString);
                                sqlCmd.ExecuteNonQuery();
                                MessageBox.Show("Registration is complete");
                                Clear();
                                this.Hide(); 
                                Form6 form6 = new Form6();
                                Form6.fullscreencheck(this);
                                form6.Show();
                            }
                        }
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

        void Clear()
        {
            txtuser.Text = txtpass.Text = txtcon.Text = "";
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

        private void txtcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void btback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void txtcon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btsubmit.PerformClick();
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

        private void button2_Click(object sender, EventArgs e)
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

    }
}
