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

            if (check_select)
            {
                for (int i = 0; i < point.Count(); i++)
                {
                    Gp.FillRectangle(myBrush, point[i].X - 5, point[i].Y - 5, 10, 10);
                }
            }

            this.a = -point[1].Y + point[0].Y;
            this.b = point[1].X - point[0].X;
            this.c = -a * point[0].X - b * point[0].Y;
        }

        public override void Create_Obj(Point pt, Color mycolor, int MySize)
        {
            this.myPen = new Pen(mycolor, MySize);
            this.point.Add(pt);
            this.point.Add(pt);
            this.myBrush = new SolidBrush(mycolor);
            this.check_select = false;
        }


        public override bool Select_Obj(Point pt)
        {
            int KC = (int)((Math.Abs(a * pt.X + b * pt.Y + c)) / (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))));
            if (KC < 10)
                return true;
            return false;

        }

        //public override void Select_GP(Graphics Gp)
        //{
        //    for (int i = 0; i < point.Count(); i++)
        //    {
        //        Gp.FillRectangle(myBrush, point[i].X - 5, point[i].Y - 5, 10, 10);
        //    }
        //}
    }
}
