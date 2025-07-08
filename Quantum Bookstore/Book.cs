using System;

namespace Quantum_Bookstore
{
    // Abstract base class for all books
    public abstract class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public Book(string isbn, string title, int year, decimal price, string author)
        {
            ISBN = isbn;
            Title = title;
            Year = year;
            Price = price;
            Author = author;
        }
        public abstract bool IsForSale { get; }
    }

    // Paper book
    public class PaperBook : Book
    {
        public int Stock { get; set; }
        public PaperBook(string isbn, string title, int year, decimal price, string author, int stock)
            : base(isbn, title, year, price, author)
        {
            Stock = stock;
        }
        public override bool IsForSale => true;
    }

    // EBook
    public class EBook : Book
    {
        public string FileType { get; set; }
        public EBook(string isbn, string title, int year, decimal price, string author, string fileType)
            : base(isbn, title, year, price, author)
        {
            FileType = fileType;
        }
        public override bool IsForSale => true;
    }

    // Showcase/Demo book
    public class ShowcaseBook : Book
    {
        public ShowcaseBook(string isbn, string title, int year, decimal price, string author)
            : base(isbn, title, year, price, author) { }
        public override bool IsForSale => false;
    }
} 