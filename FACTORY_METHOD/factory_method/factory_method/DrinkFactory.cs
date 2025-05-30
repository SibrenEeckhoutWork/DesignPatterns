using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    internal abstract class DrinkFactory
    {
        protected DrinkFactory() { }
        public abstract IDrink CreateDrink();
    }
}
