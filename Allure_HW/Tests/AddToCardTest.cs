using Allure.Net.Commons;
using Allure_HW.Helpers.Configuration;
using Allure_HW.Pages;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure_HW.Tests
{
    [AllureSuite("Тесты на проверку возможностей работы с заказом")]
    [AllureOwner("Makusheva Ksenya")]
    public class AddToCardTest : BaseTest
    {
        [Test]
        [AllureSeverity(SeverityLevel.critical)]
        [Description("Проверка добавления товара в корзину")]
        public void AddProductToCart()
        {
            new LoginPage(Driver).SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            
            ProductsPage productsPage = new ProductsPage(Driver);
            productsPage.AddProduct();

            Assert.Multiple(() =>
            {
                Assert.That(productsPage.ShoppingCartBadge.Text, Is.EqualTo("1"));
                Assert.That(productsPage.RemoveBackpackButton.Displayed);
            });

            CartPage cartPage = new CartPage(Driver, true);
            Assert.That(cartPage.IsPageOpened());
            Assert.That(cartPage.ItemLabel.Text, Is.EqualTo("Sauce Labs Backpack"));
        }
    }
}
