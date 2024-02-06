using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest.Tests;

public class FirstTest : BaseTest
{    
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        // Thread.Sleep(3000); // выскакивает реклама, надо подтвердить ручками и продолжить работу
        Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@src]")));

        IWebElement ageInput = Driver.FindElement(By.Id("age"));
        ageInput.SendKeys("25");

        SelectElement selectSex = new SelectElement(Driver.FindElement(By.Id("sex")));
        selectSex.SelectByText("Женский");

        IWebElement creatinineInput = Driver.FindElement(By.Id("cr"));
        creatinineInput.SendKeys("125.6");

        SelectElement selectCreatinin = new SelectElement(Driver.FindElement(By.Id("cr-size")));
        selectCreatinin.SelectByText("ммоль/л");

        SelectElement selectRace = new SelectElement(Driver.FindElement(By.Id("race")));
        selectRace.SelectByValue("N");

        IWebElement massInput = Driver.FindElement(By.Id("mass"));
        massInput.SendKeys("62");

        IWebElement growInput = Driver.FindElement(By.Id("grow"));
        growInput.SendKeys("175");

        IWebElement button = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));
        button.Click();

        Thread.Sleep(3000);

        IWebElement resultMDRD = Driver.FindElement(By.Id("mdrd_res"));
        Assert.That(resultMDRD.Text, Is.EqualTo("0.02"));

        IWebElement resultMDRDUnits = Driver.FindElement(By.TagName("i"));
        Assert.That(resultMDRDUnits.Text, Is.EqualTo("мл/мин/1.73м2"));

        IWebElement resultDiagnosis = Driver.FindElement(By.ClassName("diagnosis"));
        Assert.That(resultDiagnosis.Text, Is.EqualTo("Терминальная почечная недостаточность (C5)"));

        IWebElement resultCKDEPI = Driver.FindElement(By.Id("ckd_epi_res"));
        Assert.That(resultCKDEPI.Text, Is.EqualTo("0.01"));

        IWebElement resultKokroft = Driver.FindElement(By.Id("cge_res"));
        Assert.That(resultKokroft.Text, Is.EqualTo("0.06"));

        IWebElement resultKokroftUnits = Driver.FindElement(By.CssSelector("#cge i"));
        Assert.That(resultKokroftUnits.Text, Is.EqualTo("мл/мин"));

        Thread.Sleep(5000);


    }
}