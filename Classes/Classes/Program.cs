﻿using System.Security.Cryptography.X509Certificates;
using Classes.Models;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 14, -4, 0, 7 };

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Array.Reverse(array);
            {
                foreach (var item in array)
                {
                    Console.Write($"{item}\t");
                }

                Console.WriteLine();
            }

            PrintArray(array);

            void PrintArray(int[] arr)
            {
                foreach (var item in arr)
                {
                    Console.Write($"{item}\t");
                }

                Console.WriteLine();
            }


            // -=================== Метод без параметров ===================-
            void MethodWithoutParameters()
            {
                // Тело метода
            }


            // -=================== Метод без возвращаемого значения ===================-
            // Параметр - требование метода передать мне что-то
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }

            PrintMessage("Text");

            string tmp = "Taskghghgh";
            PrintMessage(tmp);

            // -=================== Метод с возвращаемым значением ===================-



            // -=================== Метод с параметрами по умолчанию ===================-
            void DisplayGreeting(string greetingMessage, string name = "Гость")
            {
                Console.WriteLine($"{greetingMessage}, {name}!");
            }

            DisplayGreeting("Hello");
            DisplayGreeting("Hello", "Alex");
            DisplayGreeting("Alex", "Hello");

            // -=================== Метод с переменным числом аргументов ===================-
            int CalculateSum(params int[] numbers)
            {
                int sum = 0;

                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }

            int sum1 = CalculateSum(1, 2, 3, 4, 5);
            int sum2 = CalculateSum(); // Пустой вызов

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);

            // -=================== Передача параметров ===================-
            // -=================== По значению

            void SimpleAdd(int x, int y)                //По умолчанию аргументы передаются по значению,
            {
                int ans = x + y;
                // Вызывающий код не увидит эти изменения, т.к. модифицируется копия исходных данных,

                // Разкомментировать
                //х = 10000;
                //у = 88888;
            }

            // -=================== По ссылке
            // -=================== Out
            // Значения выходных параметров должны быть установлены внутри вызываемого метода.
            static void OutAdd(int x, int y, out int ans)
            {
                ans = x + y;
            }
            // Присваивать начальные значения локальным переменным, используемым как выходные параметры, не обязательно
            // при условии, что они впервые используются
            OutAdd(90, 90, out int ans); // - Первый вариант

            //int ans;
            //Add(90, 90, out ans); // - Второй вариант

            Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);

            // Практическое применение в тестировании - возврат данных
            void FillTheseValues(out int a, out string b, out bool c)
            {
                a = 9;
                b = "Enjoy your string.";
                c = true;
            }


            // -=================== Ref
            void ModifyValue(ref int value)
            {
                value = value * 2;
            }

            int mainValue = 5;      // Если закоментировать - будет ошибка
            Console.WriteLine($"mainValue is {mainValue}");
            ModifyValue(ref mainValue);
            Console.WriteLine($"mainValue now is {mainValue}");

            // -=================== Возврат значений ===================-
            // -=================== Возврат значения
            int GetPersonAge()
            {
                return 25;
            }

            Console.WriteLine($"Age: {GetPersonAge()}");  // Используе м название метода как переменную. 
                                                          // Она будет содержать значение, которое будет передаваться в return
                                                          // return присвает значение, которое стоит после него в переменную метода и его потом вызывает consolewriteline 
                                                          // поэтому метод можно использовать как переменную для вывода

            // -=================== Возврат нескольких значений
            (string, int) GetPersonInfo()
            {
                return ("John", 25);
            }

            var person = GetPersonInfo();
            Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");

            // -=================== Сжатый метод
            int ShortAdd(int х, int у) => х + у;

            // -=================== Рекурсивная функция
            int Factorial(int n)
            {
                if (n == 1) return 1;

                return n * Factorial(n - 1);
            }

            int factorial4 = Factorial(4);  // 24 
            int factorial5 = Factorial(5);  // 120
            int factorial6 = Factorial(6);  // 720

            Console.WriteLine($"Факториал числа 4 = {factorial4}");
            Console.WriteLine($"Факториал числа 5 = {factorial5}");
            Console.WriteLine($"Факториал числа 6 = {factorial6}");

            // -=================== Классы ===================-
            // -=================== Структура класса
            EmptyClass emptyClassObject = new EmptyClass(); // указываем тип - переменная - new - указываем имя класса в виде метода с круглыми скобками


            Person personObj = new Person();

            Person personObj2 = new Person("Ксюша");
            Person personObj3 = new Person(24);
            Person personObj4 = new Person("Ксюша", 26);

            personObj.Print();

            personObj.name = "Alex";
            personObj.age = 45;
            personObj.Print();

            // -=================== Создание конструкторов
            ConstructorByDefault constructorByDefault = new ConstructorByDefault();

            ConstructorCustom constructorCustom1 = new ConstructorCustom(1);
            ConstructorCustom constructorCustom2 = new ConstructorCustom("test");

            ConstructorFull constructorFull1 = new ConstructorFull();
            ConstructorFull constructorFull2 = new ConstructorFull(1);
            ConstructorFull constructorFull3 = new ConstructorFull("test");

            // -=================== Цепочка вызова конструкторов
            PersonChain personChain1 = new PersonChain();
            PersonChain personChain2 = new PersonChain("Alex");
            PersonChain personChain3 = new PersonChain("Alex", 45);

            personChain1.Print();
            personChain2.Print();
            personChain3.Print();

            // -=================== Первичные конструкторы
            // PersonPrimaryConstructors personPrimaryConstructors1 = new PersonPrimaryConstructors();          - Ошибка
            PersonPrimaryConstructors personPrimaryConstructors2 = new PersonPrimaryConstructors(name: "Alex");
            // PersonPrimaryConstructors personPrimaryConstructors3 = new PersonPrimaryConstructors(age: 45);   - Ошибка
            PersonPrimaryConstructors personPrimaryConstructors4 = new PersonPrimaryConstructors(name: "Alex", age: 45);

            personPrimaryConstructors2.Print();
            personPrimaryConstructors4.Print();

            // -=================== This
            PersonThis personThis = new PersonThis("Alex", 45);


            NameSpaceA.ClassA classA = new NameSpaceA.ClassA();
            classA.Print();

            NameSpaceB.ClassA classB = new NameSpaceB.ClassA();
            classB.Print();

            // -=================== Практика ===================-
            // -=================== Задача 1

            Student[] students = new Student[14];

            for (int i = 0; i < 14; i++)
            {
                students[i] = new Student();
                students[i].name = "Alex" + i;
                students[i].group = new Random().Next(2);
                students[i].diplomMark = new Random().Next(1, 11);
            }

            Console.WriteLine($"Students.Length: {students.Length}");

            foreach (var student in students)
            {
                Console.Write($"Name: {student.name}, Group: {student.group}, Mark: {student.diplomMark}");
                Console.WriteLine();
            }
            Console.WriteLine();

            // -=================== Задача 2
            foreach (Student student in students)
            {
                if (student.diplomMark == 9 || student.diplomMark == 10)
                {
                    student.Print();
                }
            }
            Console.WriteLine();
            
            // -=================== Задача 3
            Student[] students1 = new Student[14];

            for (int i = 0; i < 14; i++) students1[i] = new Student("Alex" + i);
            foreach (var student in students1) student.Print();
            Console.WriteLine();

            // -=================== Задача 4
            Cat cat = new Cat();
            cat.name = "Barsik";
            cat.age = 2;
            cat.maxFoodCount = 3;

            Console.WriteLine($"Наелся? - {cat.Feed(2)}");
            Console.WriteLine($"Наелся? - {cat.Feed(4)}");
            Console.WriteLine("Наелся? - {0}", cat.Feed(3) ? "Да" : "Нет");
            
        }
    }
}