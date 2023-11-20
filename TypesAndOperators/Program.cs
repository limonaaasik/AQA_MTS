
using System;

int[] array1;
int n = 4;
array1 = new int[n];

int[] array2 = new int[5] { 1, 9, 6, 3, 5 };


int[] array = { 1, 9, 3, 6, 5 };

Console.WriteLine(array[2]);                                        // Получение элемента массива (мы обращаемся к элементу индекса 2, значит результат выйдет 3)

array[0] = 10;
Console.WriteLine(array[0]);                                        // Обратиться к элементу массива (мы обращаемся к элементу индекса 0, значит результат выйдет 10, т.к. до этого определили, что первый элемент = 10)


Console.WriteLine("Length: " + array.Length);                       // возвращает общее количество элементов, содержащихся в массиве; Если массив пуст, возвращается ноль.
Console.WriteLine("Rank: " + array.Rank);                           // ранк массива 
Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк в измерении
Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetUpperBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк; В скобочках 0 - указываем строку, с которой сейчас мы работаем



Console.WriteLine($"Last item in array: {array[array.Length - 1]}");    // Вычисление последнего элемента в массиве
Console.WriteLine($"Last item in array: {array[^2]}");                  // Вычисление n-го элемента в массиве; ^ заменяет часть "array.Length -"

Console.WriteLine($"Last item in array: {array[array.GetUpperBound(0)]}");      // Получение верхней границы  в текущей строке



// Циклы
/*
for (объявление переменной; условие; изменение переменной)
{
    блок операций, которые надо повторить много раз
}
*/

for (int i = 0; i <= array.GetLength(0) - 1; i++) 
{
    Console.Write($"{array[i]} ") ;
}

Console.WriteLine();

for (int i = 0; i < array.GetUpperBound(0); i++)
{
    Console.Write($"{array[i]} ");
}

/*
int[,] array9 = new int[2, 5] { { 1, 9, 3, 6, 5 }, { 2, 8, 9, 7, 6 } };
Console.WriteLine("GetLength(0): " + array9.GetLength(0));
Console.WriteLine("GetLength(1): " + array9.GetLength(1));
Console.WriteLine("GetLength: " + array9.Length);
*/


for (int i = 0; i <= array.GetUpperBound(0); i++)
{
    array[i] = new Random().Next(100);
}

Console.WriteLine();

// Тут работаем со значениями нашего массива (foreach). В этом цикле нельзя модифицировать элемент массива (item)
foreach (int item in array) // item - это должен быть тип массива, с которым мы работаем (массив array)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} Hello");
}

Console.WriteLine();

for (int i = 0; i <= 10; i += 2) // i = i + 2
{
    Console.WriteLine($"{i} ");
}

Console.WriteLine();

string text = "Hello";
foreach (char ch in text)
{
    Console.Write($"{ch} ");
}


// Операторы continue и break
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i <= 10; i += 2) // i = i + 2
{
    if (i == 6)
        continue;
    Console.Write($"{i} ");
}

for (int i = 0; i <= 10; i += 2) // i = i + 2
{
    if (i == 6)
        break;
    Console.Write($"{i} ");
}




// Цикл DO WHILE. 
Console.WriteLine();
Console.WriteLine();


int u = 6;
bool flag = true;
do
{
    if (u < 0) flag = false; //действие цикла
    Console.WriteLine($"{u} ");
    u--;
}
while (flag);   // условие

Console.WriteLine();
Console.WriteLine();

u = 6;
do
{
    //действие цикла
    Console.WriteLine($"{u} ");
    u--;
}
while (u >= 0);   // условие



// Цикл WHILE. 


// -============================================= Двумерный массив =============================================-

int[,] array8 = new int[4, 5];
Console.WriteLine("Length: " + array8.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array8.Rank);                           // ранк массива
Console.WriteLine("GetLength(0): " + array8.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array8.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetLength(1): " + array8.GetLength(1));           // количество столбцов
Console.WriteLine("GetUpperBound(1): " + array8.GetUpperBound(1));   // Верхний индекс столбцов
Console.WriteLine("GetLowerBound(0): " + array8.GetLowerBound(0));   // Нижний индекс строк
Console.WriteLine("GetLowerBound(1): " + array8.GetLowerBound(1));   // Нижний индекс столбцов

Console.WriteLine("=========");

int t = 1;

// Задание значений
for (int i = 0; i < array8.GetLength(0); i++)
{
    for (int j = 0; j < array8.GetLength(1); j++)
    {
        array8[i, j] = i + j;
    }
}

int rows = array8.GetLength(0);
int columns = array8.GetLength(1);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array8[i, j]} \t");
    }
    Console.WriteLine();
}


foreach (int item in array)
{
    Console.Write($"{item} ");
}


