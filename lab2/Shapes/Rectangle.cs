using System;
namespace Shapes
{
    public class Rectangle : Shape
    {
        private int _a;
        private int _b;

        public Rectangle(int x, int y, int a, int b) : base(x, y)
        {
            this._a = Math.Abs(a);
            this._b = Math.Abs(b);
        }

        public virtual void Show()
        {
            Console.WriteLine("Class: Rectangle | Location: ({0},{1}) | Sides(a, b): ({2}, {3})", this._location.X, this._location.Y, this._a, this._b);
        }

        public override double GetArea()
        {
            return this._a * this._b;
        }
    }
}
