using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_23.Task_2_Dop_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int[] ar = textBox1.Text.Split(' ').
                Where(x => !string.IsNullOrWhiteSpace(x)).
                Select(x => int.Parse(x)).ToArray();
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 5 == 0)
                {
                    sum += ar[i];
                }
            }
            textBox2.Text = Convert.ToString(sum);
        }
    }
}
