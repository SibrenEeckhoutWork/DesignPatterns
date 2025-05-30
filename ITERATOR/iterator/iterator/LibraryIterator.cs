using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public class LibraryIterator : IIterator<IBookComponent>
    {
        private readonly List<IBookComponent> _components;
        private int _position = 0;

        public LibraryIterator(List<IBookComponent> components)
        {
            _components = components;
        }

        public bool HasNext()
        {
            return _position < _components.Count;
        }

        public IBookComponent Next()
        {
            if (!HasNext())
                throw new InvalidOperationException("No more elements.");

            return _components[_position++];
        }
    }
}
