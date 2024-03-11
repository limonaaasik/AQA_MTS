using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrappers_HW.Helpers.Configuration;
using Wrappers_HW.Pages.ProjectPages;

namespace Wrappers_HW.Tests
{
    public class DropDownTest : BaseTest
    {
        [Test]
        public void CheckDropDown()
        {
            UserSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            AddTestCasePage testCasePage = new AddTestCasePage(Driver, true);
            Assert.That(testCasePage.IsPageOpened());

            testCasePage.SectionDropDown.SelectByText("Software & Versions");
            Thread.Sleep(2000);
            testCasePage.TemplateDropDown.SelectByIndex(1);
            Thread.Sleep(2000);
            testCasePage.TypeDropDown.SelectedText();

            Assert.That(testCasePage.SectionDropDown.SelectedText(), Is.EqualTo("Software & Versions"));
            Thread.Sleep(2000);

        }
    }
}
