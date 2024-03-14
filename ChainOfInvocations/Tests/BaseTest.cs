using OpenQA.Selenium;
using ChainOfInvocations_HW.Core;
using ChainOfInvocations_HW.Helpers;
using ChainOfInvocations_HW.Helpers.Configuration;
using ChainOfInvocations_HW.Steps;

namespace ChainOfInvocations_HW.Tests;

//[Parallelizable(scope: ParallelScope.All)]
//[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected NavigationSteps _navigationSteps;
    
    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        _navigationSteps = new NavigationSteps(Driver);
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}