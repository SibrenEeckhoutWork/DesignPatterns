﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method
{
    internal class TeaFactory : DrinkFactory
    {
        public override IDrink CreateDrink()
        {
            return new Tea();
        }
    }
}
