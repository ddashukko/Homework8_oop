
using System;

namespace Hw8_4_oop
{
    interface IPricable
    {
        void SetPrice(double price);
    }

    interface IDiscountable
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
    }

    interface IColorable
    {
        void SetColor(byte color);
    }

    interface ISizable
    {
        void SetSize(byte size);
    }

    class Book : IPricable, IDiscountable
    {
        public void SetPrice(double price) { }
        public void ApplyDiscount(string discount) { }
        public void ApplyPromocode(string promocode) { }
    }

    class Outerwear : IPricable, IDiscountable, IColorable, ISizable
    {
        public void SetPrice(double price) { }
        public void ApplyDiscount(string discount) { }
        public void ApplyPromocode(string promocode) { }
        public void SetColor(byte color) { }
        public void SetSize(byte size) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.SetPrice(15.99);
            book.ApplyDiscount("WinterSale");

            Outerwear coat = new Outerwear();
            coat.SetPrice(100.00);
            coat.SetColor(1);
            coat.SetSize(42);
            coat.ApplyPromocode("NewYear2025");
        }
    }
}
//Solution: розділила один громіздкий інтерфейс IItem на 4 маленькі спеціалізовані (IPricable, IDiscountable, IColorable, ISizable)