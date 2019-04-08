using Shapes;
using System;

namespace ConnApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!!!");
            //Console.ReadKey(); 

            Rectangle rect = new Rectangle(0, 0, 10, 5);
            rect.Show();

            Ellipse ellipse = new Ellipse(10, 10, 100, 50);
            Circle circle = new Circle(20, 20, 50);
            ellipse.Show();
            circle.Show();
        }
    }
}
