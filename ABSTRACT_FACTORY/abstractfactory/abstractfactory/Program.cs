using abstractfactory;

IDrinkFactory hotDrinkFactory = new HotDrinkFactory();
DrinkMachine hotDrinkMachine = new DrinkMachine(hotDrinkFactory);
hotDrinkMachine.ServeDrink("coffee");
hotDrinkMachine.ServeDrink("hotchocolate");

// Voor Koud Dranken
IDrinkFactory coldDrinkFactory = new ColdDrinkFactory();
DrinkMachine coldDrinkMachine = new DrinkMachine(coldDrinkFactory);
coldDrinkMachine.ServeDrink("tea");
coldDrinkMachine.ServeDrink("orangejuice");


