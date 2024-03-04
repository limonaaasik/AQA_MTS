using OpenQA.Selenium;

namespace Wrappers_HW.Steps;

public class BaseSteps
{
    protected IWebDriver Driver;

    public BaseSteps(IWebDriver driver)
    {
        Driver = driver;
    }
}