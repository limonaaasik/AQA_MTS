using System;
using Task_2;

List<int> nums = new List<int> { 1, 5, 5, 7, 8, 8, 9, 10, 12, 12, 15 };

Console.WriteLine("Исходная коллекция:");
PrintHelper.Print(nums);

var numsResult = nums.Where(number => (number % 2 != 0)).Distinct();

Console.WriteLine("Результат:");
PrintHelper.Print(numsResult);