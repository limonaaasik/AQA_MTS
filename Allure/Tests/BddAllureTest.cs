using Allure.Net.Commons;
using NUnit.Allure.Attributes;

namespace Allure.Tests;

[AllureEpic("Web interface")]
[AllureFeature("Essential features")]
public class BddAllureTest : BaseTest
{
    // Стандартные методы
    [Test]
    [AllureStory("Labels")]
    public void TestCreateLabel()
    {
        Assert.That(true);
    }

    // API Allure
    [Test]
    [AllureStory("Labels")]
    public void TestCreateLabelByApi()
    {
        AllureApi.AddEpic("Web interface");
        AllureApi.AddFeature("Essential features");
        AllureApi.AddStory("Labels");
        
        Assert.That(true);
    }
}