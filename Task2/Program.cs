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
                ulong.TryParse(Console.ReadLine(), out id);
                Console.WriteLine("Введите название товара:");
                string name = Console.ReadLine();
                double cost;
                Console.WriteLine("Введите стоимость товара:");
                double.TryParse(Console.ReadLine(), out cost);
                int quantity;
                Console.WriteLine("Введите количество товара на складе:");
                int.TryParse(Console.ReadLine(), out quantity);

                Product product = new Product(id, name, cost, quantity);
                shop.AddProduct(product);
                break;
            }

        case "показать":
            shop.ShowProducts();
            break;

        case "поиск":
            {
                Console.WriteLine("Введите ID товара:");
                ulong id;
                ulong.TryParse(Console.ReadLine(), out id);
                shop.ShowProductById(id);
                break;
            }

        case "обновить":
            {
                Console.WriteLine("Введите ID товара:");
                ulong id;
                ulong.TryParse(Console.ReadLine(), out id);
                shop.UpdateProduct(id);
                break;
            }

        case "удалить":
            {
                Console.WriteLine("Введите ID товара:");
                ulong id;
                ulong.TryParse(Console.ReadLine(), out id);
                shop.RemoveProduct(id);
                break;
            }
    }
    Console.WriteLine("Введите команду:");
}
Console.WriteLine("Вы вышли из программы.");