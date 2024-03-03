using Allure_HW.Pages;
using Allure_HW.Helpers.Configuration;
using Allure_HW.Pages;
using NUnit.Allure.Attributes;
using Allure.Net.Commons;

namespace Allure_HW.Tests;

[AllureSuite("Тесты на проверку регистрации пользователя")]
[AllureOwner("Makusheva Ksenya")]
public class LoginTest : BaseTest
{
    [Test]
    [AllureSeverity(SeverityLevel.critical)]
    [Description("Проверка успешного входа в систему")]
    public void SuccessfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        ProductsPage productsPage = new ProductsPage(Driver);
        
        Assert.That(productsPage.IsPageOpened);
    }
    
    [Test]
    [AllureSeverity(SeverityLevel.critical)]
    [Description("Проверка неуспешного входа в систему")]
    public void InvalidUsernameLoginTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("ssdd", "")
                .ErrorLabel.Text.Trim(), 
            Is.EqualTo("Epic sadface: Password is required"));
    }

    // Специально допустаила ошибку в логине юзера, чтобы проверить наличие скриншота при падении теста
    [Test]
    [AllureSeverity(SeverityLevel.minor)]
    [Description("Проверка логина заблокированного пользователя")]
    public void LockedUserLogin()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("locked_out_userR", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
}