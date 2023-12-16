namespace Task2
{
    internal class Consignment : ProductChild
    {
        private int count;

        public Consignment(string name, double price, DateTime dateOfManufacture, DateTime expirationDate, int count) : base(name, price, dateOfManufacture, expirationDate)
        {
            this.count = count;
        }

        public override void GetProductInfo()
        {
            Console.WriteLine($"\nИнформация о партии: ");
            Console.WriteLine($"Название товара: {name}, Стоимость партии: {price * count}, Количество шт: {count} Дата производства: {dateOfManufacture}, Срок годности: {expirationDate}"); 
        }
    }
}
