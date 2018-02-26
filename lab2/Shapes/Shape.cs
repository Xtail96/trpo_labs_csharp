namespace Shapes
{
    public abstract class Shape
    {
        private Location _location;

        protected Shape(int x, int y)
        {
            _location = new Location() { X = x, Y = y };
        }

        public void MoveTo(int x, int y)
        {
            _location.X = x;
            _location.Y = y;
        }

        public abstract double GetArea();
    }
}
