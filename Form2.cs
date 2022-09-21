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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        public static implicit operator Form2(Form3 v)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            staff s = new staff();
            s.Show();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            Branch b = new Branch();
            b.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_customer a = new add_customer();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you sure exit?","close",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you sure logout?", "logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                this.Close();

            }

        }
    }
}
