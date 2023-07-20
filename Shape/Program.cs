using System;
using ShapeLibrary;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            Triangle triangle = new Triangle(-3, 4, 6);

            Console.WriteLine(circle.Square());
            Console.WriteLine(triangle.Square());
            Console.WriteLine(triangle.IsRectangular());
        }
    }
}
