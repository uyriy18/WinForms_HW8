namespace Winform_Exam_Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.MOde_Panel = new System.Windows.Forms.Panel();
            this.triangle_pcbx = new System.Windows.Forms.PictureBox();
            this.pen_pcbx = new System.Windows.Forms.PictureBox();
            this.width_lbl = new System.Windows.Forms.Label();
            this.width_trBar = new System.Windows.Forms.TrackBar();
            this.currentColor_pcbx = new System.Windows.Forms.PictureBox();
            this.Color_panel = new System.Windows.Forms.Panel();
            this.Color_btn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_panel = new System.Windows.Forms.Panel();
            this.Layer0_pcbx = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rectangle_pcbx = new System.Windows.Forms.PictureBox();
            this.ellipse_pcbx = new System.Windows.Forms.PictureBox();
            this.menu_panel.SuspendLayout();
            this.MOde_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triangle_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pen_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_trBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColor_pcbx)).BeginInit();
            this.Color_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Layer0_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipse_pcbx)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu_panel.Controls.Add(this.MOde_Panel);
            this.menu_panel.Controls.Add(this.width_lbl);
            this.menu_panel.Controls.Add(this.width_trBar);
            this.menu_panel.Controls.Add(this.currentColor_pcbx);
            this.menu_panel.Controls.Add(this.Color_panel);
            this.menu_panel.Controls.Add(this.menuStrip1);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(800, 84);
            this.menu_panel.TabIndex = 0;
            // 
            // MOde_Panel
            // 
            this.MOde_Panel.Controls.Add(this.ellipse_pcbx);
            this.MOde_Panel.Controls.Add(this.rectangle_pcbx);
            this.MOde_Panel.Controls.Add(this.triangle_pcbx);
            this.MOde_Panel.Controls.Add(this.pen_pcbx);
            this.MOde_Panel.Location = new System.Drawing.Point(12, 48);
            this.MOde_Panel.Name = "MOde_Panel";
            this.MOde_Panel.Size = new System.Drawing.Size(280, 36);
            this.MOde_Panel.TabIndex = 5;
            // 
            // triangle_pcbx
            // 
            this.triangle_pcbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangle_pcbx.BackgroundImage")));
            this.triangle_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangle_pcbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangle_pcbx.Location = new System.Drawing.Point(42, 6);
            this.triangle_pcbx.Name = "triangle_pcbx";
            this.triangle_pcbx.Size = new System.Drawing.Size(26, 26);
            this.triangle_pcbx.TabIndex = 1;
            this.triangle_pcbx.TabStop = false;
            this.triangle_pcbx.Click += new System.EventHandler(this.triangle_pcbx_Click);
            // 
            // pen_pcbx
            // 
            this.pen_pcbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pen_pcbx.BackgroundImage")));
            this.pen_pcbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pen_pcbx.Location = new System.Drawing.Point(3, 6);
            this.pen_pcbx.Name = "pen_pcbx";
            this.pen_pcbx.Size = new System.Drawing.Size(26, 26);
            this.pen_pcbx.TabIndex = 0;
            this.pen_pcbx.TabStop = false;
            this.pen_pcbx.Click += new System.EventHandler(this.pen_pcbx_Click);
            // 
            // width_lbl
            // 
            this.width_lbl.AutoSize = true;
            this.width_lbl.Location = new System.Drawing.Point(542, 29);
            this.width_lbl.Name = "width_lbl";
            this.width_lbl.Size = new System.Drawing.Size(0, 13);
            this.width_lbl.TabIndex = 4;
            // 
            // width_trBar
            // 
            this.width_trBar.Location = new System.Drawing.Point(432, 27);
            this.width_trBar.Maximum = 100;
            this.width_trBar.Minimum = 1;
            this.width_trBar.Name = "width_trBar";
            this.width_trBar.Size = new System.Drawing.Size(104, 45);
            this.width_trBar.TabIndex = 3;
            this.width_trBar.Value = 5;
            this.width_trBar.Scroll += new System.EventHandler(this.width_trBar_Scroll);
            // 
            // currentColor_pcbx
            // 
            this.currentColor_pcbx.Location = new System.Drawing.Point(392, 27);
            this.currentColor_pcbx.Name = "currentColor_pcbx";
            this.currentColor_pcbx.Size = new System.Drawing.Size(34, 24);
            this.currentColor_pcbx.TabIndex = 2;
            this.currentColor_pcbx.TabStop = false;
            // 
            // Color_panel
            // 
            this.Color_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Color_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Color_panel.Controls.Add(this.Color_btn);
            this.Color_panel.Controls.Add(this.pictureBox5);
            this.Color_panel.Controls.Add(this.pictureBox4);
            this.Color_panel.Controls.Add(this.pictureBox3);
            this.Color_panel.Controls.Add(this.pictureBox2);
            this.Color_panel.Controls.Add(this.pictureBox1);
            this.Color_panel.Location = new System.Drawing.Point(12, 27);
            this.Color_panel.Name = "Color_panel";
            this.Color_panel.Size = new System.Drawing.Size(280, 24);
            this.Color_panel.TabIndex = 1;
            // 
            // Color_btn
            // 
            this.Color_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Color_btn.ForeColor = System.Drawing.Color.White;
            this.Color_btn.Location = new System.Drawing.Point(200, -2);
            this.Color_btn.Name = "Color_btn";
            this.Color_btn.Size = new System.Drawing.Size(78, 24);
            this.Color_btn.TabIndex = 4;
            this.Color_btn.Text = "More...";
            this.Color_btn.UseVisualStyleBackColor = false;
            this.Color_btn.Click += new System.EventHandler(this.Color_btn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(160, -2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 24);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(120, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 24);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(80, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 24);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(40, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 24);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.Layer0_pcbx);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 84);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(800, 366);
            this.main_panel.TabIndex = 1;
            // 
            // Layer0_pcbx
            // 
            this.Layer0_pcbx.BackColor = System.Drawing.Color.White;
            this.Layer0_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Layer0_pcbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layer0_pcbx.Location = new System.Drawing.Point(0, 0);
            this.Layer0_pcbx.Name = "Layer0_pcbx";
            this.Layer0_pcbx.Size = new System.Drawing.Size(800, 366);
            this.Layer0_pcbx.TabIndex = 0;
            this.Layer0_pcbx.TabStop = false;
            this.Layer0_pcbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Layer0_pcbx_MouseDown);
            this.Layer0_pcbx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Layer0_pcbx_MouseMove);
            this.Layer0_pcbx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Layer0_pcbx_MouseUp);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "jpg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // rectangle_pcbx
            // 
            this.rectangle_pcbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle_pcbx.BackgroundImage")));
            this.rectangle_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangle_pcbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rectangle_pcbx.Location = new System.Drawing.Point(82, 6);
            this.rectangle_pcbx.Name = "rectangle_pcbx";
            this.rectangle_pcbx.Size = new System.Drawing.Size(26, 26);
            this.rectangle_pcbx.TabIndex = 2;
            this.rectangle_pcbx.TabStop = false;
            this.rectangle_pcbx.Click += new System.EventHandler(this.rectangle_pcbx_Click);
            // 
            // ellipse_pcbx
            // 
            this.ellipse_pcbx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipse_pcbx.BackgroundImage")));
            this.ellipse_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ellipse_pcbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ellipse_pcbx.Location = new System.Drawing.Point(122, 6);
            this.ellipse_pcbx.Name = "ellipse_pcbx";
            this.ellipse_pcbx.Size = new System.Drawing.Size(26, 26);
            this.ellipse_pcbx.TabIndex = 3;
            this.ellipse_pcbx.TabStop = false;
            this.ellipse_pcbx.Click += new System.EventHandler(this.elipse_pcbx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.menu_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.MOde_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triangle_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pen_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_trBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColor_pcbx)).EndInit();
            this.Color_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Layer0_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipse_pcbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox Layer0_pcbx;
        private System.Windows.Forms.Panel Color_panel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Color_btn;
        private System.Windows.Forms.PictureBox currentColor_pcbx;
        private System.Windows.Forms.Label width_lbl;
        private System.Windows.Forms.TrackBar width_trBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel MOde_Panel;
        private System.Windows.Forms.PictureBox triangle_pcbx;
        private System.Windows.Forms.PictureBox pen_pcbx;
        private System.Windows.Forms.PictureBox ellipse_pcbx;
        private System.Windows.Forms.PictureBox rectangle_pcbx;
    }
}

