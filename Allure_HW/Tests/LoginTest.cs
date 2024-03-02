using Allure_HW.Pages;
using Allure_HW.Helpers.Configuration;
using Allure_HW.Pages;

namespace Allure_HW.Tests;

public class LoginTest : BaseTest
{
    [Test]
    [Description("Проверка успешного входа в систему")]
    public void SuccessfulLoginTest()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        ProductsPage productsPage = new ProductsPage(Driver);
        
        // Проверка 
        Assert.That(productsPage.IsPageOpened);
    }
    
    [Test]
    [Description("Проверка неуспешного входа в систему")]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "")
                .ErrorLabel.Text.Trim(), 
            Is.EqualTo("Epic sadface: Password is required"));
    }

    [Test]
    [Description("Проверка логина заблокированного пользователя")]
    public void LockedUserLogin()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
}