using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730akanzenbach
{
    public partial class akanzenbach1b1 : Form
    {
        public akanzenbach1b1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCaalculate_Click(object sender, EventArgs e)
        {
            txtDiscountAmount.Text = 
                (Convert.ToDecimal(txtSubtotal.Text) 
                * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            txtTotal.Text =
                (Convert.ToDecimal(txtSubtotal.Text)
                - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
        }
        


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
