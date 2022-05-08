using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAnGiuaKy_CaNhan.FObject
{
    class DrawObjEllipse : DrawObject
    {
        public override void Draw(Graphics Gp)
        {
            int width = Math.Abs(this.point[1].X - this.point[0].X);
            int height = Math.Abs(this.point[1].Y - this.point[0].Y);
            Gp.FillEllipse(this.myBrush, this.point[0].X, this.point[0].Y, width, height);

            if (check_select)
            {
                for (int i = 0; i < point.Count(); i++)
                {
                    Gp.FillRectangle(myBrush, Math.Abs(point[i].X - 5), Math.Abs(point[i].Y - 5), 10, 10);
                    Gp.DrawRectangle(this.myPen, this.point[0].X, this.point[0].Y, width, height);

                }
            }
        }

        public override void Create_Obj(Point pt, Color mycolor, int MySize)
        {
            this.myBrush = new SolidBrush(mycolor);
            this.myPen = new Pen(mycolor, 1);
            this.myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.point.Add(pt);
            this.point.Add(pt);
            this.check_select = false;
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
