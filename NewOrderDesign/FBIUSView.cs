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
    public partial class FBIUSView : Form
    {
        public FBIUSView()
        {
            InitializeComponent();
        }

        private void continueFBIUSView_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBIStateDashboard form4 = new FBIStateDashboard();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataSelection form2 = new DataSelection();
            form2.Show();
        }
    }


}
