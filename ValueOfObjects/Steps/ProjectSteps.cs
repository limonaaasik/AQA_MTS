using OpenQA.Selenium;
using ValueOfObjects.Models;
using ValueOfObjects.Pages;
using ValueOfObjects.Pages.ProjectPages;

namespace ValueOfObjects.Steps;

public class ProjectSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        DashboardPage dashboardPage = new DashboardPage(Driver, true);

        return dashboardPage
            .ClickAddProjectButton()
            .InputName(project.ProjectName)
            .InputAnnouncement(project.Announcement)
            .CheckShowAnnouncementCheckbox(project.IsShowAnnouncement)
            .ChooseProjectType(project.ProjectTypeINT)
            .CheckCaseApprovalsCheckbox(project.IsTestCaseApprovals)
            .ClickAddButton();
    }
}