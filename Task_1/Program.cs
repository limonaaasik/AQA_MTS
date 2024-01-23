List<int> nums = new List<int> { 1, 5, 5, 7, 8, 8, 9, 10, 12, 12, 15 };

var numsResult = nums.Where(number => (number % 2 != 0)).Distinct();

Console.WriteLine("Результат:");
foreach (var item in numsResult)
{
    Console.WriteLine(item);
}