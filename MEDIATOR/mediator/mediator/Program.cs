using mediator;

ChatMediator mediator = new ChatMediator();

// Maak gebruikers en registreer ze bij de mediator
User alice = new ConcreteUser("Alice");
User bob = new ConcreteUser("Bob");
User charlie = new ConcreteUser("Charlie");

mediator.RegisterUser(alice);
mediator.RegisterUser(bob);
mediator.RegisterUser(charlie);

// Gebruikers sturen berichten
alice.SendMessage("Hello everyone!");
bob.SendMessage("Hi Alice!");
charlie.SendMessage("Good day!");