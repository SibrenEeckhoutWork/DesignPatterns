using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory
{
    internal class HotDrinkFactory : IDrinkFactory
    {
        public IDrink CreateDrink(string type)
        {
            return type.ToLower() switch
            {
                "coffee" => new Coffee(),
                "hotchocolate" => new HotChocolate(),
                _ => throw new ArgumentException("Invalid type", nameof(type))
            };
        }
    }
}
