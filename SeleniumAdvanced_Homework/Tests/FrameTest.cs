using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced_Homework.Tests
{
    public class FrameTest : BaseTest
    {
        [Test]
        public void FrameCheckText()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/frames");

            // Ищу ссылку iFrame и кликаю по ней
            var link = WaitsHelper.WaitForVisibilityLocatedBy(By.LinkText("iFrame"));
            link.Click();

            // Переключаюсь на фрэйм
            Driver.SwitchTo().Frame(Driver.FindElement(By.Id("mce_0_ifr")));

            // Проверяю, что на открытой странице, текст соответствует "Your content goes here."
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.TagName("p")).Text, Is.EqualTo("Your content goes here."));
        }
    }
}
