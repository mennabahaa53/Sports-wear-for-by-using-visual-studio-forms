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
    public partial class add_customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL-LAPTOP;Initial Catalog=sportswear;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        public add_customer()
        {
            InitializeComponent();
        }

        private void add_customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportswearDataSet1.customer' table. You can move, or remove it, as needed.
            //  this.customerTableAdapter.Fill(this.sportswearDataSet1.customer);
            display_data();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 r = new Form2();
            r.Show();
        }

        private void clear()
        {
            textBox1.Clear();
            male.Checked = false;
            female.Checked = false;
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer where c_name ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();


        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from customer";
            cmd.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string type = "";
            bool ischeck = male.Checked;
            if (ischeck)
            {
                type = male.Text;
            }
            else
            {
                type = female.Text;
            }

            cmd = new SqlCommand("insert into customer(c_name,mobile,gender,c_address) values ('" + textBox1.Text + "'," + textBox4.Text + ",'" + textBox5.Text + "','" +type + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("done save");
            clear();
            display_data();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("delete customer where id=" + textBox2.Text + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("done delete");
            textBox2.Clear();
            display_data();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            display_data();
            clear();
        }
    }
}
