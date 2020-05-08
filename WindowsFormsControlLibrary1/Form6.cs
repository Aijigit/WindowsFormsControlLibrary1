using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void childWindow1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 myForm = new Form7();
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        private void existingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = "C:";
            dialog.ShowDialog();
            pictureBox1.Image = Image.FromFile(dialog.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "All Files(*.*)|*.*";
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
                MessageBox.Show("Выбран файл с именем" + saveDialog.FileName);
           
            }
        }

        private void exitCtrlF10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрытие приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes) 
            {
                Application.Exit();
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.MdiParent = this;
            f7.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = System.DateTime.Today.ToLongDateString();
            toolStripStatusLabel4.Text = System.DateTime.Now.ToLongTimeString();  
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }
    }
}
