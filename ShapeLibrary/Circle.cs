using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Значение радиуса круга не может быть меньше 0");
            }
            else
            {
                Radius = radius;
            }
        }

        public override double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
