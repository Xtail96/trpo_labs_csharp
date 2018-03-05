using System;
using System.Runtime.Serialization;

namespace Shapes
{
    public abstract class Shape : IComparable
    {
        protected Location _location;

        public Shape(int x, int y)
        {
            _location = new Location() { X = x, Y = y };
        }

        public void MoveTo(int x, int y)
        {
            _location.X = x;
            _location.Y = y;
        }

        protected Location Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }

        public abstract double GetArea();

        //сравнивать будем по площади фигуры
        public abstract int CompareTo(object obj);
    }
}
