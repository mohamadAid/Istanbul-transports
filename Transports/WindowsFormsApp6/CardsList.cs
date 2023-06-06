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
    public partial class CardsList : Form
    {
        public CardsList()
        {
            InitializeComponent();
        }
        public static int count = 0;
            private void button1_Click(object sender, EventArgs e)
            {
               SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
               conn.Open();
               SqlCommand comm1 = new SqlCommand("Insert into Card(card_type,customer_type,balance) values('"+comboBox1.Text+"','"+comboBox2.Text+"','"+textBox2.Text+"')", conn);
               comm1.ExecuteNonQuery();
               MessageBox.Show("Adding Card done Successfully.");
               textBox2.Text = "";
               comboBox1.Text = "";
               comboBox2.Text = "";
               String no = textBox1.Text;
               int newno = int.Parse(no) + 1;
               textBox1.Text = newno.ToString();
               conn.Close();
            }

        private void CardsList_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            SqlCommand comm1 = new SqlCommand("select max(card_no)+1 from Card",conn);
            SqlDataReader reader = comm1.ExecuteReader();
            reader.Read();
            textBox1.Text = reader[0].ToString();
            conn.Close();
            DataTable dtt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Card", conn);
            sda.Fill(dtt);
            comboBox3.DataSource = dtt;
            comboBox3.DisplayMember = "card_no";
            textBox3.DataBindings.Add("Text", dtt, "card_type");
            textBox4.DataBindings.Add("Text", dtt, "customer_type");
            textBox5.DataBindings.Add("Text", dtt, "balance");
        }
        private void g1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Electronic Card")
            {
                comboBox2.Visible = false;
                label3.Visible = false;
            }
            else
            {
                comboBox2.Visible = true;
                label3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cardno = int.Parse(comboBox3.Text);
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            SqlCommand comm1 = new SqlCommand("update Card SET [card_type]='" + textBox3.Text +"', [customer_type]='" + textBox4.Text + "' ,[balance]='" + textBox5.Text + "' where [card_no]= '" + cardno + "' ", conn);
            comm1.ExecuteNonQuery();
            MessageBox.Show("Editting Card done Successfully.");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cardno = int.Parse(comboBox3.Text);
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            SqlCommand comm1 = new SqlCommand("Delete from Card where [card_no]= '" + cardno + "'", conn);
            comm1.ExecuteNonQuery();
            MessageBox.Show("Deleting Card done Successfully.");
            conn.Close();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Card", conn);
            sda1.Fill(dt);
            g1.DataSource = dt;
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

