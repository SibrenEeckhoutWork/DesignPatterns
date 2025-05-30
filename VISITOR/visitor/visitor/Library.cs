using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor
{
    public class Library : IBookComponent
    {
        private readonly List<IBookComponent> _components = new List<IBookComponent>();

        public void Add(IBookComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IBookComponent component)
        {
            _components.Remove(component);
        }

        public List<IBookComponent> GetComponents()
        {
            return _components;
        }

        public void Accept(IBookVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var component in _components)
            {
                component.Accept(visitor);
            }
        }
    }
}
