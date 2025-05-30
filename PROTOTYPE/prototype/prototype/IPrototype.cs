using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype
{
    public interface IPrototype<T>
    {
        T Clone();
        T DeepClone();
    }
}
