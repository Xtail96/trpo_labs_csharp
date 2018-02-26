using System;
using System.Collections.Generic;

using Shapes;
using ConApp.Factories;
using System.Linq;

namespace ConApp
{
    class Program
    {
        private const int SHAPE_COUNT = 5;

        private static Random _random = new Random(DateTime.Now.Millisecond);


        static void CreateShapes(ref IList<Shape> shapes)
        {
            for (int i = 0; i < SHAPE_COUNT; i++)
            {
                int x = _random.Next();
                int y = _random.Next();

                bool flag = _random.Next() % 2 == 0 ? true : false;
                if (flag)
                    shapes.Add(new Ellipse(x, y, _random.Next() % 40, _random.Next() % 40));
                else
                    shapes.Add(new Circle(x, y, _random.Next() % 40));
            }
        }

        static void CreateShapesByFactory(ref IList<Shape> shapes)
        {
            var factories = new List<ShapeFactory>(new ShapeFactory[]
                {
                    new EllipseFactory(),
                    new CircleFactory()
                });
            for (int i = 0; i < SHAPE_COUNT; i++)
            {
                int factoryIdx = _random.Next() % factories.Count;

                int x = _random.Next();
                int y = _random.Next();
                shapes.Add(factories[factoryIdx].CreateShape(x, y));
            }
        }

        static void Main(string[] args)
        {
            IList<Shape> shapes = new List<Shape>();
            //CreateShapes(ref shapes);
            CreateShapesByFactory(ref shapes);

            foreach(var shape in shapes)
            {
                Console.Write("Object: {0}  ", shape.GetType());
                Console.WriteLine(shape.GetArea());
            }

            var shapes1 = shapes.Select(x => x.GetArea() < 20);

            Console.ReadKey();
        }
    }
}
