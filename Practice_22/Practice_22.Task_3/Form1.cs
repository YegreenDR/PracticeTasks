using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_22.Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double x = Convert.ToDouble(textBox2.Text);
            double u; 
            if ((i % 2 != 0) & (x > 0))
            {
                double u = i * Math.Sqrt(x);
            }
            else if ((i % 2 == 0) & (x < 0))
            {
                double u = i / 2 * Math.Sqrt(Math.Abs(x));
            }
            else
            {
                double u = Math.Sqrt(i * x);
            }
            textBox3.Text = u.ToString();
        }
    }
}
