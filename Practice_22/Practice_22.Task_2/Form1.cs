using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_22.Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
                textBox2.Text = "Понедельник";
            else if (textBox1.Text == "2")
                textBox2.Text = "Вторник";
            else if (textBox1.Text == "3")
                textBox2.Text = "Среда";
            else if (textBox1.Text == "4")
                textBox2.Text = "Четверг";
            else if (textBox1.Text == "5")
                textBox2.Text = "Пятница";
            else if (textBox1.Text == "6")
                textBox2.Text = "Суббота";
            else if (textBox1.Text == "7")
                textBox2.Text = "Воскресенье";
            else textBox2.Text = "Такого дня не существует";
        }
    }
}
