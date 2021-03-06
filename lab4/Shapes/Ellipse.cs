﻿using System;

namespace Shapes
{
    public class Ellipse : Shape
    {
        private int _radiusX;
        private int _radiusY;

        public Ellipse(int x, int y, int radiusX, int radiusY) : base (x, y)
        {
            _radiusX = radiusX;
            _radiusY = radiusY;
        }

        public int RadiusY
        {
            get
            {
                return _radiusY;
            }

            set
            {
                _radiusY = value;
            }
        }

        public int RadiusX
        {
            get
            {
                return _radiusX;
            }

            set
            {
                _radiusX = value;
            }
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
