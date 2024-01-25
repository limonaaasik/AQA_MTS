namespace NUnitProject;

public class PrePostConditionExample
{

    /// <summary>
    /// Initializes Global test objects
    /// </summary>
    /// 
    [OneTimeSetUp]  // данный метод нужно выполнитьь 1 раз перед тестовым набором
    public void OneTimeSetUp()
    {
        Console.WriteLine($"{this}: OneTimeSetUp...");
    }
    
    [SetUp] // каждый раз перед каждым тестовым методом
            // (накатить какие-то настройки/выполнить действия перед выполнением)
    public void Setup()
    {
        Console.WriteLine($"{this}: SetUp...");
    }

    [Test] // основной атрибут для запуска теста
    public void Test()
    {
        Console.WriteLine($"{this}: Test...");
    }
    
    [TearDown]  // каждый раз перед каждым тестовым методом
                // (откатить настройки/выполенные действия после выполнения)
    public void TearDown()
    {
        Console.WriteLine($"{this}: TearDown...");
    }

    [OneTimeTearDown]   // метод будет выполняться 1 раз после всех тестов
    public void OneTimeTearDown()
    {
        Console.WriteLine($"{this}: OneTimeTearDown...");
    }
}