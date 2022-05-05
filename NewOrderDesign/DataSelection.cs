using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOrderDesign
{
    public partial class DataSelection : Form
    {
        string user = Form6.username;
        public DataSelection()
        {
            InitializeComponent();
            if (Form6.fullscreentoggle == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            if (Form6.button2_Clicked == true)
            {
                label1.Text = "Guest";
                Form6.button2_Clicked = false;
            }
            else
            {
                label1.Text = user;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void covidbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6.fullscreencheck(this);
            CovidUSOverview form2 = new CovidUSOverview();
            form2.Show();
        }

        private void fbibutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6.fullscreencheck(this);
            USOverview form5 = new USOverview();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6.fullscreencheck(this);
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

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

        private Size oldsize;
        private void DataSelection_Load(object sender, EventArgs e)
        {
            oldsize = base.Size;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
