using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task2
{
    public class Shop
    {
        Dictionary<ulong, Product> shopList = new Dictionary<ulong, Product>()
        {
            {5485, new Product(5485, "телик", 1354.58, 60) },
            {1235, new Product(1235, "велик", 34568.66, 10) },
            {398, new Product(398, "моник", 9857, 250) }
        };

        public void AddProduct(Product product)
        {
            shopList.Add(product.id, product);
            Console.WriteLine("Товар добавлен.");
        }

        public void ShowProducts()
        {
            Console.WriteLine($"Продукты:");
            foreach (var pair in shopList)
            {
                var item = pair.Value;
                item.ShowInfo();
            }
        }

        public void ShowProductById(ulong id)
        {
            Product product;
            if (shopList.TryGetValue(id, out product))
            {
                Console.WriteLine($"Информация о товаре с ID: {id}");
                product.ShowInfo();
            }
            else
            {
                Console.WriteLine("Не найдено товаров по данному ID.");
            }
        }

        public void RemoveProduct(ulong id)
        {
            if (shopList.ContainsKey(id))
            {
                shopList.Remove(id);
                Console.WriteLine("Товар удалён.");
            }
            else
            {
                Console.WriteLine($"Товар с ID {id} не найден.");
            }
        }

        public void UpdateProduct(ulong id)
        {
            Product product;
            if (shopList.TryGetValue(id, out product))
            {
                Console.WriteLine("Что необходимо обновить: стоимость или количество товара?");
                Console.WriteLine("Введите команду \"стоимость\" или \"количество\"");
                string command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "стоимость":
                        Console.WriteLine("Введите новую стоимость товара:");
                        double newPrice;
                        if (double.TryParse(Console.ReadLine(), out newPrice))
                        {
                            product.cost = newPrice;
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат стоимости");
                        }
                        break;

                    case "количество":
                        Console.WriteLine("Введите новое количетсво товара:");
                        int newQuantity;
                        if (int.TryParse(Console.ReadLine(), out newQuantity))
                        {
                            product.quantity = newQuantity;
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат количества товаров");
                        }
                        break;

                    default: Console.WriteLine("Неверно указана команда.");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"Товар с ID {id} не найден.");
            }
        }

    }
}
