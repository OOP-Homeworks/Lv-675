using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace justCoding
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Perimeter2x3_5x5_4x3_return7_84()
        {
            //Arrange
            Point p1 = new Point(2, 3);
            Point p2 = new Point(5, 5);
            Point p3 = new Point(4, 3);
            double expected = 7.84;

            //Act
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Perimeter();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Perimeter1x2_3x4_5x6_return11_31()
        {
            //Arrange
            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(5, 6);
            double expected = 11.31;

            //Act
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Perimeter();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square2x2_3x3_4x4_return40_28()
        {
            //Arrange
            Point p1 = new Point(2, 2);
            Point p2 = new Point(3, 3);
            Point p3 = new Point(4, 4);
            double expected = 40.28;

            //Act
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Square();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square5x7_3x2_6x3_return18_29()
        {
            //Arrange
            Point p1 = new Point(5, 7);
            Point p2 = new Point(3, 2);
            Point p3 = new Point(6, 3);
            double expected = 18.29;

            //Act
            Triangle triangle = new Triangle(p1, p2, p3);
            double result = triangle.Square();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
