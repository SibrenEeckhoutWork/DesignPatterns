﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chain_of_responsibillity
{
    public interface IRequestHandler
    {
        void SetNextHandler(IRequestHandler nextHandler);
        void HandleRequest(string request);
    }
}
