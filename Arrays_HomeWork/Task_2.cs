using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays_HomeWork
{
    internal class Task_2
    {
        static void Main(string[] args)
        {

            //Задание 2
            //Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
            //Пусть число задается с консоли.Если такого числа нет -выведите сообщения об этом.
            //В результате должен быть новый массив без указанного числа.

            int[] array = { 11, 20, 1, 7, 258, 36, 79, 6 };

            Console.WriteLine("Массив:");

            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите число:");
            string? numberToDeleteString = Console.ReadLine();
            int numberToDelete = Convert.ToInt32(numberToDeleteString);

            // Решение задачи
            int count = 0;

            foreach (int item in array)
            {
                if (item == numberToDelete) count++;
            }

            int[] newArray = new int[array.Length - count];
            int newIndex = 0;

            foreach (var item in array)
            {
                if (item != numberToDelete)
                {
                    newArray[newIndex] = item;
                    newIndex++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"Число {numberToDelete} удалено из массива {count} раз(а).");
                Console.WriteLine("Новый массив:");

                foreach (var num in newArray)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine($"Число {numberToDelete} не найдено в массиве.");
            }
        }
    }
}
