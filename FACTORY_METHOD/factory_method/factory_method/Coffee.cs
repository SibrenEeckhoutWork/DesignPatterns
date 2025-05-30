using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    internal class Coffee : IDrink
    {
        public Coffee() { }
        public void Serve()
        {
            Console.WriteLine("Serving Coffee.");
        }
    }
}
