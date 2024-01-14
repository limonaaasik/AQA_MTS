using Task1;

Console.WriteLine("Для добавления книги напишите \"добавить\"\n" +
    "Для отображения списка книг напишите \"показать\"\n" +
    "Для поиска книги по автору напишите \"поиск\"\n" +
    "Для удаления книги напишите \"удалить\"\n" +
    "Для выхода из программы напишите \"выход\"\n\n" + 
    "Введите команду:");
Library library = new Library();
string command;
while ((command = Console.ReadLine().ToLower()) != "выход") //ToLower - приводит к нижнему регистру
{
    switch (command)
    {
        case "добавить":
            Console.WriteLine("Введите название книги:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите автора книги:");
            string author = Console.ReadLine();
            Console.WriteLine("Введите год публикации книги:");
            int year;
            if (int.TryParse(Console.ReadLine(), out year))
            {
                Book book = new Book(name, author, year);
                library.AddBook(book);
                break;
            }
            else
            {
                Console.WriteLine("Введен неверный формат года публикации");
                break;
            }

        case "показать":
            library.ShowBooks();
            break;

        case "поиск":
            Console.WriteLine("Введите автора книги:");
            string bookauthor = Console.ReadLine();
            library.ShowBooksByAuthor(bookauthor);
            break;

        case "удалить":
            Console.WriteLine("Введите индекс книги:");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                library.RemoveBookFromList(index);
                break;
            }
            else
            {
                Console.WriteLine("Введен неверный формат индекса");
                break;
            }
    }
    Console.WriteLine("Введите команду:");
}
Console.WriteLine("Вы вышли из программы.");