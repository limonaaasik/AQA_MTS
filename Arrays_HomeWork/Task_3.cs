using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Arrays_HomeWork
{
    internal class Task_3
    {
        static void Main3(string[] args)
        {
            /*Задание 3
            Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
            Для генерации случайного числа используйте метод Random().Пусть будет возможность создавать массив произвольного размера. 
            Пусть размер массива вводится с консоли. */

            Console.WriteLine("Введите размер массива:");
            int massiveSize = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[massiveSize];
            var rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(100);
            }

            Console.WriteLine("Ваш массив:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }

            Console.WriteLine();

            int sum = 0;
            for (int i = 0;i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            double sred = Convert.ToDouble(sum) / nums.Length;
            Console.WriteLine($"Среднее значение массива: {sred}") ;

            int maxNum = Int32.MinValue;
            int minNum = Int32.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxNum)
                {
                    maxNum = nums[i];
                }
                if (nums[i] < minNum)
                {
                    minNum = nums[i];
                }
            }
            Console.WriteLine($"Максимальное значение массива: {maxNum}");
            Console.WriteLine($"Минимальное значение массива: {minNum}");

        }
    }
}
