// See https://aka.ms/new-console-template for more information

using decoder;

Cafe koffie = new BasisKoffie("zwarte koffie");
Console.WriteLine(koffie.getDescription());
Console.WriteLine(koffie.getPrice());

koffie = new Melk(koffie);
Console.WriteLine(koffie.getDescription());
Console.WriteLine(koffie.getPrice());

koffie = new Suiker(koffie);
Console.WriteLine(koffie.getDescription());
Console.WriteLine(koffie.getPrice());

koffie = new Chocolade(koffie);
Console.WriteLine(koffie.getDescription());
Console.WriteLine(koffie.getPrice());
