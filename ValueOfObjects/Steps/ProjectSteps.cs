using OpenQA.Selenium;
using ChainOfInvocations_HW.Models;
using ChainOfInvocations_HW.Pages;
using ChainOfInvocations_HW.Pages.ProjectPages;

namespace ChainOfInvocations_HW.Steps;

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