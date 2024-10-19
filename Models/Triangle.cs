using SquareLibrary.Interfaces;

namespace SquareLibrary.Models
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _baseLength;
        private double _height;
        private bool _isUsingSides;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Длины сторон должны быть положительными.");

            _a = a;
            _b = b;
            _c = c;
            _isUsingSides = true;
        }

        public Triangle(double baseLength, double height)
        {
            if (baseLength <= 0 || height <= 0)
                throw new ArgumentException("Основание и высота должны быть положительными.");

            _baseLength = baseLength;
            _height = height;
            _isUsingSides = false;
        }

        public double Square()
        {
            if (_isUsingSides)
            {
                double s = (_a + _b + _c) / 2;
                return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
            }
            else
            {
                return 0.5 * _baseLength * _height;
            }
        }

        public bool IsRightTriangle()
        {
            if (!_isUsingSides) 
                throw new InvalidOperationException("Невозможно проверить прямоугольность для основания и высоты.");

            double[] sides = new double[] { _a, _b, _c };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
