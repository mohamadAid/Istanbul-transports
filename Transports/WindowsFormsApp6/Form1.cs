﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IstanbulCardForm f = new IstanbulCardForm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BlueCardForm f2 = new BlueCardForm();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElectronicCardForm f3 = new ElectronicCardForm();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CardsList f5 = new CardsList();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transmission t2 = new Transmission();
            t2.Show();
        }
    }
}
