using OpenQA.Selenium;
using ChainOfInvocations_HW.Elements;
using ChainOfInvocations_HW.Pages.ProjectPages;

namespace ChainOfInvocations_HW.Pages
{
    public class DashboardPage(IWebDriver? driver, bool openByURL) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "index.php?/dashboard";

        // Описание элементов
        private static readonly By TitleLabelBy = By.ClassName("page_title");
        private static readonly By SidebarProjectsAddButtonBy = By.ClassName("sidebar-button");
        
        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                return SidebarProjectsAddButton.Displayed && TitleLabel.Text.Trim().Equals("All Projects");
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public Button SidebarProjectsAddButton => new Button(Driver, SidebarProjectsAddButtonBy);
        private UIElement TitleLabel => new UIElement(Driver, TitleLabelBy);

        public AddProjectPage ClickAddProjectButton()
        {
            SidebarProjectsAddButton.Click();
            return new AddProjectPage(Driver, true);
        }
    }
}