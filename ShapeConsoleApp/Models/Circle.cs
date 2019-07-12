namespace ShapeConsoleApp.Models
{
    public class Circle : Shape
    {
        private readonly int _radius;

        public Circle(Color color, int radius) : base(color)
        {
            _radius = radius;
        }

        public override double Area
        {
            get
            {
                return _radius * _radius * System.Math.PI;
            }
        }
    }
}
