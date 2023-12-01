using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Cat
    {
        public string name;
        public int age;
        public int maxFoodCount;

        public bool Feed(int foodCount)
        {
            return foodCount >= maxFoodCount;
        }
    }
}
