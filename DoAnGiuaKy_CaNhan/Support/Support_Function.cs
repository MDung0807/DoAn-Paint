using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DoAnGiuaKy_CaNhan.FObject;
using System.Drawing;
using System.Windows.Forms;
using DoAnGiuaKy_CaNhan;

namespace DoAnGiuaKy_CaNhan.Support
{
    class Support_Funtion
    {
        public Graphics Gp;
        public Color myColor;
        
        public Support_Funtion(Color myColor, Graphics Gp)
        {
            this.Gp = Gp;
            this.myColor = myColor;
        }

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
        public bool check_cursor = false;

        public bool enable_function = false;
        public bool select = false;
        public bool un_select = false;
        public bool select_to_more = false;
        public bool newObj = false;
        bool select_point;
        DrawObject obj;
        int index;

        public Point p1, p2;
        public int MySize;

        public List<DrawObject> lstDrawObj = new List<DrawObject>();

        public void Update_Data(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void Change_Cursor(Point pt)
        {
            foreach (DrawObject i in lstDrawObj)
            {
              
                if (bMove)
                    Cursor.Current = Cursors.SizeAll;

                else if (bChange_size)
                {
                    for (int j = 0; j < i.point.Count(); j++)
                    {
                        if (Distance(i.point[j], pt) <= 10)
                        {
                            Cursor.Current = Cursors.SizeAll;
                        }
                    }
                }
                else
                    Cursor.Current = Cursors.Default;

            }
        }

        public void Change_Size()
        {
            if (select_point == false)
            {
                foreach (DrawObject i in lstDrawObj)
                {
                    if (i.check_select)
                    {
                        for (int j = 0; j < i.point.Count(); j++)
                        {
                            if (Distance(i.point[j], p1) <= 10)
                            {
                                i.Change_Size_Obj(p2, j);
                                this.select_point = true;
                                this.obj = i;
                                this.index = j;
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                obj.Change_Size_Obj(p2, index);
            }
        }

        public int Distance(Point A, Point B)
        {
            int distance;
            distance = Convert.ToInt32(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)));
            return distance;
        }
       
        public void Paint (Graphics gp)
        {
            for (int i = 0; i < this.lstDrawObj.Count; i++)
            {
                this.lstDrawObj[i].Draw(gp);
            }

            foreach (DrawObject i in lstDrawObj)
            {
                if (i.check_select)
                {
                    this.enable_function = true;
                    break;
                }
            }
            
        }

        public void Clear ()
        {
            this.Gp.Clear(Color.White);
            this.lstDrawObj.Clear();
        }

        public void Delete ()
        {

            for (int i = 0; i < lstDrawObj.Count(); i++)
            {
                if (lstDrawObj[i].check_select)
                {
                    this.lstDrawObj.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Create_Obj()
        {
            if (bLine == true) // Create a line
            {
                DrawObject Cline = new DrawObjLine();
                Cline.Create_Obj(p1, this.myColor, this.MySize);
                this.lstDrawObj.Add(Cline);
            }

            else if (bEllipse == true) // Create a ellipse
            {
                DrawObject CCircle = new DrawObjEllipse();
                CCircle.Create_Obj(p1, myColor, this.MySize);
                this.lstDrawObj.Add(CCircle);
            }

            else if (bRectangle == true) // Create a Rectangle
            {
                DrawObject CRectangle = new DrawObjRectangle();
                CRectangle.Create_Obj(p1, myColor, this.MySize);
                this.lstDrawObj.Add(CRectangle);
            }

            else if (bCircle == true) // Create Circle
            {
                DrawObject CCircle = new DrawObjCircle();
                CCircle.Create_Obj(this.p1, myColor, this.MySize);
                this.lstDrawObj.Add(CCircle);
            }

            else if (bSquare == true) // Create a Square
            {
                DrawObject CSquare = new DrawObjSquare();
                CSquare.Create_Obj(this.p1, myColor, this.MySize);
                this.lstDrawObj.Add(CSquare);
            }
            else if (bDcong == true) // Create a Curve
            {

                if (newObj == true) // If it is the first time the left click, then create the object
                {
                    DrawObjCurve CCurve = new DrawObjCurve();
                    CCurve.Create_Obj(this.p1, myColor, this.MySize);
                    CCurve.point.Add(this.p1);
                    this.lstDrawObj.Add(CCurve);
                    newObj = false;
                }
                else // Add Point
                    this.lstDrawObj[this.lstDrawObj.Count - 1].point.Add(this.p1);
            }

            else if (bPolygon == true) // Create a Polygon
            {
                if (newObj == true) // If it is the first time the left click, then create the object
                {
                    DrawObject Polygon = new DrawObjPolyon();
                    Polygon.Create_Obj(this.p1, myColor, this.MySize);
                    Polygon.point.Add(this.p1);
                    this.lstDrawObj.Add(Polygon);
                    newObj = false;
                }
                else
                    this.lstDrawObj[this.lstDrawObj.Count - 1].point.Add(this.p1);
            }

        }

        public void Update_Point()
        {
            if (bEllipse == true ||
                bLine == true ||
                bCircle == true ||
                bRectangle == true ||
                bSquare == true ||
                bDcong == true ||
                bPolygon == true)
            {
                int Len = this.lstDrawObj[this.lstDrawObj.Count - 1].point.Count;
                this.lstDrawObj[this.lstDrawObj.Count - 1].point[Len - 1] = this.p2;
            }
        }

        public void Off_flag()
        {
            isPress = false;
            bLine = false;
            bCircle = false;
            bEllipse = false;
            bMove = false;
            bRectangle = false;
            bSquare = false;
            bChange_size = false;
            select_point = false;
            check_cursor = false;
        }

        public void Move_Mouse(ref int dx, ref int dy)
        {
            dx = this.p2.X - this.p1.X;
            dy = this.p2.Y - this.p1.Y;
        }
        public void Event_Move()
        {
            int dx = 0, dy = 0;
            foreach (DrawObject i in lstDrawObj)
                if (i.check_select)
                {
                    Move_Mouse(ref dx, ref dy);
                    i.Move_Obj(dx, dy);
                }
        }

        public void Un_Select(Point pt)
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

        public void Is_Select(Point pt)
        {
            foreach (DrawObject i in lstDrawObj)
            {
                if (i.Select_Obj(pt))
                {
                    i.check_select = true;
                    if (select_to_more == false)
                    {
                        select = false;
                        break;
                    }
                }
            }
        }

        
        
    }
}
