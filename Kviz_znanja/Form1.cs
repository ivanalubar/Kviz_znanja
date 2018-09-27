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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string ime;
        public string lik;
        public Igrac igr;
        public int b;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 druga = new Form2();
            druga.ShowDialog();
            b = druga.bodovi;
            if (textBox1.Text != "")
            {
                ime = textBox1.Text;
            }
            else
                ime = "nema imena";
            igr = new Igrac(ime, druga.bodovi);
            treca.bod = druga.bodovi;
            treca.Ii = igr;
            druga.i = igr;
        }
        public Form3 treca = new Form3();
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            treca.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
