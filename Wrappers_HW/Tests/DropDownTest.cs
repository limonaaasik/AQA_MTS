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

        }
    }
}
