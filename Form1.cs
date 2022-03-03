using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_2
{
    public partial class Form1 : Form
    {

        double price;

        public void CalPrice()
        {
            if (rdbH1.Checked == true) price = 3000;
            if (rdbH2.Checked == true) price = 3500;
            if (rdbH3.Checked == true) price = 4000;

            if (rdbD2.Checked == true) price = price * 0.8;

            if (rdbV1.Checked == true) price = price * 0.85;

            lblPrice.Text = "價錢：" + price.ToString() + " 元";
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void rdbH1_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "";
            CalPrice();
        }

        private void rdbH2_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "";
            CalPrice();
        }

        private void rdbH3_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "";
            CalPrice();
        }

        private void rdbD1_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "";
            CalPrice();
        }

        private void rdbD2_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "";
            CalPrice();
        }

        private void rdbV1_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "";
            CalPrice();
        }

        private void rdbV2_CheckedChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "";
            CalPrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CalPrice();
        }
    }
}
