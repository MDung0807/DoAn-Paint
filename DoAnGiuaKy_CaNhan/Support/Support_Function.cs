//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DoAnGiuaKy_CaNhan.FObject;
//using System.Drawing;

//namespace DoAnGiuaKy_CaNhan.Support
//{
//    class Support_Funtion : Form1
//    {
//        public bool isPress = false;
//        public bool bLine = false;
//        public bool bEllipse = false;
//        public bool bCircle = false;
//        public bool bRectangle = false;
//        public bool bMove = false;
//        bool bPencil = false;
//        public bool bDcong = false;
//        public bool bPolygon = false;
//        public bool bSquare = false;
//        public bool bDelete = false;
//        public bool bChange_size = false;

//        public bool enable_function = false;
//        public bool select = false;
//        public bool un_select = false;
//        public bool select_to_more = false;
//        public bool newObj = false;

//        public void Create_Obj()
//        {
//            if (bLine == true) // Create a line
//            {
//                DrawObject Cline = new DrawObjLine();
//                Cline.Create_Obj(p1, this.myColor, this.MySize);
//                this.lstDrawObj.Add(Cline);
//            }

//            else if (bEllipse == true) // Create a ellipse
//            {
//                DrawObject CCircle = new DrawObjEllipse();
//                CCircle.Create_Obj(p1, myColor, this.MySize);
//                this.lstDrawObj.Add(CCircle);
//            }

//            else if (bRectangle == true) // Create a Rectangle
//            {
//                DrawObject CRectangle = new DrawObjRectangle();
//                CRectangle.Create_Obj(p1, myColor, this.MySize);
//                this.lstDrawObj.Add(CRectangle);
//            }

//            else if (bCircle == true) // Create Circle
//            {
//                DrawObject CCircle = new DrawObjCircle();
//                CCircle.Create_Obj(this.p1, myColor, this.MySize);
//                this.lstDrawObj.Add(CCircle);
//            }

//            else if (bSquare == true) // Create a Square
//            {
//                DrawObject CSquare = new DrawObjSquare();
//                CSquare.Create_Obj(this.p1, myColor, this.MySize);
//                this.lstDrawObj.Add(CSquare);
//            }
//            else if (bDcong == true) // Create a Curve
//            {

//                if (newObj == true) // If it is the first time the left click, then create the object
//                {
//                    DrawObjCurve CCurve = new DrawObjCurve();
//                    CCurve.Create_Obj(this.p1, myColor, this.MySize);
//                    CCurve.point.Add(this.p1);
//                    this.lstDrawObj.Add(CCurve);
//                    newObj = false;
//                }
//                else // Add Point
//                    this.lstDrawObj[this.lstDrawObj.Count - 1].point.Add(this.p1);
//            }

//            else if (bPolygon == true) // Create a Polygon
//            {
//                if (newObj == true) // If it is the first time the left click, then create the object
//                {
//                    DrawObject Polygon = new DrawObjPolyon();
//                    Polygon.Create_Obj(this.p1, myColor, this.MySize);
//                    Polygon.point.Add(this.p1);
//                    this.lstDrawObj.Add(Polygon);
//                    newObj = false;
//                }
//                else
//                    this.lstDrawObj[this.lstDrawObj.Count - 1].point.Add(this.p1);
//            }

//        }

//        public void Update_Point()
//        {
//            if (bEllipse == true ||
//                bLine == true ||
//                bCircle == true ||
//                bRectangle == true ||
//                bSquare == true ||
//                bDcong == true ||
//                bPolygon == true)
//            {
//                int Len = this.lstDrawObj[this.lstDrawObj.Count - 1].point.Count;
//                this.lstDrawObj[this.lstDrawObj.Count - 1].point[Len - 1] = this.p2;
//            }
//            this.pic.Refresh();
//        }

//        public void Off_flag()
//        {
//            isPress = false;
//            bLine = false;
//            bCircle = false;
//            bEllipse = false;
//            bMove = false;
//            bRectangle = false;
//            bSquare = false;
//            bChange_size = false;
//        }

//        void Change_Cursor()
//        {
//            for (int i = 0; i < this.lstDrawObj.Count; i++)
//            {
//                if (this.lstDrawObj[i].Select_Obj(Cursor.Position))
//                    this.pic.Cursor = Cursors.SizeAll;
//                else this.pic.Cursor = Cursors.Default;
//            }
//        }

//        public void Move_Mouse(ref int dx, ref int dy)
//        {
//            dx = this.p2.X - this.p1.X;
//            dy = this.p2.Y - this.p1.Y;
//        }
//        public void Event_Move()
//        {
//            int dx = 0, dy = 0;
//            foreach (DrawObject i in lstDrawObj)
//                if (i.check_select)
//                {
//                    Move_Mouse(ref dx, ref dy);
//                    i.Move_Obj(dx, dy);
//                }
//        }

//        public void Enable_Fuction()
//        {
//            if (enable_function)
//            {
//                this.btnUnGroup.Enabled = true;
//                this.btn_move.Enabled = true;
//                this.btnGroup.Enabled = true;
//                this.btnUnGroup.Enabled = true;
//                this.btnDelete.Enabled = true;
//            }
//            else
//            {
//                this.btnUnGroup.Enabled = false;
//                this.btn_move.Enabled = false;
//                this.btnGroup.Enabled = false;
//                this.btnUnGroup.Enabled = false;
//                this.btnDelete.Enabled = false;
//            }

//        }

//        public void Un_Select(Point pt)
//        {
//            foreach (DrawObject i in lstDrawObj)
//            {
//                if (i.Select_Obj(pt))
//                {
//                    if (i.check_select)
//                    {
//                        i.check_select = false;
//                    }
//                }
//            }
//        }

//        public void Is_Select(Point pt)
//        {
//            foreach (DrawObject i in lstDrawObj)
//            {
//                if (i.Select_Obj(pt))
//                {
//                    i.check_select = true;
//                    if (select_to_more == false)
//                    {
//                        select = false;
//                        break;
//                    }
//                }
//            }
//        }

//        public int Distance(Point A, Point B)
//        {
//            int distance;
//            distance = Convert.ToInt32(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)));
//            return distance;
//        }
//        public void Change_Size()
//        {
//            foreach (DrawObject i in lstDrawObj)
//            {
//                if (i.check_select)
//                {
//                    for (int j = 0; j < i.point.Count(); j++)
//                    {
//                        if (Distance(i.point[j], p1) <= 10)
//                        {
//                            int dx = 0, dy = 0;
//                            Move_Mouse(ref dx, ref dy);
//                            i.Change_Size_Obj(p2, j);
//                            break;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
