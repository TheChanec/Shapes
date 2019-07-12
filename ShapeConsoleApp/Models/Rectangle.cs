namespace ShapeConsoleApp.Models
{
    public class Rectangle : Shape
    {
        private readonly int _height;
        private readonly int _width;

        public Rectangle(Color color, int height, int width) : base(color)
        {
            _height = height;
            _width = width;
        }

        public override double Area
        {
            get
            {
                return _width * _height;
            }
        }
    }
}
