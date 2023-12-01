using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Student
    {
        public string name;
        public int group;
        public int diplomMark;

        public Student()
        {
        }

        public Student(string name)
        {
            this.name = name;  // this,name - переменная класса из блока переменных, name - перемменная из конструктора
            group = 1;
            diplomMark = new Random().Next(1, 11);
        }
        public void Print()
        {
            Console.Write($"Name: {name}, Group: {group}, Mark: {diplomMark}");
            Console.WriteLine();
        }


    }
}
