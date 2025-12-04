using System;

namespace Hw8_2_oop
{
    interface ILog
    {
        void Info(string message);
    }

    class ConsoleLogger : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }

    class EmailSender
    {
        // ... sending...

        private readonly ILog _logger;

        public EmailSender(ILog logger)
        {
            _logger = logger;
        }

        public void Send(Email email)
        {
            _logger.Info($"Email from '{email.From}' to '{email.To}' was sent");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
            Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
            Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
            Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
            Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
            Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

            ILog logger = new ConsoleLogger();
            EmailSender es = new EmailSender(logger);

            es.Send(e1);
            es.Send(e2);
            es.Send(e3);
            es.Send(e4);
            es.Send(e5);
            es.Send(e6);

            Console.ReadKey();
        }
    }
}

// тут була порушена помилка як і в попередньому завданні, Принцип єдиної відповідальності (Single Responsibility Principle — SRP).
//Клас EmailSender має лише відправляти листи, але він також бере на себе відповідальність за те, як і куди виводити інформацію про цю дію