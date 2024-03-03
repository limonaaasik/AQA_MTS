using OpenQA.Selenium;
using Allure_HW.Core;
using Allure_HW.Helpers;
using Allure_HW.Helpers.Configuration;
using NUnit.Allure.Core;
using Allure.Net.Commons;

namespace Allure_HW.Tests;
[AllureNUnit]
[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    
    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
            byte[] scrBytes = screenshot.AsByteArray;

            AllureApi.AddAttachment("errorScreenShot", "image/png", scrBytes);
        }
        Driver.Quit();
    }
}