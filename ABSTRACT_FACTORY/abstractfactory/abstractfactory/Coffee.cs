using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory
{
    internal class Coffee : IDrink
    {
        public void serve()
        {
            Console.WriteLine("Serving Coffee.");
        }
    }
}
