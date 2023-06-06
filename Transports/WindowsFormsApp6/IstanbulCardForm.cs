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
    public partial class IstanbulCardForm : Form
    {
        public IstanbulCardForm()
        {
            InitializeComponent();
        }
        public static int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int no, trans, stops;
            double balance, deduct;
            string type, vehicle;
            no = Convert.ToInt32(comboBox1.Text);
            balance = Convert.ToDouble(textBox2.Text);
            type = textBox1.Text;
            vehicle = comboBox2.Text;
            IstanbulCard card = new IstanbulCard(no, type, balance);
            if (vehicle == "Bus")
            {
                trans = Convert.ToInt32(textBox3.Text);
                deduct = card.transfer(trans);
            }
            else if (vehicle == "Metrobus")
            {
                stops = Convert.ToInt32(textBox3.Text);
                deduct = card.metrobus(stops);
            }
            else
            {
                MessageBox.Show("You Should choise the vehicle type");
                deduct = 0;
            }
            textBox4.Text = deduct.ToString();
            textBox5.Text = card.Balance.ToString();
            g1.Rows[count].Cells[0].Value = card.No.ToString();
            g1.Rows[count].Cells[1].Value = card.Type;
            g1.Rows[count].Cells[2].Value = card.Balance.ToString();
            count++;
            int cardno = int.Parse(comboBox1.Text);
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            SqlCommand comm1 = new SqlCommand("update Card SET [balance]='" + textBox5.Text + "' where [card_no]= '" + cardno + "' ", conn);
            comm1.ExecuteNonQuery();
            SqlCommand comm2 = new SqlCommand("Insert into Transmissions(card_no,vehicle,trans,deduct) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
            comm2.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Bus")
                label5.Text = "Trans";
            else label5.Text = "stops";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IstanbulCardForm_Load(object sender, EventArgs e)
        {
            String cardType = "Istanbul Card";
            SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-UO0RD8P\SQLEXPRESS ;Initial catalog= Transmission;Integrated Security=true");
            conn.Open();
            DataTable dtt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Card where card_type ='" + cardType + "' ", conn);
            sda.Fill(dtt);
            comboBox1.DataSource = dtt;
            comboBox1.DisplayMember = "card_no";
            textBox1.DataBindings.Add("Text", dtt, "customer_type");
            textBox2.DataBindings.Add("Text", dtt, "balance");
            conn.Close();
            g1.ColumnCount = 3;
            g1.RowCount = 9;
            g1.Columns[0].Name = "Number";
            g1.Columns[1].Name = "Type";
            g1.Columns[2].Name = "Balance";
        }
    }
}
