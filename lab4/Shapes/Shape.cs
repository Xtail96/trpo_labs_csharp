using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

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

        public abstract double GetArea();

        // представление объекта в виде JSON
        public virtual string JSONSerialize()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            return JsonConvert.SerializeObject(this, settings);
        }

    }
}
