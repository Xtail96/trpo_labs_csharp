using System;
using System.Collections.Generic;
using System.Linq;

using Shapes;
using ConApp.Factories;

namespace ConApp
{
    class Program
    {
        private const int SHAPE_COUNT = 5;

        private static Random _random = new Random(DateTime.Now.Millisecond);


        static void CreateShapes(ref ICollection<Shape> shapes)
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

        static void CreateShapesByFactory(ref ICollection<Shape> shapes)
        {
            var factories = new List<ShapeFactory>(new ShapeFactory[]
                {
                    new EllipseFactory(),
                    new CircleFactory()
                });
            for (int i = 0; i < SHAPE_COUNT; i++)
            {
                int factoryIdx = _random.Next() % factories.Count;
                var factory = factories[factoryIdx];

                int x = _random.Next();
                int y = _random.Next();
                shapes.Add(factory.CreateShape(x, y));
            }
        }

        static void Main(string[] args)
        {
            ICollection<Shape> shapes = new List<Shape>();
            //CreateShapes(ref shapes);
            CreateShapesByFactory(ref shapes);

            foreach (var shape in shapes)
            {
                Console.Write("Object: {0}  ", shape.GetType());
                Console.WriteLine(shape.GetArea());
            }
            Console.WriteLine();

            var shapes1 = from shape in shapes where shape.GetArea() < 20 select shape;
            Console.WriteLine("Shapes1:");
            foreach (var shape in shapes1)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();

            Console.WriteLine("Shapes2:");
            var shapes2 = shapes.Where(x => x.GetArea() < 20);
            foreach(var shape in shapes2)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine();


            ICollection<Shape> sortedShapes = new SortedSet<Shape>();
            CreateShapesByFactory(ref sortedShapes);
            Console.WriteLine("Sorted Shapes:");
            sortedShapes.ToList<Shape>().ForEach(i => Console.WriteLine("{0} | Area:{1}", i, i.GetArea()));

            Console.ReadKey();
        }
    }
}
