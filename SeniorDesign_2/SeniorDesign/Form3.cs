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
    public partial class DataSelectionFrm : Form
    {
        public DataSelectionFrm()
        {
            InitializeComponent();
        }
        private void covidbutton_Click(object sender, EventArgs e)
        {
            CovidDataFrm form4 = new CovidDataFrm();
            form4.Show();
        }
 

        private void button2_Click(object sender, EventArgs e)
        {
            FBIdatafrm form5 = new FBIdatafrm();
            form5.Show();
        }
       private void button1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void terrordatabutton_Click(object sender, EventArgs e)
        {
            TerrorismDataFrm form6 = new TerrorismDataFrm();
            form6.Show();
        }
    }
}
