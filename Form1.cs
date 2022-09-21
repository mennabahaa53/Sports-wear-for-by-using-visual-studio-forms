using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sports_wear
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string passward = textBox2.Text;
            if (username == "admin" && passward == "12345")
            {

                Form2 f1 = new Form2();
                f1.Show();

                textBox1.Clear();
                textBox2.Clear();
            }
            else if (username == "" || passward == "")
            {
                MessageBox.Show("Enter your bassward and username");
            }
            else
            {
                MessageBox.Show("Enter correct your bassward and username");
            }

          


            
        }
    }
}
