// Voor Koffie
using factory_method;

DrinkFactory coffeeFactory = new CoffeeFactory();
DrinkMachine coffeeMachine = new DrinkMachine(coffeeFactory);
coffeeMachine.ServeDrink();

// Voor Thee
DrinkFactory teaFactory = new TeaFactory();
DrinkMachine teaMachine = new DrinkMachine(teaFactory);
teaMachine.ServeDrink();