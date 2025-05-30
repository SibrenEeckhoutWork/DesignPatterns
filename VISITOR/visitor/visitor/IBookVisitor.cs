using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public interface IBookVisitor
    {
        void Visit(Book book);
        void Visit(Library library);
    }
}
