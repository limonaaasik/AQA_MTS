using Task2;

Console.WriteLine("Для добавления товара напишите \"добавить\"\n" +
    "Для отображения списка товаров напишите \"показать\"\n" +
    "Для поиска товара по ID напишите \"поиск\"\n" +
    "Для обновления стоимости или количества напишите \"обновить\"\n" +
    "Для удаления товара напишите \"удалить\"\n" +
    "Для выхода из программы напишите \"выход\"\n\n" +
    "Введите команду:");
Shop shop = new Shop();

string command;
while ((command = Console.ReadLine().ToLower()) != "выход") //ToLower - приводит к нижнему регистру
{
    switch (command)
    {
        case "добавить":
            {
                ulong id;
                Console.WriteLine("Введите ID товара (число больше 0):");
                if (ulong.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Введите название товара:");
                }
                else
                {
                    Console.WriteLine("Введен неверный ID.");
                    break;
                }
                string name = Console.ReadLine();
                double cost;
                Console.WriteLine("Введите стоимость товара:");
                if (double.TryParse(Console.ReadLine(), out cost))
                {
                    Console.WriteLine("Введите количество товара на складе:");
                }
                else
                {
                    Console.WriteLine("Введен неверный формат стоимости.");
                    break;
                }
                int quantity;
                if (int.TryParse(Console.ReadLine(), out quantity))
                {
                    Product product = new Product(id, name, cost, quantity);
                    shop.AddProduct(product);
                    break;
                }
                break;
            }

        case "показать":
            shop.ShowProducts();
            break;

        case "поиск":
            {
                Console.WriteLine("Введите ID товара:");
                ulong id;
                if (ulong.TryParse(Console.ReadLine(), out id))
                {
                    shop.ShowProductById(id);
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неверный ID.");
                    break;
                }

            }

        case "обновить":
            {
                Console.WriteLine("Введите ID товара:");
                ulong id;
                if (ulong.TryParse(Console.ReadLine(), out id))
                {
                    shop.UpdateProduct(id);
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неверный ID.");
                    break;
                }
            }

        case "удалить":
            {
                Console.WriteLine("Введите ID товара:");
                ulong id;
                if (ulong.TryParse(Console.ReadLine(), out id))
                {
                    shop.RemoveProduct(id);
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неверный ID.");
                    break;
                }
            }
    }
    Console.WriteLine("Введите команду:");
}
Console.WriteLine("Вы вышли из программы.");