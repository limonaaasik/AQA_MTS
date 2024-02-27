using OpenQA.Selenium;

namespace PageObject_HW.Pages;

public abstract class ProjectBasePage : BasePage
{
    private static readonly By NameInputBy = By.Id("name");
    
    public ProjectBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }
    
    // Атомарные Методы
    public IWebElement NameInput => WaitsHelper.WaitForExists(NameInputBy);
}