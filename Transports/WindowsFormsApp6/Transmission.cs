using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Transmission : Form
    {
        public Transmission()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transmission_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            DataTable dtt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Transmissions", conn);
            sda.Fill(dtt);
            comboBox1.DataSource = dtt;
            comboBox1.DisplayMember = "tran_no";
            textBox1.DataBindings.Add("Text", dtt, "card_no");
            textBox2.DataBindings.Add("Text", dtt, "vehicle");
            textBox3.DataBindings.Add("Text", dtt, "trans");
            textBox4.DataBindings.Add("Text", dtt, "deduct");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cardno = int.Parse(comboBox1.Text);
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            SqlCommand comm1 = new SqlCommand("Delete from Transmissions where [tran_no]= '" + cardno + "'", conn);
            comm1.ExecuteNonQuery();
            MessageBox.Show("Deleting Transmission done Successfully.");
            conn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Transmissions", conn);
            sda1.Fill(dt);
            g1.DataSource = dt;
            conn.Close();
        }
    }
}
