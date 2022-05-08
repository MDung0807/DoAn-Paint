
namespace DoAnGiuaKy_CaNhan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.pic_Color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_cong = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_square = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeSize = new System.Windows.Forms.Button();
            this.btnunSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.TrackBar();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 33);
            this.panel2.TabIndex = 4;
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(12, 12);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(72, 33);
            this.btn_move.TabIndex = 23;
            this.btn_move.Text = "Di Chuyển";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(406, 59);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(54, 30);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.DarkGray;
            this.btn_eraser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Location = new System.Drawing.Point(83, 54);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(69, 43);
            this.btn_eraser.TabIndex = 7;
            this.btn_eraser.Text = "eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            // 
            // pic_Color
            // 
            this.pic_Color.Location = new System.Drawing.Point(5, 54);
            this.pic_Color.Name = "pic_Color";
            this.pic_Color.Size = new System.Drawing.Size(61, 43);
            this.pic_Color.TabIndex = 3;
            this.pic_Color.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_polygon);
            this.panel3.Controls.Add(this.btn_cong);
            this.panel3.Controls.Add(this.btn_circle);
            this.panel3.Controls.Add(this.btn_square);
            this.panel3.Controls.Add(this.pic_Color);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Location = new System.Drawing.Point(498, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 100);
            this.panel3.TabIndex = 21;
            // 
            // btn_polygon
            // 
            this.btn_polygon.BackColor = System.Drawing.Color.DarkGray;
            this.btn_polygon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_polygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_polygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_polygon.ForeColor = System.Drawing.Color.Black;
            this.btn_polygon.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_polygon_16;
            this.btn_polygon.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_polygon.Location = new System.Drawing.Point(362, 3);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(63, 43);
            this.btn_polygon.TabIndex = 27;
            this.btn_polygon.Text = "DaGiac";
            this.btn_polygon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_polygon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_polygon.UseVisualStyleBackColor = false;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_cong
            // 
            this.btn_cong.BackColor = System.Drawing.Color.DarkGray;
            this.btn_cong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_cong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cong.ForeColor = System.Drawing.Color.Black;
            this.btn_cong.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_squiggly_line_24;
            this.btn_cong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cong.Location = new System.Drawing.Point(298, 54);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(58, 43);
            this.btn_cong.TabIndex = 26;
            this.btn_cong.Text = "Dcong";
            this.btn_cong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cong.UseVisualStyleBackColor = false;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.Color.DarkGray;
            this.btn_circle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_circle.ForeColor = System.Drawing.Color.Black;
            this.btn_circle.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_circle_16;
            this.btn_circle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_circle.Location = new System.Drawing.Point(298, 3);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(58, 43);
            this.btn_circle.TabIndex = 25;
            this.btn_circle.Text = "HTròn";
            this.btn_circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_circle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_circle.UseVisualStyleBackColor = false;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_square
            // 
            this.btn_square.BackColor = System.Drawing.Color.DarkGray;
            this.btn_square.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_square.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_square.ForeColor = System.Drawing.Color.Black;
            this.btn_square.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_square_16;
            this.btn_square.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_square.Location = new System.Drawing.Point(230, 52);
            this.btn_square.Name = "btn_square";
            this.btn_square.Size = new System.Drawing.Size(62, 45);
            this.btn_square.TabIndex = 24;
            this.btn_square.Text = "HVuông";
            this.btn_square.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_square.UseVisualStyleBackColor = false;
            this.btn_square.Click += new System.EventHandler(this.btn_square_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.DarkGray;
            this.btn_line.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_line_16;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.Location = new System.Drawing.Point(230, 3);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(62, 43);
            this.btn_line.TabIndex = 10;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.DarkGray;
            this.btn_color.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_color.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_color.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_paint_palette_16;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_color.Location = new System.Drawing.Point(3, 3);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(63, 43);
            this.btn_color.TabIndex = 4;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.DarkGray;
            this.btn_rect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_rectangle_19;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(158, 54);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(66, 43);
            this.btn_rect.TabIndex = 9;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.DarkGray;
            this.btn_fill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_fill_color_16;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(362, 54);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(63, 43);
            this.btn_fill.TabIndex = 5;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ellipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_ellipse_24;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(158, 3);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(66, 43);
            this.btn_ellipse.TabIndex = 8;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.DarkGray;
            this.btn_pencil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Image = global::DoAnGiuaKy_CaNhan.Properties.Resources.icons8_pen_30;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.Location = new System.Drawing.Point(83, 3);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(69, 43);
            this.btn_pencil.TabIndex = 6;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnChangeSize);
            this.panel1.Controls.Add(this.btnunSelect);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSize);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnUnGroup);
            this.panel1.Controls.Add(this.btnGroup);
            this.panel1.Controls.Add(this.btn_move);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 108);
            this.panel1.TabIndex = 3;
            // 
            // btnChangeSize
            // 
            this.btnChangeSize.Location = new System.Drawing.Point(266, 28);
            this.btnChangeSize.Name = "btnChangeSize";
            this.btnChangeSize.Size = new System.Drawing.Size(82, 45);
            this.btnChangeSize.TabIndex = 30;
            this.btnChangeSize.Text = "Change\r\nSize";
            this.btnChangeSize.UseVisualStyleBackColor = true;
            this.btnChangeSize.Click += new System.EventHandler(this.ChangeSize_Click);
            // 
            // btnunSelect
            // 
            this.btnunSelect.Location = new System.Drawing.Point(188, 12);
            this.btnunSelect.Name = "btnunSelect";
            this.btnunSelect.Size = new System.Drawing.Size(72, 33);
            this.btnunSelect.TabIndex = 29;
            this.btnunSelect.Text = "UnSelect";
            this.btnunSelect.UseVisualStyleBackColor = true;
            this.btnunSelect.Click += new System.EventHandler(this.unSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 33);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(370, 12);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(104, 45);
            this.btnSize.TabIndex = 27;
            this.btnSize.Value = 1;
            this.btnSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(100, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(72, 33);
            this.btnSelect.TabIndex = 26;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.Location = new System.Drawing.Point(100, 51);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(72, 33);
            this.btnUnGroup.TabIndex = 25;
            this.btnUnGroup.Text = "UnGroup";
            this.btnUnGroup.UseVisualStyleBackColor = true;
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(12, 51);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(72, 33);
            this.btnGroup.TabIndex = 24;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = true;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1261, 520);
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.Button btn_cong;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button pic_Color;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_square;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TrackBar btnSize;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnunSelect;
        private System.Windows.Forms.Button btnChangeSize;
    }
}

