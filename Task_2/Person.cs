using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            Console.WriteLine("Создание объекта Person");
            name = this.name;
            age = this.age;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
}