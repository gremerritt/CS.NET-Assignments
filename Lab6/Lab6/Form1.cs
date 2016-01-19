using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Lab6
{
    public enum CellSelection {N, O, X};
    public partial class Form1 : Form
    {
        //dimensions
        private const float clientSize = 100;
        private const float lineLength = 80;
        private const float block = lineLength / 3;
        private const float offset = 10;
        private const float delta = 5;
        private float scale; //current scale factor 
        TicTacToe_Game_Engine game = new TicTacToe_Game_Engine();

        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ApplyTransform(g);
            //draw board
            g.DrawLine(Pens.Black, block, 0, block, lineLength);
            g.DrawLine(Pens.Black, 2 * block, 0, 2 * block, lineLength);
            g.DrawLine(Pens.Black, 0, block, lineLength, block);
            g.DrawLine(Pens.Black, 0, 2 * block, lineLength, 2 * block);
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    if (game.getCell(i, j) == CellSelection.O) DrawO(i, j, g);
                    else if (game.getCell(i, j) == CellSelection.X) DrawX(i, j, g);
                }
            }
        }

        private void ApplyTransform(Graphics g)
        {
            scale = Math.Min(ClientRectangle.Width / clientSize,
            ClientRectangle.Height / clientSize);
            if (scale == 0f) return;
            g.ScaleTransform(scale, scale);
            g.TranslateTransform(offset, offset);
        }

        private void DrawX(int i, int j, Graphics g)
        {
            g.DrawLine(Pens.Black, j * block + delta, i * block + delta, (j * block) + block - delta, (i * block) + block - delta);
            g.DrawLine(Pens.Black, (j * block) + block - delta, i * block + delta, (j * block) + delta, (i * block) + block - delta);
        }

        private void DrawO(int i, int j, Graphics g)
        {
            g.DrawEllipse(Pens.Black, j * block + delta, i * block + delta, block - 2 * delta, block - 2 * delta);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!game.isGameover())
            {
                Menu_Game_ComputerStart.Enabled = false;
                Graphics g = CreateGraphics();
                ApplyTransform(g);
                PointF[] p = { new Point(e.X, e.Y) };
                g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, p);
                if (p[0].X < 0 || p[0].Y < 0) return;
                int col = (int)(p[0].X / block);
                int row = (int)(p[0].Y / block);
                if (row > 2 || col > 2) return;

                if (game.isOpen(row, col)) { game.makeMove(row, col, CellSelection.X); }
                else { System.Windows.Forms.MessageBox.Show("This cell is already taken."); }
                if (!check_For_Win_or_Tie(CellSelection.X))
                {
                    game.computerTurn();
                    check_For_Win_or_Tie(CellSelection.O);
                }
                this.Invalidate();
            }
        }

        private bool check_For_Win_or_Tie(CellSelection player)
        {
            if (game.isWin(player))
            {
                this.Invalidate();
                if (player == CellSelection.X) { System.Windows.Forms.MessageBox.Show("Congratulations! You win!"); }
                else { System.Windows.Forms.MessageBox.Show("Uh oh! You lost!"); }
                return true;
            }
            else if (game.isTie())
            {
                this.Invalidate();
                System.Windows.Forms.MessageBox.Show("It's a tie!");
                return true;
            }
            return false;
        }

        private void Menu_Game_New_Click(object sender, EventArgs e)
        {
            game.clear();
            Menu_Game_ComputerStart.Enabled = true;
            this.Invalidate();
        }

        private void Menu_Game_ComputerStart_Click(object sender, EventArgs e)
        {
            game.computerTurn();
            Menu_Game_ComputerStart.Enabled = false;
            this.Invalidate();
        }

        private void Menu_File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
