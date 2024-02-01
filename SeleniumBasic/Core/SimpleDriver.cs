using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace NUnitTest.Core;

public class SimpleDriver   // создать экземпл€р определенного веб-драйвера и отдать объект этого класса
{
    public IWebDriver Driver
    {
        get
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); // правильный путь к хром драйверу
            //string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName; //путь к хром драйверу
            
            //return new ChromeDriver(path + @"/Resources/");
            return new ChromeDriver();
        }
    }
}