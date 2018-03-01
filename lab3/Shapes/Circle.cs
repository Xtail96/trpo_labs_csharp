namespace Shapes
{
    public class Circle : Ellipse
    {
        private int _radius;

        public Circle(int x, int y, int radius) : base(x, y, radius, radius)
        {
            _radius = radius;
        }

        public override string ToString()
        {
            return string.Format("Circle: ({0}, {1} ; {2})", _location.X, _location.Y, _radius);
        }
    }
}
