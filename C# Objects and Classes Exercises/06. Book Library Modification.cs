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
        
        public ListBook Books { get; set; }
    }
    
    class Program
    {
        public static void Main()
        {
            int countOfBooks = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.NameOfLibrary = Library;
            library.Books = new ListBook();
            Dictionarystring, DateTime books = new Dictionarystring, DateTime();
            for (int i = 0; i  countOfBooks; i++)
            {
                string[] infoAboutTheBook = Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                Book currentBook = ReadBook(infoAboutTheBook);
                library.Books.Add(currentBook);
            }

            for (int i = 0; i  library.Books.Count; i++)
            {
                if (!books.ContainsKey(library.Books[i].Title))
                {
                    books.Add(library.Books[i].Title, library.Books[i].ReleaseDate);
                }
                else
                {
                    books[library.Books[i].Title] = library.Books[i].ReleaseDate;
                }
            }

            DateTime biggerThanThisDate = DateTime.ParseExact(Console.ReadLine(),
                dd.MM.yyyy, CultureInfo.InvariantCulture);
            
            var sortedBooks = books.ToList();
            sortedBooks = books.Where(x = x.Value  biggerThanThisDate).ToList();
            sortedBooks.Sort((x1, x2) =
            {
                if (x1.Value.CompareTo(x2.Value) == 0)
                {
                    return String.Compare(x1.Key, x2.Key, StringComparison.Ordinal);
                }
                return x1.Value.CompareTo(x2.Value);
            });
            
            foreach (var book in sortedBooks)
            {
                int day = book.Value.Day;
                int month = book.Value.Month;
                Console.WriteLine(${book.Key} - {dayD2}.{monthD2}.{book.Value.Year});
            }
        }
        
        public static Book ReadBook(string[] infoAboutBook)
        {
            Book book = new Book();
            book.Title = infoAboutBook[0];
            book.Author = infoAboutBook[1];
            book.Publisher = infoAboutBook[2];
            book.ReleaseDate = DateTime.ParseExact(infoAboutBook[3], dd.MM.yyyy, CultureInfo.InvariantCulture);
            book.NumberIsbn = infoAboutBook[4];
            book.Price = double.Parse(infoAboutBook[5]);
            return book;
        }
    }
}