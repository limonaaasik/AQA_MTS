using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced_Homework.Tests
{
    public class ContextMenuTest : BaseTest
    {
        [Test]
        public void ClickContextMenuTest()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");

            var contextElement = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("hot-spot"));

            var actions = new Actions(Driver);

            actions.MoveToElement(contextElement, 30, 30).ContextClick().Build().Perform();

            IAlert alert = Driver.SwitchTo().Alert();

            Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));

            alert.Accept();

            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("a[target=_blank]")).Displayed);
        }
    }
}
