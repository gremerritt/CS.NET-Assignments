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

namespace Lab5
{
    public partial class Lab5 : Form
    {
        private bool clicked = false;
        private Point first_click_point = new Point();
        private Point second_click_point = new Point();

        private ArrayList objects = new ArrayList();
        private Brush[] pen_colors = new Brush[4] { Brushes.Black, Brushes.Red, Brushes.Blue, Brushes.Green };
        private Brush[] fill_colors = new Brush[5] { Brushes.White, Brushes.Black, Brushes.Red, Brushes.Blue, Brushes.Green };

        public Lab5()
        {
            InitializeComponent();
            Initialize_Pen_Color();
            Initialize_Fill_Color();
            Initialize_Width();
        }

        private void Initialize_Pen_Color()
        {
            Select_Pen_Color.Items.Add("Black");
            Select_Pen_Color.Items.Add("Red");
            Select_Pen_Color.Items.Add("Blue");
            Select_Pen_Color.Items.Add("Green");
            Select_Pen_Color.SetSelected(0, true);
        }

        private void Initialize_Fill_Color()
        {
            Select_Fill_Color.Items.Add("White");
            Select_Fill_Color.Items.Add("Black");
            Select_Fill_Color.Items.Add("Red");
            Select_Fill_Color.Items.Add("Blue");
            Select_Fill_Color.Items.Add("Green");
            Select_Fill_Color.SetSelected(0, true);
        }

        private void Initialize_Width()
        {
            for (int i = 1; i <= 10; i++) { Select_Pen_Width.Items.Add(i.ToString()); }
            Select_Pen_Width.SetSelected(0, true);
        }

        private void Panel_Drawing_Area_MouseClick(object sender, MouseEventArgs e)
        {
            if (!clicked)
            {
                clicked = true;
                first_click_point.X = e.X;
                first_click_point.Y = e.Y;
            }
            else
            {
                second_click_point.X = e.X;
                second_click_point.Y = e.Y;
                
                if (Radio_Line.Checked)
                {
                    cLine l = new cLine(first_click_point,
                                        second_click_point,
                                        pen_colors[Select_Pen_Color.SelectedIndex],
                                        Select_Pen_Width.SelectedIndex + 1);
                    objects.Add(l);
                    Panel_Drawing_Area.Invalidate();
                    clicked = false;
                }
                else if (Radio_Rectangle.Checked && (Checkbox_Fill.Checked || Checkbox_Outline.Checked))
                {
                    cRectangle r = new cRectangle(first_click_point,
                                                  second_click_point,
                                                  pen_colors[Select_Pen_Color.SelectedIndex],
                                                  Select_Pen_Width.SelectedIndex + 1,
                                                  fill_colors[Select_Fill_Color.SelectedIndex],
                                                  Checkbox_Fill.Checked,
                                                  Checkbox_Outline.Checked);
                    objects.Add(r);
                    Panel_Drawing_Area.Invalidate();
                    clicked = false;
                }
                else if (Radio_Ellipse.Checked && (Checkbox_Fill.Checked || Checkbox_Outline.Checked))
                {
                    cEllipse el = new cEllipse(first_click_point,
                                               second_click_point,
                                               pen_colors[Select_Pen_Color.SelectedIndex],
                                               Select_Pen_Width.SelectedIndex + 1,
                                               fill_colors[Select_Fill_Color.SelectedIndex],
                                               Checkbox_Fill.Checked,
                                               Checkbox_Outline.Checked);
                    objects.Add(el);
                    Panel_Drawing_Area.Invalidate();
                    clicked = false;
                }
                else if (TextBox.Text != "")
                {
                    cText t = new cText(first_click_point, second_click_point, pen_colors[Select_Pen_Color.SelectedIndex], TextBox.Text);
                    objects.Add(t);
                    Panel_Drawing_Area.Invalidate();
                    clicked = false;
                }
            }
        }

        private void Panel_Drawing_Area_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (Graphics_Base gb in objects) { gb.draw(g); }
            g.Dispose();
        }

        private void Menu_Edit_Undo_Click(object sender, EventArgs e)
        {
            if (objects.Count > 0) { objects.RemoveAt(objects.Count - 1); }
            Panel_Drawing_Area.Invalidate();
        }

        private void Menu_File_Clear_Click(object sender, EventArgs e)
        {
            objects.Clear();
            Panel_Drawing_Area.Invalidate();
        }

        private void Menu_File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    class Graphics_Base
    {
        protected Point point_a;
        protected Point point_b;
        protected Brush pen_color;

        protected Graphics_Base(Point point_a, Point point_b, Brush pen_color) {
            // this bit makes sure point_a is upper left and point_b is lower right
            //
            // the cLine child class overrides this because there we don't care about
            // the bounding box, but do care about the where the actual corners are
            if (point_a.X < point_b.X)
            {
                if (point_a.Y < point_b.Y)
                {
                    this.point_a.X = point_a.X;
                    this.point_a.Y = point_a.Y;
                    this.point_b.X = point_b.X;
                    this.point_b.Y = point_b.Y;
                }
                else
                {
                    this.point_a.X = point_a.X;
                    this.point_a.Y = point_b.Y;
                    this.point_b.X = point_b.X;
                    this.point_b.Y = point_a.Y;
                }
            }
            else
            {
                if (point_a.Y < point_b.Y)
                {
                    this.point_a.X = point_b.X;
                    this.point_a.Y = point_a.Y;
                    this.point_b.X = point_a.X;
                    this.point_b.Y = point_b.Y;
                }
                else
                {
                    this.point_a.X = point_b.X;
                    this.point_a.Y = point_b.Y;
                    this.point_b.X = point_a.X;
                    this.point_b.Y = point_a.Y;
                }
            }
            this.pen_color = pen_color;
        }

        virtual public void draw(Graphics g) {
            // this will be overridden in each derived class
        }
    }

    class cLine : Graphics_Base
    {
        private int pen_width;

        public cLine(Point point_a, Point point_b, Brush pen_color, int pen_width) : base(point_a, point_b, pen_color)
        {
            this.pen_width = pen_width;
            this.point_a = point_a;
            this.point_b = point_b;
        }

        override public void draw(Graphics g)
        {
            Pen p = new Pen(pen_color, pen_width);
            g.DrawLine(p, point_a, point_b);
            p.Dispose();
        }
    }

    class cRectangle : Graphics_Base
    {
        private int pen_width;
        private Brush fill_color;
        private bool filled;
        private bool outlined;

        public cRectangle(Point point_a, Point point_b, Brush pen_color, int pen_width, Brush fill_color, bool filled, bool outlined) : base(point_a, point_b, pen_color)
        {
            this.pen_width = pen_width;
            this.fill_color = fill_color;
            this.filled = filled;
            this.outlined = outlined;
        }

        override public void draw(Graphics g)
        {

            if (filled) { g.FillRectangle(fill_color, point_a.X, point_a.Y, point_b.X - point_a.X, point_b.Y - point_a.Y); }
            if (outlined)
            {
                Pen p = new Pen(pen_color, pen_width);
                g.DrawRectangle(p, point_a.X, point_a.Y, point_b.X - point_a.X, point_b.Y - point_a.Y);
                p.Dispose();
            }
        }
    }

    class cEllipse : Graphics_Base
    {
        private int pen_width;
        private Brush fill_color;
        private bool filled;
        private bool outlined;

        public cEllipse(Point point_a, Point point_b, Brush pen_color, int pen_width, Brush fill_color, bool filled, bool outlined) : base(point_a, point_b, pen_color)
        {
            this.pen_width = pen_width;
            this.fill_color = fill_color;
            this.filled = filled;
            this.outlined = outlined;
        }

        override public void draw(Graphics g)
        {
            if (filled) { g.FillEllipse(fill_color, point_a.X, point_a.Y, point_b.X - point_a.X, point_b.Y - point_a.Y); }
            if (outlined)
            {
                Pen p = new Pen(pen_color, pen_width);
                g.DrawEllipse(p, point_a.X, point_a.Y, point_b.X - point_a.X, point_b.Y - point_a.Y);
                p.Dispose();
            }
        }
    }

    class cText : Graphics_Base
    {
        String text;

        public cText(Point point_a, Point point_b, Brush pen_color, String text) : base(point_a, point_b, pen_color)
        {
            this.text = text;
        }

        override public void draw(Graphics g)
        {
            StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
            RectangleF bounding_rect = new RectangleF(point_a.X, point_a.Y, point_b.X - point_a.X, point_b.Y - point_a.Y);
            Font font = new Font("Arial", 10);
            g.DrawString(text, font, pen_color, bounding_rect, format);
            font.Dispose();
            format.Dispose();
        }
    }
}