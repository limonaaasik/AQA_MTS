using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure_HW.Pages
{
    public class FirstCheckOutPage : BasePage
    {
        private static string END_POINT = "checkout-step-one.html";

        // Описание элементов
        private static readonly By TitleLabelBy = By.ClassName("title");
        private static readonly By FirstNameInputBy = By.Id("first-name");
        private static readonly By LastNameInputBy = By.Id("last-name");
        private static readonly By PostalCodeInputBy = By.Id("postal-code");
        private static readonly By ContinueButtonBy = By.Id("continue");
        private static readonly By CancelButtonBy = By.Id("cancel");

        // Инициализация класса + переопределение
        public FirstCheckOutPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Your Information");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        // Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement FirstNameInput => WaitsHelper.WaitForExists(FirstNameInputBy);
        public IWebElement LastNameInput => WaitsHelper.WaitForExists(LastNameInputBy);
        public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(PostalCodeInputBy);
        public IWebElement ContinueButton => WaitsHelper.WaitForExists(ContinueButtonBy);
        public IWebElement CancelButton => WaitsHelper.WaitForExists(CancelButtonBy);

        // Комплексные методы
        [AllureStep("Заполнение информации для заказа")]
        public SecondCheckOutPage ContinueProductToPageTwo()
        {
            FirstNameInput.SendKeys("Ksenya");
            LastNameInput.SendKeys("Makusheva");
            PostalCodeInput.SendKeys("365448");
            ContinueButton.Click();
            return new SecondCheckOutPage(Driver);
        }
    }
}
