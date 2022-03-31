using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW10
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Perimeter1x3_2x5_5x3_return9_84()
        {
            //arrange
            Point p1 = new Point(1, 3);
            Point p2 = new Point(2, 5);
            Point p3 = new Point(5, 3);
            double expected = 9.84;

            //actually
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Perimeter();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Perimeter13x2_35x4_5x63_return149_8()
        {
            //arrange
            Point p1 = new Point(13, 2);
            Point p2 = new Point(35, 4);
            Point p3 = new Point(5, 63);
            double expected = 149.8;

            //actually
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Perimeter();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Area15x2_32x3_4x9_return64_91()
        {
            //arrange
            Point p1 = new Point(15, 2);
            Point p2 = new Point(32, 3);
            Point p3 = new Point(4, 9);
            double expected = 64.91 ;

            //actually
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Area();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Area10x11_20x21_30x31_return2_03()
        {
            //arrange
            Point p1 = new Point(10, 11);
            Point p2 = new Point(20, 21);
            Point p3 = new Point(30, 31);
            double expected = 2.03;

            //actually
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Area();

            //assert
            Assert.AreEqual(expected, result);
        }


    }
}