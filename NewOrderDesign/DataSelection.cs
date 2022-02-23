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
        public DataSelection()
        {
            InitializeComponent();
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
            CovidStateData form3 = new CovidStateData();
            form3.Show();
        }

        private void fbibutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            USOverview form5 = new USOverview();
            form5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage form1 = new LandingPage();
            form1.Show();
        }
    }
}
