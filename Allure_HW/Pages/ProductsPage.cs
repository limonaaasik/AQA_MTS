using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure_HW.Pages
{
    public class ProductsPage : BasePage
    {
        private static string END_POINT = "inventory.html";

        // Описание элементов
        private static readonly By TitleLabelBy = By.ClassName("title");
        private readonly By ProductBackpackBy = By.ClassName("inventory_item_name");
        private readonly By AddToCartButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
        private readonly By RemoveToCartButtonBy = By.Id("remove-sauce-labs-backpack");
        private readonly By ShoppingCartBadgeBy = By.ClassName("shopping_cart_badge");
        private readonly By ShoppingCartLinkBy = By.ClassName("shopping_cart_link");

        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }

        // Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement BackpackLabel => WaitsHelper.WaitForExists(ProductBackpackBy);
        public IWebElement AddBackpackButton => WaitsHelper.WaitForExists(AddToCartButtonBy);
        public IWebElement RemoveBackpackButton => WaitsHelper.WaitForExists(RemoveToCartButtonBy);
        public IWebElement ShoppingCartLink => WaitsHelper.WaitForExists(ShoppingCartLinkBy);
        public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Products");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        [AllureStep ("Добавление товара в корзину")]
        public void AddProduct() => AddBackpackButton.Click();

        [AllureStep("Удаление товара из корзины")]
        public void RemoveProduct() => RemoveBackpackButton.Click();
    }
}
