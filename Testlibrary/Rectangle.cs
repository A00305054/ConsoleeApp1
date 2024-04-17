// SquareTests.cs in Test Library
using TestLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class Rectangle
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var rectangle = new Rectangle(5 ,6);

        // Act
        var result = rectangle.CalculateArea();

        // Assert
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void TestRectanglePerimeter()
    {
        // Arrange
        var rectangle = new Rectangle(6, 7);

        // Act
        var p = rectangle.CalculatePerimeter();

        // Assert
        Assert.AreEqual(26, p);
    }

}
