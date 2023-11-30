using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_HomeWork
{
    internal class Task_1
    {
        static void Main1(string[] args)
        {
            //Задание 1
            //Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, 
            //входит ли заданное число в массив или нет.Пусть число для поиска задается с консоли.

            int[] numbers = new int[] {1, 2, 3, 4};
            Console.WriteLine("Введите число:");
            string? num = Console.ReadLine();
            double numDouble = Convert.ToDouble(num);
            bool result = false;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                if (numbers[i] == numDouble)
                {
                    result = true;
                }
            }

            if (result == true)
            {
                Console.WriteLine("Заданное число входит в массив");
            } else
            {
                Console.WriteLine("Заданное число не входит в массив");
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.Write($"{numbers[i]} "); 
            }

            
        }
    }
}
