using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rasst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Расстояние (см) =";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a,b;
            a = double.Parse(textBox1.Text);
            b = a / 100;
            textBox1.Text = Math.Round(b,2).ToString();

        }
    }
}
