using Task2;

Product[] productsArray = new Product[3];
productsArray[0] = new ProductChild("Шоколадка", 126, new DateTime(2023, 08, 15), new DateTime(2023, 12, 20));
productsArray[1] = new Consignment("Доширак", 345.50, new DateTime(2023, 03, 20), new DateTime(2023, 12, 08), 10);

ProductChild[] complectProducts = new ProductChild[3];
complectProducts[0] = new ProductChild("Шоколадка", 126, new DateTime(2023, 06, 11), new DateTime(2024, 05, 17));
complectProducts[1] = new ProductChild("Колбаса", 500, new DateTime(2023, 11, 30), new DateTime(2023, 12, 11));
complectProducts[2] = new ProductChild("Молоко", 80.32, new DateTime(2023, 12, 15), new DateTime(2023, 12, 20));

productsArray[2] = new Complect("Комлект 1", complectProducts);

//Вызов информации о товарах и поиск просроченного товара
foreach (var product in productsArray)
{
    product.GetProductInfo();
    product.CheckExpirationDate();
}