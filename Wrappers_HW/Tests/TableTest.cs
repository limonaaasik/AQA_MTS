using OpenQA.Selenium;
using Wrappers_HW.Elements;
using Wrappers_HW.Helpers.Configuration;
using Wrappers_HW.Pages;
using Wrappers_HW.Pages.ProjectPages;

namespace Wrappers_HW.Tests;

public class TableTest : BaseTest
{
    [Test]
    public void AddProjectCorrectTest()
    {
        UserSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
            .AddProjectButton.Click();

        ProjectsPage projectsPage = new ProjectsPage(Driver, true);
        TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "Test2", "Project");
        tableCell.GetLink().Click();
    }
}