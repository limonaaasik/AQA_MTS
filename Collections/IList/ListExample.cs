using Collections.Helper;

namespace Collections.IList;

public class ListExample
{
    public void Run()
    { 
        // Создаем список строк
        List<string> stringList = new List<string>();
        List<string> stringList12 = new List<string>(16); // Устанавливаем capacity в (16)

        // Добавление элементов
        stringList.Add("Первый");
        stringList.Add("Второй");
        stringList.Add("Третий");

        // Вставка элемента по индексу
        stringList.Insert(1, "Новый Второй");

        // Вывод всех элементов
        Console.WriteLine("Элементы в списке:");
        PrintHelper.PrintCollection(stringList);

        // Получение элемента по индексу
        string elementAtIndex = stringList[2];
        Console.WriteLine($"Элемент по индексу 2: {elementAtIndex}");

        // Проверка присутствия элемента в коллекции
        bool containsElement = stringList.Contains("Третий");
        Console.WriteLine($"Список содержит 'Третий': {containsElement}");

        // Сортировка элементов
        stringList.Sort();
        Console.WriteLine("Отсортированная коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Бинарный поиск элемента
        // Перед использованием нужно отсортировать коллекцию
        var item = stringList.BinarySearch("Новый Второй"); // в ответе вернет индекс первого появления элемента в коллекции
        Console.WriteLine($"Бинарный поиск 'Новый Второй': {item}");

        // Поиск индекса элемента
        var index = stringList.IndexOf("Новый Второй"); // в ответе вернет индекс первого появления элемента в коллекции
        Console.WriteLine($"Поиск индекса 'Новый Второй': {index}");
        
        // Удаление значения
        bool result = stringList.Remove("Третий");    // удалит первый найденный элемент, вернет boolезультат: удалил или нет
        Console.WriteLine($"Удаление элемента 'Третий': {result}");

        // Удаление значения по индексу
        stringList.RemoveAt(0);

        // Вывод после удаления
        Console.WriteLine("Элементы после удаления:");
        PrintHelper.PrintCollection(stringList);

        // Удаление группы элементов
        stringList.RemoveRange(0, 1);   // Первый параметр - указать с какого элемента (индекс), второй параметр - сколько элементов удалять
        Console.WriteLine("Остаток:");

        // Reverse элементов
        stringList.Reverse();
        stringList.Reverse(0, 2);   // Первый параметр - указать с какого элемента переворачивать (индекс), второй параметр - сколько элементов переворачивать
        Console.WriteLine("Перевернутая коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Очистка. Удаляет все элементы из коллекции (capacity не меняется)
        stringList.Clear();
        Console.WriteLine($"Количество элементов после очистки: {stringList.Count}");
        PrintHelper.PrintCollection(stringList);
    }
}