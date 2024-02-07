using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests
{
    public class SauceDemo : BaseTest
    {
        [Test]
        public void LocatorsTest()
        {
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            // Basic
            Assert.That(Driver.FindElement(By.Id("user-name")).Displayed);
            Assert.That(Driver.FindElement(By.Name("user-name")).Displayed);
            Assert.That(Driver.FindElement(By.ClassName("form_column")).Displayed);
            Assert.That(Driver.FindElement(By.TagName("input")).Displayed);

        }
    }
}
