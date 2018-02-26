using System;
using System.Drawing;

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

        public virtual void Show(Graphics graphics)
        {
            var X = _location.X - _radiusX;
            var Y = _location.Y - _radiusY;
            graphics.DrawEllipse(Pens.Black, new Rectangle(X, Y, _radiusX * 2, _radiusY * 2));
        }
    }
}
