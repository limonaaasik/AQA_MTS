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
        plashkaLength.SendKeys("12500");

        IWebElement plashkaWidth = Driver.FindElement(By.Id("wd_lam_id"));
        plashkaWidth.Clear();
        plashkaWidth.SendKeys("250");

        IWebElement plashkaCount = Driver.FindElement(By.Id("n_packing"));
        plashkaLength.Clear();
        plashkaLength.SendKeys("100");

        IWebElement packingArea = Driver.FindElement(By.Id("area"));
        packingArea.Clear();
        packingArea.SendKeys("3");

        SelectElement direction = new SelectElement(Driver.FindElement(By.Id("#direction-laminate-id0")));
        direction.SelectByValue("0");

        SelectElement installationMethod = new SelectElement(Driver.FindElement(By.Id("#laying_method_laminate")));
        installationMethod.SelectByValue("2");

        IWebElement minCuttingLength = Driver.FindElement(By.Id("min_length_segment_id"));
        plashkaWidth.Clear();
        plashkaWidth.SendKeys("120");

        IWebElement indent = Driver.FindElement(By.Id("indent_walls_id"));
        plashkaWidth.Clear();
        plashkaWidth.SendKeys("12");

        Driver.FindElement(By.Id("btn_calculate")).Click();
        
        Thread.Sleep(2000);
    }
    
}