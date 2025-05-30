using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory
{
    internal interface IDrinkFactory
    {
        IDrink CreateDrink(string type);
    }
}
