namespace Task2
{
    internal class Complect : Product
    {
        public string nameComplect;
        public ProductChild[] listProducts = new ProductChild[6];

        public Complect(string nameComplect, ProductChild[] listProducts)
        {
            this.nameComplect = nameComplect;
            this.listProducts = listProducts;
        }

        // Метод для вывода перечн продуктов
        private void PrintListProducts()
        {
            foreach (var item in listProducts)
            {
                Console.WriteLine(item.name);
            }
        }

        // Метод для подсчета стоимости комплектов
        // Тянет стоимость продуктов из массива
        private double GetPriceComplect() 
        {
            double priceComplect = 0;
            foreach (ProductChild product in listProducts)
            {
                priceComplect = priceComplect + product.price;
            }
            return priceComplect;
        }

        public override void CheckExpirationDate()
        {
            foreach (ProductChild product in listProducts)
            {
                if (product.expirationDate <= DateTime.Today)
                {
                    Console.WriteLine($"В комплекте просроченный товар: {product.name}.");
                    return;
                }
            }
            Console.WriteLine("Просроченного товара в комплекте нет.");
        }

        public override void GetProductInfo()
        {
            Console.WriteLine($"Информация о комлекте: ");
            Console.WriteLine($"Название комлекта: {nameComplect}, Стоимость комплекта: {GetPriceComplect()}, Перечень продуктов: ");
            PrintListProducts();
        }
    }
}
