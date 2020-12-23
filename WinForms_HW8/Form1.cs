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
            bool isBlack = false;
            bool swap = false;
            Graphics g = e.Graphics;

            for (int i = 0; i < 400; i += 50)
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
                for (int j = 0; j < 400; j += 50)
                {

                    if (isBlack)
                    {
                        Rectangle r = new Rectangle(i, j, 50, 50);

                        TextureBrush tBrush = new TextureBrush(new Bitmap(@"D:\Images\venge.jpg"));
                        g.FillRectangle(tBrush, r);
                        isBlack = false;
                    }
                    else
                    {
                        Rectangle r = new Rectangle(i, j, 50, 50);

                        TextureBrush tBrush = new TextureBrush(new Bitmap(@"D:\Images\milky.jpg"));
                        g.FillRectangle(tBrush, r);
                        isBlack = true;
                    }



                }
                i++;
            }
        }



    }
}
