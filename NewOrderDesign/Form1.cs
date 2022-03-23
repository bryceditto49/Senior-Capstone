﻿using System;
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
        string connectionString = (@"Data Source=74.192.196.118\SQLEXPRESS,2022;Initial Catalog=Credentials;User ID=apeuser;Password=daylonswallows123");
        public Form1()
        {
            InitializeComponent();
        }

        private Size oldsize;
        private void Form1_Load(object sender, EventArgs e)
        {
            oldsize = base.Size;
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
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UserAdds", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@username", txtuser.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@password", txtpass.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration is complete");
                        Clear();
                        this.Hide(); 
                        Form6 form6 = new Form6();
                        form6.Show();
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
    }
}
