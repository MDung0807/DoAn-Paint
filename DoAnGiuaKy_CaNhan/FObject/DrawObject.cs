using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAnGiuaKy_CaNhan.FObject
{
    public abstract class DrawObject
    {
        public Pen myPen;
        public SolidBrush myBrush;
        public List<Point> point = new List<Point>();

        public abstract void Draw(Graphics Gp);
        public abstract void Create_Obj(Point pt, Color mycolor, int MySize);

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

        public abstract bool Select_Obj(Point pt);
    }
}
