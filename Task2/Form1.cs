using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        List<Point> pointCollection = new List<Point>();
        Graphics g;
        Pen pen;
        int pointX = -10;
        int pointY = -10;
        bool isMoving = false;
            
        public Form1()  
        {
            InitializeComponent();
            g = Canvas_panel.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void Canvas_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMoving = true;
                pointX = e.X;
                pointY = e.Y;
            }
        }

        private void Canvas_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving && pointX != -10 && pointY != -10)
            {
                g.DrawLine(pen, new Point(pointX, pointY), e.Location);
                pointX = e.X;
                pointY = e.Y;
            }
        }

        private void Canvas_panel_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            pointX = -10;
            pointY = -10;
        }

        private void ColorDialog_btn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
            }
        }
    }
}
