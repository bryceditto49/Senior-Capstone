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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {

        }

        string state;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            state = textBox1.Text;
        }
    }
}
