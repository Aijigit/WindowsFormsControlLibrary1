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
            if (a > 99999)
            {
                MessageBox.Show("Введите число меньше 100000!");
                textBox1.Text = "";
            }
            else
            {
                dollars = a / 100;
                cents = a % 100;
                label2.Text = dollars.ToString();
                label3.Text = cents.ToString();
            }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9][^.][^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = "";
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Valuta valuta = new Valuta();
            double  dollar,som;
            dollar = Convert.ToDouble(textBox2.Text);
            som = Convert.ToDouble(textBox3.Text);
            label6.Text = valuta.dollAr(dollar, som).ToString();
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Valuta valuta = new Valuta();
            double dollar, som;
            dollar = Convert.ToDouble(textBox2.Text);
            som = Convert.ToDouble(textBox3.Text);
            label6.Text = valuta.euRo(dollar, som).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Valuta valuta = new Valuta();
            double dollar, som;
            dollar = Convert.ToDouble(textBox2.Text);
            som = Convert.ToDouble(textBox3.Text);
            label6.Text = valuta.Sum(dollar, som).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Valuta valuta = new Valuta();
            double dollar, som;
            dollar = Convert.ToDouble(textBox2.Text);
            som = Convert.ToDouble(textBox3.Text);
           
            label6.Text = valuta.Tenge(dollar, som).ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9][^.][^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = "";
            }
        }
    }
}
