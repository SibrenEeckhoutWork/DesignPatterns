using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public class CountVisitor : IBookVisitor
    {
        private int _bookCount;
        private int _libraryCount;

        public void Visit(Book book)
        {
            _bookCount++;
        }

        public void Visit(Library library)
        {
            _libraryCount++;
            foreach (var component in library.GetComponents())
            {
                component.Accept(this);
            }
        }

        public int GetBookCount()
        {
            return _bookCount;
        }

        public int GetLibraryCount()
        {
            return _libraryCount;
        }
    }
}
