using SquareLibrary.Models;

namespace SquareLibraryTests
{
    public class CircleTests
    {
        [Fact]
        public void Square_Should_Return_Correct_Area_For_Given_Radius()
        {
            double radius = 5.0; 
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius; 

            double actualArea = circle.Square(); 

            Assert.Equal(expectedArea, actualArea, precision: 5); 
        }
    }
}
