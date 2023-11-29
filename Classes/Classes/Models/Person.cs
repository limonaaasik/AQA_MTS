namespace Classes.Models;

public class Person
{
    // Блок полей (переменных)
    public string name = "Undefined";   // имя
    public int age;                     // возраст
 
    // Блок конструктора
    public Person()
    {
    }

    public Person(string personName)
    {
        name = personName;
    }

    public Person(int personAge)
    {
        age = personAge;
    }

    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
    }

    // Блок методов и свойств
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}