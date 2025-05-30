using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public class Book : IBookComponent
    {
        public string Title { get; }

        public Book(string title)
        {
            Title = title;
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}Book: {Title}");
        }

        public IIterator<IBookComponent> CreateIterator()
        {
            return new NullIterator(); // Bladknopen hebben geen kinderen om doorheen te itereren
        }
    }
}
