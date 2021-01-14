using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AllInOneForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(new Pen(Color.Black, 4), flowLayoutPanel1.Width, 0, flowLayoutPanel1.Width,
                flowLayoutPanel1.Height);
        }
    }
}