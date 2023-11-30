using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_HomeWork
{
    internal class Task_4
    {
        static void Main(string[] args)
        {
            //Задание 4
            //Создайте 2 массива из 5 чисел.
            //Выведите массивы на консоль в двух отдельных строках.
            //Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше
            //(либо сообщите, что их средние арифметические равны).

            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[] { 6, 7, 8, 9, 10 };

            Console.Write($"Элементы массива 1: ");

            foreach (int i in array1)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            Console.Write($"Элементы массива 2: ");

            foreach (int i in array2)
            {
                Console.Write($"{i} ");
            }



        }
    }
}
