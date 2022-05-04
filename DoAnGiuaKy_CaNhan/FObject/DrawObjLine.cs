using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAnGiuaKy_CaNhan.FObject
{
    class DrawObjLine : DrawObject
    {

        int a, b, c;
        public override void Draw(Graphics Gp)
        {
            Gp.DrawLine(this.myPen, this.point[0], this.point[1]);
            this.a = -point[1].Y + point[0].Y;
            this.b = point[1].X - point[0].X;
            this.c = -a * point[0].X - b * point[0].Y;
        }

        public override void Create_Obj(Point pt, Color mycolor, int MySize)
        {
            this.myPen = new Pen(mycolor, MySize);
            this.point.Add(pt);
            this.point.Add(pt);
            
        }


        public override bool Select_Obj(Point pt)
        {
            //if ((a * pt.X + b * pt.Y + c) == 0)
            //    return true;
            //return false;

            int KC = (int)((Math.Abs(a * pt.X + b * pt.Y + c)) / (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))));
            if (KC < 10)
                return true;
            return false;

            //int max_point_X = point[0].X, max_point_Y = point[0].Y;
            //int min_point_X = point[0].X, min_point_Y = point[0].Y;
            //for (int i = 0; i < this.point.Count; i++)
            //{
            //    if (max_point_X < this.point[i].X)
            //        max_point_X = this.point[i].X;
            //    if (max_point_Y < this.point[i].Y)
            //        max_point_Y = this.point[i].Y;
            //    if (min_point_X > this.point[i].X)
            //        min_point_X = this.point[i].X;
            //    if (min_point_Y > this.point[i].Y)
            //        min_point_Y = this.point[i].Y;
            //}


            //if (pt.X > min_point_X &&
            //    pt.Y < max_point_Y &&
            //    pt.X < max_point_X &&
            //    pt.Y > min_point_Y)
            //    return true;
            //return false;
        }
    }
}
