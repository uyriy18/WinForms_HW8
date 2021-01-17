namespace Paint
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
            this.menu_panel = new System.Windows.Forms.Panel();
            this.fontStyle_cmbx = new System.Windows.Forms.ComboBox();
            this.fontHeight_cmbx = new System.Windows.Forms.ComboBox();
            this.MOde_Panel = new System.Windows.Forms.Panel();
            this.eraser_pxbx = new System.Windows.Forms.PictureBox();
            this.pipete_pcbx = new System.Windows.Forms.PictureBox();
            this.fill_pcbx = new System.Windows.Forms.PictureBox();
            this.text_pcbx = new System.Windows.Forms.PictureBox();
            this.line_pcbx = new System.Windows.Forms.PictureBox();
            this.ellipse_pcbx = new System.Windows.Forms.PictureBox();
            this.rectangle_pcbx = new System.Windows.Forms.PictureBox();
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Layer0_pcbx = new System.Windows.Forms.PictureBox();
            this.menu_panel.SuspendLayout();
            this.MOde_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eraser_pxbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipete_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fill_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipse_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_pcbx)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.Layer0_pcbx)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.Controls.Add(this.fontStyle_cmbx);
            this.menu_panel.Controls.Add(this.fontHeight_cmbx);
            this.menu_panel.Controls.Add(this.MOde_Panel);
            this.menu_panel.Controls.Add(this.width_lbl);
            this.menu_panel.Controls.Add(this.width_trBar);
            this.menu_panel.Controls.Add(this.currentColor_pcbx);
            this.menu_panel.Controls.Add(this.Color_panel);
            this.menu_panel.Controls.Add(this.menuStrip1);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(800, 100);
            this.menu_panel.TabIndex = 0;
            // 
            // fontStyle_cmbx
            // 
            this.fontStyle_cmbx.FormattingEnabled = true;
            this.fontStyle_cmbx.Location = new System.Drawing.Point(459, 71);
            this.fontStyle_cmbx.Name = "fontStyle_cmbx";
            this.fontStyle_cmbx.Size = new System.Drawing.Size(127, 21);
            this.fontStyle_cmbx.TabIndex = 7;
            this.fontStyle_cmbx.SelectedIndexChanged += new System.EventHandler(this.fontStyle_cmbx_SelectedIndexChanged);
            // 
            // fontHeight_cmbx
            // 
            this.fontHeight_cmbx.FormattingEnabled = true;
            this.fontHeight_cmbx.Location = new System.Drawing.Point(368, 71);
            this.fontHeight_cmbx.Name = "fontHeight_cmbx";
            this.fontHeight_cmbx.Size = new System.Drawing.Size(44, 21);
            this.fontHeight_cmbx.TabIndex = 6;
            this.fontHeight_cmbx.SelectedIndexChanged += new System.EventHandler(this.fontHeight_cmbx_SelectedIndexChanged);
            // 
            // MOde_Panel
            // 
            this.MOde_Panel.Controls.Add(this.eraser_pxbx);
            this.MOde_Panel.Controls.Add(this.pipete_pcbx);
            this.MOde_Panel.Controls.Add(this.fill_pcbx);
            this.MOde_Panel.Controls.Add(this.text_pcbx);
            this.MOde_Panel.Controls.Add(this.line_pcbx);
            this.MOde_Panel.Controls.Add(this.ellipse_pcbx);
            this.MOde_Panel.Controls.Add(this.rectangle_pcbx);
            this.MOde_Panel.Controls.Add(this.triangle_pcbx);
            this.MOde_Panel.Controls.Add(this.pen_pcbx);
            this.MOde_Panel.Location = new System.Drawing.Point(4, 62);
            this.MOde_Panel.Name = "MOde_Panel";
            this.MOde_Panel.Size = new System.Drawing.Size(320, 32);
            this.MOde_Panel.TabIndex = 5;
            // 
            // eraser_pxbx
            // 
            this.eraser_pxbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eraser_pxbx.Image = global::Paint.Properties.Resources.Eraser;
            this.eraser_pxbx.Location = new System.Drawing.Point(276, 3);
            this.eraser_pxbx.Name = "eraser_pxbx";
            this.eraser_pxbx.Size = new System.Drawing.Size(28, 28);
            this.eraser_pxbx.TabIndex = 8;
            this.eraser_pxbx.TabStop = false;
            this.eraser_pxbx.Click += new System.EventHandler(this.eraser_pxbx_Click);
            // 
            // pipete_pcbx
            // 
            this.pipete_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pipete_pcbx.Image = global::Paint.Properties.Resources.pipette;
            this.pipete_pcbx.Location = new System.Drawing.Point(242, 3);
            this.pipete_pcbx.Name = "pipete_pcbx";
            this.pipete_pcbx.Size = new System.Drawing.Size(28, 28);
            this.pipete_pcbx.TabIndex = 7;
            this.pipete_pcbx.TabStop = false;
            this.pipete_pcbx.Click += new System.EventHandler(this.pipete_pcbx_Click);
            // 
            // fill_pcbx
            // 
            this.fill_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fill_pcbx.Image = global::Paint.Properties.Resources.Bg_Color_icon;
            this.fill_pcbx.Location = new System.Drawing.Point(208, 3);
            this.fill_pcbx.Name = "fill_pcbx";
            this.fill_pcbx.Size = new System.Drawing.Size(28, 28);
            this.fill_pcbx.TabIndex = 6;
            this.fill_pcbx.TabStop = false;
            this.fill_pcbx.Click += new System.EventHandler(this.fill_pcbx_Click);
            // 
            // text_pcbx
            // 
            this.text_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.text_pcbx.Image = global::Paint.Properties.Resources.Text;
            this.text_pcbx.Location = new System.Drawing.Point(174, 3);
            this.text_pcbx.Name = "text_pcbx";
            this.text_pcbx.Size = new System.Drawing.Size(28, 28);
            this.text_pcbx.TabIndex = 5;
            this.text_pcbx.TabStop = false;
            this.text_pcbx.Click += new System.EventHandler(this.text_pcbx_Click);
            // 
            // line_pcbx
            // 
            this.line_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.line_pcbx.Image = global::Paint.Properties.Resources.Line;
            this.line_pcbx.Location = new System.Drawing.Point(140, 3);
            this.line_pcbx.Name = "line_pcbx";
            this.line_pcbx.Size = new System.Drawing.Size(28, 28);
            this.line_pcbx.TabIndex = 4;
            this.line_pcbx.TabStop = false;
            this.line_pcbx.Click += new System.EventHandler(this.line_pcbx_Click);
            // 
            // ellipse_pcbx
            // 
            this.ellipse_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ellipse_pcbx.Image = global::Paint.Properties.Resources.Ellipse_;
            this.ellipse_pcbx.Location = new System.Drawing.Point(106, 3);
            this.ellipse_pcbx.Name = "ellipse_pcbx";
            this.ellipse_pcbx.Size = new System.Drawing.Size(28, 28);
            this.ellipse_pcbx.TabIndex = 3;
            this.ellipse_pcbx.TabStop = false;
            this.ellipse_pcbx.Click += new System.EventHandler(this.elipse_pcbx_Click);
            // 
            // rectangle_pcbx
            // 
            this.rectangle_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangle_pcbx.Image = global::Paint.Properties.Resources.Rectangle;
            this.rectangle_pcbx.Location = new System.Drawing.Point(72, 3);
            this.rectangle_pcbx.Name = "rectangle_pcbx";
            this.rectangle_pcbx.Size = new System.Drawing.Size(28, 28);
            this.rectangle_pcbx.TabIndex = 2;
            this.rectangle_pcbx.TabStop = false;
            this.rectangle_pcbx.Click += new System.EventHandler(this.rectangle_pcbx_Click);
            // 
            // triangle_pcbx
            // 
            this.triangle_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.triangle_pcbx.Image = global::Paint.Properties.Resources.Triangle;
            this.triangle_pcbx.Location = new System.Drawing.Point(40, 3);
            this.triangle_pcbx.Name = "triangle_pcbx";
            this.triangle_pcbx.Size = new System.Drawing.Size(28, 28);
            this.triangle_pcbx.TabIndex = 1;
            this.triangle_pcbx.TabStop = false;
            this.triangle_pcbx.Click += new System.EventHandler(this.triangle_pcbx_Click);
            // 
            // pen_pcbx
            // 
            this.pen_pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pen_pcbx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pen_pcbx.Image = global::Paint.Properties.Resources.pen;
            this.pen_pcbx.Location = new System.Drawing.Point(8, 3);
            this.pen_pcbx.Name = "pen_pcbx";
            this.pen_pcbx.Size = new System.Drawing.Size(28, 28);
            this.pen_pcbx.TabIndex = 0;
            this.pen_pcbx.TabStop = false;
            this.pen_pcbx.Click += new System.EventHandler(this.pen_pcbx_Click);
            // 
            // width_lbl
            // 
            this.width_lbl.AutoSize = true;
            this.width_lbl.Location = new System.Drawing.Point(559, 31);
            this.width_lbl.Name = "width_lbl";
            this.width_lbl.Size = new System.Drawing.Size(0, 13);
            this.width_lbl.TabIndex = 4;
            // 
            // width_trBar
            // 
            this.width_trBar.Location = new System.Drawing.Point(449, 27);
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
            this.currentColor_pcbx.Location = new System.Drawing.Point(368, 27);
            this.currentColor_pcbx.Name = "currentColor_pcbx";
            this.currentColor_pcbx.Size = new System.Drawing.Size(44, 28);
            this.currentColor_pcbx.TabIndex = 2;
            this.currentColor_pcbx.TabStop = false;
            this.currentColor_pcbx.Click += new System.EventHandler(this.currentColor_pcbx_Click);
            // 
            // Color_panel
            // 
            this.Color_panel.Controls.Add(this.Color_btn);
            this.Color_panel.Controls.Add(this.pictureBox5);
            this.Color_panel.Controls.Add(this.pictureBox4);
            this.Color_panel.Controls.Add(this.pictureBox3);
            this.Color_panel.Controls.Add(this.pictureBox2);
            this.Color_panel.Controls.Add(this.pictureBox1);
            this.Color_panel.Location = new System.Drawing.Point(4, 28);
            this.Color_panel.Name = "Color_panel";
            this.Color_panel.Size = new System.Drawing.Size(320, 27);
            this.Color_panel.TabIndex = 1;
            // 
            // Color_btn
            // 
            this.Color_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Color_btn.ForeColor = System.Drawing.Color.White;
            this.Color_btn.Location = new System.Drawing.Point(242, -1);
            this.Color_btn.Name = "Color_btn";
            this.Color_btn.Size = new System.Drawing.Size(75, 28);
            this.Color_btn.TabIndex = 3;
            this.Color_btn.Text = "More ...";
            this.Color_btn.UseVisualStyleBackColor = false;
            this.Color_btn.Click += new System.EventHandler(this.Color_btn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(183, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 21);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Green;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(138, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 21);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(93, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 21);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(48, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 21);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 21);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
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
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            this.aboutProgramToolStripMenuItem.Text = "About program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = " \"Файлы изображений|*.jpg;*.png;*.jpeg\";";
            // 
            // Layer0_pcbx
            // 
            this.Layer0_pcbx.BackColor = System.Drawing.Color.White;
            this.Layer0_pcbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layer0_pcbx.Location = new System.Drawing.Point(0, 100);
            this.Layer0_pcbx.Name = "Layer0_pcbx";
            this.Layer0_pcbx.Size = new System.Drawing.Size(800, 350);
            this.Layer0_pcbx.TabIndex = 1;
            this.Layer0_pcbx.TabStop = false;
            this.Layer0_pcbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Layer0_pcbx_MouseClick);
            this.Layer0_pcbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Layer0_pcbx_MouseDown);
            this.Layer0_pcbx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Layer0_pcbx_MouseMove);
            this.Layer0_pcbx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Layer0_pcbx_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Layer0_pcbx);
            this.Controls.Add(this.menu_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.MOde_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eraser_pxbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipete_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fill_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ellipse_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangle_pcbx)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.Layer0_pcbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Panel MOde_Panel;
        private System.Windows.Forms.PictureBox ellipse_pcbx;
        private System.Windows.Forms.PictureBox rectangle_pcbx;
        private System.Windows.Forms.PictureBox triangle_pcbx;
        private System.Windows.Forms.PictureBox pen_pcbx;
        private System.Windows.Forms.Label width_lbl;
        private System.Windows.Forms.TrackBar width_trBar;
        private System.Windows.Forms.PictureBox currentColor_pcbx;
        private System.Windows.Forms.Panel Color_panel;
        private System.Windows.Forms.Button Color_btn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.PictureBox Layer0_pcbx;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox line_pcbx;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.PictureBox text_pcbx;
        private System.Windows.Forms.PictureBox fill_pcbx;
        private System.Windows.Forms.ComboBox fontStyle_cmbx;
        private System.Windows.Forms.ComboBox fontHeight_cmbx;
        private System.Windows.Forms.PictureBox pipete_pcbx;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.PictureBox eraser_pxbx;
    }
}

