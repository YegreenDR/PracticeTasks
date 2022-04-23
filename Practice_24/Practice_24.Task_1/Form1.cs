using System;
using System.Windows.Forms;

namespace Practice_24.Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    textBox1.Text = "𐐘 𐑀 ඞ 𐐘 𐐘 𐑀 ඞ";
                    spWin.Text = "Windows is horizontal";
                    InitializeComponent();
                    spData.Text = Convert.ToString(DateTime.Today.ToLongDateString());
                    break;
                case "Cascade":
                    textBox2.Text = "Button2Clicked";
                    break;
                case "Title":
                    textBox3.Text = "Button3Clicked";
                    break;
            }
        }
    }
}
