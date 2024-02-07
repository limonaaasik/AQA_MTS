using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTest.Tests;

public class LaminateTest : BaseTest
{
    [Test]
    public void CalcLaminateTest()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        IWebElement roomLength = Driver.FindElement(By.Id("ln_room_id"));
        roomLength.Clear();
        roomLength.SendKeys("500");

        IWebElement roomWidth = Driver.FindElement(By.Id("wd_room_id"));
        roomWidth.Clear();
        roomWidth.SendKeys("400");

        IWebElement plashkaLength = Driver.FindElement(By.Id("ln_lam_id"));
        plashkaLength.Clear();
        plashkaLength.SendKeys("1200");

        IWebElement plashkaWidth = Driver.FindElement(By.Id("wd_lam_id"));
        plashkaWidth.Clear();
        plashkaWidth.SendKeys("250");

        IWebElement plashkaCount = Driver.FindElement(By.Id("n_packing"));
        plashkaCount.Clear();
        plashkaCount.SendKeys("100");

        IWebElement packingArea = Driver.FindElement(By.Id("area"));
        packingArea.Clear();
        packingArea.SendKeys("3");

        IWebElement direction = Driver.FindElement(By.Id("direction-laminate-id0"));
        direction.Click();

        SelectElement installationMethod = new SelectElement(Driver.FindElement(By.Id("laying_method_laminate")));
        installationMethod.SelectByValue("2");

        ////// Поля, в которых числа считываются как символы/буквы. Закомментировала.
        IWebElement minCuttingLength = Driver.FindElement(By.Id("min_length_segment_id"));
        minCuttingLength.SendKeys(Keys.Control + "a");
        minCuttingLength.SendKeys(Keys.Delete);
        minCuttingLength.SendKeys("270");


        IWebElement indent = Driver.FindElement(By.Id("indent_walls_id"));
        indent.SendKeys(Keys.Control + "a");
        indent.SendKeys(Keys.Delete);
        indent.SendKeys("12");

        Driver.FindElement(By.Id("btn_calculate")).Click();
        
        Thread.Sleep(10000);

        IWebElement result1 = Driver.FindElement(By.XPath("//*[contains(text(),'Требуемое количество плашек ламината')]//descendant::span"));
        Assert.That(result1.Text, Is.EqualTo("72"));

        IWebElement result2 = Driver.FindElement(By.XPath("//*[contains(text(),'Количество упаковок ламината')]//descendant::span"));
        Assert.That(result2.Text, Is.EqualTo("1"));

        IWebElement result3 = Driver.FindElement(By.XPath("//*[contains(text(),'Стоимость ламината')]//descendant::span"));
        Assert.That(result3.Text, Is.EqualTo("0 руб"));

        IWebElement result4 = Driver.FindElement(By.XPath("//*[contains(text(),'Вес ламината')]//descendant::span"));
        Assert.That(result4.Text, Is.EqualTo("0 кг"));
    }

}