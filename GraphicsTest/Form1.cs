using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsTest
{
    public partial class Form1 : Form
    {
        Graphics g = null;
        Pen myPen = new Pen(Color.Black);

        private Random rnd = new Random();

        static int startX;
        static int startY;

        static int endX;
        static int endY;

        static int myVipu1 = 1;
        static int myVipu2 = 1;
        static int myVipu3 = 1;
        static int myVipu4 = 1;

        public Form1()
        {
            InitializeComponent();
            startX = canvas.Width / 2;
            startY = canvas.Height / 2;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            myPen.Width = 1;
            g = canvas.CreateGraphics();
            for (int i = 0; i < Int32.Parse(vipu3.Text); i++)
            {
                DrawLine();
                myPen.Color = RandomPenColor();
            }
        }

        private Color RandomPenColor()
        {
            return Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void DrawLine()     
        {
            myVipu4 += Int32.Parse(vipu4.Text);
            endX = (int)(startX + myVipu2 * Math.Cos(myVipu4 * .017453292519));
            endY = (int)(startY + myVipu2 * Math.Sin(myVipu4 * .017453292519));
            Point[] points = new Point[]
            {
                new Point(startX, startY),
                new Point(endX, endY)
            };

            g.DrawLines(myPen, points);
            myPen.Width += myVipu1;
            startX = endX;
            startY = endY;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myVipu1 = Int32.Parse(vipu1.Text);
            myVipu2 = Int32.Parse(vipu2.Text);
            myVipu3 = Int32.Parse(vipu3.Text);
            myVipu4 = Int32.Parse(vipu4.Text);

            startX = canvas.Width / 2;
            startY = canvas.Height / 2;

            canvas.Refresh();
        }
    }
}
