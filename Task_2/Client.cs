using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Client
    {
        public int code;
        public int year;
        public int month;
        public int trainingDuration;

        public Client(int code, int year, int month, int traininDuration) 
        {
            code = this.code;
            this.year = year;
            this.month = month;
            this.trainingDuration = traininDuration;
        }
    }
}
