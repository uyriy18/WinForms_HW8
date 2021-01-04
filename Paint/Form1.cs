using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int X0;                    //mouse down X coordinate
        int Y0;                    //mouse down Y coordinate
        int X;                     //mouse moving X coordinate
        int Y;                     //mouse moving Y coordinate
        Bitmap pic;                //Canvas for drawing
        Color color;               //Chosen color (default - black)
        int width;                 //Width of our pen and brush
        string paintMode = "pen";  //Drawing mode, denpends on what we want to draw (rectangle, triangle, lines, pen , brush)
        bool isMoving;             //when mouse down isMoving = true, when mouse up isMoving = false
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            color = Color.Black;
            width = 5;
            currentColor_pcbx.BackColor = color;
            pic = new Bitmap(1000, 1000);
            width_lbl.Text = width.ToString();
            pen = new Pen(color, width);
        }

        private void Layer0_pcbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMoving = true;
                X0 = e.X;
                Y0 = e.Y;

                Graphics g = Graphics.FromImage(pic);
                switch (paintMode)
                {
                    case "pen":
                        pen = new Pen(color, width);
                        pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;  // using round cap
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  // make's line more smoothy
                        Layer0_pcbx.Cursor = Cursors.Cross;
                        break;
                    case "triangle":
                        Point p = e.Location;
                        List<Point> pointCollection = new List<Point>();
                        pointCollection.Add(p);
                        g.FillEllipse(new SolidBrush(color), new Rectangle(X0, Y0, 5, 5));
                        if (pointCollection.Count == 3)
                        {
                            g.DrawLine(pen, pointCollection[0], pointCollection[1]);
                            g.DrawLine(pen, pointCollection[1], pointCollection[2]);
                            g.DrawLine(pen, pointCollection[2], pointCollection[0]);
                            pointCollection.Clear();
                        }
                        break;
                }
            }

        }

        private void Layer0_pcbx_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                X = e.X;
                Y = e.Y;
                Graphics g = Graphics.FromImage(pic);
                switch (paintMode)
                {
                    case "pen":
                        g.DrawLine(pen, X0, Y0, X, Y);
                        Layer0_pcbx.Image = pic;
                        break;
                }
                X0 = e.X;
                Y0 = e.Y;
            }
        }

        private void Layer0_pcbx_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            Layer0_pcbx.Cursor = Cursors.Default;

        }

        // Colors panel for color chosing
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            color = p.BackColor;
            currentColor_pcbx.BackColor = color;
        }

        // Invoke color dialog for color_btn
        private void Color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                color = cd.Color;
                currentColor_pcbx.BackColor = color;
            }
        }

        private void width_trBar_Scroll(object sender, EventArgs e)        //adjusting pen's cap width
        {
            width = width_trBar.Value;
            width_lbl.Text = width.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                pic.Save(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                Layer0_pcbx.Image = pic;
            }
        }

        private void pen_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "pen";
        }

        private void triangle_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "triangle";
        }

        private void rectangle_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "rectangle";
        }

        private void elipse_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "elipse";
        }
    }
}
