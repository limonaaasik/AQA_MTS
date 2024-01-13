using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Library
    {
        ArrayList bookList = new ArrayList();

        public void AddBook(Book book)
        {
            bookList.Add(book);
            Console.WriteLine("Книга добавлена");
        }

        public void ShowBooks()
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                Console.Write($"{i}. "); // индексы элементов
                ((Book)bookList[i]).ShowInfo();     // указала что для элементов bookList[i] - это тип Book           
            }
        }

        public void ShowBooksByAuthor(string author)
        {
            author = author.ToLower();
            bool bookFound = false;
            foreach (Book book in bookList)
            {
                if (author == book.author.ToLower())
                {
                    bookFound = true;
                    book.ShowInfo();
                }
            }

            if (!bookFound)
            {
                Console.WriteLine("Не найдено книг по данному автору");
            }
        }

        public void RemoveBookFromList(int index)   // на вход ввести индекс книги
        {
            if (index > bookList.Count - 1 || index < 0)
            {
                Console.WriteLine("Вы ввели несуществующий индекс.");
            }
            else
            {
                bookList.RemoveAt(index);
                Console.WriteLine("Книга удалена.");
            }
        }

    }
}
