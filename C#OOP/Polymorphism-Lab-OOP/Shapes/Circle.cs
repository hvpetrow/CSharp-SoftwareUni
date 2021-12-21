using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius
        {
            get { return radius; }
           protected set
            {
                radius = value;
            }
        }

        public override double CalculatePerimeter()
       => 2 * Radius * Math.PI;

        public override double CalculateArea()
            => Math.Pow(Radius, 2) * Math.PI;

        public override string Draw()
            => base.Draw() + GetType().Name;
    }
}
