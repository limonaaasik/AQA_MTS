using OpenQA.Selenium;

namespace ValueOfObjects.Elements
{
    public class Checkbox
    {
        private UIElement _uiElement;

        public Checkbox(IWebDriver webDriver, By by)
        {
            _uiElement = new UIElement(webDriver, by);
        }

        public Checkbox(IWebDriver webDriver, IWebElement webElement)
        {
            _uiElement = new UIElement(webDriver, webElement);
        }
        public void Click() => _uiElement.Click();

        // выбран ли чекбокс
        public bool IsSelected => _uiElement.Selected;
        public bool Displayed => _uiElement.Displayed;

        // можно ли нажать на чекбокс
        public bool Enabled => _uiElement.Enabled;

        // кликнуть по чекбоксу, если он не выбран
        public void SetFlag(bool value)
        {
            if (IsSelected != value)
            {
                Click();
            }
        }
    }
}
