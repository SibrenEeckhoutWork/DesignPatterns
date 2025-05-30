using builder;

var builder = new PizzaBuilder();
var director = new PizzaDirector(builder);

// Building a Margherita Pizza
director.BuildMargheritaPizza();
Pizza margherita = builder.Build();
Console.WriteLine("Margherita Pizza:");
Console.WriteLine(margherita.ToString());

Console.WriteLine();

// Building a Pepperoni Pizza
director.BuildPepperoniPizza();
Pizza pepperoni = builder.Build();
Console.WriteLine("Pepperoni Pizza:");
Console.WriteLine(pepperoni.ToString());

Console.WriteLine();

// Building a Custom Pizza
var customToppings = new List<string> { "Mushrooms", "Ham", "Pineapple" };
director.BuildCustomPizza("Large", "Gluten-Free", "BBQ Sauce", "Vegan Cheese", customToppings);
Pizza customPizza = builder.Build();
Console.WriteLine("Custom Pizza:");
Console.WriteLine(customPizza.ToString());