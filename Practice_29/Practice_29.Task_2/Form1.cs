using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_29.Task_2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap baner;
        Rectangle rct;
        public Form1()
        {
            InitializeComponent();
            try
            {
                baner = new Bitmap(@"E:\Практика\C#\Practice\PracticeTasks\Practice_29\Practice_29.Task_2\baner.png");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка загрузки файла баннера\n" + e.ToString(), "Баннер");
                this.Close();
                return;
            }
            this.Paint += Form1_Paint;

            rct.X = 0;
            rct.Y = 0;
            rct.Width = baner.Width;
            rct.Height = baner.Height;
            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImage(baner, rct.X + rct.Width, rct.Y);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            rct.X -= 4;
            if (Math.Abs(rct.X) > rct.Width && rct.X < 0)
                rct.X = this.ClientSize.Width + 2;
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rct.Y + rct.Height) && (e.Y > rct.Y))
            {
                if (timer1.Enabled != true)
                    timer1.Enabled = false;
            }
            else
            {
                if (timer1.Enabled != true)
                    timer1.Enabled = true;
            }
        }
    }
}