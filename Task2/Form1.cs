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
        Stack<Rectangle> rectangleCollection = new Stack<Rectangle>();
        Graphics g;
        Pen pen;
        Point locationXY;
        Point locationX1Y1;
     
        bool isMoving = false;
            
        public Form1()  
        {
            InitializeComponent();
            g = Canvas_panel.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Figure_cmbx.SelectedItem = "Pen";
        }
        //Select color from panel
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
                locationXY = e.Location;
            }
            //if triangle was chosen
            if(Figure_cmbx.SelectedItem.ToString() == "Triangle")
            {
                Point p = locationXY;
                pointCollection.Add(p);
                Rectangle r = new Rectangle(locationXY.X, locationXY.Y , 5, 5);
                g.FillRectangle(new SolidBrush(pen.Color), r);
                if(pointCollection.Count == 3)
                {
                    g.DrawLine(pen, pointCollection[0], pointCollection[1]);
                    g.DrawLine(pen, pointCollection[1], pointCollection[2]);
                    g.DrawLine(pen, pointCollection[2], pointCollection[0]);
                    pointCollection.Clear();
                }
            }
        }

        private void Canvas_panel_MouseMove(object sender, MouseEventArgs e)
        {
            Coordenates_lbl.Text = $"pointX = {locationXY.X}, pointY = {locationXY.Y}, e.X = {locationX1Y1.X}, e.Y = {locationX1Y1.Y}";
            if (isMoving)
            {
                locationX1Y1 = e.Location;

                //If combo box selected item name = "Pen"
                if (Figure_cmbx.SelectedItem.ToString() == "Pen")
                {
                    g.DrawLine(pen, locationXY, e.Location);
                    locationXY.X = e.X;
                    locationXY.Y = e.Y;
                }
                else if (Figure_cmbx.SelectedItem.ToString() == "Rectangle")
                {
                    g.FillRectangle(new SolidBrush(pen.Color), locationXY.X, locationXY.Y, e.X - locationXY.X, e.Y - locationXY.Y);
                                     
                }
            }
        }

        private void Canvas_panel_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            locationX1Y1 = e.Location;
            if (Figure_cmbx.SelectedItem.ToString() == "Rectangle")
            {
                g.FillRectangle(new SolidBrush(pen.Color), locationXY.X, locationXY.Y, e.X - locationXY.X, e.Y - locationXY.Y);

            }

        }
        // Select color additional colors
        private void ColorDialog_btn_Click(object sender, EventArgs e)    
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                pen.Color = cd.Color;
            }
        }
        //Show instructions
        private void Figure_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Figure_cmbx.SelectedItem) 
            {
                case "Triangle":
                    MessageBox.Show("To draw Triangle select 3 points");
                    break;
            }

        }

        private void addRectangle()
        {
            Rectangle rect = new Rectangle();
            rect.X = Math.Min(locationXY.X, locationX1Y1.X);
            rect.Y = Math.Min(locationXY.Y, locationX1Y1.Y);
            rect.Height = Math.Abs(locationXY.X - locationX1Y1.X);
            rect.Width = Math.Abs(locationXY.Y - locationX1Y1.Y);
            rectangleCollection.Push(rect);
            locationXY =new Point(0, 0);
            locationX1Y1 = new Point(0, 0);

        }

        private void Canvas_panel_Paint(object sender, PaintEventArgs e)
        {
            if(rectangleCollection.Count > 0 && Figure_cmbx.SelectedItem.ToString() == "Rectangle")
            {
                g.DrawRectangle(pen, rectangleCollection.Pop());
            }
        }
    }
}
