using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practice_29.Task_1
{
    public partial class Form1 : Form
    {
        Graphics g;
        private Pen pen;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 2);
            this.Load += Form1_Load;
            timer1.Tick += timer1_Tick;
            btnStartTimer.Click += btnStartTimer_Click;
            btnStopTimer.Click += btnStopTimer_Click;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            r = 150;
            a = 0;
            x1 = this.ClientSize.Width / 2;
            y1 = this.ClientSize.Width / 2;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
        }
        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        private int x1, y1, x2, y2, r;
        private double a;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawLine(pen, x1, y1, x2, y2);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            a -= 0.1;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            Invalidate();
        }
    }
}
