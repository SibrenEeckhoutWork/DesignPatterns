using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public class Library : IBookComponent
    {
        private readonly List<IBookComponent> _components = new List<IBookComponent>();
        public string Name { get; }

        public Library(string name)
        {
            Name = name;
        }

        public void Add(IBookComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IBookComponent component)
        {
            _components.Remove(component);
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent}Library: {Name}");
            foreach (var component in _components)
            {
                component.Display(indent + "   ");
            }
        }

        public IIterator<IBookComponent> CreateIterator()
        {
            return new LibraryIterator(_components);
        }
    }
}
