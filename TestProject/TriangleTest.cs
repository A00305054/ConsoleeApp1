using ClassLibrary;
using TestProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            // Arrange
            var triangle = new Triangle(5, 3, 4);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TestTrianglePerimeter()
        {
            // Arrange
            var triangle = new Triangle(5, 7, 8);

            // Act
            var perimeter = triangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, perimeter);
        }
    }
}
