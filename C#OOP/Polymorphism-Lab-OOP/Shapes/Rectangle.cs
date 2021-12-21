using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height
        {
            get { return height; }
            protected set
            {
                height = value;
            }
        }
        public int Width
        {
            get => width;
            protected set
            {
                width = value;
            }
        }

        public override double CalculateArea()
        => Height * Width;

        public override double CalculatePerimeter()
        => (Height + Width) * 2;

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
    }
}
