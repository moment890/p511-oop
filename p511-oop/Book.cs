using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop 
{
    internal class Book {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string author, string title, string publisher, int year, int pages) {
            Author = author;
            Title = title;
            Publisher = publisher;
            Year = year;
            Pages = pages;
        }

        public void Print() {
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Издательство: {Publisher}");
            Console.WriteLine($"Год: {Year}");
            Console.WriteLine($"Количество страниц: {Pages}");
        }
    }
}
