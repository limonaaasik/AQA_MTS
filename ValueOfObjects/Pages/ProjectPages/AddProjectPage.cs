using OpenQA.Selenium;
using ValueOfObjects.Elements;

namespace ValueOfObjects.Pages.ProjectPages;

public class AddProjectPage(IWebDriver? driver, bool openByURL) : ProjectBasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By _nameInputBy = By.Id("name");
    private static readonly By _announcementInputBy = By.Id("announcement_display");
    private static readonly By _showCheckboxBy = By.Id("show_announcement");
    private static readonly By _projectTypeRadioButtonBy = By.Name("suite_mode");
    private static readonly By _caseApprovalsCheckboxBy = By.Id("case_statuses_enabled");
    private static readonly By AddButtonBy = By.Id("accept");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }
    
    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(AddButtonBy).Displayed;
    }
    
    // Атомарные Методы
    public Button AddButton => new Button(Driver, AddButtonBy);
    public UIElement NameInput => new UIElement(Driver, _nameInputBy);
    public UIElement AnnouncementInput => new UIElement(Driver, _announcementInputBy);
    public Checkbox ShowAnnouncementCheckbox => new (Driver, _showAnnouncementCheckboxBy);
    public RadioButton ProjectTypeRadio => new(Driver, _projectTypeRadioBy);
    public Checkbox CaseApprovalsCheckbox => new(Driver, _caseApprovalsCheckboxBy);
}