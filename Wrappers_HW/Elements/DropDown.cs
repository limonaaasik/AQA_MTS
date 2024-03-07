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

        public DropDown(IWebDriver webDriver, By by)
        {
            _uiElement = new UIElement(webDriver, by);
        }

        public DropDown(IWebDriver webDriver, IWebElement webElement)
        {
            _uiElement = new UIElement(webDriver, webElement);
        }

        public bool Displayed => _uiElement.Displayed;
        public bool Selected => _uiElement.Selected;

        public void SelectByText(string text)
        {
            
        }

        public void SelectByValue(string value)
        {
            
        }

        public string SelectedText()
        {
            
        }
    }
}
