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
        }

        public void ShowBooks() 
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                Console.Write($"{i} ");
                ((Book)bookList[i]).ShowInfo();     // указала что для элементов i - это тип Book           
            }
        }

        public void ShowBooksByAuthor(string author)
        {
            bool bookFound = false;
            foreach(Book book in bookList)
            {
                if (author == book.author)
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
    }
}
