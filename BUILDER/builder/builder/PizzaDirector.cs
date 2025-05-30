using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class PizzaDirector
    {
        private readonly IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public void BuildMargheritaPizza()
        {
            _builder.SetSize("Medium");
            _builder.SetDough("Normal");
            _builder.SetSauce("Tomato Sauce");
            _builder.SetCheese("Normal Cheese");
            _builder.AddTopping("Basil");
        }

        public void BuildPepperoniPizza()
        {
            _builder.SetSize("Large");
            _builder.SetDough("Thin Crust");
            _builder.SetSauce("Tomato Sauce");
            _builder.SetCheese("Extra Cheese");
            _builder.AddTopping("Pepperoni");
            _builder.AddTopping("Olives");
        }

        public void BuildCustomPizza(string size, string dough, string sauce, string cheese, List<string> toppings)
        {
            _builder.SetSize(size);
            _builder.SetDough(dough);
            _builder.SetSauce(sauce);
            _builder.SetCheese(cheese);
            foreach (var topping in toppings)
            {
                _builder.AddTopping(topping);
            }
        }
    }
}
