using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public interface IBookComponent
    {
        void Accept(IBookVisitor visitor);
    }
}
