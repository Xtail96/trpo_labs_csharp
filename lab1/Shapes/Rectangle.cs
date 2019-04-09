using System;
namespace Shapes
{
    // Класс описывающий прямоугольник
    public class Rectangle
    {
        // Двумерные координаты (X, Y)
        protected Location _location;

        // Сторона a
        private int _a;

        // Сторона b
        private int _b;

        // Конструктор класса
        public Rectangle(int x, int y, int a, int b)
        {
            this._location = new Location() { X = x, Y = y };
            this._a = a;
            this._b = b;
        }

        // Выводит в консоль информацию о прямоугольнике
        public virtual void Show()
        {
            Console.WriteLine("Class: Rectangle | Location: ({0},{1}) | Sides(a, b): ({2}, {3})", this._location.X, this._location.Y, this._a, this._b);
        }
    }
}
