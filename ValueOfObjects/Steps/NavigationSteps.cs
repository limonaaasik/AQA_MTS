using OpenQA.Selenium;
using ChainOfInvocations_HW.Models;
using ChainOfInvocations_HW.Pages;
using ChainOfInvocations_HW.Pages.ProjectPages;

namespace ChainOfInvocations_HW.Steps;

public class NavigationSteps : BaseStep
{
    public NavigationSteps(IWebDriver driver) : base(driver) { }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver);
    }

    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage(Driver, true);
    }
    
    public AddProjectPage NavigateToAddProjectPage()
    {
        return new AddProjectPage(Driver, true);
    }
    
    public DashboardPage SuccessfulLogin(User user)
    {
        return Login<DashboardPage>(user);
    }

    public LoginPage IncorrectLogin(User user)
    {
        return Login<LoginPage>(user);
    }
    
    public T Login<T>(User user) where T : BasePage
    {
        LoginPage = new LoginPage(Driver);
        
        LoginPage.EmailInput.SendKeys(user.Email);
        LoginPage.PswInput.SendKeys(user.Password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}