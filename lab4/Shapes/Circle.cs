namespace Shapes
{
    public class Circle : Ellipse
    {
        private int _radius;

        public Circle(int x, int y, int radius) : base(x, y, radius, radius)
        {
            _radius = radius;
        }
    }
}
