using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int dollars, cents;
            a = Convert.ToInt32(textBox1.Text);
           
            dollars = a / 100;
            cents = a % 100;
            label2.Text = dollars.ToString();
            label3.Text = cents.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9][^.][^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        double dollAr(double dollar)
        {
            double res, som = 80;
            dollar = Convert.ToDouble(textBox2.Text);
            res = dollar * som;
            return res;
        }
        double euRo(double dollar)
        {
            double res, som = 87;
            dollar = Convert.ToDouble(textBox3.Text);
            res = dollar * som;
            return res;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double res, dollar, euro, euroResult;
            dollar = Convert.ToDouble(textBox2.Text);
            euro = Convert.ToDouble(textBox3.Text);
            res = dollAr(dollar);
            euroResult = euRo(euro);
            label6.Text = res.ToString();
            label7.Text = euroResult.ToString();
        }
    }
}
