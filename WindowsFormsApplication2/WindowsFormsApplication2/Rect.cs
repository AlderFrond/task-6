using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication2
{
    class Rect
    {
        //public - виден везде
        //protected - виден внутри класса и в наследниках
        //private - только внутри класса

        public int X;
        public int Y;
        public int Width;
        public int Height;
        public Color Color;

        public void Draw(Graphics gr)
        {
            Pen pen = new Pen(Color, 5);
            gr.DrawRectangle(pen, X, Y, Width, Height);
        }
        public bool IsInside(int x, int y)
        {
            //return ((X <= x) && (x <= X + Width) && (Y < = y) && (y <= Y + Heigh)))
            if ((X <= x) && (x <= X + Width) &&
                (Y <= y) && (y <= Y + Height))
            {
                return true;
            }
            return false;
        }
    }
}
