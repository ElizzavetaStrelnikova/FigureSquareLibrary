using SquareLibrary.Interfaces;

namespace SquareLibrary.Models
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Square()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
