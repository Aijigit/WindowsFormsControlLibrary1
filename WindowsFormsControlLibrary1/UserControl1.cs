using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Dance!!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Hello world!";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "It Works!";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form6 f3 = new Form6();
            f3.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }
    }
}
