using Task_3;

List<string> words = new List<string> { "FEATURE", "BOW", "MOTHER", "HELLO", "PEW", "APPLE", "STAR"};

Console.WriteLine($"Начальная коллекция:");
PrintHelper.Print(words);

var result = words
                .Select(word => word)
                .OrderBy(word => word.Length)
                .ThenByDescending(word => word);

Console.WriteLine("Итоговая коллекция: ");
PrintHelper.Print(result);
