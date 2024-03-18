using ChainOfInvocations_HW.Models;
using ChainOfInvocations_HW.Pages.ProjectPages;

namespace ChainOfInvocations_HW.Tests
{
    public class AddProjectTest : BaseTest
    {
        [Test]
        public void SuccessAddProjectTest()
        {
            _navigationSteps.SuccessfulLogin(Admin);

            Project newProject = new Project()
            {
                ProjectName = "Тестовый проект",
                Announcement = "проверим как работает",
                IsShowAnnouncement = true,
                ProjectTypeINT = 1,
                IsTestCaseApprovals = true
            };

            ProjectsPage projectsPage = _projectSteps.AddProject(newProject);

            Assert.That(projectsPage.ProjectsTable.GetCell("Project", newProject.ProjectName, 0).Text, Is.EqualTo(newProject.ProjectName));
        }
    }
}
