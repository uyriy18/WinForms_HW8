using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_HW8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(0, 0, 460, 460);
            TextureBrush br = new TextureBrush(new Bitmap(@"Images\darkoack.jpg"));
            g.FillRectangle(br, r);

            fillDesk(e);                                         // draw the chess desk
            fillBroad(e);                                        // draw the broad          

            Figures f = new Figures();
            for(int i = 43; i < 443; i+= 50)                    // drawn black pawns
            {
                f.drawPawn(e, i, 85, Color.Black);     
            }
            for (int i = 43; i < 443; i += 50)                   // drawn wight pawns
            {
                f.drawPawn(e, i, 85 + 250, Color.DarkGray);     
            }
            for(int i = 94; i < 360; i += 250)                   // draw black knights
            {
                f.drawKnight(e, i, 35, Color.Black);
            }
            for (int i = 94; i < 360; i += 250)                  // draw wight knights
            {
                f.drawKnight(e, i, 385, Color.DarkGray);
            }
            for (int i = 44; i < 460; i += 350)                  // draw black rooks
            {
                f.drawRook(e, i, 35, Color.Black);
            }
            for (int i = 44; i < 460; i += 350)                  // draw wight rooks
            {
                f.drawRook(e, i, 385, Color.DarkGray);
            }
            for (int i = 144; i < 300; i += 150)                 // draw black elephants
            {
                f.drawElephant(e, i, 35, Color.Black);
            }
            for (int i = 144; i < 300; i += 150)                // draw wight elephants
            {
                f.drawElephant(e, i, 385, Color.DarkGray);
            }
            f.drawQueen(e, 191, 35, Color.Black);               // draw black queen
            f.drawQueen(e, 191, 385, Color.DarkGray);           // draw wight queen
            f.drawKing(e, 241, 35, Color.Black);                // draw black king
            f.drawKing(e, 241, 385, Color.DarkGray);            // draw wight king
        }
            

      

        void fillBroad(PaintEventArgs e)                         // drawing the broad, letters and digits
        {
            Graphics g = e.Graphics;
            int leftDigit = 8;
            int rightDigit = 8;
            int underL = 65;                                     // ascii valoe of "A" in the down desk side
            int upL = 65;                                        // ascii valoe of "A" in the up desk side

            //draw the inside and outside border lines
            Pen p = new Pen(Color.DarkGoldenrod);
            e.Graphics.DrawLine(p, 0, 0, 0, 460);
            e.Graphics.DrawLine(p, 0, 0, 460, 0);
            e.Graphics.DrawLine(p, 460, 0, 460, 460);
            e.Graphics.DrawLine(p, 0, 460, 460, 460);

            e.Graphics.DrawLine(p, 30, 30, 30, 430);
            e.Graphics.DrawLine(p, 30, 30, 430, 30);
            e.Graphics.DrawLine(p, 430, 30, 430, 430);
            e.Graphics.DrawLine(p, 30, 430, 430, 430);


            // Draw digits and letters
            for (int i = 0; i <= 400; i += 50)
            {
                for (int j = 0; j <= 400; j += 50)
                {
                    if (i == 0 && leftDigit > 0 )
                    {
                        g.DrawString($"{leftDigit--}", new Font("Arial", 10), Brushes.Gold, i + 15, j + 45, StringFormat.GenericTypographic);   // draw digits on the left side of the desk
                    }
                    else if (i == 400 && rightDigit > 0 )
                    {
                        g.DrawString($"{rightDigit--}", new Font("Arial", 10), Brushes.Gold, i + 40, j + 45, StringFormat.GenericTypographic);   // draw digits on the right side of the desk
                    }
                    if (j == 0)
                    {
                        if (underL < 73)
                        {
                            g.DrawString($"{(char)upL++}", new Font("Arial", 10), Brushes.Gold, i + 50, j + 15, StringFormat.GenericTypographic);    // draw letters
                        }
                    }
                    else if (j == 400)
                    {
                        if (underL < 73)
                        {
                            g.DrawString($"{(char)underL++}", new Font("Arial", 10), Brushes.Gold, i + 50, j + 30, StringFormat.GenericTypographic);    // draw letters
                        }

                    }
                }
               
            }
        }

        void fillDesk(PaintEventArgs e)                           // draw the chess desk
        {
            bool isBlack = false;
            bool swap = false;
            Graphics g = e.Graphics;

            for (int i = 30; i < 430; i += 50)
            {
                if (swap)
                {
                    isBlack = true;
                    swap = false;
                }
                else
                {
                    isBlack = false;
                    swap = true;
                }
                for (int j = 30; j < 430; j += 50)
                {

                    if (isBlack)
                    {
                        Rectangle r = new Rectangle(i, j, 50, 50);

                       TextureBrush tBrush = new TextureBrush(imageList1.Images[2]);
                        g.FillRectangle(tBrush, r);
                        isBlack = false;
                    }
                    else
                    {
                        Rectangle r = new Rectangle(i, j, 50, 50);

                        TextureBrush tBrush = new TextureBrush(imageList1.Images[1]);
                        g.FillRectangle(tBrush, r);
                        isBlack = true;
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {

            }
        }
    }
}
