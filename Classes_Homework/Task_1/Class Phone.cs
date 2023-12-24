
using System.Security.Cryptography;

public class Phone
{
    // блок переменных
    public string number;
    public string model;
    public double weight;

    // блок конструкторов
    public Phone()
    {

    }

    public Phone(string number, string model)
    {
        this.number = number;
        this.model = model;
    }

    public Phone(string number, string model, double weight) : this (number, model)
    {
        this.weight = weight;
    }


    // блок методов
    public void receiveCall(string name)
    {
        Console.WriteLine($"Звонит: {name}");
    }

    public string getNumber()
    {
        return number;
    }

    public void sendMessage(params string[] nums )
    {
        Console.WriteLine("Сообщение будет отправлено следующим номерам: ");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }

    public void Print()
    {
        Console.WriteLine($"Значения экземпляра: Номер: {number}, Модель: {model}, Вес: {weight}");
    }
}


//Задание 1:
//Создайте класс Phone, который содержит переменные number, model и weight.

//Добавить конструкторы в класс Phone: 
//конструктор без параметров.
//принимает на вход два параметра для инициализации переменных класса - number, model.
//принимает на вход три параметра для инициализации всех переменных класса Phone. Вызвать из этого конструктора конструктор с двумя параметрами.

//Добавить в класс Phone методы: 
//receiveCall, с одним параметром “имя звонящего”. 
//Этот метод выводит на консоль сообщение “Звонит {name}”. 
//getNumber
//Этот метод возвращает номер телефона.
//sendMessage с аргументами переменной длины.  
//Этот метод принимает на вход номера телефонов, которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов 

//Создайте три экземпляра этого класса используя разные конструкторы.
//Выведите на консоль значения их переменных.
//Вызвать методы receiveCall и getNumber для каждого из объектов.
//Вызвать метод sendMessage с 2-мя и 5-ю номерами телефонов.
