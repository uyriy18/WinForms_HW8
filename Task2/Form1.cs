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
                pointX = e.X;
                pointY = e.Y;
            }
            //if triangle was chosen
            if(Figure_cmbx.SelectedItem.ToString() == "Triangle")
            {
                Point p = new Point(pointX, pointY);
                pointCollection.Add(p);
                Rectangle r = new Rectangle(pointX, pointY, 5, 5);
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
            //If combo box selected item name = "Pen"
            if(Figure_cmbx.SelectedItem.ToString() == "Pen")
            {
                if (isMoving && pointX != -10 && pointY != -10)
                {
                    g.DrawLine(pen, new Point(pointX, pointY), e.Location);
                    pointX = e.X;
                    pointY = e.Y;
                }
            }
           
        }

        private void Canvas_panel_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
            pointX = -10;
            pointY = -10;
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
    }
}
