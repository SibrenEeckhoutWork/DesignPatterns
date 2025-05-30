using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public interface IBookComponent
    {
        void Display(string indent);
        IIterator<IBookComponent> CreateIterator();
    }
}
