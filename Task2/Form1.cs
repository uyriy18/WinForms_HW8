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
            
        public Form1()  
        {
            InitializeComponent();
        }

        void drawTriangle(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            Pen redPen = new Pen(Color.Red);
            Point p1 = new Point(e.X, e.Y);
            Rectangle r = new Rectangle(p1.X, p1.Y, 5, 5);
            g.FillEllipse(new SolidBrush(Color.Red), r);
            pointCollection.Add(p1);
            if(pointCollection.Count == 3)
            {
                g.DrawLine(redPen, pointCollection[0], pointCollection[1]);
                g.DrawLine(redPen, pointCollection[1], pointCollection[2]);
                g.DrawLine(redPen, pointCollection[2], pointCollection[0]);
                pointCollection.Clear();
            }


        }

        
    }
}
