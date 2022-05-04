﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAnGiuaKy_CaNhan.FObject
{
    class DrawObjSquare : DrawObject
    {
        public override void Draw(Graphics Gp)
        {
            Gp.FillRectangle(myBrush, this.point[0].X, this.point[0].Y, this.point[1].Y - this.point[0].Y, this.point[1].Y - this.point[0].Y);
        }

        public override void Create_Obj(Point pt, Color mycolor, int MySize)
        {
            this.myPen = new Pen(mycolor, MySize);
            this.myBrush = new SolidBrush(mycolor);
            this.point.Add(pt);
            this.point.Add(pt);
        }

        public override bool Select_Obj(Point pt)
        {
            int max_point_X = point[0].X, max_point_Y = point[0].Y;
            int min_point_X = point[0].X, min_point_Y = point[0].Y;
            for (int i = 0; i < this.point.Count; i++)
            {
                if (max_point_X < this.point[i].X)
                    max_point_X = this.point[i].X;
                if (max_point_Y < this.point[i].Y)
                    max_point_Y = this.point[i].Y;
                if (min_point_X > this.point[i].X)
                    min_point_X = this.point[i].X;
                if (min_point_Y > this.point[i].Y)
                    min_point_Y = this.point[i].Y;
            }


            if (pt.X > min_point_X &&
                pt.Y < max_point_Y &&
                pt.X < max_point_X &&
                pt.Y > min_point_Y)
                return true;
            return false;
        }
    }
}
