using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_17._03._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double priceForALiter = 0;
            double kilometers = double.Parse(textBox1.Text);
            double for100KM = double.Parse(textBox2.Text);
            double total = 0;

            if (radioButton1.Checked)
            {
                priceForALiter = 2.83;
                label3.Text = priceForALiter.ToString() + " лв.";
                total = ((kilometers / 100) * for100KM) * priceForALiter;
                label6.Text = total.ToString() + " лв.";
            }
            else if (radioButton2.Checked)
            {
                priceForALiter = 1.2;
                label3.Text = priceForALiter.ToString() + " лв.";
                total = ((kilometers / 100) * for100KM) * priceForALiter;
                label6.Text = total.ToString() + " лв.";
            }
            else if (radioButton3.Checked)
            {
                priceForALiter = 2.75;
                label3.Text = priceForALiter.ToString() + " лв.";
                total = ((kilometers / 100) * for100KM) * priceForALiter;
                label6.Text = total.ToString() + " лв.";  
            }
            else if (radioButton4.Checked)
            {
                priceForALiter = 2.79;
                label3.Text = priceForALiter.ToString() + " лв.";
                total = ((kilometers / 100) * for100KM) * priceForALiter;
                label6.Text = total.ToString() + " лв.";
            }
            
        }
    }
}
