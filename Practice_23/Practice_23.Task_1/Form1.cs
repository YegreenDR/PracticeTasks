﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_23.Task_1
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
            str = str.Replace(" ", string.Empty);
            char[] ar = str.ToCharArray();
            int kol = ar.Count(x => x % 2 == 0);
            textBox2.Text = kol.ToString();
        }
    }
}
