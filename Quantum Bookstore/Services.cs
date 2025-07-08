using System;

namespace Quantum_Bookstore
{
    // Dummy ShippingService
    public static class ShippingService
    {
        public static void Ship(string address, PaperBook book, int quantity)
        {
            Console.WriteLine($"Quantum book store: Shipping {quantity} of '{book.Title}' to {address}");
        }
    }

    // Dummy MailService
    public static class MailService
    {
        public static void Send(string email, EBook book)
        {
            Console.WriteLine($"Quantum book store: Sending eBook '{book.Title}' to {email}");
        }
    }
} 