using Shapes;
using System;

namespace ConApp
{
    class SomeAbstractClass
    {
        public static void StaticMethod(object obj, Location l)
        {
            Console.WriteLine("static function");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(10, 10, 25);
            IPublisher publisher = new Ellipse(30, 40, 50, 20);
            publisher.LocationChanged += delegate (object pub, Location e) { Console.WriteLine("{0} moved to: ({1}, {2})", pub, e.X, e.Y); };

            Console.WriteLine(circle);
            Console.WriteLine(publisher);
            if (publisher is Shape)
                ((Shape)publisher).MoveTo(50, 50);


            IPublisher myPublisher = new Rectangle(0, 0, 10, 5);
            myPublisher.LocationChanged += delegate (object obj, Location l)
            {
                Console.WriteLine("{0} moved to: ({1}, {2})", obj, l.X, l.Y);
            };
            myPublisher.LocationChanged += SomeAbstractClass.StaticMethod;

            Console.WriteLine(myPublisher);
            if(myPublisher is Shape)
            {
                ((Shape)myPublisher).MoveTo(100, 100);
            }

            Console.ReadKey();
        }
    }
}
