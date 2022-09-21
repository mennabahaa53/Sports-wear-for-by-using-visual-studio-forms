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

    public partial class staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL-LAPTOP;Initial Catalog=sportswear;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
      
       

        public staff()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select* from customer", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
           
        }
       
     

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from staff where number_ID='"+textBox2.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
            MessageBox.Show("sucessful!");
            display_data();
            clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string gender = "";
            bool ischeck = male.Checked;
            if (ischeck)
            {
                gender = male.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
             cmd.CommandText = "insert into staff(s_name,number_ID,mobile,gender,statu,sallery)values ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + gender + "','" + textBox5.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record inserted sucessful!");
            clear();
            display_data();
        }


        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff";
            cmd.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();
        }
        private void clear()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton2.Checked = false;
            male.Checked = false;
            
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportswearDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.sportswearDataSet.staff);

            display_data();
           

        }

        private void sportswearDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff where number_ID ='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            con.Close();
            clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool ischeck = male.Checked;
            if (ischeck)
            {
                gender = male.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update staff set s_name='"+textBox1.Text+"',gender='"+gender+ "',mobile="+textBox3.Text+ ",statu='"+textBox5.Text+ "',sallery='"+textBox4.Text+"' where number_ID='" + textBox2.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_data();
            MessageBox.Show("record updated successfully!");
            display_data();
            clear();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            display_data();
            clear();
        }
    }
    }

