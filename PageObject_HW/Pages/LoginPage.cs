using OpenQA.Selenium;
using Allure_HW.Pages;

namespace Allure_HW.Pages
{
    public class LoginPage : BasePage
    {
        private static string END_POINT = "";
        
        // Описание элементов
        private static readonly By EmailInputBy = By.Id("user-name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By LoginInButtonBy = By.Id("login-button");
        private static readonly By ErrorLabelBy = By.XPath("//h3[@data-test='error']");

        // Инициализация класса + переопределение
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && EmailInput.Displayed;
        }

        // Методы
        public IWebElement EmailInput => WaitsHelper.WaitForExists(EmailInputBy);  
        public IWebElement ErrorLabel => WaitsHelper.WaitForExists(ErrorLabelBy);  
        public IWebElement PswInput => WaitsHelper.WaitForExists(PswInputBy);
        public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);

        // Комплексные методы
        public ProductsPage SuccessFulLogin(string username, string password)
        {
            EmailInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return new ProductsPage(Driver);
        }

        public LoginPage IncorrectLogin(string username, string password)
        {
            EmailInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return this;
        }
    }
}