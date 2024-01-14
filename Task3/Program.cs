List<string> numbers = new List<string>() { "1, 2, 3, 4, 4, 5" };

var numbers = "1, 2, 3, 4, 4, 5".Split(',').Select(x => int.Parse(x)).ToList();
