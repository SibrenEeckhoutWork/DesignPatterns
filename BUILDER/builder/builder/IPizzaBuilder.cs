using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    internal interface IPizzaBuilder
    {
        void SetSize(string size);
        void SetDough(string dough);
        void SetSauce(string sauce);
        void SetCheese(string cheese);
        void AddTopping(string topping);
        Pizza Build();
    }
}
