using System;
namespace Shapes
{
    // Класс для описания прямоугольника
    // Наследник базового класса Shape
    public class Rectangle : Shape
    {
        // Сторона A
        private int _a;

        // Сторона B
        private int _b;

        // Конструктор класса
        public Rectangle(int x, int y, int a, int b) : base(x, y)
        {
            this._a = Math.Abs(a);
            this._b = Math.Abs(b);
        }

        // Выводит в консоль информацию о прямоугольнике
        public virtual void Show()
        {
            Console.WriteLine("Class: Rectangle | Location: ({0},{1}) | Sides(a, b): ({2}, {3})", this._location.X, this._location.Y, this._a, this._b);
        }

        // Переопределяет метод вычисления площади
        public override double GetArea()
        {
            return this._a * this._b;
        }
    }
}
