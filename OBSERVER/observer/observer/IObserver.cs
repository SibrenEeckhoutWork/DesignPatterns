﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    public interface IObserver
    {
        void Update(float temperature);
    }
}
