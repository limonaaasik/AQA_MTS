using NUnitTest.Core;
using OpenQA.Selenium;

namespace NUnitTest.Tests;

[TestFixture]
public class WebDriverTest
{
    [Test]
    public void FactoryDriverTest()
    {
        IWebDriver webDriver = new Browser().Driver!;
        webDriver.Navigate().GoToUrl("http://onliner.by");
        webDriver.Quit();
    } 
}