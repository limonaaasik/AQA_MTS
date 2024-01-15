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
            for (int item = 0; item < array.Length; item++)
            {
                array[item] = value;
            }
        }
    }
}
