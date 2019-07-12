namespace ShapeConsoleApp.Models
{
    public abstract class Shape
    {
        private readonly Color _color;

        public Shape(Color color)
        {
            _color = color;
        }

        public abstract double Area { get;  }
    }
}
