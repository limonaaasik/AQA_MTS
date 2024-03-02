using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure_HW.Pages
{
    public class CartPage : BasePage
    {
        private static string END_POINT = "cart.html";

        // Описание элементов
        private static readonly By TitleLabelBy = By.ClassName("title");
        private static readonly By ItemLabelBy = By.ClassName("inventory_item_name");
        private static readonly By RemoveButtonBy = By.Id("remove-sauce-labs-backpack");
        private static readonly By ShoppingCartBadgeBy = By.ClassName("shopping_cart_badge");
        private static readonly By CheckoutButtonBy = By.Id("checkout");
        private static readonly By ContinueShoppingButtonBy = By.Id("continue-shopping");

        // Инициализация класса + переопределение
        public CartPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Your Cart");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        // Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement ItemLabel => WaitsHelper.WaitForExists(ItemLabelBy);
        public bool ItemLabelInvisibility => WaitsHelper.WaitForElementInvisible(ItemLabelBy);
        public bool ShoppingCartBadgeInvisibility => WaitsHelper.WaitForElementInvisible(ShoppingCartBadgeBy);
        public IWebElement RemoveButton => WaitsHelper.WaitForExists(RemoveButtonBy);
        public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
        public IWebElement ContinueShoppingButton => WaitsHelper.WaitForExists(ContinueShoppingButtonBy);

        [AllureStep("Нажать на кнопку Remove в корзине")]
        public void ClickRemovebutton() => RemoveButton.Click();

        [AllureStep("Нажать на кнопку Checkout в корзине")]
        public void ClickCheckoutButtonn() => CheckoutButton.Click();

        [AllureStep("Нажать на кнопку ContinueShopping в корзине")]
        public void ClickContinueShoppingButton() => ContinueShoppingButton.Click();
    }
}
