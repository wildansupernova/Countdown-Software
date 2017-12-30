using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formUtama : Form
    {
        public formUtama()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "")
            {
                label4.Text = "Please fill the number.";
            }
            else
            {
                int hasil = (Int32.Parse(textBox1.Text)*3600) + (Int32.Parse(textBox1.Text)*60) + Int32.Parse(textBox3.Text);
                countdown mulai = new countdown();
                mulai.test(hasil);
                mulai.Show();

                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            long a;
            if (!long.TryParse(textBox1.Text,out a))
            {
                textBox1.Clear();
                label4.Text = "Please type number not character";
            }
            else
            {
                label4.Text = "OK.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            long a;
            if (!long.TryParse(textBox2.Text, out a))
            {
                textBox2.Clear();
                label4.Text = "Please type number not character";
            }
            else
            {
                label4.Text = "OK.";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            long a;
            if (!long.TryParse(textBox3.Text, out a))
            {
                textBox3.Clear();
                label4.Text = "Please type number not character";
            }
            else
            {
                label4.Text = "OK.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countdown c = new countdown();
            c.test(300);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
