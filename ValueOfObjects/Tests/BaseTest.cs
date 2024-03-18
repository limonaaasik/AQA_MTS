using OpenQA.Selenium;
using ChainOfInvocations_HW.Core;
using ChainOfInvocations_HW.Helpers.Configuration;
using ChainOfInvocations_HW.Models;
using ChainOfInvocations_HW.Steps;

namespace ChainOfInvocations_HW.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectSteps _projectSteps;

    protected User Admin { get; private set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;

        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);

        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}