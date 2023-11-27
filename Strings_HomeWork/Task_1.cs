using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_HomeWork
{
    internal class Task_1
    {
        static void Main1(string[] args)
        {
            // Задание 1:
            //Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.

            string message = "You can 123 test it on 99 Monday at 6 pm test";
            message = message.Replace("test", "testing");

            for (int i = 0; i < 10; i++)
            {
                message = message.Replace($"{i}", "");
            }

            Console.WriteLine(message);
        }
    }
}
