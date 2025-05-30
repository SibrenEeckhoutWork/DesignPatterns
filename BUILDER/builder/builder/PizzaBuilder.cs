using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder() { }
        public void SetSize(string size)
        {
            _pizza.Size = size;
        }

        public void SetDough(string dough)
        {
            _pizza.Dough = dough;
        }

        public void SetSauce(string sauce)
        {
            _pizza.Sauce = sauce;
        }

        public void SetCheese(string cheese)
        {
            _pizza.Cheese = cheese;
        }

        public void AddTopping(string topping)
        {
            _pizza.Toppings.Add(topping);
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}
