using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers_HW.Pages;

namespace Wrappers_HW.Steps;

public class UserSteps : BaseSteps
{
    private LoginPage _loginPage;
    
    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }

    // Комплексные
    [AllureStep]
    public DashboardPage SuccessfulLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.ClickLoginInButton();

        return new DashboardPage(Driver);
    }
    
    public LoginPage IncorrectLogin(string username, string password)
    {
        _loginPage.EmailInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return _loginPage;
    }
}