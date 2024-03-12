using OpenQA.Selenium;
using Wrappers_HW.Elements;

namespace Wrappers_HW.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";
    
    // Описание элементов
    private static readonly By AddButtonBy = By.Id("name");
    private static readonly By AddProjectTitleBy = By.ClassName("page_title");
    private static readonly By ShowAnnouncementCheckboxBy = By.Id("show_announcement");

    public AddProjectPage(IWebDriver driver) : base(driver)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitlePageAddPrj.Text.Trim().Equals("Add Project");
    }

    // Атомарные Методы
    public IWebElement AddButton => Driver.FindElement(AddButtonBy);
    public IWebElement TitlePageAddPrj => Driver.FindElement(AddProjectTitleBy);
    public Checkbox ShowAnnouncementCheckbox => new Checkbox(Driver, ShowAnnouncementCheckboxBy);
}