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

            // Создаем прямоугольник
            Rectangle rect = new Rectangle(0, 0, 10, 5);

            // Выодим информацию в консоль
            rect.Show();

            Ellipse ellipse = new Ellipse(10, 10, 100, 50);
            Circle circle = new Circle(20, 20, 50);
            ellipse.Show();
            circle.Show();
        }
    }
}
