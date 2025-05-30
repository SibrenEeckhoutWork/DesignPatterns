using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Forest
    {
        private readonly List<(ITree tree, int x, int y)> _trees = new List<(ITree tree, int x, int y)>();
        private readonly TreeFactory _treeFactory;

        public Forest(TreeFactory treeFactory)
        {
            _treeFactory = treeFactory;
        }

        public void PlantTree(string type, string color, string texture, int x, int y)
        {
            ITree tree = _treeFactory.GetTree(type, color, texture);
            _trees.Add((tree, x, y));
        }

        public void DisplayForest()
        {
            foreach (var (tree, x, y) in _trees)
            {
                tree.Display(x, y);
            }
        }
    }
}
