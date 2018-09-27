using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviz_znanja
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int bod;
        public Igrac Ii;
        private void Form3_Load(object sender, EventArgs e)
        {
            if (Ii == null)
            {
                MessageBox.Show("Nijedan igrac nije registriran!");
                this.Close();
            }
            else
            {
                if (bod <= 5)
                {
                    pictureBox1.Show();
                    label0.Text = Ii.Ime;
                }
                if (bod <= 10 && bod > 5)
                {
                    pictureBox2.Show();
                    pictureBox1.Hide();
                    label0.Text = "";
                    label1.Text = Ii.Ime;
                }
                if (bod <= 20 && bod > 10)
                {
                    pictureBox3.Show();
                    pictureBox2.Hide();
                    label1.Text = "";
                    label2.Text = Ii.Ime;
                }
                if (bod <= 30 && bod > 20)
                {
                    pictureBox4.Show();
                    pictureBox3.Hide();
                    label2.Text = "";
                    label3.Text = Ii.Ime;
                }
                if (bod <= 40 && bod > 30)
                {
                    pictureBox5.Show();
                    pictureBox4.Hide();
                    label3.Text = "";
                    label4.Text = Ii.Ime;
                }
                if (bod <= 50 && bod > 40)
                {
                    pictureBox6.Show();
                    pictureBox5.Hide();
                    label4.Text = "";
                    label5.Text = Ii.Ime;
                }
                if (bod <= 60 && bod > 50)
                {
                    pictureBox7.Show();
                    pictureBox6.Hide();
                    label5.Text = "";
                    label6.Text = Ii.Ime;
                }
                if (bod <= 70 && bod > 60)
                {
                    pictureBox8.Show();
                    pictureBox7.Hide();
                    label6.Text = "";
                    label7.Text = Ii.Ime;
                }
                if (bod <= 80 && bod > 70)
                {
                    pictureBox9.Show();
                    pictureBox8.Hide();
                    label7.Text = "";
                    label8.Text = Ii.Ime;
                }
                if (bod <= 90 && bod > 80)
                {
                    pictureBox10.Show();
                    pictureBox9.Hide();
                    label8.Text = "";
                    label9.Text = Ii.Ime;
                }
                if (bod > 90)
                {
                    pictureBox10.Show();
                    pictureBox9.Hide();
                    label8.Text = "";
                    label9.Text = Ii.Ime;
                }
            }

        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
          
        }
    }
}
