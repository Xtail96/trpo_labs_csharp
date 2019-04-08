using System;

namespace Shapes
{
    public abstract class Shape : IComparable
    {
        protected Location _location;

        protected Shape(int x, int y)
        {
            _location = new Location() { X = x, Y = y };
        }

        public virtual void MoveTo(int x, int y)
        {
            _location.X = x;
            _location.Y = y;
        }

        public abstract double GetArea();

        //сравнивать будем по площади фигуры
        public virtual int CompareTo(object obj)
        {
            if (obj is Shape shape)
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
