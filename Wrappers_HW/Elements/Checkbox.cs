using OpenQA.Selenium;

namespace Wrappers_HW.Elements;

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

    // ������ �� �������
    public bool IsSelected => _uiElement.Selected;
    public bool Displayed => _uiElement.Displayed;

    // ����� �� ������ �� �������
    public bool Enabled => _uiElement.Enabled;

    // �������� �� ��������, ���� �� �� ������
    public void SetFlag(bool value)
    {
        if (IsSelected != value)
        {
            Click();
        }
    }
}