using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DoAnGiuaKy_CaNhan;

namespace DoAnGiuaKy_CaNhan.FObject
{
    public abstract class DrawObject
    {
        public Pen myPen;
        public SolidBrush myBrush;
        public List<Point> point = new List<Point>();
        public bool check_select;
        public abstract void Draw(Graphics Gp);
        public abstract void Create_Obj(Point pt, Color mycolor, int MySize);

        public abstract bool Select_Obj(Point pt);

        public void Move_Obj(int dx, int dy)
        {

            for (int i = 0; i < this.point.Count; i++)
            {
                Point pt = point[i];
                pt.X += dx;
                pt.Y += dy;
                point[i] = pt;
            }
        }

        public void Change_Size_Obj (Point pt, int index)
        {
            point[index] = pt;
        }
        protected int Distance(Point A, Point B)
        {
            int distance;
            distance = Convert.ToInt32(Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)));
            return distance;
        }
    }
}
