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
    private static readonly By _addButtonBy = By.Id("accept");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }
    
    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(_addButtonBy).Displayed;
    }
    
    // Атомарные Методы
    public Button AddButton => new Button(Driver, _addButtonBy);
    public UIElement NameInput => new UIElement(Driver, _nameInputBy);
    public UIElement AnnouncementInput => new UIElement(Driver, _announcementInputBy);
    public Checkbox ShowCheckbox => new Checkbox(Driver, _showCheckboxBy);
    public RadioButton ProjectTypeRadio => new RadioButton(Driver, _projectTypeRadioButtonBy);
    public Checkbox CaseApprovalsCheckbox => new Checkbox(Driver, _caseApprovalsCheckboxBy);

    public AddProjectPage InputName(string value)
    {
        NameInput.SendKeys(value);
        return this;
    }

    public AddProjectPage InputAnnouncement(string value)
    {
        AnnouncementInput.SendKeys(value);
        return this;
    }

    public AddProjectPage CheckShowAnnouncementCheckbox(bool value)
    {
        ShowCheckbox.SetFlag(value);
        return this;
    }

    public AddProjectPage ChooseProjectType(string value)
    {
        ProjectTypeRadio.SelectByText(value);
        return this;
    }

    public AddProjectPage ChooseProjectType(int index)
    {
        ProjectTypeRadio.SelectByIndex(index);
        return this;
    }

    public AddProjectPage CheckCaseApprovalsCheckbox(bool value)
    {
        CaseApprovalsCheckbox.SetFlag(value);
        return this;
    }

    public ProjectsPage ClickAddButton()
    {
        AddButton.Click();
        return new ProjectsPage(Driver);
    }
}