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

        public override int CompareTo(object obj)
        {
            var shape = obj as Shape;
            if(shape != null)
            {
                if (GetArea() < shape.GetArea())
                    return -1;
                else if (GetArea() > shape.GetArea())
                    return 1;
                else
                    return 0;
            }
            else
            {
                throw new InvalidCastException("Can't compare Shape object with another type");
            }
        }
    }
}
