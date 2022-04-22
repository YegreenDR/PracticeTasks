using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_24.Task_2._3
{
    public class ClickButton : System.Windows.Forms.Button
    {
        int mClicks;
        public int Clicks
        {
            get { return mClicks; }
        }
        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            base.OnClick(e);
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            System.Drawing.Graphics g = pevent.Graphics;
            System.Drawing.SizeF stringsize;
            stringsize = g.MeasureString(Clicks.ToString(),this.Font, this.Width);
            g.DrawString(Clicks.ToString(), this.Font,
            System.Drawing.SystemBrushes.ControlText,this.Width - stringsize.Width - 1, 
                this.Height -stringsize.Height - 3);
        }
    }
}
