using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Homework
{
    public class CreditCard
    {
        // Блок переменных
        public string accountNumber;
        public double accountSum;


        //Блок конструктора
        public CreditCard(string accountNumber, double accountSum) 
        {
            this.accountNumber = accountNumber;
            this.accountSum = accountSum;
        }


        // Блок методов
        public void sendMoneyToCard(double amount)
        {
            accountSum += amount;
        }

        public void takeCashFromCard(double amount)
        {
            accountSum -= amount;
        }

        public void InfoCard()
        {
            Console.WriteLine($"Номер счета: {accountNumber}, Текущая сумма на счету: {accountSum}");
        }
    }
}
