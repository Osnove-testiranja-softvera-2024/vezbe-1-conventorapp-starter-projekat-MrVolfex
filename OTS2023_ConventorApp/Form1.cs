using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (radioButtonLength.Checked) { 
                double km=Convert.ToDouble(textBox1.Text)*0.453;
                textBox2.Text = km.ToString();
            }
            else if (radioButtonMass.Checked) {
                double kg = Convert.ToDouble(textBox1.Text) * 0.305;
                textBox2.Text = kg.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMass_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButtonMass.Checked==true) {
                label1.Text = "punds";
                label2.Text = "kg";
            }
            if (radioButtonLength.Checked == true)
            {
                label1.Text = "feet";
                label2.Text = "meters";
            }

        }
    }
}
