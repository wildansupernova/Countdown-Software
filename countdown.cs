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
    public partial class countdown : Form
    {
        public int sekon { get; set; }
        public bool berjalan { get; set; }
        public int sekonNow { get; set; }
        public countdown()
        {
            InitializeComponent();
        }


        public void test(int jumlahSek)
        {
            sekon = jumlahSek;
            sekonNow = jumlahSek;
            this.Show();
            timer1.Enabled = true;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.ForeColor = Color.Black;
            formUtama c = new formUtama();
            c.Show();
            timer1.Enabled = false;
            label1.Text = "00:00:00";
            this.Hide();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = sekonNow.ToString();
            //label2.Text = progressBar1.Value.ToString();
            if (sekonNow == 0)
            {
                progressBar1.Value = 0;
                formUtama c = new formUtama();
                label1.ForeColor = Color.Black;
                c.Show();
                this.Hide();

                timer1.Enabled = false;
                label1.Text = "00:00:00";
                
            }
            else
            {
                progressBar1.Value = ((sekon - sekonNow) * 100) / sekon;
                //label2.Text = ( ((sekon - sekonNow)*100 ) / sekon).ToString();
                label1.Text = (sekonNow / 3600).ToString() + ":" + ((sekonNow % 3600) / 60).ToString() + ":" + ((sekonNow % 3600) % 60).ToString();
                sekonNow--;
            }

            if (sekonNow>0 && sekonNow<=10 && label1.ForeColor == Color.Black)
            {
                label1.ForeColor = Color.Red;
            }
            else if (sekonNow > 0 && sekonNow <= 10 && label1.ForeColor == Color.Red)
            {
                label1.ForeColor = Color.Black;
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void countdown_Load(object sender, EventArgs e)
        {

        }
    }
}
