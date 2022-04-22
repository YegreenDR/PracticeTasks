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
    public partial class UserControlTimer2 : UserControl
    {
        public UserControlTimer2()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Refresh();
        }
    }
}
