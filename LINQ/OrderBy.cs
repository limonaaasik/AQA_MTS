namespace LINQ;

public class OrderBy
{
    private TestIntSet _testIntSet = new();
    private TestStringSet _testStringSet = new();
    private TestObjectSet _testObjectSet = new();

    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");
        
        // Прямая сортировка
        var queryResult =
            from number in _testIntSet
            orderby number descending   // descending дописать, чтобы сортировка по убыванию была
            select number;

        var queryResult1 =
            from text in _testStringSet.List
            orderby text    
            select text;

        var queryResult2 =
            from person in _testObjectSet
            orderby person.Age, person.Name descending // я хочу двойную сортировку. Первичная - по возрасту,
                                                       // вторичная - по имени (если есть одинаоквые записи по возрасту, отсортировать по убыванию по имени)
            select person;

        foreach (var i in queryResult)
        {
            Console.WriteLine($"Int: {i}");
        }
        foreach (var i in queryResult1)
        {
            Console.WriteLine($"String: {i}");
        }
        foreach (var i in queryResult2)
        {
            Console.WriteLine($"Person: {i}");
        }
        
        // Обратная сортировка
        var queryResult3 =
            from obj in _testObjectSet
            orderby obj.Age descending 
            select obj;
        
        foreach (var i in queryResult3)
        {
            Console.WriteLine($"{i}");
        }
        
        // Множественная сортировка
        var queryResult4 =
            from obj in _testObjectSet
            orderby obj.Age, obj.Name descending
            select obj;
        
        foreach (var i in queryResult4)
        {
            Console.WriteLine($"{i}");
        }

    }
    
    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");
        
        // Прямая сортировка
        var queryResult = _testIntSet.OrderByDescending(number => number);
        PrintHelper.Print(queryResult, item => Console.WriteLine(item)); 

        var queryResult1 = _testStringSet.List.OrderBy(text => text);
        PrintHelper.Print(queryResult1, item => Console.WriteLine(item));

        var queryResult2 = _testObjectSet.OrderBy(person => person.Age);
        PrintHelper.Print(queryResult2, item => Console.WriteLine(item));

        // Обратная сортировка
        var queryResult3 = _testObjectSet.OrderByDescending(obj => obj.Age);

        PrintHelper.Print(queryResult3, item => Console.WriteLine(item));

        // Множественная сортировка
        var queryResult4 = _testObjectSet.OrderBy(obj => obj.Age).ThenByDescending(obj => obj.Name);    // двойная сортировка, сначала по возрасту, потом сортирую по имени 
        
        foreach (var i in queryResult4)
        {
            Console.WriteLine($"{i}");
        }
    }
}