using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = ReadLibrary();
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

            var sortedLibrary = SumOfPrices(library, date);

            foreach (var author in sortedLibrary)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:dd.MM.yyyy}");
            }
        }

        private static Dictionary<string, DateTime> SumOfPrices(Library library, DateTime date)
        {
            var sortedLibrary = library.books
                .Where(x => x.datePublished > date)
                .OrderBy(x => x.datePublished)
                .ThenBy(x => x.title)
                .ToDictionary(x => x.title, x=> x.datePublished);

            return sortedLibrary;
        }

        static Library ReadLibrary()
        {
            var library = new Library();
            var books = new List<Book>();
            var n = int.Parse(Console.ReadLine());
            library.books = books;

            for (int i = 0; i < n; i++)
            {
                var book = new Book();
                var input = Console.ReadLine().Split().ToList();
                book.title = input[0];
                book.datePublished = DateTime.ParseExact(input[3], "d.M.yyyy", CultureInfo.InvariantCulture);
                books.Add(book);
            }

            return library;
        }
    }

    internal class Library
    {
        public string name { get; set; }
        public List<Book> books { get; set; }
    }

    public class Book
    {
        public string title { get; set; }
        public DateTime datePublished { get; set; }
    }
}
