using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorDesign
{
    public partial class CitySelectionFrm : Form
    {
        public CitySelectionFrm()
        {
            InitializeComponent();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            DataSelectionFrm form3 = new DataSelectionFrm();
            form3.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            StartFrm form1 = new StartFrm();
            form1.Show();

        }
    }
}
