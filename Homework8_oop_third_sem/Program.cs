using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            var repository = new OrderRepository();
            var printer = new OrderPrinter();

            repository.Save(order);
            printer.PrintOrder(order);

            Console.ReadLine();
        }
    }

    class Item { }

    class Order
    {
        public List<Item> ItemList { get; set; } = new List<Item>();

        public void AddItem(Item item)
        {
            ItemList.Add(item);
        }

        public void DeleteItem(Item item)
        {
            ItemList.Remove(item);
        }

        public decimal CalculateTotalSum()
        {
            return 0;
        }
    }

    class OrderRepository
    {
        public void Load(Order order) { }
        public void Save(Order order) { }
        public void Update(Order order) { }
        public void Delete(Order order) { }
    }

    class OrderPrinter
    {
        public void PrintOrder(Order order) { }
        public void ShowOrder(Order order) { }
    }
}
//тут було порушення Single Responsibility Principle (SRP) 