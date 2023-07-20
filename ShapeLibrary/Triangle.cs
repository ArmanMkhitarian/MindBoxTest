using System;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {
        public double SideA;
        public double SideB;
        public double SideC;
        public Triangle(double sideA, double sideB, double sideC)
        {
            if(IsExistTriangle(sideA, sideB, sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
        }

        public override double Square()
        {
            var perimetr = (SideA + SideB + SideC) / 2;
            var square = Math.Round(Math.Sqrt(perimetr * (perimetr - SideA) * (perimetr - SideB) * (perimetr - SideC)), 2);
            return square;
        }

        private bool IsExistTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentException("Значение одной из сторон треугольника меньше 0");
            }

            if (sideA > (sideB + sideC) || sideB > (sideA + sideC) || sideC > (sideA + sideB))
            {
                throw new ArgumentException("Одна из сторон треугольника больше, чем сумма двух других");
            }

            return true;
        }

        public bool IsRectangular()
        {
            if (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
               (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)) ||
               (Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
