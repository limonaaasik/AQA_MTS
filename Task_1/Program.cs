
using System.Drawing;
using Task_1;

//Реализовать класс Point, который определяет точку на координатной плоскости. В классе реализовать:
//внутренние поля x, y;
//конструктор с 2 параметрами;
//свойства доступа к внутренним полям класса;
//метод, выводящий значения внутренних полей класса.

Console.WriteLine("Вывод коррдинат точек: ");

Point<int> intPoint = new Point<int>(10, 20);
intPoint.PrintInfo();

Point<string> stringPoint = new Point<string>("координата 1", "координата 2");
stringPoint.PrintInfo();

Random randomPoint = new Random();
Point<int> pointRandom = new Point<int>(randomPoint.Next(), randomPoint.Next());
pointRandom.PrintInfo();