using System;

namespace Shapes
{
    public class Ellipse : Shape
    {
        protected Location _location;  // поле доступное в классе наследнике
        private int _radiusX;
        private int _radiusY;

        public Ellipse(int x, int y, int radiusX, int radiusY) : base (x, y)
        {
            _location = new Location() { X = x, Y = y }; // специальный синтаксис инициализации свойств объекта
            _radiusX = radiusX;
            _radiusY = radiusY;
        }

        public override double GetArea()
        {
            return Math.PI * _radiusX *_radiusY;
        }
    }
}
