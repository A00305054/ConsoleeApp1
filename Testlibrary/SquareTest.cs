using TestLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestLibrary 
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestArea()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculateArea();

            // Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var perimeter = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, perimeter);
        }
    }
}