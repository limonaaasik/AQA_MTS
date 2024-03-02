using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure_HW.Pages
{
    public class FinishCheckOutPage : BasePage
    {
        private static string END_POINT = "checkout-complete.html";

        // Описание элементов
        private static readonly By TitleLabelBy = By.ClassName("title");
        private readonly By ComleteLabelBy = By.ClassName("complete-header");
        private readonly By BackHomeButtonBy = By.Id("back-to-products");

        // Инициализация класса + переопределение
        public FinishCheckOutPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Complete!");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        // Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement ComleteLabel => WaitsHelper.WaitForExists(ComleteLabelBy);
        public IWebElement BackHomeButton => WaitsHelper.WaitForExists(BackHomeButtonBy);
        public bool BackHomeButtonVisible => WaitsHelper.WaitForVisibility(BackHomeButton);

        [AllureStep("Нажатие на кнопку Back Home после завершения оформления заказа")]
        public void ClickBackHomeButton()
        {
            BackHomeButton.Click();
        }
    }
}
