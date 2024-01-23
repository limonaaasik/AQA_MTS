using System;

List<int> nums = new List<int> { 1, 5, 5, 7, 8, 8, 9, 10, 12, 12, 15 };

Console.WriteLine("Исходная коллекция:");
foreach (var item in nums)
{
    Console.Write($"{item} ");
}

var numsResult = nums.Where(number => (number % 2 != 0)).Distinct();

Console.WriteLine(); 
Console.WriteLine();

Console.WriteLine("Результат:");
foreach (var item in numsResult)
{
    Console.Write($"{item} ");
}