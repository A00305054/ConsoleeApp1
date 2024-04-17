using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;
using ClassLibrary;

namespace TestProject
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
        public void TestPerimeter()
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