using ShapeConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace ShapeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            Shapes.Add(new Triangle(Color.Yellow,5,6));
            Shapes.Add(new Square(Color.Red, 8));
            Shapes.Add(new Circle(Color.Blue, 5));
            Shapes.Add(new Triangle(Color.Green, 5, 6));
            Shapes.Add(new Rectangle(Color.Purple,10,5));

            Console.WriteLine("Hello World!");

        }
    }
}
