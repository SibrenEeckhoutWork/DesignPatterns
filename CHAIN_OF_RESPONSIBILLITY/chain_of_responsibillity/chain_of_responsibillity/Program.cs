using chain_of_responsibillity;

IRequestHandler manager = new ManagerHandler();
IRequestHandler director = new DirectorHandler();
IRequestHandler ceo = new CEOHandler();

// Stel de keten samen
manager.SetNextHandler(director);
director.SetNextHandler(ceo);

// Verstuur verzoeken
Console.WriteLine("Sending Low-Level Request:");
manager.HandleRequest("Low-Level Request");

Console.WriteLine("\nSending Medium-Level Request:");
manager.HandleRequest("Medium-Level Request");

Console.WriteLine("\nSending High-Level Request:");
manager.HandleRequest("High-Level Request");

Console.WriteLine("\nSending Unknown Request:");
manager.HandleRequest("Unknown Request");