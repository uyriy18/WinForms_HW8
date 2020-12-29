using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_HW8
{
    public class Figures
    {

        //draw pawns
        public void drawPawn(PaintEventArgs e, int x, int y, Color c)
        {
            Graphics g = e.Graphics;
            SolidBrush br = new SolidBrush(c);
            Rectangle r1 = new Rectangle((x + 4), (y), 15, 15);
            g.FillEllipse(br, r1);

            r1 = new Rectangle((x + 7), (y + 15), 10, 15);
            g.FillRectangle(br, r1);

            r1 = new Rectangle(x, y + 30, 24, 10);
            g.FillRectangle(br, r1);       
        }

        //draw knight
        public void drawKnight(PaintEventArgs e, int x, int y, Color c)
        {
            Graphics g = e.Graphics;
            SolidBrush br = new SolidBrush(c);
            Rectangle r1 = new Rectangle((x - 3), (y + 5), 20, 10);
            g.FillRectangle(br, r1);

            r1 = new Rectangle((x + 7), (y + 15), 10, 15);
            g.FillRectangle(br, r1);

            r1 = new Rectangle(x - 3, y + 30, 28, 10);
            g.FillRectangle(br, r1);
        }

        //draw rook
        public void drawRook(PaintEventArgs e, int x, int y, Color c)
        {
            Graphics g = e.Graphics;
            SolidBrush br = new SolidBrush(c);
            Rectangle r1 = new Rectangle((x + 2), (y + 6), 21, 11);
            g.FillRectangle(br, r1);

            r1 = new Rectangle((x + 5), (y + 15), 15, 20);
            g.FillRectangle(br, r1);

            r1 = new Rectangle(x  - 2, y + 31, 28, 10);
            g.FillRectangle(br, r1);
        }

        //draw elephant
        public void drawElephant(PaintEventArgs e, int x, int y, Color c)
        {
            Graphics g = e.Graphics;
            SolidBrush br = new SolidBrush(c);
            Rectangle r1 = new Rectangle((x + 2), (y + 3), 15, 30);
            g.FillEllipse(br, r1);

            r1 = new Rectangle((x + 5), (y + 26), 10, 15);
            g.FillRectangle(br, r1);
            r1 = new Rectangle(x , y + 35, 20, 7);
            g.FillRectangle(br, r1);
        }

        //draw queen
        public void drawQueen(PaintEventArgs e, int x, int y, Color c)
        {
            Graphics g = e.Graphics;
            SolidBrush br = new SolidBrush(c);
            Rectangle r1 = new Rectangle(x + 2, y, 5, 5);
            g.FillRectangle(br, r1);
            r1 = new Rectangle(x + 12, y, 5, 5);
            g.FillRectangle(br, r1);
            r1 = new Rectangle(x + 22, y, 5, 5);
            g.FillRectangle(br, r1);
            r1 = new Rectangle((x + 2), (y + 5), 25, 20);
            g.FillRectangle(br, r1);
            r1 = new Rectangle((x + 5), (y + 24), 20, 10);
            g.FillRectangle(br, r1);
            r1 = new Rectangle(x + 2, y + 32, 25, 10);
            g.FillRectangle(br, r1);
        }

        //draw king
        public void drawKing(PaintEventArgs e, int x, int y, Color c)
        {
            Graphics g = e.Graphics;
            SolidBrush br = new SolidBrush(c);
            Rectangle r1 = new Rectangle(x + 12, y, 5, 5);
            g.FillRectangle(br, r1);
            r1 = new Rectangle((x + 2), (y + 5), 25, 20);
            g.FillRectangle(br, r1);
            r1 = new Rectangle((x + 5), (y + 24), 20, 10);
            g.FillRectangle(br, r1);
            r1 = new Rectangle(x + 2, y + 32, 25, 10);
            g.FillRectangle(br, r1);
        }
    }
}
