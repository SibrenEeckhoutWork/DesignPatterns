using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public class NullIterator : IIterator<IBookComponent>
    {
        public bool HasNext() => false;

        public IBookComponent Next()
        {
            throw new InvalidOperationException("No elements.");
        }
    }
}
