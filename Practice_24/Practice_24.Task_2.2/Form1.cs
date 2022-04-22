using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_24.Task_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width, this.Height);
            pe.Graphics.DrawString(DateTime.Now.ToLongTimeString(),
                this.Font, new SolidBrush(this.ForeColor), 0, 0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
