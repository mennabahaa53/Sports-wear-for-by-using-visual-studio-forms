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
    public partial class Branch : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DELL-LAPTOP;Initial Catalog=sportswear;Integrated Security=True");
        SqlDataAdapter Da;
        DataTable Dt = new DataTable();
        SqlCommand cmd;
        public Branch()
        {

            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();
            g.Show();
        }

        private void Branch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportswearDataSet.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.sportswearDataSet.branch);
            // TODO: This line of code loads data into the 'sportswearDataSet.branch' table. You can move, or remove it, as needed.
            //  this.branchTableAdapter.Fill(this.sportswearDataSet.branch);
            // TODO: This line of code loads data into the 'dataSet2.medicine1' table. You can move, or remove it, as needed.
            // this.medicine1TableAdapter.Fill(this.dataSet2.medicine1);
            Da = new SqlDataAdapter("Select * From Branch", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Branch(phone,b_address)values(" + textBox2.Text + ",'" + textBox3.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
            MessageBox.Show("Done Save");
            Da = new SqlDataAdapter("Select * From Branch", con);
            Da.Fill(Dt);
            dataGridView1.DataSource = Dt;
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
