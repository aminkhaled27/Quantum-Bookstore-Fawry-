using System;
using System.Collections.Generic;
using System.Linq;

namespace Quantum_Bookstore
{
    public class Inventory
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Quantum book store: Added book {book.Title} ({book.ISBN})");
        }
        public Book RemoveBook(string isbn)
        {
            var book = books.FirstOrDefault(b => b.ISBN == isbn);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine($"Quantum book store: Removed book {book.Title} ({book.ISBN})");
            }
            return book;
        }
        public List<Book> RemoveOutdatedBooks(int maxYears)
        {
            int currentYear = DateTime.Now.Year;
            var outdated = books.Where(b => (currentYear - b.Year) > maxYears).ToList();
            foreach (var book in outdated)
            {
                books.Remove(book);
                Console.WriteLine($"Quantum book store: Removed outdated book {book.Title} ({book.ISBN})");
            }
            return outdated;
        }
        public Book GetBookByISBN(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn);
        }
    }
} 