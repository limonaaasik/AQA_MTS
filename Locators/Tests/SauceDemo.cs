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

            //XPath
            Assert.That(Driver.FindElement(By.XPath("//div/input[@placeholder='Password']")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[text()='secret_sauce']")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[contains(@data-test,'pass')]")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[contains(text(),'standard_')]")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@placeholder='Password']/ancestor::div")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@class='login-box']/descendant::div")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@class='login_credentials']//following::div")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@id='root']/parent::*")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//*[@id='login_button_container']//preceding::div")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//input[@placeholder='Username' and @type='text']")).Displayed);

            // CSS Selector
            Assert.That(Driver.FindElement(By.CssSelector(".form_column")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector(".submit-button.btn_action")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector(".login-box .input_error")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("#login_button_container")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("h4")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("div.login_password")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[placeholder='Username']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("input[name~='user-name']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[class|='login']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[autocorrect^='of']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[autocorrect$='ff']")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[class*=_]")).Displayed);

            //Basic
            Assert.That(Driver.FindElement(By.Id("user-name")).Displayed);
            Assert.That(Driver.FindElement(By.Name("user-name")).Displayed);
            Assert.That(Driver.FindElement(By.ClassName("form_column")).Displayed);
            Assert.That(Driver.FindElement(By.TagName("input")).Displayed);

            Driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            Driver.FindElement(By.Id("login-button")).Click();

            Assert.That(Driver.FindElement(By.LinkText("Sauce Labs Bike Light")).Displayed);
            Assert.That(Driver.FindElement(By.PartialLinkText("Bike Light")).Displayed);
        }
    }
}
