using ClassLibrary;

namespace TestProject
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestArea()
        {
            // Arrange
            var rectangle = new Rectangle(6, 7);

            // Act
            var area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(42, area);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            // Arrange
            var rectangle = new Rectangle(6, 7);

            // Act
            var perimeter = rectangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(26, perimeter);
        }
    }
}