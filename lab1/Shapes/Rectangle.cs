using System;
namespace Shapes
{
    public class Rectangle
    {
        protected Location _location;  // поле доступное в классе наследнике
        private int _a;
        private int _b;

        public Rectangle(int x, int y, int a, int b)
        {
            this._location = new Location() { X = x, Y = y };
            this._a = a;
            this._b = b;
        }

        public virtual void Show()
        {
            Console.WriteLine("Class: Rectangle | Location: ({0},{1}) | Sides(a, b): ({2}, {3})", this._location.X, this._location.Y, this._a, this._b);
        }
    }
}
