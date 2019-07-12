namespace ShapeConsoleApp.Models
{
    public class Square : Rectangle
    {
        private readonly int _side;

        public Square(Color color, int side) : base(color, side, side)
        {
            _side = side;
        }

    }
}
