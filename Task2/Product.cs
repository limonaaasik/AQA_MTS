using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Product
    {
        public ulong id;
        public string name;
        public double cost;
        public int quantity;

        public Product(ulong id, string name, double cost, int quantity)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.quantity = quantity;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Идентификатор товара: {id}, Название товара: {name}, Цена товара: {cost}, Количетво на складе: {quantity}");
        }

    }
}
