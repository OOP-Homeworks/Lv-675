using Gural_HW10;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Perimeter1x1_3x3_2x1()
        {
            //arrange
            Point a = new Point(1, 1);
            Point b = new Point(3, 3);
            Point c = new Point(2, 1);

            double expected = 6.06;

            //actually
            Triangle triangle = new Triangle(a, b, c);
            double result = triangle.Perimeter();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Area1x1_3x3_2x1()
        {
            //arrange
            Point a = new Point(1, 1);
            Point b = new Point(3, 3);
            Point c = new Point(2, 1);
            double expected = 0.99;

            //actually
            Triangle triangle = new Triangle(a, b, c);
            double result = triangle.Area();

            //assert
            Assert.AreEqual(expected, result);
        }

    }
}
