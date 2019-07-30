using ShapeConsoleApp.Models;
using System.Linq;

namespace ShapeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Triangle(Color.Yellow,5,6),
                new Square(Color.Red, 8),
                new Circle(Color.Blue, 3),
                new Triangle(Color.Green, 5, 6),
                new Rectangle(Color.Purple, 10, 5)
            };

            foreach (Shape s in shapes.OrderBy(x=> x.Area))
            {
                System.Console.WriteLine($"{s.GetType()} {s.Area} { s.Color } ");
            }
            

        }
    }
}
