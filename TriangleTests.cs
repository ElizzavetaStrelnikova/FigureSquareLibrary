using SquareLibrary.Models;

namespace SquareLibraryTests
{
    public class TriangleTests
    {
        [Fact]
        public void Area_ShouldReturnCorrectValueForGivenSides()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            var triangle = new Triangle(a, b, c);

            double area = triangle.Square();

            Assert.Equal(6, area);
        }

        [Fact]
        public void Area_ShouldReturnCorrectValueForBaseAndHeight()
        {
            double baseLength = 6;
            double height = 4;
            var triangle = new Triangle(baseLength, height);

            double area = triangle.Square();

            Assert.Equal(12, area);
        }
    }
}