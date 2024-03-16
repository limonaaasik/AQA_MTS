using OpenQA.Selenium;
using ValueOfObjects.Elements;
using Wrappers.Elements;

namespace ValueOfObjects.Pages.ProjectPages;

public class ProjectsPage(IWebDriver? driver, bool openByURL) : BasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/overview";
        
    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[contains(@class, 'page_title') and contains(text(), 'Projects')]");
    private static readonly By SuccessMessageBy = By.ClassName("message-success");
    private static readonly By ProjectsTableBy = By.CssSelector("table.grid");

    protected override bool EvaluateLoadedStatus()
    {
        return Title.Displayed && SuccessMessage.Displayed;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }
    
    public UIElement Title => new UIElement(Driver, TitleBy);
    public UIElement SuccessMessage => new UIElement(Driver, SuccessMessageBy);
    public Table ProjectsTable => new Table(Driver, ProjectsTableBy);
}