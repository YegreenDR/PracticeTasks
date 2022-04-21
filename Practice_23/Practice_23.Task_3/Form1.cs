using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_23.Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen = new Pen(Color.Black, 2);
        private void Form1_Paint(object sender,PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.DrawEllipse(pen, 360, 324, 100, 100);
            g.DrawEllipse(pen, 675, 333, 100, 100);
            g.DrawLine(pen, 328, 310, 892, 311);
            g.DrawLine(pen, 892, 311, 891, 231);
            g.DrawLine(pen, 891, 231, 663, 232);
            g.DrawLine(pen, 663, 232, 663, 160);
            g.DrawLine(pen, 663, 160, 485, 162);
            g.DrawLine(pen, 485, 162, 487, 231);
            g.DrawLine(pen, 487, 231, 333, 232);
            g.DrawLine(pen, 333, 232, 328, 310);
        }
    }
}
