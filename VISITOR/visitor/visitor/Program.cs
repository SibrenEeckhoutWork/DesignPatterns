using visitor;

Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
Book book2 = new Book("1984", "George Orwell");

// Maak bibliotheken
Library library1 = new Library();
Library library2 = new Library();

// Voeg boeken toe aan bibliotheken
library1.Add(book1);
library2.Add(book2);
library1.Add(library2);

// Maak bezoekers
IBookVisitor printVisitor = new PrintVisitor();
IBookVisitor countVisitor = new CountVisitor();

// Bezoek boeken en bibliotheken
Console.WriteLine("Printing Books and Libraries:");
library1.Accept(printVisitor);

Console.WriteLine("\nCounting Books and Libraries:");
library1.Accept(countVisitor);
Console.WriteLine($"Total Books: {((CountVisitor)countVisitor).GetBookCount()}");
Console.WriteLine($"Total Libraries: {((CountVisitor)countVisitor).GetLibraryCount()}");
