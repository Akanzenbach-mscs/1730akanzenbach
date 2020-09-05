using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akanzenbach1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void newzealandTextChanged(object sender, EventArgs e)
        {
            txtUSDNewZealand.Text = (
                       0.671074m * Convert.ToDecimal(txtAmountNewZealand.Text)
                ).ToString("0.00");
        }

        private void belgiumTextChanged(object sender, EventArgs e)
        {
            txtUSDBelgian.Text = (
                1.18384m * Convert.ToDecimal(txtAmountBelgian.Text)
                ).ToString("0.00");
              

        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                0.0136524m * Convert.ToDecimal(txtAmountBhutan.Text)
                ).ToString("0.00");
        }

        private void canadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
                0.765462m * Convert.ToDecimal(txtAmountCanada.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text =
                (Convert.ToDecimal(txtUSDNewZealand.Text) + (Convert.ToDecimal(txtUSDBelgian) + (Convert.ToDecimal(txtUSDBhutan) +
                (Convert.ToDecimal(txtUSDCanada));
        }
    }
    }

