using System;

namespace Hw8_3_oop 
{
    interface IShape
    {
        int Area();
    }

    class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area()
        {
            return Width * Height;
        }
    }

    class Square : IShape
    {
        public int Side { get; set; }

        public int Area()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { Width = 5, Height = 10 };
            Console.WriteLine(rect.Area());

            Square square = new Square { Side = 10 };
            Console.WriteLine(square.Area());

            Console.ReadKey();
        }
    }
}

/* Тут порушено Принцип підстановки Лісков (Liskov Substitution Principle — LSP).

Цей принцип говорить, що об'єкти базового класу (Rectangle) повинні мати можливість бути заміненими об'єктами похідного класу (Square)
без зміни коректності роботи програми.
Тут це неможливо, бо квадрат змінює логіку роботи сторін (вони залежні), 
тоді як у прямокутника вони незалежні.
Виправлення:
Щоб вирішити проблему, потрібно розірвати наслідування між Квадратом і Прямокутником. Вони повинні реалізовувати спільний інтерфейс. */