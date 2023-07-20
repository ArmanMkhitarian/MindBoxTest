using NUnit.Framework;
using ShapeLibrary;
using System;

namespace ShapeTest
{
    public class Tests
    {
        [Test]
        public void TestSquare()
        {
            Circle circle = new Circle(4);
            Assert.That(circle.Square(), Is.EqualTo(50.27));
        }


        [Test]
        public void TestException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Circle(-2));

            StringAssert.Contains("Значение радиуса круга не может быть меньше 0", ex.Message.ToString());
        }
    }
}