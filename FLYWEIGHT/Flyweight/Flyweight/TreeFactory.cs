using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TreeFactory
    {
        private readonly Dictionary<string, ITree> _trees = new Dictionary<string, ITree>();

        public ITree GetTree(string type, string color, string texture)
        {
            string key = $"{type}_{color}_{texture}";

            if (!_trees.ContainsKey(key))
            {
                _trees[key] = new Tree(type, color, texture);
            }

            return _trees[key];
        }
    }
}
