using System;

namespace Shapes
{
    public class Ellipse
    {
        protected Location _location;  // поле доступное в классе наследнике
        private int _radiusX;
        private int _radiusY;

        public Ellipse(int x, int y, int radiusX, int radiusY)
        {
            _location = new Location() { X = x, Y = y }; // специальный синтаксис инициализации свойств объекта
            _radiusX = radiusX;
            _radiusY = radiusY;
        }

        public virtual void Show()
        {
            Console.WriteLine("Class: Ellipse | Location: ({0},{1}) | Radius(X/Y): ({2}, {3})", _location.X, _location.Y, _radiusX, _radiusY);
        }
    }
}
