using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    internal class Class1
    {
        //[SetUp]
        //public void Setup1()
        //{
        //    Console.WriteLine($"{this}: SetUp1... {++i}");
        //}

        [Test]
        public void Test()
        {
            Console.WriteLine($"{this}: Test...");  // с помощью this узнаем где мы находимся
            Assert.Pass();
        }
    }
}
