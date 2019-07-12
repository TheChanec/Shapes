namespace ShapeConsoleApp.Models
{
    public class Triangle : Shape
    {
        private readonly int _height;
        private readonly int _base;

        public Triangle(Color color, int height, int base_) : base(color)
        {
            _height = height;
            _base = base_;
        }

        public override double Area { get => (_base * _height / 2) ; }
    }
}
