using NUnit.Framework;
using ShapeLibrary;
using System;

namespace ShapeTest
{
    public class TriangleTest
    {
        [Test]
        public void TestSquare()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.Square(), Is.EqualTo(6));
        }

        [Test]
        public void TestIsRectangular()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.IsRectangular(), Is.EqualTo(true));

            Triangle triangleNotRectangular = new Triangle(3, 4, 6);
            Assert.That(triangleNotRectangular.IsRectangular(), Is.EqualTo(false));
        }

        [Test]
        public void TestException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(-2, 4, 5));
            StringAssert.Contains("Значение одной из сторон треугольника меньше 0", ex.Message.ToString());

            var ex2 = Assert.Throws<ArgumentException>(() => new Triangle(-2, -4, 5));
            StringAssert.Contains("Значение одной из сторон треугольника меньше 0", ex2.Message.ToString());

            var ex3 = Assert.Throws<ArgumentException>(() => new Triangle(2, 4, -5));
            StringAssert.Contains("Значение одной из сторон треугольника меньше 0", ex3.Message.ToString());

            var ex4 = Assert.Throws<ArgumentException>(() => new Triangle(2, -4, 5));
            StringAssert.Contains("Значение одной из сторон треугольника меньше 0", ex4.Message.ToString());

            var ex5 = Assert.Throws<ArgumentException>(() => new Triangle(2, 3, 18));
            StringAssert.Contains("Одна из сторон треугольника больше, чем сумма двух других", ex5.Message.ToString());

            var ex6 = Assert.Throws<ArgumentException>(() => new Triangle(18, 3, 4));
            StringAssert.Contains("Одна из сторон треугольника больше, чем сумма двух других", ex6.Message.ToString());

            var ex7 = Assert.Throws<ArgumentException>(() => new Triangle(6,18, 4));
            StringAssert.Contains("Одна из сторон треугольника больше, чем сумма двух других", ex7.Message.ToString());
        }
    }
}
