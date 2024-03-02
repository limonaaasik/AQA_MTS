using Allure_HW.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure_HW.Steps
{
    internal class LoginSteps : BaseSteps
    {
        public LoginSteps(IWebDriver driver) : base(driver)
        {
        }

        public ProductsPage SuccessfulLogin(string username, string password)
        {
            Login(username, password);
            return ProductsPage;
        }
    }
}
