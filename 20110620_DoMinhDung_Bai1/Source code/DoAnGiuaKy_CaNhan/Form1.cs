using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnGiuaKy_CaNhan.FObject;
using DoAnGiuaKy_CaNhan.Support;

namespace DoAnGiuaKy_CaNhan
{
    public partial class Form1 : Form
    {
        public Graphics Gp;
        public Bitmap bm;
        public Color myColor;
        public ColorDialog color = new ColorDialog();
        public Point p1, p2;
        public int MySize;

        Support_Funtion sp;

        public bool isPress = false;

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(this.pic.Width, this.pic.Height);
            Gp = Graphics.FromImage(bm);
            Gp.Clear(Color.White);
            pic.Image = bm;
            myColor = Color.FromArgb(255, 128, 128);
            this.pic_Color.BackColor = myColor;
            sp = new Support_Funtion(myColor, Gp);
        }

        void Enable_Fuction()
        {
            if (sp.enable_function)
            {
                this.btnUnGroup.Enabled = true;
                this.btn_move.Enabled = true;
                this.btnGroup.Enabled = true;
                this.btnUnGroup.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnunSelect.Enabled = true;
                this.btnChangeSize.Enabled = true;
            }
            else
            {
                this.btnUnGroup.Enabled = false;
                this.btn_move.Enabled = false;
                this.btnGroup.Enabled = false;
                this.btnUnGroup.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnunSelect.Enabled = false;
                this.btnChangeSize.Enabled = false;
            }

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            this.isPress = true;
            this.p1 = e.Location;
            sp.Update_Data(p1, p2);
            sp.Create_Obj();

            if (sp.select)
            {
                sp.Is_Select(e.Location);
            }

            if (sp.un_select)
            {
                sp.Un_Select(e.Location);
                sp.un_select = false;
            }    
   
            if (sp.bMove)
            {
                sp.Event_Move();
            }
            
            if (sp.bChange_size)
            {
                sp.Change_Size();
            }    
            
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            this.p2 = e.Location;
            sp.Update_Data(p1, p2);
            if ( isPress)
            {
                sp.Update_Point();
                if (sp.bMove)
                    sp.Event_Move();
                if (sp.bChange_size)
                    sp.Change_Size();
            }
            this.pic.Refresh();
            this.p1 = this.p2;
            //Cursor.Current = Cursors.Default;
            if (sp.check_cursor)
                sp.Change_Cursor(e.Location);
            //sp.enable_function = false;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            this.p2 = e.Location;
            sp.Update_Data(p1, p2);
            if (isPress)
            {
                sp.Update_Point();
                if (sp.bMove)
                    sp.Event_Move();
                if (sp.bChange_size)
                    sp.Change_Size();
            }
            sp.Off_flag();

            if (e.Button == MouseButtons.Right)
            {
                sp.bDcong = false;
                sp.bPolygon = false;
            }
            this.isPress = false;
            if (sp.bDcong|| sp.bPolygon)
                this.isPress = true;
            this.pic.Refresh();
            
            this.p1 = p2;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            sp.Paint(e.Graphics);
            Enable_Fuction();
            

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            this.color.ShowDialog();
            sp.myColor = this.color.Color;
            this.pic_Color.BackColor = sp.myColor;

        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            sp.bLine = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.pic.Image = bm;
            this.pic.Refresh();
            sp.Clear();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            sp.bMove = true;
            sp.check_cursor = true;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            sp.bEllipse = true;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            sp.bRectangle = true;
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            sp.bSquare = true;
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            sp.bCircle = true;
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            sp.newObj = true;
            sp.bDcong = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            sp.select = true;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            sp.MySize = this.btnSize.Value;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                sp.select = true;
                sp.select_to_more = true;
            }    
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                sp.select_to_more = false;
                sp.select = false;
            }    
        }

       
        private void bntDelete_Click(object sender, EventArgs e)
        {
            sp.Delete();
            this.pic.Refresh();
        }

        private void unSelect_Click(object sender, EventArgs e)
        {
            sp.un_select = true;
        }

        private void ChangeSize_Click(object sender, EventArgs e)
        {
            sp.bChange_size = true;
            sp.check_cursor = true ;
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
            sp.newObj = true;
            sp.bPolygon = true;
        }
    }
}
