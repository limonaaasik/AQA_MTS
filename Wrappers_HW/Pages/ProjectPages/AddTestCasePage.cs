using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wrappers_HW.Elements;

namespace Wrappers_HW.Pages.ProjectPages
{
    public class AddTestCasePage : BasePage
    {
        private static string END_POINT = "index.php?/cases/add/1";

        private static readonly By PageTitleBy = By.ClassName("page_title");
        private static readonly By SectionDropDownBy = By.Id("section_id_chzn");
        private static readonly By TemplateDropDownBy = By.Id("template_id_chzn");
        private static readonly By TypeDropDownBy = By.Id("type_id_chzn");
        private static readonly By PriorityDropDownBy = By.Id("priority_id_chzn");
        private static readonly By AssignedToDropDownBy = By.Id("assigned_to_id_chzn");
        private static readonly By AutomationTypeDropDownBy = By.Id("custom_automation_type_chzn");

        public AddTestCasePage(IWebDriver driver) : base(driver)
        {
        }

        // Атомарные Методы
        public UIElement TitlePage => new (Driver, PageTitleBy);
        public DropDown SectionDropDown => new (Driver, SectionDropDownBy);
        public DropDown TemplateDropDown => new (Driver, TemplateDropDownBy);
        public DropDown TypeDropDown => new (Driver, TypeDropDownBy);
        public DropDown PriorityDropDown => new DropDown(Driver, PriorityDropDownBy);
        public DropDown AssignedToDropDown => new DropDown(Driver, AssignedToDropDownBy);
        public DropDown AutomationTypeDropDown => new DropDown(Driver, AutomationTypeDropDownBy);

        public override bool IsPageOpened()
        {
            return TitlePage.Text.Trim().Equals("Add Test Case");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
