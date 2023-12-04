using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card1 = new CreditCard("8797 8989 8989 8954", 1000);
            CreditCard card2 = new CreditCard("2222 8989 2222 1111", 2000.35);
            CreditCard card3 = new CreditCard("5555 6666 2222 7777", 35897.06);

            card1.sendMoneyToCard(1858.96);
            card2.sendMoneyToCard(3000);
            card3.takeCashFromCard(15000);

            card1.InfoCard();
            card2.InfoCard();
            card3.InfoCard();
        }
    }
}
