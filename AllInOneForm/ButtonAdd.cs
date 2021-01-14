using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KGySoft.Drawing;

namespace AllInOneForm
{
    public class ButtonAdd : Form1
    {
        private static bool mouseOver = false;
        public static void panelAdd_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = new Rectangle(6, 6, panelAdd.Width - 12, panelAdd.Height - 12);
            if (mouseOver)
            {
                g.FillRoundedRectangle(Brushes.Gray, rect, 3);
                g.DrawRoundedRectangle(new Pen(Color.Brown, 3), rect, 3);
            }
            else
            {
                g.DrawRoundedRectangle(new Pen(Color.Brown, 3), rect, 3);
            }
            g.SmoothingMode = SmoothingMode.None;
            g.DrawLine(new Pen(Color.Black, 6), panelAdd.Width / 2, panelAdd.Height / 2 + 12, panelAdd.Width / 2,
                panelAdd.Height / 2 - 12);
            g.DrawLine(new Pen(Color.Black, 6), panelAdd.Width / 2 + 12, panelAdd.Height / 2, panelAdd.Width / 2 - 12,
                panelAdd.Height / 2);
        }

        public static void panelAdd_MouseEnter(object sender, EventArgs e)
        {
            mouseOver = true;
            panelAdd.Refresh();
        }

        public static void panelAdd_MouseLeave(object sender, EventArgs e)
        {
            mouseOver = false;
            panelAdd.Refresh();
        }

        public static void panelAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}