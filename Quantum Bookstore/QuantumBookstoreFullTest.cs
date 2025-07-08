using System;
using Quantum_Bookstore;

namespace Quantum_Bookstore
{
    public class QuantumBookstoreFullTest
    {
        public static void RunTest()
        {
            var store = new BookStore();
            // Add books
            store.Inventory.AddBook(new PaperBook("ISBN001", "Quantum Physics", 2015, 50.0m, "Alice Smith", 10));
            store.Inventory.AddBook(new EBook("ISBN002", "Quantum Computing", 2020, 30.0m, "Bob Jones", "pdf"));
            store.Inventory.AddBook(new ShowcaseBook("ISBN003", "Quantum Demo", 2010, 0.0m, "Carol Lee"));

            // Remove outdated books (older than 8 years)
            var outdated = store.Inventory.RemoveOutdatedBooks(8);
            Console.WriteLine($"Quantum book store: Outdated books removed: {outdated.Count}");

            // Buy a paper book
            try
            {
                var paid = store.BuyBook("ISBN001", 2, "buyer@example.com", "123 Quantum St");
                Console.WriteLine($"Quantum book store: Paid amount: {paid:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Buy an ebook
            try
            {
                var paid = store.BuyBook("ISBN002", 1, "buyer@example.com", "");
                Console.WriteLine($"Quantum book store: Paid amount: {paid:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Try to buy a showcase book
            try
            {
                store.BuyBook("ISBN003", 1, "buyer@example.com", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
} 