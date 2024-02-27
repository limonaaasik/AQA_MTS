using PageObject_HW.Helpers.Configuration;
using PageObject_HW.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject_HW.Tests
{
    public class PaymentTest : BaseTest
    {
        [Test]
        [Description("Проверка оплаты товара")]
        public void CheckPaymentTest()
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
            cartPage.ClickCheckoutButtonn();

            FirstCheckOutPage firstCheckOutPage = new FirstCheckOutPage(Driver);
            firstCheckOutPage.IsPageOpened();
            firstCheckOutPage.ContinueProductToPageTwo();

            SecondCheckOutPage secondCheckOutPage = new SecondCheckOutPage(Driver);
            secondCheckOutPage.IsPageOpened();
            Assert.That(secondCheckOutPage.ProductBackpack.Text.Trim(), Is.EqualTo("Sauce Labs Backpack"));
            Assert.That(secondCheckOutPage.SummaryTotalLabel.Text.Trim(), Is.EqualTo("Total: $32.39"));
            Assert.That(secondCheckOutPage.FinishButtonVisible, Is.EqualTo(true));
            secondCheckOutPage.ClickFinishButton();

            FinishCheckOutPage finishPage = new FinishCheckOutPage(Driver);
            Assert.That(finishPage.IsPageOpened);
            Assert.That(finishPage.ComleteLabel.Text.Trim(), Is.EqualTo("Thank you for your order!"));
            
            finishPage.ClickBackHomeButton();
            Assert.That(productsPage.IsPageOpened);
        }
    }
}
