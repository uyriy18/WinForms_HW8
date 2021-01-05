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
        Bitmap mainPic;                //Canvas for drawing
        Bitmap tmpPic;             //Temporary layer for drawing
        Color color;               //Chosen color (default - black)
        int width;                 //Width of our pen and brush
        string paintMode = "pen";  //Drawing mode, denpends on what we want to draw (rectangle, triangle, lines, pen , brush)
        bool isMoving;             //when mouse down isMoving = true, when mouse up isMoving = false
        Pen pen;
        List<Point> pointCollection; //point list for triangle drawing
        public Form1()
        {
            InitializeComponent();
            color = Color.Black;
            width = 5;                    
            currentColor_pcbx.BackColor = color;
            mainPic = new Bitmap(1000, 1000);
            tmpPic = new Bitmap(1000, 1000);
            width_lbl.Text = width.ToString();
            pen = new Pen(color, width);
            pointCollection = new List<Point>();
        }

        private void Layer0_pcbx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMoving = true;
                X0 = e.X;
                Y0 = e.Y;

                Graphics g = Graphics.FromImage(mainPic);
                pen = new Pen(color, width);
                Layer0_pcbx.Cursor = Cursors.Cross;
                switch (paintMode)
                {
                    case "pen":
                        pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;  // using round cap
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  // make's line more smoothy                      
                        break;
                    case "triangle":
                        pointCollection.Add(new Point(X0, Y0));                               //adding new pint to point list
                        g.FillEllipse(new SolidBrush(color), new Rectangle(X0, Y0, 5, 5));    //draw point
                        if (pointCollection.Count == 3)                                       //if point amount == 3 - draw triangle and clear the list
                        {
                            g.DrawLine(pen, pointCollection[0], pointCollection[1]);
                            g.DrawLine(pen, pointCollection[1], pointCollection[2]);
                            g.DrawLine(pen, pointCollection[2], pointCollection[0]);
                            pointCollection.Clear();
                        }
                        Layer0_pcbx.Image = mainPic;
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
                Graphics g = Graphics.FromImage(mainPic);
                Graphics g1 = Graphics.FromImage(tmpPic);                // create new graphics for temp images
                switch (paintMode)
                {
                    case "pen":
                        g.DrawLine(pen, X0, Y0, X, Y);
                        Layer0_pcbx.Image = mainPic;
                        X0 = e.X;
                        Y0 = e.Y;
                        break;
                    case "rectangle":
                        g1.Clear(Color.White);                            // drop previous temp rectangle. We will set on main layer only last rectangle after mouseUp event
                        g1.DrawRectangle(pen, X0, Y0, X - X0, Y - Y0);    // draw new temp rectangle
                        break;
                    case "ellipse":                                       // as rectangle
                        g1.Clear(Color.White);
                        g1.DrawEllipse(pen, X0, Y0, X - X0, Y - Y0);
                        break;
                    case "line":
                        g1.Clear(Color.White);
                        g1.DrawLine(pen, X0, Y0, X, Y);
                        break;
                }
                
                g1.DrawImage(mainPic, 0, 0);                              // transport main picture on temp layer
                Layer0_pcbx.Image = tmpPic;                               // transport full composition on main layer
            }
        }

        private void Layer0_pcbx_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            Layer0_pcbx.Cursor = Cursors.Default;

            Graphics g = Graphics.FromImage(mainPic);
            switch (paintMode)
            {
                case "rectangle":
                    g.DrawRectangle(pen, X0, Y0, X - X0, Y - Y0);        // Draw rectangle on main canvas
                    break;
                case "ellipse":                                          // as recangle
                    g.DrawEllipse(pen, X0, Y0, X - X0, Y - Y0);
                    break;
                case "line":
                    g.DrawLine(pen, X0, Y0, X, Y);
                    break;

            }

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
                mainPic.Save(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                mainPic = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                Layer0_pcbx.Image = mainPic;
            }
        }

        private void pen_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "pen";
            pen_pcbx.BorderStyle = BorderStyle.Fixed3D;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
        }

        private void triangle_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "triangle";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.Fixed3D;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
        }

        private void rectangle_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "rectangle";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.Fixed3D;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
        }

        private void elipse_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "ellipse";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.Fixed3D;
            line_pcbx.BorderStyle = BorderStyle.None;
        }

        private void line_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "line";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
