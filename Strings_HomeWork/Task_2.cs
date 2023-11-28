using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_HomeWork
{
    internal class Task_2
    {
        static void Main2(string[] args)
        {
            //Задание 2
            //Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
            //Welcome to the TMS lesons.
            //Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome".Не забывайте о пробелах после каждого слова

            string s5 = "Welcome ";
            string s6 = "to ";
            string s7 = "the ";
            string s8 = "TMS ";
            string s9 = "lesons";
            string s10 = ".";

            string final = s5 + s6 + s7 + s8 + s9 + s10;
            Console.WriteLine(final);

        }
    }
}
