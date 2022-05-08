//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using DoAnGiuaKy_CaNhan.FObject;
//using System.Drawing;
//using DoAnGiuaKy_CaNhan;

//namespace DoAnGiuaKy_CaNhan.Support
//{
//    class Support_Funtion
//    {
//        Form1 fm = new Form1();
//        //public bool isPress = false;
//        //public bool bLine = false;
//        //public bool bEllipse = false;
//        //public bool bCircle = false;
//        //public bool bRectangle = false;
//        //public bool bMove = false;
//        //public bool bDcong = false;
//        //public bool bPolygon = false;
//        //public bool bSquare = false;
//        //public bool bDelete = false;
//        //public bool bChange_size = false;

//        //public bool enable_function = false;
//        //public bool select = false;
//        //public bool un_select = false;
//        //public bool select_to_more = false;
//        //public bool newObj = false;

//        public void Create_Obj()
//        {
//            if (fm.bLine == true) // Create a line
//            {
//                DrawObject Cline = new DrawObjLine();
//                Cline.Create_Obj(fm.p1, this.fm.myColor, this.fm.MySize);
//                this.fm.lstDrawObj.Add(Cline);
//            }

//            else if (fm.bEllipse == true) // Create a ellipse
//            {
//                DrawObject CCircle = new DrawObjEllipse();
//                CCircle.Create_Obj(fm.p1, fm.myColor, this.fm.MySize);
//                this.fm.lstDrawObj.Add(CCircle);
//            }

//            else if (fm.bRectangle == true) // Create a Rectangle
//            {
//                DrawObject CRectangle = new DrawObjRectangle();
//                CRectangle.Create_Obj(fm.p1, fm.myColor, this.fm.MySize);
//                this.fm.lstDrawObj.Add(CRectangle);
//            }

//            else if (fm.bCircle == true) // Create Circle
//            {
//                DrawObject CCircle = new DrawObjCircle();
//                CCircle.Create_Obj(this.fm.p1, fm.myColor, this.fm.MySize);
//                this.fm.lstDrawObj.Add(CCircle);
//            }

//            else if (fm.bSquare == true) // Create a Square
//            {
//                DrawObject CSquare = new DrawObjSquare();
//                CSquare.Create_Obj(this.fm.p1, fm.myColor, this.fm.MySize);
//                this.fm.lstDrawObj.Add(CSquare);
//            }
//            else if (fm.bDcong == true) // Create a Curve
//            {

//                if (fm.newObj == true) // If it is the first time the left click, then create the object
//                {
//                    DrawObjCurve CCurve = new DrawObjCurve();
//                    CCurve.Create_Obj(this.fm.p1, fm.myColor, this.fm.MySize);
//                    CCurve.point.Add(this.fm.p1);
//                    this.fm.lstDrawObj.Add(CCurve);
//                    fm.newObj = false;
//                }
//                else // Add Point
//                    this.fm.lstDrawObj[this.fm.lstDrawObj.Count - 1].point.Add(this.fm.p1);
//            }

//            else if (fm.bPolygon == true) // Create a Polygon
//            {
//                if (fm.newObj == true) // If it is the first time the left click, then create the object
//                {
//                    DrawObject Polygon = new DrawObjPolyon();
//                    Polygon.Create_Obj(this.fm.p1, fm.myColor, this.fm.MySize);
//                    Polygon.point.Add(this.fm.p1);
//                    this.fm.lstDrawObj.Add(Polygon);
//                    fm.newObj = false;
//                }
//                else
//                    this.fm.lstDrawObj[this.fm.lstDrawObj.Count - 1].point.Add(this.fm.p1);
//            }

//        }

//        public void Update_Point()
//        {
//            if (fm.bEllipse == true ||
//                fm.bLine == true ||
//                fm.bCircle == true ||
//                fm.bRectangle == true ||
//                fm.bSquare == true ||
//                fm.bDcong == true ||
//                fm.bPolygon == true)
//            {
//                int Len = this.fm.lstDrawObj[this.fm.lstDrawObj.Count - 1].point.Count;
//                this.fm.lstDrawObj[this.fm.lstDrawObj.Count - 1].point[Len - 1] = this.fm.p2;
//            }
//            this.fm.pic.Refresh();
//        }

//        public void Off_flag()
//        {
//            fm.isPress = false;
//            fm.bLine = false;
//            fm.bCircle = false;
//            fm.bEllipse = false;
//            fm.bMove = false;
//            fm.bRectangle = false;
//            fm.bSquare = false;
//            fm.bChange_size = false;
//        }

//        //void Change_Cursor()
//        //{
//        //    for (int i = 0; i < this.lstDrawObj.Count; i++)
//        //    {
//        //        if (this.lstDrawObj[i].Select_Obj(Cursor.Position))
//        //            this.pic.Cursor = Cursors.SizeAll;
//        //        else this.pic.Cursor = Cursors.Default;
//        //    }
//        //}

//        public void Move_Mouse(ref int dx, ref int dy)
//        {
//            dx = this.fm.p2.X - this.fm.p1.X;
//            dy = this.fm.p2.Y - this.fm.p1.Y;
//        }
//        public void Event_Move()
//        {
//            int dx = 0, dy = 0;
//            foreach (DrawObject i in fm.lstDrawObj)
//                if (i.check_select)
//                {
//                    Move_Mouse(ref dx, ref dy);
//                    i.Move_Obj(dx, dy);
//                }
//        }

//        public void Enable_Fuction()
//        {
//            if (fm.enable_function)
//            {
//                this.fm.btnUnGroup.Enabled = true;
//                this.fm.btn_move.Enabled = true;
//                this.fm.btnGroup.Enabled = true;
//                this.fm.btnUnGroup.Enabled = true;
//                this.fm.btnDelete.Enabled = true;
//            }
//            else
//            {
//                this.fm.btnUnGroup.Enabled = false;
//                this.fm.btn_move.Enabled = false;
//                this.fm.btnGroup.Enabled = false;
//                this.fm.btnUnGroup.Enabled = false;
//                this.fm.btnDelete.Enabled = false;
//            }

//        }

//        public void Un_Select(Point pt)
//        {
//            foreach (DrawObject i in fm.lstDrawObj)
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
//            foreach (DrawObject i in fm.lstDrawObj)
//            {
//                if (i.Select_Obj(pt))
//                {
//                    i.check_select = true;
//                    if (fm.select_to_more == false)
//                    {
//                        fm.select = false;
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
//            foreach (DrawObject i in fm.lstDrawObj)
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
