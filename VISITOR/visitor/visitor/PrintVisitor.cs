using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public class PrintVisitor : IBookVisitor
    {
        public void Visit(Book book)
        {
            Console.WriteLine($"Book: {book.Title} by {book.Author}");
        }

        public void Visit(Library library)
        {
            Console.WriteLine("Library contains:");
        }
    }
}
