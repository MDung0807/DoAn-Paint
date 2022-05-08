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



        //bool isPress = false;
        //bool bLine = false;
        //bool bEllipse = false;
        //bool bCircle = false;
        //bool bRectangle = false;
        //bool bMove = false;
        //bool bDcong = false;
        //bool bPolygon = false;
        //bool bSquare = false;
        //bool bDelete = false;
        //bool bChange_size = false;

        //bool enable_function = false;
        //bool select = false;
        //bool un_select = false;
        //bool select_to_more = false;
        //bool newObj = false;

        public bool isPress = false;
        public bool bLine = false;
        public bool bEllipse = false;
        public bool bCircle = false;
        public bool bRectangle = false;
        public bool bMove = false;
        public bool bDcong = false;
        public bool bPolygon = false;
        public bool bSquare = false;
        public bool bDelete = false;
        public bool bChange_size = false;

        public bool enable_function = false;
        public bool select = false;
        public bool un_select = false;
        public bool select_to_more = false;
        public bool newObj = false;

        public List<DrawObject> lstDrawObj = new List<DrawObject>();

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(this.pic.Width, this.pic.Height);
            Gp = Graphics.FromImage(bm);
            Gp.Clear(Color.White);
            pic.Image = bm;
            myColor = Color.FromArgb(255, 128, 128);
            this.pic_Color.BackColor = myColor;
        }

        void Create_Obj()
        {
            if (this.bLine == true) // Create a line
            {
                DrawObject Cline = new DrawObjLine();
                Cline.Create_Obj(p1, this.myColor, this.MySize);
                this.lstDrawObj.Add(Cline);
            }

            else if (this.bEllipse == true) // Create a ellipse
            {
                DrawObject CCircle = new DrawObjEllipse();
                CCircle.Create_Obj(p1, myColor, this.MySize);
                this.lstDrawObj.Add(CCircle);
            }

            else if (this.bRectangle == true) // Create a Rectangle
            {
                DrawObject CRectangle = new DrawObjRectangle();
                CRectangle.Create_Obj(p1, myColor, this.MySize);
                this.lstDrawObj.Add(CRectangle);
            }

            else if (this.bCircle == true) // Create Circle
            {
                DrawObject CCircle = new DrawObjCircle();
                CCircle.Create_Obj(this.p1, myColor, this.MySize);
                this.lstDrawObj.Add(CCircle);
            }

            else if (this.bSquare == true) // Create a Square
            {
                DrawObject CSquare = new DrawObjSquare();
                CSquare.Create_Obj(this.p1, myColor, this.MySize);
                this.lstDrawObj.Add(CSquare);
            }
            else if (this.bDcong == true) // Create a Curve
            {

                if (this.newObj == true) // If it is the first time the left click, then create the object
                {
                    DrawObjCurve CCurve = new DrawObjCurve();
                    CCurve.Create_Obj(this.p1, myColor, this.MySize);
                    CCurve.point.Add(this.p1);
                    this.lstDrawObj.Add(CCurve);
                    this.newObj = false;
                }
                else // Add Point
                    this.lstDrawObj[this.lstDrawObj.Count - 1].point.Add(this.p1);
            }

            else if (this.bPolygon == true) // Create a Polygon
            {
                if (this.newObj == true) // If it is the first time the left click, then create the object
                {
                    DrawObject Polygon = new DrawObjPolyon();
                    Polygon.Create_Obj(this.p1, myColor, this.MySize);
                    Polygon.point.Add(this.p1);
                    this.lstDrawObj.Add(Polygon);
                    this.newObj = false;
                }
                else
                    this.lstDrawObj[this.lstDrawObj.Count - 1].point.Add(this.p1);
            }

        }

        void Update_Point()
        {
            if (this.bEllipse == true ||
                this.bLine == true ||
                this.bCircle == true ||
                this.bRectangle == true ||
                this.bSquare == true ||
                this.bDcong == true ||
                this.bPolygon == true)
            {
               int Len = this.lstDrawObj[this.lstDrawObj.Count - 1].point.Count;
               this.lstDrawObj[this.lstDrawObj.Count - 1].point[Len - 1] = this.p2;
            }
            this.pic.Refresh();
        }

        void Off_flag ()
        {
            this.isPress = false;
            this.bLine = false;
            this.bCircle = false;
            this.bEllipse = false;
            this.bMove = false;
            this.bRectangle = false;
            this.bSquare = false;
            this.bChange_size = false;
        }

        void Change_Cursor()
        {
            for (int i = 0; i< this.lstDrawObj.Count; i++)
            {
                if (this.lstDrawObj[i].Select_Obj(Cursor.Position))
                    this.pic.Cursor = Cursors.SizeAll;
                else this.pic.Cursor = Cursors.Default;
            }   
        }

        void Move_Mouse (ref int dx, ref int dy)
        {
            dx = this.p2.X - this.p1.X;
            dy = this.p2.Y - this.p1.Y;
        }
        void Event_Move ()
        {
            int dx = 0, dy = 0;
            foreach (DrawObject i in lstDrawObj)
            if (i.check_select)
            {
                dx = this.p2.X - this.p1.X;
                dy = this.p2.Y - this.p1.Y;
                Move_Mouse(ref dx, ref dy);
                i.Move_Obj(dx, dy);
            }
        }

        void Enable_Fuction ()
        {
            if (enable_function)
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

        void Un_Select (Point pt)
        {
            foreach (DrawObject i in lstDrawObj)
            {
                if (i.Select_Obj(pt))
                {
                    if (i.check_select)
                    {
                        i.check_select = false;
                    }
                }
            }
        }

        void Is_Select (Point pt)
        {
            foreach (DrawObject i in lstDrawObj)
            {
                if (i.Select_Obj(pt))
                {
                    i.check_select = true;
                    if (select_to_more == false)
                    {
                        this.select = false;
                        break;
                    }
                }
            }
        }

        int Distance (Point A, Point B)
        {
            int distance;
            distance = Convert.ToInt32(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)));
            return distance;
        }
        void Change_Size ()
        {
            foreach (DrawObject i in lstDrawObj)
            {
                if (i.check_select)
                {
                    for (int j = 0; j <i.point.Count(); j++)
                    {
                        if (Distance (i.point[j], p1) <= 10)
                        {
                            i.Change_Size_Obj(p2, j);
                            break;
                        }    
                    }    
                }    
            }
        }
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            this.isPress = true;
            this.p1 = e.Location;

            Create_Obj();

            if (select)
            {
                Is_Select(e.Location);
            }

            if (un_select)
            {
                Un_Select(e.Location);
                this.un_select = false;
            }    
   
            if (bMove)
            {
                Event_Move();
            }
            
            if (bChange_size)
            {
                Change_Size();
            }    
            
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            this.p2 = e.Location;
            if ( isPress)
            {
                Update_Point();
                if (bMove == true)
                    Event_Move();
                if (bChange_size)
                    Change_Size();
            }
            this.p1 = this.p2;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            this.p2 = e.Location;
            if (isPress)
            {
                Update_Point();
                if (bMove == true)
                    Event_Move();
                if (bChange_size)
                    Change_Size();
            }
            Off_flag();

            if (e.Button == MouseButtons.Right)
            {
                this.bDcong = false;
                this.bPolygon = false;
            }

            if (this.bDcong == true || this.bPolygon == true)
                this.isPress = true;
            this.p1 = p2;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            for (int i = 0; i < this.lstDrawObj.Count; i++)
            {
                this.lstDrawObj[i].Draw(G);
            }
            
            foreach (DrawObject i in lstDrawObj)
            {
                if (i.check_select)
                {
                    this.enable_function = true;
                    break;
                }
            }
            Enable_Fuction();
            this.enable_function = false;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            this.color.ShowDialog();
            this.myColor = this.color.Color;
            this.pic_Color.BackColor = this.myColor;

        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            this.bLine = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Gp.Clear(Color.White);
            this.pic.Image = bm;
            this.lstDrawObj.Clear();
            this.pic.Refresh();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            this.bMove = true;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            this.bEllipse = true;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            this.bRectangle = true;
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            this.bSquare = true;
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            this.bCircle = true;
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            this.newObj = true;
            this.bDcong = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.select = true;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.MySize = this.btnSize.Value;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                this.select = true;
                this.select_to_more = true;
            }    
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                this.select_to_more = false;
                this.select = false;
            }    
        }

       
        private void bntDelete_Click(object sender, EventArgs e)
        {
            this.bDelete = true;
            if (bDelete)
            {
                for (int i = 0; i < lstDrawObj.Count(); i++)
                {
                    if (lstDrawObj[i].check_select)
                    {
                        this.lstDrawObj.RemoveAt(i);
                        i--;
                    }
                }
                this.bDelete = false;
                this.pic.Refresh();
            }    
        }

        private void unSelect_Click(object sender, EventArgs e)
        {
            this.un_select = true;
        }

        private void ChangeSize_Click(object sender, EventArgs e)
        {
            this.bChange_size = true;
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
            this.newObj = true;
            this.bPolygon = true;
        }
    }
}
