using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Array<T>
    {
        public T[] array;

        public void Add(T value)
        {
            var tmp = new List<T>(array);
            tmp.Add(value);
            array = tmp.ToArray();
        }
        public void PrintArray(T[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]} ");
            }
            Console.WriteLine();
        }
    }
}
