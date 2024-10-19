using SquareLibrary.Interfaces;

namespace SquareLibrary
{
    public class Program
    {
        static void Main()
        {
            List<IFigure> figures = new List<IFigure>
            {
                FigureFactory.CreateCircle(5), 
                FigureFactory.CreateTriangle(3, 4, 5) 
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Площадь фигуры: {figure.Square()}");
            }
        }
    }
}
