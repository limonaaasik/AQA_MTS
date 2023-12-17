using Collections.Helper;

namespace Collections.IList;

public class ListExample
{
    public void Run()
    { 
        // Создаем список строк
        List<string> stringList = new List<string>();
        List<string> stringList12 = new List<string>(16); // Устанавливаем capacity в (16)
        Console.WriteLine($"Capacity1 : {stringList.Capacity}");
        Console.WriteLine($"Capacity2 : {stringList12.Capacity}");


        // Добавление элементов
        stringList.Add("Первый");
        stringList.Add("Второй");
        stringList.Add("Третий");
        stringList.AddRange(new[] {"Test", "Test1, Test1" });

        // Вставка элемента по индексу
        stringList.Insert(1, "Новый Второй");
        stringList.InsertRange(stringList.Count, new List<string>() { "Test4", "Test5" });   // Вставка группы элементов. Указать с какого элемента и массив элементов, которые надо вставить

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
        stringList.RemoveRange(0, 1);   // Первый параметр - указать с какого элемента (индекс),
                                        // второй параметр - сколько элементов удалять
        Console.WriteLine("Остаток:");

        // Reverse элементов
        stringList.Reverse();
        Console.WriteLine("Перевернутая коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Reverse группы элементов
        stringList.Reverse(1, stringList.Count - 1);// Первый параметр - указать с какого элемента переворачивать (индекс),
                                                    // второй параметр - сколько элементов переворачивать
        Console.WriteLine("Перевернутая коллекция:");
        PrintHelper.PrintCollection(stringList);

        // Получение диапазона и копирование в массив
        List<string> range = stringList.GetRange(0, 2); // команда создает копию куска нашей коллекции.
                                                        // 1 параметр - указать с какого индекса элемента, 2 параметр -  количество
        Console.WriteLine("Часть коллекции:");
        PrintHelper.PrintCollection(range);

        string[] part = new string[3];
        stringList.CopyTo(0, part, 1, 2);   // команда делает копию коллекции в массив part.
                                            // 1 параметр - копируем, начиная с 0 элемента коллекции
                                            // 2 параметр - вставляем в массив part
                                            // 3 параметр - вставляем в массив, начиная с индекса 1
                                            // 4 параметр - количество элементов, которое мы должны скопировть
        Console.WriteLine("Копия коллекции:");
        PrintHelper.PrintCollection(part);

        // Пример ForEach вывода на экран
        stringList.ForEach(p => Console.WriteLine(p));

        // Очистка. Удаляет все элементы из коллекции (capacity не меняется)
        stringList.Clear();
        Console.WriteLine($"Количество элементов после очистки: {stringList.Count}");
        PrintHelper.PrintCollection(stringList);    }
}