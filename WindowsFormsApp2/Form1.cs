using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int a = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Selected Index: " + comboBox1.SelectedIndex);
            a = comboBox1.SelectedIndex;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // button1
        {
            switch (a){
                case 0:
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
                    break;
                case 1:
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
                    break;
                case 2:
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
                    break;
                case 3:
                    textBox3.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
                    break;
                default:
                    textBox3.Text = "Error";
                    break;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // close program
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
