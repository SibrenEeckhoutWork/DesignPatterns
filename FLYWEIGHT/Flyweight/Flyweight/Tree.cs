using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Tree : ITree
    {
        private readonly string _type;
        private readonly string _color;
        private readonly string _texture;

        public Tree(string type, string color, string texture)
        {
            _type = type;
            _color = color;
            _texture = texture;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Tree of type {_type}, color {_color}, texture {_texture} is displayed at ({x}, {y}).");
        }
    }
}
