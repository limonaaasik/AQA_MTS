using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class MainClass
    {
        public delegate int[] SortArray(int[] numbers);

        public SortArray SelectSortMethod (Sort method)
        {
            switch (method) 
            {
                case Sort.Bubble:
                    return new SortArray(BubbleSort.Sort);
                case Sort.Shell:
                    return new SortArray(ShellSort.Sort);
                default: return null;
            }
        }
    }
}
