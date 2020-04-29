using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sourceValue = textBox1.Text;
             double doubleValue;
            if (double.TryParse(sourceValue, out doubleValue))
            {
                if (doubleValue >= 8.00 && doubleValue < 12.00)
                {
                    label2.Text = "Доброе утро!";

                } else if (doubleValue >= 12.00 && doubleValue < 17.00)
                {
                    label2.Text = "Добрый день!";
                }
                else if (doubleValue >= 17.00 && doubleValue <= 23.59 )
                {
                    label2.Text = "Добрый вечер!";
                } else
                {
                    label2.Text = "Добрый ночь!";
                }
            }
            else
            {
                // Here you can display an error message like 'Invalid value'
            }
            

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9][^.][^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
