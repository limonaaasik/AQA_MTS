using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            Phone phone2 = new Phone("+375-29-578-69-99", "Samsung");
            Phone phone3 = new Phone("+7-912-639-94-89", "Xiaomi", 105.8);

            // Вывод через консоль значения переменных
            Console.WriteLine($"Значения 1 экземпляра: Номер: {phone1.number}, Модель: {phone1.model}, Вес: {phone1.weight}");
            Console.WriteLine($"Значения 2 экземпляра: Номер: {phone2.number}, Модель: { phone2.model}, Вес: { phone2.weight}");
            Console.WriteLine($"Значения 3 экземпляра: Номер: {phone3.number}, Модель: {phone3.model}, Вес: {phone3.weight}");

            Console.WriteLine();

            // Вывод через метод значения переменных
            phone1.Print();
            phone2.Print();
            phone3.Print();

            Console.WriteLine();

            // Вызов методов receiveCall и getNumber для каждого из объектов.
            phone1.receiveCall("Ксюша");
            phone2.receiveCall("Даша");
            phone3.receiveCall("Костя");

            phone1.getNumber();
            phone2.getNumber();
            phone3.getNumber();

            Console.WriteLine();


            // Вызов метода sendMessagge
            phone1.sendMessage("+7-912-896-78-78", "+375-29-548-69-96", "+7-961-896-87-33");
            Console.WriteLine();
            phone2.sendMessage("+7-912-896-78-78", "+375-29-548-69-96", "+7-961-896-87-33", "+7-916-896-00-33", "+7-961-896-85-00");

        }
    }
}
