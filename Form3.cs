using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sports_wear
{
    
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = .; Initial Catalog = sportswear; Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportswearDataSet.product' table. You can move, or remove it, as needed.
            //  this.productTableAdapter.Fill(this.sportswearDataSet.product);
            display_data();
      
        }
        private void clear()
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product";
            cmd.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from product where product_ID = ('" + textBox1.Text + "');", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted successfully");
            display_data();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string type = "";
            bool ischeck = radioButton1.Checked;
            if (ischeck)
            {
                type = radioButton1.Text;
            }
            else
            {
                type = radioButton2.Text;
            }
            cmd = new SqlCommand("insert into product(p_name,type_gender,quantity,price) values('" + textBox4.Text + "','" + type + "','" + textBox3.Text + "', '" + textBox2.Text + "');", con);
            con.Open();
           
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted sucessful!");
            clear();
            display_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from product where p_name ='" + textBox4.Text + "'";
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted sucessful!");
            clear();
            display_data();
            textBox4.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
