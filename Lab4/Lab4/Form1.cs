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

namespace Lab4
{
    public partial class Form1 : Form
    {
        Board board;
        bool hint;

        public Form1()
        {
            InitializeComponent();
            board = new Board();
            hint = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int numQueens = board.getNumQueens();

            String s;
            if (numQueens == 1) { s = String.Format("You have 1 queen on the board."); }
            else { s = String.Format("You have {0} queens on the board.", numQueens); }

            g.DrawString(s, Font, Brushes.Black, 250, 44);
            board.draw(g);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int col = getCoord(e.X);
            int row = getCoord(e.Y);

            if (e.Button == MouseButtons.Left)
            {
                if (row >= 0 && col >= 0)
                {
                    if (board.isSafe(row, col) && !board.getHasQ(row, col))
                    {
                        board.setHasQ(row, col, true, hint);
                        this.Invalidate();

                        if (board.getNumQueens() == 8) 
                        {
                            System.Windows.Forms.MessageBox.Show("Congratulations! You did it!");
                        }
                    }
                    else
                    {
                        System.Media.SystemSounds.Beep.Play();
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (row >= 0 && col >= 0 && board.getHasQ(row, col))
                {
                    board.setHasQ(row, col, false, hint);
                    this.Invalidate();
                }
            }
        }

        private int getCoord(int num)
        {
            if (num > 100 && num < 150)
            {
                return 0;
            }
            else if (num > 150 && num < 200)
            {
                return 1;
            }
            else if (num > 200 && num < 250)
            {
                return 2;
            }
            else if (num > 250 && num < 300)
            {
                return 3;
            }
            else if (num > 300 && num < 350)
            {
                return 4;
            }
            else if (num > 350 && num < 400)
            {
                return 5;
            }
            else if (num > 400 && num < 450)
            {
                return 6;
            }
            else if (num > 450 && num < 500)
            {
                return 7;
            }
            else
            {
                return -1;
            }
        }

        private void hints_CheckedChanged(object sender, EventArgs e)
        {
            hint = !hint;

            if (board.getNumQueens() > 0)
            {
                board.updateColors(hint);
                this.Invalidate();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (board.getNumQueens() > 0)
            {
                board.clear();
                this.Invalidate();
            }
        }
    }

    public class Square
    {
        Brush defaultColor;
        Brush color;
        Brush defaultFontColor;
        Brush fontColor;
        Point point;
        bool hasQ;
        bool isValid;
        ArrayList sources;

        public Square(int x, int y, Brush color, Brush fontColor)
        {
            this.defaultColor = color;
            this.color = color;
            this.point = new Point(x, y);
            this.defaultFontColor = fontColor;
            this.fontColor = fontColor;
            this.hasQ = false;
            this.isValid = true;
            this.sources = new ArrayList();
        }

        public void setColor(Brush color)
        {
            this.color = color;
        }

        public void setFontColor(Brush color)
        {
            this.fontColor = color;
        }

        public void setHasQ(bool hasQ)
        {
            this.hasQ = hasQ;
        }

        public void setIsValid(bool isValid)
        {
            this.isValid = isValid;
        }

        public void addSource(Point p)
        {
            sources.Add(p);
        }

        public int deleteSource(Point p)
        {
            sources.Remove(p);
            return sources.Count;
        }

        public void clearSources()
        {
            sources.Clear();
        }

        public Brush getDefaultColor()
        {
            return this.defaultColor;
        }

        public Brush getDefaultFontColor()
        {
            return this.defaultFontColor;
        }

        public Brush getColor()
        {
            return this.color;
        }

        public Brush getFontColor()
        {
            return this.fontColor;
        }

        public Point getPoint()
        {
            return this.point;
        }

        public bool getHasQ()
        {
            return this.hasQ;
        }

        public bool getIsValid()
        {
            return this.isValid;
        }
    }

    public class Board
    {
        Square[,] board = new Square[8, 8];
        Font font = new Font("Arial", 34, FontStyle.Bold);
        int numQueens = 0;

        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == j % 2)
                    {
                        this.board[i, j] = new Square(100 + (j * 50), 100 + (i * 50), Brushes.White, Brushes.Black);
                    }
                    else
                    {
                        this.board[i, j] = new Square(100 + (j * 50), 100 + (i * 50), Brushes.Black, Brushes.White);
                    }
                }
            }
        }

        public void draw(Graphics g)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Brush color = board[i, j].getColor();
                    Point p = board[i, j].getPoint();
                    int x = p.X;
                    int y = p.Y;
                    bool hasQ = board[i, j].getHasQ();

                    g.FillRectangle(color, x, y, 50, 50);
                    g.DrawRectangle(Pens.Black, x, y, 50, 50);
                    if (hasQ) { 
                        g.DrawString("Q", this.font, this.board[i, j].getFontColor(), p );
                    }
                }
            }
        }

        public void setHasQ(int i, int j, bool hasQ, bool hint)
        {
            this.board[i, j].setHasQ(hasQ);

            if (hasQ) { this.numQueens++; }
            else { this.numQueens--; }

            this.updateSafe(i, j, hasQ, hint);
            
        }

        public bool getHasQ(int i, int j)
        {
            return this.board[i, j].getHasQ();
        }

        public int getNumQueens()
        {
            return numQueens;
        }

        public bool isSafe(int i, int j)
        {
            return board[i, j].getIsValid();
        }

        private void updateSafe(int row, int col, bool hasQ, bool hint)
        {
            // first do the square itself

            Square sq = board[row, col];
            Point p = sq.getPoint();
            updateSquare(sq, p, hasQ, hint);

            // do the col
            for (int i = 0; i < 8; i++)
            {
                if (i == row) { continue;  }
                Square s = board[i, col];
                updateSquare(s, p, hasQ, hint);
            }

            // do the row
            for (int j = 0; j < 8; j++)
            {
                if (j == col) { continue; }
                Square s = board[row, j];
                updateSquare(s, p, hasQ, hint);
            }

            // to the lower right
            for (int i = row + 1, j = col + 1; i < 8; i++, j++)
            {
                if (j > 7) { break; }
                Square s = board[i, j];
                updateSquare(s, p, hasQ, hint);
            }

            // to the upper right
            for (int i = row - 1, j = col + 1; i >= 0; i--, j++)
            {
                if (j > 7) { break; }
                Square s = board[i, j];
                updateSquare(s, p, hasQ, hint);
            }

            // to the upper left
            for (int i = row - 1, j = col - 1; i >= 0; i--, j--)
            {
                if (j < 0) { break; }
                Square s = board[i, j];
                updateSquare(s, p, hasQ, hint);
            }

            // to the lower left
            for (int i = row + 1, j = col - 1; i < 8; i++, j--)
            {
                if (j < 0) { break; }
                Square s = board[i, j];
                updateSquare(s, p, hasQ, hint);
            }
        }

        private void updateSquare(Square s, Point p, bool hasQ, bool hint)
        {
            if (hasQ)
            {
                s.setIsValid(false);
                s.addSource(p);
                if (hint)
                {
                    s.setColor(Brushes.Red);
                    s.setFontColor(Brushes.Black);
                }
            }
            else if (s.deleteSource(p) == 0)
            {
                s.setIsValid(true);
                if (hint)
                {
                    s.setColor(s.getDefaultColor());
                    s.setFontColor(s.getDefaultFontColor());
                }
            }
        }

        public void updateColors(bool hint)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square s = board[i, j];
                    if (!s.getIsValid())
                    {
                        if (hint)
                        {
                            s.setColor(Brushes.Red);
                            s.setFontColor(Brushes.Black);
                        }
                        else
                        {
                            s.setColor(s.getDefaultColor());
                            s.setFontColor(s.getDefaultFontColor());
                        }
                    }
                }
            }
        }

        public void clear()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Square s = board[i, j];
                    s.setColor(s.getDefaultColor());
                    s.setFontColor(s.getDefaultFontColor());
                    s.setHasQ(false);
                    s.setIsValid(true);
                    s.clearSources();
                }
            }
            numQueens = 0;
        }
    }
}
