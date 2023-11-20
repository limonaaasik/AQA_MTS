// See https://aka.ms/new-console-template for more information
int[] array1;
int n = 4;
array1 = new int[n];

int[] array2 = new int[5] { 1, 9, 6, 3, 5 };


int[] array = { 1, 9, 3, 6, 5 };

Console.WriteLine(array[2]);                                        // Обратиться к элементу массива (мы обращаемся к элементу индекса 2, значит результат выйдет 3

Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
Console.WriteLine("Rank: " + array.Rank);                           // ранк массива 
Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк
Console.WriteLine("GetUpperBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк

