using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_HW
{
    internal class DivideData
    {
        public static object[] DivideCasesInt =
        {
            new object[] { 12, 3, 4 },
            new object[] { -10, 2, -5 },
            new object[] { -15, -3, 5 }
        };

        public static object[] DivideCasesDouble =
        {
            new object[] { 12.2, 2, 6.1 },
            new object[] { 10, 2, 5 },
            new object[] { 20.5, 5, 4.1 }
        };
    }
}
