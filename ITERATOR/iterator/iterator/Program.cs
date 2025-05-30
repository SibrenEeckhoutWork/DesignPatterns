// Maak individuele boeken
using iterator;

var book1 = new Book("Design Patterns");
var book2 = new Book("Clean Code");
var book3 = new Book("Refactoring");

// Maak een sub-bibliotheek (Boekenplank)
var shelf1 = new Library("Software Development Shelf");
shelf1.Add(book1);
shelf1.Add(book2);
shelf1.Add(book3);

// Maak een hoofd-bibliotheek
var mainLibrary = new Library("Main Library");
mainLibrary.Add(shelf1);

// Voeg nog een individueel boek toe aan de hoofd-bibliotheek
var book4 = new Book("The Pragmatic Programmer");
mainLibrary.Add(book4);

// Itereer over de structuur
mainLibrary.Display("");

var testLibrary = new Library("Test library");

shelf1.Add(testLibrary);
testLibrary.Add(book4);
testLibrary.Add(book2);

Console.WriteLine("\nUsing Iterator to traverse the library:");

var iterator = mainLibrary.CreateIterator();
while (iterator.HasNext())
{
    var component = iterator.Next();
    component.Display(" ");
}