using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveButton
{
    public partial class Form1 : Form
    {
        private Point mouseLoc;
        private int count = 0 ;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button  btn = new Button() ;
            btn.MouseDown += new MouseEventHandler(Mouse_LButtonDown);
            btn.MouseMove += new MouseEventHandler(Mouse_Move);
            btn.Name = "Button" + count.ToString() ;
            btn.Text = "Button" + count.ToString() ;
            ++count;
            btn.Size = new Size(80,25);
            btn.Location = new Point(50,50);
            Controls.Add(btn) ;
        }

        private void Mouse_LButtonDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mouseLoc = e.Location;
            }
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int x = e.X - mouseLoc.X + (sender as Button).Location.X;
                int y = e.Y - mouseLoc.Y + (sender as Button).Location.Y;
                (sender as Button).Location = new Point(x, y);
            }
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
