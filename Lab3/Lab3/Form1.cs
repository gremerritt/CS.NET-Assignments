using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private ArrayList coordinates = new ArrayList();
        const int WIDTH = 20;
        const int HEIGHT = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void clear_menu_Click(object sender, EventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            this.coordinates.Clear();
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (ColorPoint colorPoint in this.coordinates)
            {
                Point point = colorPoint.p;
                if (colorPoint.isRed)
                {
                    g.FillEllipse(Brushes.Red, point.X - WIDTH / 2, point.Y - HEIGHT / 2, WIDTH, HEIGHT);
                }
                else
                {
                    g.FillEllipse(Brushes.Black, point.X - WIDTH / 2, point.Y - HEIGHT / 2, WIDTH, HEIGHT);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ColorPoint p = new ColorPoint(e.X, e.Y, false);
                this.coordinates.Add(p);
                this.Invalidate();
            }

            if (e.Button == MouseButtons.Right)
            {
                int i = 0;
                while (true)
                {
                    ColorPoint cpoint = (ColorPoint)coordinates[i];
                    Point point = cpoint.p;
                    if ((e.X < (point.X + (WIDTH / 2))) && (e.X > (point.X - (WIDTH / 2))) && (e.Y > (point.Y - (HEIGHT / 2))) && (e.Y < (point.Y + (HEIGHT / 2))))
                    {

                        if (!cpoint.isRed)
                        {
                            cpoint.setIsRed(true);
                            this.Invalidate();
                            i++;
                        }
                        else
                        {
                            coordinates.RemoveAt(i);
                            this.Invalidate();
                        }
                    }
                    else
                    {
                        i++;
                    }

                    if (i == coordinates.Count) { break; }
                }
            }
        }

        public class ColorPoint
        {
            public Point p;
            public bool isRed;

            public ColorPoint(int x, int y, bool isRed)
            {
                p = new Point(x, y);
                this.isRed = isRed;
            }

            public void setIsRed(bool isRed)
            {
                this.isRed = isRed;
            }
        }
    }
}
