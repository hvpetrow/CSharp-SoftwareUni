using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length; 
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                width = value;
            }
        }
        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                height = value;
            }
        }

        public double SurfaceArea()
        {
            double surfaceArea = (2 * length * width) + (2 * length * height) + (2 * width * height);
            return surfaceArea;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * length * height) + (2 * width * height);
            return lateralSurfaceArea;
        }

        public double Volume()
        {
            double volume = length * width * height;
            return volume;
        }
    }
}
