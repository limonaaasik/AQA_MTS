using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_HomeWork
{
    internal class Task_4
    {
        static void Main4(string[] args)
        {
            //Задание 4
            //Дана строка: “Плохой день.”
            //Необходимо с помощью метода substring удалить слово "плохой".
            //После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
            //Заменить последний "!" на "?"

            string text = "Плохой день.";
            string text1 = text.Substring(7);
            Console.WriteLine($"Текст после обрезки: {text1}");

            string goodDay = text1.Insert(0, "Хороший ").Replace(".", "!!!!!!!!!.");
            Console.WriteLine($"Текст после изменения: {goodDay}");

            goodDay = goodDay.Remove(goodDay.LastIndexOf('!'), 1);
            goodDay = goodDay.Insert(goodDay.Length - 2, "?");
            Console.WriteLine($"Итоговый текст: {goodDay}");


        }
    }
}
