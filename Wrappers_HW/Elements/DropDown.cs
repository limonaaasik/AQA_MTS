using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrappers_HW.Elements
{
    public class DropDown
    {
        private UIElement _uiElement;
        private By _locatorDropDownOptions = By.CssSelector(".chzn-results>li"); //поиск дочернего li с родителем chzn-results
        private List<UIElement> _items;

        public DropDown(IWebDriver webDriver, By by)
        {
            _uiElement = new UIElement(webDriver, by);
            _items = _uiElement.FindUIElements(_locatorDropDownOptions);
        }

        public DropDown(IWebDriver webDriver, IWebElement webElement)
        {
            _uiElement = new UIElement(webDriver, webElement);
        }

        public bool Displayed => _uiElement.Displayed;
        public bool Selected => _uiElement.Selected;

        public void SelectByText(string text)
        {
            foreach (UIElement element in _items)
            {
                if (element.Text.Trim() == text)
                    _uiElement.Click(); // кликнуть по самому дропдауну
                    element.Click();    // кликнуть по выбранному значению в дропдауне
            }
        }

        public void SelectByValue(string value)
        {
            
        }

        public void SelectByIndex (int index)
        {
            if (index < _items.Count)
                _uiElement.Click();
                _items[index].Click();

        }

        public string SelectedText()
        {
            return _uiElement.FindUIElement(By.ClassName("result-selected")).Text;
        }
    }
}
