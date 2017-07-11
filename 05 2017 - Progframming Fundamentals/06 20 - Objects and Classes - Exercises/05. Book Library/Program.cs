using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = ReadLibrary();

            var sortedLibrary = SumOfPrices(library);

            foreach(var author in sortedLibrary)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }

        private static Dictionary<string, double> SumOfPrices(Library library)
        {
            var sortedLibrary = new Dictionary<string, double>();

            foreach(var book in library.books)
            {
                if(sortedLibrary.ContainsKey(book.author))
                {
                    sortedLibrary[book.author] += book.price;
                    continue;
                }
                sortedLibrary[book.author] = book.price;                
            }

            return sortedLibrary.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
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
                book.author = input[1];
                book.price = double.Parse(input.Last());
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
        public string author { get; set; }
        public double price { get; set; }
    }
}
