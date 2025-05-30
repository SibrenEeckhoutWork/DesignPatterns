using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory
{
    internal class DrinkMachine
    {
        private readonly IDrinkFactory _factory;

        public DrinkMachine(IDrinkFactory factory)
        {
            _factory = factory;
        }

        public void ServeDrink(string type)
        {
            IDrink drink = _factory.CreateDrink(type);
            drink.serve();
        }
    }
}
