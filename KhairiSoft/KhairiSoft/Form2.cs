using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KhairiSoft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var
            double price1 = Convert.ToDouble(textBox1.Text);
            double price2 = Convert.ToDouble(textBox2.Text);
            double price3 = Convert.ToDouble(textBox5.Text);
            double discount = Convert.ToDouble(textBox4.Text);
            double total;
            string sin = "$";
            string rial = "﷼ ";


            //discount option
            if (discount == 0)
                total = (price1 + price2 + price3);
            else
            {
                double v = (price1 + price2 + price3);
                double vv = (discount / 100 * v);
                total = v - vv;
            }


            // sign options
            if (comboBox1.SelectedItem.ToString() == "$")
                textBox3.Text = sin + total.ToString();

            if (comboBox1.SelectedItem.ToString() == "﷼ ")
                textBox3.Text = rial + total.ToString();
    }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear popup box options
            if (MessageBox.Show("All data will be deleted? Are you sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit popup box options
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
