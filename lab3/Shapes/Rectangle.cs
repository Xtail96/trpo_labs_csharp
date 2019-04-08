using System;
namespace Shapes
{
    public class Rectangle : Shape, IPublisher
    {
        private int _a;
        private int _b;

        public event EventHandler<Location> LocationChanged;

        public Rectangle(int x, int y, int a, int b) : base(x, y)
        {
            this._a = Math.Abs(a);
            this._b = Math.Abs(b);
        }

        public override double GetArea()
        {
            return this._a * this._b;
        }

        public override void MoveTo(int x, int y)
        {
            base.MoveTo(x, y);
            if (LocationChanged != null)
                LocationChanged(this, _location);
        }

        public override string ToString()
        {
            return string.Format("Rectangle: (Location: ({0}, {1}); Sides: ({2}, {3}))",
                this._location.X, this._location.Y, this._a, this._b);
        }
    }
}
