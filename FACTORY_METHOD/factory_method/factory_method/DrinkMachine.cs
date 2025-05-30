using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    public class DrinkMachine
    {
        private readonly DrinkFactory _factory;

        internal DrinkMachine(DrinkFactory factory)
        {
            _factory = factory;
        }

        public void ServeDrink()
        {
            IDrink drink = _factory.CreateDrink();
            drink.Serve();
        }
    }
}
