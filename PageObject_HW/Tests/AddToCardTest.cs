using PageObject_HW.Helpers.Configuration;
using PageObject_HW.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject_HW.Tests
{
    public class AddToCardTest : BaseTest
    {
        [Test]
        [Description("Проверка успешного входа в систему")]
        public void SuccessfulLoginTest()
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
