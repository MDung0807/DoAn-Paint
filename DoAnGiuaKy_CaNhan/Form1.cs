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

        Graphics Gp;
        Bitmap bm;
        Color myColor;
        ColorDialog color = new ColorDialog();
        Point p1, p2;
        int MySize;


        bool isPress = false;
        bool bLine = false;
        bool bEllipse = false;
        bool bCircle = false;
        bool bRectangle = false;
        bool bMove = false;
        bool select = false;
        //bool bPencil = false;
        bool bDcong = false;
        bool bPolygon = false;
        bool bSquare = false;
        bool newObj = false;

        List<DrawObject> lstDrawObj = new List<DrawObject>();
        List<DrawObject> lstSelcetObj = new List<DrawObject>();

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(this.pic.Width, this.pic.Height);
            Gp = Graphics.FromImage(bm);
            Gp.Clear(Color.White);
            pic.Image = bm;
            myColor = Color.Aqua;
            this.pic_Color.BackColor = myColor;

        }

        void Create_Obj(MouseEventArgs e)
        {

        }
        void Add_Point()
        {

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

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            this.isPress = true;
            this.p1 = e.Location;

            if (this.bLine == true) // Create a line
            {
                DrawObject Cline = new DrawObjLine();
                Cline.Create_Obj(e.Location, this.myColor, this.MySize);
                this.lstDrawObj.Add(Cline);
            }

            else if (this.bEllipse == true) // Create a ellipse
            {
                DrawObject CCircle = new DrawObjEllipse();
                CCircle.Create_Obj(e.Location, myColor, this.MySize);
                this.lstDrawObj.Add(CCircle);
            }

            else if (this.bRectangle == true) // Create a Rectangle
            {
                DrawObject CRectangle = new DrawObjRectangle();
                CRectangle.Create_Obj(e.Location, myColor, this.MySize);
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
                    this.lstDrawObj[this.lstDrawObj.Count - 1].point.Add(this.p2);
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
                    this.lstDrawObj[this.lstDrawObj.Count - 1].point.Add(this.p2);
            }
            if (this.select == true) 
            {
                for (int i = this.lstDrawObj.Count - 1; i >= 0; i--)
                {
                    if (this.lstDrawObj[i].Select_Obj(e.Location))
                    {
                        this.pic.Cursor = System.Windows.Forms.Cursors.SizeAll;
                        this.lstSelcetObj.Add(this.lstDrawObj[i]);
                        this.select = false;
                        break;
                    }
                    this.pic.Cursor = System.Windows.Forms.Cursors.Default;
                }
            }


        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            
            this.p2 = e.Location;
            if (this.isPress == true)
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

            if (this.bMove == true)
            {
                if (this.lstSelcetObj.Count > 0)
                {
                    int dx = this.p2.X - this.p1.X;
                    int dy = this.p2.Y - this.p1.Y;
                    this.lstSelcetObj[this.lstSelcetObj.Count - 1].Move_Obj(dx, dy);

                }
                //Change_Cursor();

            }
            this.p1 = this.p2;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {

            if (this.lstSelcetObj.Count > 0)
            {
                this.lstSelcetObj.RemoveAt(this.lstSelcetObj.Count - 1);
            }


            if (this.isPress == true)
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

                //if (this.bPolygon == true)
                //{
                //    Gp.DrawLine(new Pen(myColor), this.p1, this.p2);
                //}    
                this.pic.Refresh();
            }


            this.isPress = false;
            this.bLine = false;
            this.bCircle = false;
            this.bEllipse = false;
            this.bMove = false;
            this.bRectangle = false;
            this.bSquare = false;
            if (e.Button == MouseButtons.Right)
            {
                this.bDcong = false;
                this.bPolygon = false;
            }

            if (this.bDcong == true || this.bPolygon == true)
                this.isPress = true;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            for (int i = 0; i < this.lstDrawObj.Count; i++)
            {
                this.lstDrawObj[i].Draw(G);
                //if (this.lstDrawObj[i].Select_Obj(Cursor.Position))
                //    this.pic.Cursor = Cursors.SizeAll;
            }    
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

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            //this.bPencil = true;
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
                    
            }    
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
            this.newObj = true;
            this.bPolygon = true;
        }

    }
}
