using System;
using Newtonsoft.Json;

namespace Shapes
{
    public class Rectangle : Shape
    {
        //private int _a;
        //private int _b;

        public Rectangle(int x, int y, int a, int b) : base(x, y)
        {
            this.A = Math.Abs(a);
            this.B = Math.Abs(b);
        }

        public Location Position
        {
            get
            {
                return this._location;
            }

            set
            {
                this._location = value;
            }
        }

        public int A { get; set; }

        public int B { get; set; }

        /*public int A
        {
            get
            {
                return this._a;
            }

            set
            {
                this._a = value;
            }
        }*/

        /*public int B
        {
            get
            {
                return this._b;
            }

            set
            {
                this._b = value;
            }
        }*/

        public override double GetArea()
        {
            return this.A * this.B;
        }

        public override string ToString()
        {
            return string.Format("Rectangle: (Location: ({0}, {1}); Sides: ({2}, {3}))",
                this._location.X, this._location.Y, this.A, this.B);
        }
    }
}
