using System;
using System.Collections.Generic;
using System.IO;

namespace GF3
{
    class FilledFigure : Figure
    {
        public Pen Stroke;

        public FilledFigure(Point point, Pen stroke) : base(point)
        {
            Stroke = stroke;
        }

        public FilledFigure(int x, int y, Pen stroke) : base(x, y)
        {
            Stroke = stroke;
        }

        public FilledFigure(int x, int y) : base(x, y)
        {
            basePoint = new Point(x, y);
        }

        public FilledFigure(Point point) : base(point)
        {
            basePoint = point;
        }
    }

    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }
}
