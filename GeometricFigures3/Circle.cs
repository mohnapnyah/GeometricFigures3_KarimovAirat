using System;
using System.Drawing;

namespace GF3
{
    class Circle : FilledFigure
    {
        public int radius;
        public Pen pen;

        public Circle(Point point, int radius, SolidBrush brush, Pen pen) : base(point)
        {
            this.radius = radius;
            this.pen = pen;
        }
        public Circle(Point point, int radius, int brush, int pen, int width) : base(point)
        {
            this.radius = radius;
            this.pen = new Pen(Color.FromArgb(pen), width);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, base.basePoint.X, base.basePoint.Y, radius * 2, radius * 2);
        }

        public override string ToString()
        {
            return $"Circle {base.basePoint.X} {base.basePoint.Y} {radius} {pen.Color.ToArgb()} {pen.Width}";
        }
    }
}
