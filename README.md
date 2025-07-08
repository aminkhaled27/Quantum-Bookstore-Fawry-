# Quantum-Bookstore-Fawry-
A simple, extensible online bookstore system implemented in C#.
Supports paper books, eBooks, and showcase/demo books, with inventory management and purchase simulation.
Quantum Bookstore/

#Project Structure

  Book.cs                  # Book, PaperBook, EBook, ShowcaseBook classes
  
  Inventory.cs             # Inventory management
  
  BookStore.cs             # BookStore logic (buying books)
  
  Services.cs              # ShippingService and MailService (simulated)
  
  QuantumBookstoreFullTest.cs # Test/demo class
  
  Program.cs               # Entry point
  
  Quantum Bookstore.csproj # Project file




#Example Output

Quantum book store: Added book Quantum Physics (ISBN001)

Quantum book store: Added book Quantum Computing (ISBN002)

Quantum book store: Added book Quantum Demo (ISBN003)

Quantum book store: Removed outdated book Quantum Demo (ISBN003)

Quantum book store: Outdated books removed: 1

Quantum book store: Shipping 2 of 'Quantum Physics' to 123 Quantum St

Quantum book store: Sold 2 of 'Quantum Physics' for $100.00

Quantum book store: Paid amount: $100.00

Quantum book store: Sending eBook 'Quantum Computing' to buyer@example.com

Quantum book store: Sold eBook 'Quantum Computing' for $30.00

Quantum book store: Paid amount: $30.00

Quantum book store: Book 'Quantum Demo' is not for sale.

![Screenshot 2025-07-08 204323](https://github.com/user-attachments/assets/0142f10b-23bd-411a-95e1-312adf392fd3)
