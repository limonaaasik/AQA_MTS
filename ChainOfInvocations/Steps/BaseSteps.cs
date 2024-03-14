using OpenQA.Selenium;
using ChainOfInvocations_HW.Pages;
using ChainOfInvocations_HW.Pages.ProjectPages;

namespace ChainOfInvocations_HW.Steps;

public class BaseSteps(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;
    
    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}