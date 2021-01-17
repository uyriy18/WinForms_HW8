using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int X0;                      //mouse down X coordinate
        int Y0;                      //mouse down Y coordinate
        int X;                       //mouse moving X coordinate
        int Y;                       //mouse moving Y coordinate
        Bitmap mainPic;              //Canvas for drawing
        Bitmap tmpPic;               //Temporary layer for drawing
        Color color;                 //Chosen color (default - black)
        int width;                   //Width of our pen and brush
        string paintMode = "pen";    //Drawing mode, denpends on what we want to draw (rectangle, triangle, lines, pen , brush)
        bool isMoving;               //when mouse down isMoving = true, when mouse up isMoving = false
        Pen pen;
        bool isTyping = false;       //If we are typing smth. in text mode isTyping = true, else = false
        List<Point> pointCollection; //point list for triangle drawing
        string message;
        TextBox textBox;
        int textX, textY;            //for text box coordinates storing
        int fontHeight;              //for seting text height
        string fontStyle;            //for seting text style
        InstalledFontCollection fontList; // font styles collection

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
            fontHeight = 14;
            pointCollection = new List<Point>();
            fillFontcomboBoxes();                           // fill font height and fond style combo boxes
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
                    case "text":
                        if (!isTyping)
                        {
                            textX = e.X;                                                     //set textbox field coordinates
                            textY = e.Y;
                            addText();
                        }
                        break;
                    case "fill":
                        FloodFill(mainPic, e.Location, color);
                        Layer0_pcbx.Image = mainPic;
                        break;
                    case "pipete":                
                        color = mainPic.GetPixel(e.X, e.Y);                                  // set color from mouse position
                        currentColor_pcbx.BackColor = color;
                        break;
                    case "eraser":
                        pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;  // using round cap
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;  // make's line more smoothy 
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
                        g1.DrawImage(mainPic, 0, 0);                              // transport main picture on temp layer
                        Layer0_pcbx.Image = tmpPic;                               // transport full composition on main layer
                        break;
                    case "ellipse":                                       // as rectangle
                        g1.Clear(Color.White);
                        g1.DrawEllipse(pen, X0, Y0, X - X0, Y - Y0);
                        g1.DrawImage(mainPic, 0, 0);                              // transport main picture on temp layer
                        Layer0_pcbx.Image = tmpPic;                               // transport full composition on main layer
                        break;
                    case "line":
                        g1.Clear(Color.White);
                        g1.DrawLine(pen, X0, Y0, X, Y);
                        g1.DrawImage(mainPic, 0, 0);                              // transport main picture on temp layer
                        Layer0_pcbx.Image = tmpPic;                               // transport full composition on main layer
                        break;
                    case "eraser":
                        g.DrawLine(pen, X0, Y0, X, Y);
                        Layer0_pcbx.Image = mainPic;
                        X0 = e.X;
                        Y0 = e.Y;
                        break;

                }
                
               
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
                    Layer0_pcbx.Image = mainPic;
                    break;
                case "ellipse":                                          // as recangle
                    g.DrawEllipse(pen, X0, Y0, X - X0, Y - Y0);
                    Layer0_pcbx.Image = mainPic;
                    break;
                case "line":
                    g.DrawLine(pen, X0, Y0, X, Y);
                    Layer0_pcbx.Image = mainPic;
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

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(mainPic);
            g.Clear(Color.White);
            Layer0_pcbx.Image = mainPic;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "" && result == DialogResult.OK)
            {
                mainPic.Save(saveFileDialog1.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "" && result == DialogResult.OK)
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
            text_pcbx.BorderStyle = BorderStyle.None;
            fill_pcbx.BorderStyle = BorderStyle.None;
            pipete_pcbx.BorderStyle = BorderStyle.None;
            eraser_pxbx.BorderStyle = BorderStyle.None;
        }

        private void triangle_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "triangle";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.Fixed3D;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
            text_pcbx.BorderStyle = BorderStyle.None;
            fill_pcbx.BorderStyle = BorderStyle.None;
            pipete_pcbx.BorderStyle = BorderStyle.None;
            eraser_pxbx.BorderStyle = BorderStyle.None;
        }

        private void rectangle_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "rectangle";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.Fixed3D;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
            text_pcbx.BorderStyle = BorderStyle.None;
            fill_pcbx.BorderStyle = BorderStyle.None;
            pipete_pcbx.BorderStyle = BorderStyle.None;
            eraser_pxbx.BorderStyle = BorderStyle.None;
        }

        private void elipse_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "ellipse";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.Fixed3D;
            line_pcbx.BorderStyle = BorderStyle.None;
            text_pcbx.BorderStyle = BorderStyle.None;
            fill_pcbx.BorderStyle = BorderStyle.None;
            pipete_pcbx.BorderStyle = BorderStyle.None;
            eraser_pxbx.BorderStyle = BorderStyle.None;
        }

        private void line_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "line";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.Fixed3D;
            text_pcbx.BorderStyle = BorderStyle.None;
            fill_pcbx.BorderStyle = BorderStyle.None;
            pipete_pcbx.BorderStyle = BorderStyle.None;
            eraser_pxbx.BorderStyle = BorderStyle.None;
        }
        private void text_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "text";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
            text_pcbx.BorderStyle = BorderStyle.Fixed3D;
            fill_pcbx.BorderStyle = BorderStyle.None;
            pipete_pcbx.BorderStyle = BorderStyle.None;
            eraser_pxbx.BorderStyle = BorderStyle.None;
        }

        private void fill_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "fill";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
            text_pcbx.BorderStyle = BorderStyle.None;
            fill_pcbx.BorderStyle = BorderStyle.Fixed3D;
            pipete_pcbx.BorderStyle = BorderStyle.None;
            eraser_pxbx.BorderStyle = BorderStyle.None;
        }
        private void pipete_pcbx_Click(object sender, EventArgs e)
        {
            paintMode = "pipete";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
            text_pcbx.BorderStyle = BorderStyle.None;
            fill_pcbx.BorderStyle = BorderStyle.None;
            pipete_pcbx.BorderStyle = BorderStyle.Fixed3D;
            eraser_pxbx.BorderStyle = BorderStyle.None;
        }
        private void eraser_pxbx_Click(object sender, EventArgs e)
        {
            paintMode = "eraser";
            pen_pcbx.BorderStyle = BorderStyle.None;
            triangle_pcbx.BorderStyle = BorderStyle.None;
            rectangle_pcbx.BorderStyle = BorderStyle.None;
            ellipse_pcbx.BorderStyle = BorderStyle.None;
            line_pcbx.BorderStyle = BorderStyle.None;
            text_pcbx.BorderStyle = BorderStyle.None;
            fill_pcbx.BorderStyle = BorderStyle.None;
            pipete_pcbx.BorderStyle = BorderStyle.None;
            eraser_pxbx.BorderStyle = BorderStyle.Fixed3D;
            color = Color.White;
            currentColor_pcbx.BackColor = color;
            width_trBar.Value = width = 20;
            width_lbl.Text = width.ToString();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("program was developed by IT-step academy student Bartash Yriy", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        private void FloodFill(Bitmap bmp, Point pt, Color replacementColor)  // using  flood and fill algorithm
        {
            Color targetColor = bmp.GetPixel(pt.X, pt.Y);                     // get color from selected pixel
            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))       
            {
                return;
            }

            Stack<Point> pixels = new Stack<Point>();                         // to store pixels will use Stack list

            pixels.Push(pt);                                                  // push pixel in to stack
            while (pixels.Count != 0)                                              
            {
                Point temp = pixels.Pop();                                    // pop pixel
                int y1 = temp.Y;                                              // set pixel position on Y axis
                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)    // getting up Y position to latest point meeting the condition
                {
                    y1--;                
                }
                y1++;
                bool spanLeft = false;
                bool spanRight = false;
                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));               // move cursor position on 1 point left
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));               // move cursor position on 1 point right
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }

            }
            pictureBox1.Refresh();

        }

        void addText()                                             // method for text adding
        {
            textBox = new TextBox();                               // dynamicly creating textbox
            textBox.Multiline = true;
            textBox.Size = new Size((fontHeight < 20 ? 100 : fontHeight + 300) , (fontHeight > 20 ? fontHeight + 15: 25));
            textBox.Font = new Font(fontStyle, fontHeight);
            textBox.Location = new Point(textX, textY - 15);       // get mouse pisition for our text box
            Layer0_pcbx.Controls.Add(textBox);                     // add text box to our main picture box
            isTyping = true;                                       // enter in typing mode
        }

        private void Layer0_pcbx_MouseClick(object sender, MouseEventArgs e)
        {
            if (isTyping)                                  // check : whether we in typing mode
            {
                Graphics g = Graphics.FromImage(mainPic);
                message = textBox.Text;
                Font font = new Font(fontStyle, fontHeight, FontStyle.Regular);
                g.DrawString(message, font, new SolidBrush(color), new Point(textX, textY - 15));
                Layer0_pcbx.Image = mainPic;
                textBox.Dispose();                        // close textbox
                isTyping = false;                         // exit from typing mode
            }
        }

        private void fontHeight_cmbx_SelectedIndexChanged(object sender, EventArgs e)    // set font styles in combo box
        {
            if(fontHeight_cmbx.SelectedIndex != -1 && fontStyle_cmbx.SelectedIndex != -1)
            {
                fontHeight = (int)fontHeight_cmbx.SelectedItem;
            }
        }

        private void fontStyle_cmbx_SelectedIndexChanged(object sender, EventArgs e)     // set font height in combo box
        {
            if (fontHeight_cmbx.SelectedIndex != -1 && fontStyle_cmbx.SelectedIndex != -1)
            {
                fontStyle = (string)fontStyle_cmbx.SelectedItem;
            }
        }

        private void currentColor_pcbx_Click(object sender, EventArgs e) // show color dialog
        {
            Color_btn_Click(sender, null);                
        }

        void fillFontcomboBoxes()                         // filling font height and font style comboboxes
        {
            fontList = new InstalledFontCollection();
            foreach (var item in fontList.Families)        // adding font styles
            {
                fontStyle_cmbx.Items.Add(item.Name);
            }
            for (int i = 1; i < 200; i++)                  // adding font height
            {
                fontHeight_cmbx.Items.Add(i);
            }
            fontStyle_cmbx.SelectedItem = fontStyle = "Times New Roman";  // set default font style
            fontHeight_cmbx.SelectedItem = fontHeight = 14;               // set default font height
        }
        
    }
}
