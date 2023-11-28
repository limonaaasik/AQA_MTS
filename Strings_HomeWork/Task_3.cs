using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_HomeWork
{
    internal class Task_3
    {
        static void Main3(string[] args)
        {
            //Задание 3
            //Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
            //Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
            //Результат вывести в консоль.

            string text = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string hhh = "abc";
            int indexOfABC = text.IndexOf(hhh);

            string firstPartOfText = text.Substring(0, indexOfABC);
            string middlePartOfText = text.Substring(indexOfABC, hhh.Length);
            string secondPartOfText = text.Substring(indexOfABC + hhh.Length);
            Console.WriteLine($"Первая часть текста до abc: {firstPartOfText}");
            Console.WriteLine($"Вторая часть текста после abc: {secondPartOfText}");
            Console.WriteLine($"Серединная часть текста abc: {middlePartOfText}");

        }
    }
}
