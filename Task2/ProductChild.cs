namespace Task2
{
    internal class ProductChild : Product
    {
        public string name;
        public double price;
        public DateTime dateOfManufacture;  // дата производства
        public DateTime expirationDate; // дата срока годности
        private DateTime thisDay = DateTime.Today;  // текущий день
        public ProductChild(string name, double price, DateTime dateOfManufacture, DateTime expirationDate) 
        {
            this.name = name;
            this.price = price;
            this.dateOfManufacture = dateOfManufacture;
            this.expirationDate = expirationDate;
        }

        public override void GetProductInfo()
        {
            Console.WriteLine($"\nИнформация о товаре: ");
            Console.WriteLine($"Название товара: {name}, Стоимость товара: {price}, Дата производства: {dateOfManufacture}, Срок годности: {expirationDate}");
        }

        public override void CheckExpirationDate()
        {
            if ( thisDay < expirationDate ) 
            {
                Console.WriteLine($"\nТовар не просрочен. Срок годности до {expirationDate}");
            } 
            else if (thisDay >= expirationDate)
            {
                Console.WriteLine($"Товар не просрочен. Срок годности до {expirationDate}");
            }
        }
    }
}
