// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Console.WriteLine("What is your name?");
//string name = Console.ReadLine();

//Person person = new Person(name);
//Console.WriteLine(person.WelcomeMessage);

Person p = new Student("John Doe", 20180189);
string output = p.WelcomeMessage;
Console.WriteLine(output);