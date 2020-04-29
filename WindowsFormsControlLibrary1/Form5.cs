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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sourceValue = textBox1.Text;
            int doubleValue;
            if (int.TryParse(sourceValue, out doubleValue))
            {
                string message;
                if (doubleValue >= 25 )
                {
                    message = "Можешь идти в школу. Желаю успехов!";
                    MessageBox.Show(message);
                }
                else
                {
                    message = "Занятия в школе отменяются!";
                    MessageBox.Show(message);
                }
            }
            else
            {
                // Here you can display an error message like 'Invalid value'
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9][^.][^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
