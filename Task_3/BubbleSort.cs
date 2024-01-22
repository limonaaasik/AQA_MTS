using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_3
{
    public class BubbleSort
    {
        static void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        public static int[] Sort(int[] nums)
        {
            var len = nums.Length;
            for (int i = 1; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        Swap(ref nums[j], ref nums[j + 1]);
                    }
                }
            }

            return nums;
        }
    }
}
