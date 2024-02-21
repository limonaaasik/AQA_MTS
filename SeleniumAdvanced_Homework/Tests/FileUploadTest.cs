using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced_Homework.Tests
{
    public class FileUploadTest : BaseTest
    {
        [Test]
        public void FileCheckNameTest()
        {
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");

            var fileUploadElement = WaitsHelper.WaitForExists(By.Id("file-upload"));

            // Получаем путь к исполняемому файлу
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Конструируем путь к файлу внутри проекта
            string filePath = Path.Combine(assemblyPath, "Resources", "cat_picture.jpg");

            fileUploadElement.SendKeys(filePath);

            WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();

            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("uploaded-files")).Text, Is.EqualTo("cat_picture.jpg"));
        }
    }
}
