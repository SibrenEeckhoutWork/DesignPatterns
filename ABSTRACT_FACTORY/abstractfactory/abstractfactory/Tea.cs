using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractfactory
{
    internal class Tea : IDrink
    {
        public void serve()
        {
            Console.WriteLine("Serving Tea.");
        }
    }
}
