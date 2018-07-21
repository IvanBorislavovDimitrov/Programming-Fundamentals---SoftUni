using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string NumberIsbn { get; set; }

        public double Price { get; set; }
    }

    class Library 
    {
        public string NameOfLibrary { get; set; }
        
        public List<Book> Books { get; set; }
    }
    
    class Program
    {
        public static void Main()
        {
            int countOfBooks = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.NameOfLibrary = "Library";
            library.Books = new List<Book>();
            Dictionary<string, double> books = new Dictionary<string, double>();
            for (int i = 0; i < countOfBooks; i++)
            {
                string[] infoAboutTheBook = Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Book currentBook = ReadBook(infoAboutTheBook);
                library.Books.Add(currentBook);
            }

            for (int i = 0; i < library.Books.Count; i++)
            {
                if (!books.ContainsKey(library.Books[i].Author))
                {
                    books.Add(library.Books[i].Author, library.Books[i].Price);
                }
                else
                {
                    books[library.Books[i].Author] += library.Books[i].Price;
                }
            }
            var sortedBooks = books.ToList();
            sortedBooks.Sort((x1, x2) =>
            {
                if (x2.Value.CompareTo(x1.Value) == 0)
                {
                    return String.Compare(x1.Key, x2.Key, StringComparison.Ordinal);
                }
                return x2.Value.CompareTo(x1.Value);
            });
            
                foreach (var book in sortedBooks)
            {
                Console.WriteLine($"{book.Key} -> {book.Value:F2}");
            }
        }

        public static Book ReadBook(string[] infoAboutBook)
        {
            Book book = new Book();
            book.Title = infoAboutBook[0];
            book.Author = infoAboutBook[1];
            book.Publisher = infoAboutBook[2];
            book.ReleaseDate = DateTime.ParseExact(infoAboutBook[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.NumberIsbn = infoAboutBook[4];
            book.Price = double.Parse(infoAboutBook[5]);
            return book;
        }
    }
}
