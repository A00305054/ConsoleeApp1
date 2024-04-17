// SquareTests.cs in Test Library
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class Triangle
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

    // Similarly for other shapes and methods
    public class Square
    {
        private int v;

        public Square(int v)
        {
            this.v = v;
        }

        public int CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
    public int CalculateArea()
    {
        throw new NotImplementedException();
    }

}
