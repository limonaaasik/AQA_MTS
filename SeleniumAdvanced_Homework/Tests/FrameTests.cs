using SeleniumAdvanced_Homework.Helpers;
using SeleniumAdvanced_Homework.Tests;
using OpenQA.Selenium;

namespace SeleniumAdvanced_Homework.Tests;

public class FrameTests : BaseTest
{
    [Test]
    public void FrameTest()
    {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/iframe");

        Driver.SwitchTo().Frame(Driver.FindElement(By.Id("mce_0_ifr")));
        //Driver.SwitchTo().Frame(0);
        //Driver.SwitchTo().Frame("mce_0_ifr"); // �������� �� id ��� name �������� 
        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("tinymce")).Displayed);

        Driver.SwitchTo().ParentFrame(); // ������� � ������������ ����� �� 1 ������� ����
        Driver.SwitchTo().DefaultContent(); // ������� � ������������ �������� �� ����� ������ �������

        Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.ClassName("tox-editor-container")).Displayed);
    }
}