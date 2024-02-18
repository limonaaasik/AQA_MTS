using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced_Homework.Tests
{
    public class DynamicControlsTest : BaseTest
    {
        [Test]
        public void DynamicControls()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");

            // Нахожу чекбокс
            var checkbox = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type='checkbox']"));
            // Ищу поля ввода
            var inputField = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("input[type= 'text']"));
            // Ищу кнопку Enabled
            var buttonEnable = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("button[onclick='swapInput()']"));
            
            // Ищу кнопку Remove, кликаю по кнопке
            var buttonRemove = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("button[onclick='swapCheckbox()']"));
            buttonRemove.Click();

            // Проверяю, что элемент "It's gone!" отобразилсяи и корректен
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));

            // Проверяю, что чекбокса нет
            Assert.That(WaitsHelper.WaitForElementInvisible(checkbox));

            // Проверяю, что поле ввода disabled
            Assert.That(!inputField.Enabled);

            // Кликаю по кнопке Enabled
            buttonEnable.Click();

            // Проверяю, что элемент "It's enabled!" отобразилсяи и корректен
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));

            // Проверяю, что поле Enabled
            Assert.That(inputField.Enabled);
        }

    }
}
