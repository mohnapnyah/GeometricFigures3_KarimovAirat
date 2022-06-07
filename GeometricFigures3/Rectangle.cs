using System;

namespace GF3
{
    class Rectangle : FilledFigure
    {
        public int Height;
        public int Width;
        public Pen pen;

        public Rectangle(Point point, int height, int width, Pen pen) : base(point)
        {
            Height = height;
            Width = width;
            this.pen = pen;
        }

        public Rectangle(Point point, int height, int width,  int pen, int penWidth) : base(point)
        {
            Height = height;
            Width = width;
            this.pen = new Pen(Color.FromArgb(pen), penWidth);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, base.basePoint.X, base.basePoint.Y, Width, Height);
        }

        public override string ToString()
        {
            return $"Rectangle {base.basePoint.X} {base.basePoint.Y} {Height} {Width}  {pen.Color.ToArgb()} {pen.Width}";
        }
    }
}
