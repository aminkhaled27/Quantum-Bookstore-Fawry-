using System;
using Quantum_Bookstore;

namespace Quantum_Bookstore
{
    public class BookStore
    {
        private Inventory inventory = new Inventory();
        public Inventory Inventory => inventory;

        public decimal BuyBook(string isbn, int quantity, string email, string address)
        {
            var book = inventory.GetBookByISBN(isbn);
            if (book == null)
                throw new Exception($"Quantum book store: Book with ISBN {isbn} not found.");
            if (!book.IsForSale)
                throw new Exception($"Quantum book store: Book '{book.Title}' is not for sale.");
            if (book is PaperBook paperBook)
            {
                if (paperBook.Stock < quantity)
                    throw new Exception($"Quantum book store: Not enough stock for '{paperBook.Title}'.");
                paperBook.Stock -= quantity;
                ShippingService.Ship(address, paperBook, quantity);
                Console.WriteLine($"Quantum book store: Sold {quantity} of '{paperBook.Title}' for {paperBook.Price * quantity:C}");
                return paperBook.Price * quantity;
            }
            else if (book is EBook eBook)
            {
                MailService.Send(email, eBook);
                Console.WriteLine($"Quantum book store: Sold eBook '{eBook.Title}' for {eBook.Price:C}");
                return eBook.Price;
            }
            else
            {
                throw new Exception($"Quantum book store: Book type not supported for buying.");
            }
        }
    }
} 