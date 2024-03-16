using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOfObjects.Models;
using ValueOfObjects.Pages.ProjectPages;

namespace ValueOfObjects.Tests
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
            
            Assert.That(projectsPage.)
        }
    }
}
