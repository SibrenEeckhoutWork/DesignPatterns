using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory
{
    internal class ColdDrinkFactory : IDrinkFactory
    {
        public IDrink CreateDrink(string type)
        {
            return type.ToLower() switch
            {
                "tea" => new Tea(),
                "orangejuice" => new OrangeJuice(),
                _ => throw new ArgumentException("Invalid type", nameof(type))
            };
        }
    }
}
