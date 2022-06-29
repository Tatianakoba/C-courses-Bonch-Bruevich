using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text == string.Empty;
            textBox2.Text == string.Empty;
            textBox3.Text == string.Empty;
            double tc,tk,tf;

            tc = double.Parse(textBox1.Text);
            tk = tc - 273.15;
            tf = ((tc * 9) / 5) + 32;
            textBox3.Text = "" + Math.Round(tk, 0);
            textBox2.Text = "" + Math.Round(tf, 2);
        }
    }
}
