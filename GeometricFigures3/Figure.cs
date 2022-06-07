using System;

namespace GF3
{
    class Figure
    {
        protected Point basePoint;

        public Figure()
        {

        }

        public Figure(Point point)
        {
            basePoint = point;
        }

        public Figure(int x, int y)
        {
            basePoint = new Point(x, y);
        }

        public virtual void Draw(Graphics graphics)
        {
            
        }

        public virtual string ToString()
        { 
            return $"{basePoint.X}, {basePoint.Y}"; 
        }
    }
}
