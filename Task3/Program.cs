using System.Collections;

List<string> numbers = new List<string>() { "1, 2, 3, 4, 4, 5" };
string[] nums = numbers[0].Split(", ");     // получаем из коллекции содним элементом массив
var hashset  = new HashSet<string>(nums);   // переводим массив в HashSet

foreach (var item in hashset)
{
        Console.WriteLine(item);
}