using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Book
    {
        public string name;
        public string author;
        public int yearPublication;

        public Book(string name, string author, int yearPublication)
        {
            this.name = name;
            this.author = author;
            this.yearPublication = yearPublication;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название книги: {name}, Автор книги: {author}, Год публикации: {yearPublication}");
        }

    }
}
