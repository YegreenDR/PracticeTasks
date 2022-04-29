﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practice_29.Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x1, y1, x2, y2, r;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a -= 0.1;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            r = 150;
            a = 0;
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Width / 2;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
        }
        private double a;
        private Pen pen = new Pen(Color.DarkRed, 2);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
