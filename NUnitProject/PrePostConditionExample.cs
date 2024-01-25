namespace NUnitProject;

public class PrePostConditionExample
{

    /// <summary>
    /// Initializes Global test objects
    /// </summary>
    /// 
    [OneTimeSetUp]  // ������ ����� ����� ���������� 1 ��� ����� �������� �������
    public void OneTimeSetUp()
    {
        Console.WriteLine($"{this}: OneTimeSetUp...");
    }
    
    [SetUp] // ������ ��� ����� ������ �������� �������
            // (�������� �����-�� ���������/��������� �������� ����� �����������)
    public void Setup()
    {
        Console.WriteLine($"{this}: SetUp...");
    }

    [Test] // �������� ������� ��� ������� �����
    public void Test()
    {
        Console.WriteLine($"{this}: Test...");
    }
    
    [TearDown]  // ������ ��� ����� ������ �������� �������
                // (�������� ���������/���������� �������� ����� ����������)
    public void TearDown()
    {
        Console.WriteLine($"{this}: TearDown...");
    }

    [OneTimeTearDown]   // ����� ����� ����������� 1 ��� ����� ���� ������
    public void OneTimeTearDown()
    {
        Console.WriteLine($"{this}: OneTimeTearDown...");
    }
}