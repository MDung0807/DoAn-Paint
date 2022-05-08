﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAnGiuaKy_CaNhan.FObject
{
    class DrawObjCircle : DrawObject
    {
        public override void Draw(Graphics Gp)
        {
            // Convert to Array
            Point pt = new Point();
            pt.X = point[1].X;
            pt.Y = point[0].Y + point[1].X - point[0].X;
            point[point.Count() - 1] = pt;

            //Draw
            Gp.FillEllipse(myBrush, point[0].X, point[0].Y, point[1].X - point[0].X, point[1].X - point[0].X);

            //Draw select
            if (check_select)
            {
                for (int i = 0; i < point.Count(); i++)
                {
                    Gp.DrawRectangle(myPen, point[0].X, point[0].Y, point[1].X - point[0].X, point[1].X - point[0].X);

                    Gp.FillRectangle(myBrush, point[i].X - 5, point[i].Y - 5, 10, 10);
                }
            }
        }

        public override void Create_Obj(Point pt, Color mycolor, int MySize)
        {
            this.point.Add(pt);
            this.point.Add(pt);
            this.myPen = new Pen(mycolor, 1);
            this.myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.myBrush = new SolidBrush(mycolor);
            this.check_select = false;
        }

        public override bool Select_Obj(Point pt)
        {
            int max_point_X = point[0].X, max_point_Y = point[0].Y;
            int min_point_X = point[0].X, min_point_Y = point[0].Y;
            for (int i = 0; i < this.point.Count(); i++)
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
