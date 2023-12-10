namespace Interfaces.FinalExample;

public class ApplicationTester : ITestable
{
    private Test[] tests = new Test[100];   // Используем имя абстрактного класса для создания массива, которое будет содержать в себе некоторое количество различных тестов
    private int index = 0;  // для отслеживания с каким тестом я сейчас работаю

    public void AddTest(Test test)
    {
        tests[index++] = test;
    }

    public void RunTests()
    {
        for (int i = 0; i < index; i++)
        {
            tests[i].Run();            
        }
    }
}
