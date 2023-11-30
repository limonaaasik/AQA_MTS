using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_HomeWork
{
    internal class Task_4
    {
        static void Main4(string[] args)
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

            Console.WriteLine();

            int sumArray1 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sumArray1 = sumArray1 + array1[i];
            }
            double sredArray1 = Convert.ToDouble(sumArray1) / array1.Length;
            Console.WriteLine($"Среднее арифметическое значение массива 1: {sredArray1}");

            int sumArray2 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                sumArray2 = sumArray2 + array2[i];
            }
            double sredArray2 = Convert.ToDouble(sumArray2) / array2.Length;
            Console.WriteLine($"Среднее арифметическое значение массива 2: {sredArray2}");

            if ( sredArray1 >  sredArray2) 
            {
                Console.WriteLine("Среднее арфиметическое значение массива 1 > среднего арифместического значения массива 2");
            } else if ( sredArray1 < sredArray2) 
            {
                Console.WriteLine("Среднее арфиметическое значение массива 2 > среднего арифместического значения массива 1");
            } else if ( sredArray2 == sredArray1)
            {
                Console.WriteLine("Средние арифметические массивов 1 и 2 равны");
            }
        }
    }
}
