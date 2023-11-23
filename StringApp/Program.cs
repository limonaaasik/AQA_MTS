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
            string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
            string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl

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
            Console.WriteLine(str_final);


        }
    }
}