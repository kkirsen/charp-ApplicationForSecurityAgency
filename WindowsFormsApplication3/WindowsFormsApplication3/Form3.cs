using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brigades Br = new Brigades();
            Br.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calls Cal = new Calls();
            Cal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chart Ch = new Chart();
            Ch.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clientele Cl = new Clientele();
            Cl.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Objects Ob = new Objects();
            Ob.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Price Pr = new Price();
            Pr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reason R = new Reason();
            R.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Workers W = new Workers();
            W.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Names_Brigades NB = new Names_Brigades();
            NB.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
