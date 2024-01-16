using System.Collections.Generic;
using Task_2;

Array<int> intArray = new Array<int>();
intArray.Add(1);
intArray.Add(3);
intArray.Add(10);

Console.WriteLine("Данные массива после добавления:");
intArray.PrintArray();

Console.WriteLine();
var element = intArray.GetElement(0);
Console.WriteLine($"Элемент по индексу 0: {element}");

Console.WriteLine();
intArray.Remove(1);
Console.WriteLine("Данные массива после удаления элемента по индексу 1:");
intArray.PrintArray();

Console.WriteLine();
Console.WriteLine($"Длина массива: {intArray.GetLength()}");