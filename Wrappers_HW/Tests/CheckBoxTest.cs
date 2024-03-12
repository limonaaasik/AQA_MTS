using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrappers_HW.Helpers.Configuration;
using Wrappers_HW.Pages.ProjectPages;

namespace Wrappers_HW.Tests
{
    public class CheckBoxTest :BaseTest
    {
        [Test]
        public void CheckCheckBox()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProjectButton.Click();
            
            AddProjectPage addProjectPage = new AddProjectPage(Driver);
            addProjectPage.IsPageOpened();
            addProjectPage.ShowAnnouncementCheckbox.SetFlag(true);

            Assert.That(addProjectPage.ShowAnnouncementCheckbox.IsSelected);

        }
    }
}
