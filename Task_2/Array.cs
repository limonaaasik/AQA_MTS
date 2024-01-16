using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Array<T>
    {
        public T[] array = new T[0];

        public void Add(T value)
        {
            List<T> list = new List<T>(array);
            list.Add(value);
            array = list.ToArray();
        }

        public void Remove(int index)
        {
            List<T> list = new List<T>(array);
            list.RemoveAt(index);
            array = list.ToArray();
        }

        public void PrintArray()
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]} ");
            }
            Console.WriteLine();
        }

        public T GetElement (int index)
        {
            return array[index];
        }

        public int GetLength()
        {
            return array.Length;
        }
    }
}
