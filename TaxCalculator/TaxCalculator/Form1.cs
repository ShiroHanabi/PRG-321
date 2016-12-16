using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class TaxCalc : Form
    {

        public TaxCalc()
        {
            InitializeComponent();
            
        }

        private void TaxCalc_Load(object sender, EventArgs e)
        {

        }

        private void onclick_ComputeTax(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputNumBox.Text) == true)
            {   
                MessageBox.Show("Enter Number");
                InputNumBox.Text = "";
                return;
            }
            double Price = double.Parse(InputNumBox.Text);
            double Taxrate = 7.5;
            double c = Price * Taxrate * 0.01;
            textBox2.Text = c.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InputNumBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_Key_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            InputNumBox.Text = "";
            textBox2.Text = "";
        }
    }
}
