using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace StringApp     // В каком прострастве имен мы находимся
{
    static class Program
    {
        static  void Main(string[] args)
        {
            
            string message1;
            string message2 = null;
            string message3 = System.String.Empty;
            string oldPath = "c:\\Program Files\\tmp.txt0";
            string newPath = @"c:\Program Files\""tmp"".txt";

            System.String greetings = "Hello World!!";
            string greetings1 = "Hello World!!";
            var greetings2 = "Hello World!!";
            const string greetings3 = "Hello World!!";

            string s1 = "hello";
            string s2 = new String('a', 6); // результатом будет строка "aaaaaa" - 6 раз повторит объект из первого параметра, то есть фактически создаст строку "aaaaaa".
            string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }); // конструктор принимает массив символов, из которых создается строка
            string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl конструктор позволяет создать строку из части массива символов.
                                                                                  // Второй параметр передает начальный индекс, с которого извлкаются символы,
                                                                                  // а третий параметр указывает на количество символов

            Console.WriteLine(s1);  // hello
            Console.WriteLine(s2);  // aaaaaaa
            Console.WriteLine(s3);  // world
            Console.WriteLine(s4);  // orl
            


            // Сравнение строк

            string msg1 = "Hello\0";        //  \0 - скрытый символ
            string msg2 = "Hello";

            Console.WriteLine(msg1 == msg2);  // Сравнение произойдет по значению строк
            Console.WriteLine(msg1.Equals(msg2));  // Сравнение произойдет по значению строк
            Console.WriteLine(msg1[0]);  // Обращение к символу и его вывод на экран по его индексу

            Console.WriteLine();

            foreach (var c in msg1)
            {
                Console.WriteLine(c);
            }

            int val = 10;
            string text_inter = $"""
                          <element attr="content">
                            <body>
                            {val}
                            </body>
                          </element>
                          """;
            string text1 = "<element attr=\"content\">" +
                           "<body>" +
                           "</body>" +
                           "</element>";
            Console.WriteLine(text);
            Console.WriteLine(text_inter);
            Console.WriteLine(text1);

            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";

            string[] values = new string[] { s5, s6, s7 };
            string str_final = string.Join(" : ", values);
            Console.WriteLine(str_final);  // пробел : пробел  - это разделяющий символ между выведенными элементами массива


            // -=================== Объединение строк ===================
            // -=================== Concatenate 1 
            string s11 = "A string is more ";
            string s21 = "than the sum of its chars.";

            //  Concatenate s1 and s2. This actually creates a new
            //  string object and stores it in s11, releasing the
            //  reference to the original object.
            s11 += s21;

            System.Console.WriteLine($"Concat 1: {s11}");
            // Output: A string is more than the sum of its chars.

            // -=================== Concatenate 2
            s11 = "A string is more ";
            s21 = "than the sum of its chars.";

            s11 = string.Concat(s11, s21);
            Console.WriteLine($"Concat 2: {s11}");
            // Output: A string is more than the sum of its chars.


            // -=================== Join (Объединение строк)
            string join_str1 = "Have";
            string join_str2 = "a nice";
            string join_str3 = "day";
            string[] str_array = new string[] { join_str1, join_str2, join_str3, "!" };

            string join_str_final = string.Join(" ", str_array);
            Console.WriteLine($"Join: {join_str_final}");

            // -=================== Comparison (Сравнение строк) ===================
            // -=================== Сравнение на равенство
            string comp_str1 = "hello";
            string comp_str2 = "hello";

            Console.WriteLine($"Compare ==: {comp_str1 == comp_str2}");
            Console.WriteLine($"Compare Equals: {comp_str1.Equals(comp_str2)}");

            string[] compare_values = { "hello", "world", "about" };
            foreach (string item in compare_values)
            {
                Console.WriteLine($"Compare: {comp_str1.CompareTo(item)}");
            }

            /*
             * 0 - идентичны
             * < 0 - строка 1 перед строкой 2 по алфавиту
             * > 0 - строка 1 после строки 2 по алфавиту
             */


            // -=================== Find subString (Поиск подстроки) ===================
            string f_str = "This is just an ordinary string.";

            // -=================== IndexOf and IndexOfAny
            // Позволяет понять есть ли искомое значение в строке, если есть то будет возвращен индекс (местоположение) символа внутри этой строки
            Console.WriteLine($"IndexOf 'j' (С учетом регистра): {f_str.IndexOf('j')}"); // С учетом регистра
            Console.WriteLine($"IndexOf 'J' (С учетом регистра): {f_str.IndexOf('J')}"); // С учетом регистра. Результат -1: вхождение этого символа нет в этой строке
            Console.WriteLine(
                $"IndexOf 'J' (Без учета регистра): {f_str.IndexOf('J', StringComparison.OrdinalIgnoreCase)}"); // Без учета регистра. StringComparison.OrdinalIgnoreCase - метод не учитывает регистр
            Console.WriteLine(
                $"IndexOf 'j' (С указанием начала поиска): {f_str.IndexOf('j', 9)}"); // С указанием начала поиска

            char[] chars1 = { 'T', 'o', 's' };
            char[] chars2 = { '!', '=', '^' };

            Console.WriteLine($"IndexOfAny 'chars1': {f_str.IndexOfAny(chars1)}");
            Console.WriteLine($"IndexOfAny 'chars1': {f_str.IndexOfAny(chars1, 2)}");
            Console.WriteLine($"IndexOfAny 'chars2': {f_str.IndexOfAny(chars2)}");

            Console.WriteLine($"IndexOf 'i': {f_str.IndexOf('i')}");
            Console.WriteLine($"LastIndexOf 'i': {f_str.LastIndexOf("i")}");        // Последний индекс 
            Console.WriteLine($"IndexOf 'i': {f_str.IndexOf("just")}");     // Можно искать по строчке, выведет первый символ скоторой начинается эта строчка

            // -=================== StartWith 
            // Разобрать массив строк, чтобы понять начинается ли строка с того, что нам нужно. Использовать можно либо символ '', либо строку ""
            var files = new string[]
            {
                "myapp.exe",
                "forest.jpg",
                "main.exe"
            };

            foreach (var file in files)
            {
                Console.WriteLine($"StartsWith {file} (С учетом регистра): {file.StartsWith('m')}");
                Console.WriteLine($"StartsWith {file} (С учетом регистра): {file.StartsWith('M')}");
                Console.WriteLine(
                    $"StartsWith {file} (Без учета регистра): {file.StartsWith("My", StringComparison.OrdinalIgnoreCase)}");
            }

            // -=================== EndsWith
            // Разобрать массив строк, чтобы понять заканчиваается ли строка с тем значением, которое нам нужно.  Использовать можно либо символ '', либо строку ""
            foreach (var file in files)
            {
                Console.WriteLine($"EndsWith {file} (С учетом регистра): {file.EndsWith(".jpg")}");
                Console.WriteLine($"EndsWith {file} (С учетом регистра): {file.EndsWith(".JpG")}");
                Console.WriteLine(
                    $"EndsWith {file} (Без учета регистра): {file.EndsWith(".JpG", StringComparison.OrdinalIgnoreCase)}");
            }

            // -=================== Split (Разделение строк) ===================
            // Команда возвращает массив, НЕ строку
            string text1 = "This is just an ordinary string.";
            string text2 = "10: 99: :: 55";

            string[] words1 = text1.Split(" "); // В сплите надо указывать символ, который будет разделителем. В этом случае - это пробел
            string[] words12 = text2.Split(":");

            Console.WriteLine("Ordinary:");
            foreach (var item in words1) Console.Write($"'{item}'\t");
            Console.WriteLine("Ordinary:");
            foreach (var item in words12) Console.Write($"'{item}'\t");  //Результат будет с пробелами и пустыми символами. След метод посмотри, чтобы понять как этог избежать

            string[] words2 = text2.Split(':', StringSplitOptions.TrimEntries);         // TrimEntries - удалить пробелы перед
            Console.WriteLine("\nTrimEntries:");
            foreach (var item in words2) Console.Write($"'{item}'\t");

            string[] words3 = text2.Split(":", StringSplitOptions.RemoveEmptyEntries);      // RemoveEmptyEntries - удалить пустое знчение из массива
            Console.WriteLine("\nRemoveEmptyEntries:");
            foreach (var item in words3) Console.Write($"'{item}'\t");

            string[] words4 = text2.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words4) Console.Write($"'{item}'\t");
            Console.WriteLine("\nSplit by char[]:");
            Console.WriteLine();


            // -=================== Trim (Обрезка строки) ===================
            // Удаляем символы, которые обрамляют нашу строку
            string originalString = "   Hello, world!   ";

            string trimmedString = originalString.Trim();       // Если ничего не передается, то по умолчанию тримируется пробел (обрезается пробел)
            Console.WriteLine($"Trim: {trimmedString}");                // Вывод: "Hello, world!"


            string originalString1 = "**Hello, world!**";
            char[] charsToRemove = { '*', ' ' };
            string trimmedCharsString = originalString1.Trim(charsToRemove);        // Указали массив символов, которые надо обрезать

            Console.WriteLine($"Trim Chars: {trimmedCharsString}");     // Вывод: "Hello, world!"

            // -=================== TrimStart
            string trimmedStartString = originalString.TrimStart();
            Console.WriteLine($"TrimStart: {trimmedStartString}");     // Вывод: "Hello, world!   "

            // -=================== TrimEnd
            string trimmedEndString = originalString.TrimEnd();
            Console.WriteLine($"TrimEnd: {trimmedEndString}");          // Вывод: "   Hello, world!"

            // -=================== Substring
            string originalSubstringString = "Hello, world!";

            // Пример 1: Извлечение подстроки, начиная с определенной позиции
            string substring1 = originalSubstringString.Substring(7);       // Указываем индекс начала откуда надо извлечь и до конца строки
            Console.WriteLine($"Substring(7): {substring1}");           // Вывод: "world!"

            // Пример 2: Извлечение подстроки из определенного диапазона позиций
            string substring2 = originalSubstringString.Substring(7, 5);        // Указываем индекс начала откуда надо извлечь и длину отрезаемой части
            Console.WriteLine($"Substring(7, 5): {substring2}");        // Вывод: "world"

            // Пример 3: Извлечение подстроки с использованием переменных
            int startIndex = 7;
            string worlld = "world";
            string substring3 = originalSubstringString.Substring(startIndex, world.Length);
            Console.WriteLine($"Substring(startIndex, length): {substring3}");  // Вывод: "world"


            // -=================== Insert (Вставка) ===================
            string originalInsertString = "Hello, world!";

            // Пример вставки подстроки в середину строки
            string insertedString = originalInsertString.Insert(7, "beautiful ");
            Console.WriteLine($"Insert (в середине): {insertedString}");        // Вывод: "Hello, beautiful world!"

            // Пример вставки подстроки в начало строки
            string insertedAtStart = originalInsertString.Insert(0, "Greeting: ");
            Console.WriteLine($"Insert (в начале): {insertedAtStart}");         // Вывод: "Greeting: Hello, world!"

            // Пример вставки подстроки в конец строки
            string insertedAtEnd = originalInsertString.Insert(originalInsertString.Length, " Have a nice day!");
            Console.WriteLine($"Insert (в конце): {insertedAtEnd}");            // Вывод: "Hello, world! Have a nice day!"


            // -=================== Remove (Удаление) ===================
            string originalRemoveString = "Hello, world!";

            // Пример 1: Удаление символов начиная с позиции 7
            string removedSubstring1 = originalRemoveString.Remove(7);
            Console.WriteLine($"Remove(7): {removedSubstring1}");               // Вывод: "Hello, "

            // Пример 2: Удаление 3 символов начиная с позиции 7
            string removedSubstring2 = originalRemoveString.Remove(7, 3);
            Console.WriteLine($"Remove(7, 3): {removedSubstring2}");            // Вывод: "Hello, ld!"

            // Пример 3: Удаление символов с конца строки
            string removedFromEnd = originalRemoveString.Remove(originalRemoveString.Length - 1);
            Console.WriteLine($"Remove (с конца строки): {removedFromEnd}");    // Вывод: "Hello, world"


            // -=================== Replace (Замена) ===================
            string originalReplaceString = "Hello, world! Hello, C#!";

            // Пример 1: Замена одной подстроки на другую
            string replacedString1 = originalReplaceString.Replace("Hello", "Greetings");       // Строка будет проверяться от начала до конца и все вхождения будут заменены на новое значение
            Console.WriteLine($"Replace: {replacedString1}");                   // Вывод: "Greetings, world! Greetings, C#!"

            // Пример 2: Замена символа на другой символ
            string replacedString2 = originalReplaceString.Replace('!', '?');
            Console.WriteLine($"Replace chars: {replacedString2}");             // Вывод: "Hello, world? Hello, C#?"

            // Пример 3: Удаление всех пробелов из строки
            string stringWithoutSpaces = originalReplaceString.Replace(" ", "");
            Console.WriteLine($"Replace spaces: {stringWithoutSpaces}");        // Вывод: "Hello,world!Hello,C#!"


            // -=================== ToLower and ToUpper (Смена регистра) ===================
            string hello = "Hello world!";

            Console.WriteLine(hello.ToLower()); // hello world!
            Console.WriteLine(hello.ToUpper()); // HELLO WORLD!


            // -=================== Contains ===================
            string mainString = "Hello, world!";

            // Пример 1: Проверка наличия подстроки
            bool containsSubstring1 = mainString.Contains("world");
            Console.WriteLine($"Contains: {containsSubstring1}");                           // Вывод: True

            // Пример 2: Проверка наличия подстроки (регистронезависимая)
            bool containsSubstring2 = mainString.Contains("WORLD", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Contains (регистронезависимая): {containsSubstring2}");     // Вывод: True

            // Пример 3: Проверка наличия символа
            bool containsCharacter = mainString.Contains(",");
            Console.WriteLine($"Contains (символ): {containsCharacter}");                   // Вывод: True


            // -=================== null character ===================-
            // The null character can be displayed and counted, like other chars.
            string s12 = "\x0" + "abc";     // \x0 - null символ
            string s22 = "abc" + "\x0";
            // Output of the following line: * abc*
            Console.WriteLine("*" + s12 + "*");
            // Output of the following line: *abc *
            Console.WriteLine("*" + s22 + "*");
            // Output of the following line: 4
            Console.WriteLine(s22.Length);
            


            // -=================== Форматирование строк string.Format ===================-
            string formattedString1 = string.Format("Hello, {0}! Today is {1}.", "John", DateTime.Now.DayOfWeek);
            Console.WriteLine(formattedString1);                                            // Вывод: Hello, John! Today is Wednesday.

            // Пример 2: Форматирование чисел
            string formattedString2 = string.Format("The price is: {0:C}", 123.45);
            Console.WriteLine(formattedString2);                                            // Вывод: The price is: $123.45

            // Пример 3: Форматирование с использованием различных форматов
            string formattedString3 = string.Format("Decimal: {0:D}, Hexadecimal: {0:X}, Scientific: {1:E}", 42, Math.PI);
            Console.WriteLine(formattedString3);                                            // Вывод: Decimal: 42, Hexadecimal: 2A, Scientific: 3.141593E+00

            // Настраиваемые форматы
            long number = 19876543210;
            string result = string.Format("{0:+# (###) ###-##-##}", number);
            Console.WriteLine(result);                                                      // +1 (987) 654-32-10


            // -=================== String Builder ===================
            // -=================== Constructor
            
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder("Hello World!!!");
            Console.WriteLine($"Значение переменной: {sb1.ToString()}");    // Hello World!!!
            Console.WriteLine(sb1.ToString());                              // Hello World!!!
            Console.WriteLine($"Просто объект: {sb1}");                     // Hello World!!!

            // -=================== Append ===================
            StringBuilder sbAppend = new StringBuilder();
            sbAppend.Append("Hello, ");
            sbAppend.Append("world!");

            Console.WriteLine($"Append : {sbAppend}");                     // Hello World!
            Console.WriteLine($"Length : {sbAppend.Length}");              // 13

            // -=================== AppendLine  Позволяет сделать перевод каретки на новую строчку
            StringBuilder sbAppendLine = new StringBuilder();
            sbAppendLine.Append("Hello, ");
            sbAppendLine.AppendLine("world!");
            sbAppendLine.AppendLine("How are you?");

            Console.WriteLine($"AppendLine : {sbAppendLine}");
            /* Вывод:
               Hello, world!
               How are you?
            */

            // -=================== AppendFormat
            // Пример 1: Простой пример форматирования
            StringBuilder sb1AppendFormat = new StringBuilder();
            sb1AppendFormat.AppendFormat("Hello, {0}! Today is {1}.", "John", DateTime.Now.DayOfWeek);
            Console.WriteLine(sb1AppendFormat.ToString());                          // Вывод: Hello, John! Today is Wednesday.

            // Пример 2: Форматирование чисел
            StringBuilder sb2AppendFormat = new StringBuilder();
            sb2AppendFormat.AppendFormat("The price is: {0:C}", 123.45);
            Console.WriteLine(sb2AppendFormat.ToString());                          // Вывод: The price is: $123.45

            // Пример 3: Форматирование с использованием различных форматов
            StringBuilder sb3AppendFormat = new StringBuilder();
            sb3AppendFormat.AppendFormat("Decimal: {0:D}, Hexadecimal: {0:X}, Scientific: {1:E}", 42, Math.PI);
            Console.WriteLine(sb3AppendFormat.ToString());                          // Вывод: Decimal: 42, Hexadecimal: 2A, Scientific: 3.141593E+00


            // -=================== Replace
            StringBuilder sbReplace = new StringBuilder("Hello, world!");
            sbReplace.Replace("world", "C#");

            Console.WriteLine($"Replace : {sbReplace}");                    // Вывод: Hello, C#!

            // -=================== Remove      // указываем начальный символ откуда удалить и сколько удалить
            StringBuilder sbRemove = new StringBuilder("Hello, world!");
            sbRemove.Remove(7, 6);                                          // Удаляем "world"

            Console.WriteLine($"Remove : {sbRemove}");                      // Вывод: Hello!

            // -=================== Insert      // С какого индекса вставлять и какое значение вставлять
            StringBuilder sbInsert = new StringBuilder("Hello!");
            sbInsert.Insert(5, " world");

            Console.WriteLine($"Insert : {sbInsert}");                      // Вывод: Hello world!        


            // -=================== Capacity        // Свойство класса стрингбилдера
            StringBuilder sbCapacity = new StringBuilder();

            // Получаем текущую емкость
            int initialCapacity = sbCapacity.Capacity;
            Console.WriteLine($"Initial Capacity: {initialCapacity}");

            // Добавляем текст
            sbCapacity.Append("Hello, world!");

            // Получаем новую емкость после добавления текста
            int newCapacity = sbCapacity.Capacity;
            Console.WriteLine($"New Capacity: {newCapacity}");

            // Устанавливаем явно емкость (в данном случае, увеличиваем)
            sbCapacity.Capacity = newCapacity * 2;

            // Получаем емкость после установки
            int updatedCapacity = sbCapacity.Capacity;
            Console.WriteLine($"Updated Capacity: {updatedCapacity}");


            // -=================== Регулярные выражения (Regex) ===================-
            // -=================== Cоответствие строки регулярному выражению
            string input = "Hello, 123!";
            string pattern = @"(\d+)"; // Шаблон: одна или более цифр

            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch)
            {
                Console.WriteLine("Строка содержит цифры.");
            }
            else
            {
                Console.WriteLine("Строка не содержит цифры.");
            }


            // -=================== Извлечение подстрок с использованием групп
            // -=================== Пример 1
            string input1 = "Дата: 2023-11-19";
            string pattern1 = @"Дата: (\d{4}-\d{2}-\d{2})"; // Группа для извлечения даты

            Match match = Regex.Match(input1, pattern1);

            if (match.Success)
            {
                string date = match.Groups[1].Value;
                Console.WriteLine($"Извлеченная дата: {date}");
            }
            else
            {
                Console.WriteLine("Дата не найдена.");
            }

            // -=================== Пример 2
            string input11 = "Дата: 2023-11-19, Дата: 2023-12-25";
            string pattern12 = @"Дата: (\d{4}-\d{2}-\d{2})"; // Группа для извлечения даты

            MatchCollection matches = Regex.Matches(input11, pattern12);

            if (matches.Count > 0)
            {
                Console.WriteLine($"Найдено {matches.Count} вхождений:");

                foreach (Match matchItem in matches)
                {
                    string date = matchItem.Groups[1].Value;
                    Console.WriteLine($"Извлеченная дата: {date}");
                }
            }
            else
            {
                Console.WriteLine("Дата не найдена.");
            }

            // -=================== Замена с использованием регулярного выражения
            string input2 = "Текст с цифрами: 12345 и 67890";
            string pattern2 = @"\d+"; // = @"(\d+) Шаблон: одна или более цифр

            string replacement = "###";

            string result2 = Regex.Replace(input2, pattern2, replacement);

            Console.WriteLine($"Исходная строка: {input2}");
            Console.WriteLine($"Строка после замены: {result2}");
        }
    }
}