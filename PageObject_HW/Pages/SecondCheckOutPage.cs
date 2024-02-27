using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject_HW.Pages
{
    public class SecondCheckOutPage : BasePage
    {
        private static string END_POINT = "checkout-step-two.html";

        // Описание элементов
        private static readonly By TitleLabelBy = By.ClassName("title");
        private readonly By ProductBackpackBy = By.ClassName("inventory_item_name");
        private readonly By SummaryTotalLabelBy = By.CssSelector("[class~='summary_total_label']");
        private readonly By FinishButtonBy = By.Id("finish");

        // Инициализация класса + переопределение
        public SecondCheckOutPage(IWebDriver driver, bool openPageByUrl = false) : base(driver, openPageByUrl)
        {
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Overview");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        // Методы
        public IWebElement TitleLabel => WaitsHelper.WaitForExists(TitleLabelBy);
        public IWebElement ProductBackpack => WaitsHelper.WaitForExists(ProductBackpackBy);
        public IWebElement SummaryTotalLabel => WaitsHelper.WaitForExists(SummaryTotalLabelBy);
        public IWebElement FinishButton => WaitsHelper.WaitForExists(FinishButtonBy);
        public bool FinishButtonVisible => WaitsHelper.WaitForVisibility(FinishButton);

        public void ClickFinishButton() => FinishButton.Click();
    }
}
