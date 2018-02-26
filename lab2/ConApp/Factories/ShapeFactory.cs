using Shapes;
using System;

namespace ConApp.Factories
{
    internal abstract class ShapeFactory
    {
        public abstract Shape CreateShape(int x, int y);
    }

    internal class EllipseFactory : ShapeFactory
    {
        private Random _random = new Random(DateTime.Now.Millisecond);

        public override Shape CreateShape(int x, int y)
        {
            return new Ellipse(x, y, _random.Next(), _random.Next());
        }
    }

    internal class CircleFactory : ShapeFactory
    {
        public override Shape CreateShape(int x, int y)
        {
            return new Circle(x, y, 0);
        }
    }
}
