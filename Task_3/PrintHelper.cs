using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class PrintHelper
    {
        public static void Print(IEnumerable array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
